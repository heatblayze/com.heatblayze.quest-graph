using ScriptableObjectGraph;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QuestGraph.Core
{
    public class Questline : NodeBase, INodeContainer<QuestNodeBase>
    {
        public List<QuestNodeBase> Children => _children;
        [SerializeField]
        List<QuestNodeBase> _children;

        public NodeBase EntryNode => _entryNode;

        public string EditorWindowPrefix => "Quest";

        [SerializeField]
        NodeBase _entryNode;
        protected override void OnCreated()
        {
            _connections = new NodePort[] { new NodePort() };
        }

        public IEnumerable<QuestNodeBase> GetNodes()
        {
            return _children;
        }

        public NodeBase CreateNode(Type type)
        {
            QuestNodeBase questNode = CreateInstance(type) as QuestNodeBase;
            questNode.name = type.Name;

            if (_entryNode == null)
                _entryNode = questNode;
            _children.Add(questNode);
            return questNode;
        }

        public void AddNode(QuestNodeBase node)
        {

        }

        public void DeleteNode(QuestNodeBase node)
        {
            if (_entryNode == node)
                _entryNode = null;

            _children.Remove(node);
        }
    }
}

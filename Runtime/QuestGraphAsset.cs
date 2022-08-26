using ScriptableObjectGraph;
using System;
using System.Collections.Generic;
using UnityEngine;


namespace QuestGraph.Core
{
    [CreateAssetMenu(menuName = "RPG Tools/Quest Graph", order = 120)]
    public class QuestGraphAsset : GuidScriptable, INodeContainer<Questline>
    {
        public List<Questline> Questlines => _questlines;
        [SerializeField]
        List<Questline> _questlines = new List<Questline>();

        public NodeComponentList Attributes => _attributes;
        [SerializeField]
        NodeComponentList _attributes;

        public Questline EntryNode => _entryNode;

        public string EditorWindowPrefix => "Questline";

        [SerializeField]
        Questline _entryNode;

        public IEnumerable<Questline> GetNodes()
        {
            return _questlines;
        }

        public NodeBase CreateNode(Type type)
        {
            Questline questline = CreateInstance(type) as Questline;
            questline.name = type.Name;
            return questline;
        }

        public void AddNode(Questline node)
        {
            if (_entryNode == null)
                _entryNode = node;
            _questlines.Add(node);
        }

        public void DeleteNode(Questline node)
        {
            if (_entryNode == node)
                _entryNode = null;

            _questlines.Remove(node);
        }
    }
}

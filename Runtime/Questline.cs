using ScriptableObjectGraph;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QuestGraph.Core
{
    public class Questline : NodeContainerNode<QuestNodeBase>
    {
        public override string EditorWindowPrefix => "Quest";

        protected override void OnCreated()
        {
            _connections = new NodePort[] { new NodePort() };
        }
    }
}

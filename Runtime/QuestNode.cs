using QuestGraph.Core;
using ScriptableObjectGraph;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QuestGraph
{
    public class QuestNode : QuestNodeBase
    {
        protected override void OnCreated()
        {
            _connections = new NodePort[] { new NodePort() };
        }
    }
}
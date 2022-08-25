using ScriptableObjectGraph.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QuestGraph.Core
{
    public abstract class QuestNodeBase : NodeBase
    {

    }

    public class QuestNode : QuestNodeBase
    {
        protected override void OnCreated()
        {
            _connections = new NodePort[] { new NodePort() };
        }
    }
}

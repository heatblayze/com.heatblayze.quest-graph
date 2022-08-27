using QuestGraph.Core;
using QuestGraph.Editor;
using ScriptableObjectGraph.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QuestGraph.Editor
{
    public class QuestNodeView : NodeView
    {
        public new class NodeViewFactory : NodeViewFactory<QuestNodeView, QuestNode, NodeViewTraits>
        {
            public override string ContextMenuName => "Quest";
        }
    }
}

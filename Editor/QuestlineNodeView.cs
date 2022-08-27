using QuestGraph.Core;
using ScriptableObjectGraph.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

namespace QuestGraph.Editor
{
    public class QuestlineNodeView : NodeView
    {
        public new class NodeViewFactory : NodeViewFactory<QuestlineNodeView, Questline, NodeViewTraits>
        {
            public override string ContextMenuName => "Questline";
        }
    }
}

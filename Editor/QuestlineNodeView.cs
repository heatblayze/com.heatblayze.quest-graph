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
        Questline _questline;

        public QuestlineNodeView(Questline questline) : base(questline)
        {
            _questline = questline;
            title = _questline.name;
        }
    }

    public class QuestlineNodeViewFactory : NodeViewFactory<Questline>
    {
        public override string ContextMenuName => "Questline";

        protected override NodeView GenerateNodeView(Questline asset)
        {
            return new QuestlineNodeView(asset);
        }
    }
}

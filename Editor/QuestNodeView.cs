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
        QuestNode _node;

        public QuestNodeView(QuestNode questline) : base(questline)
        {
            _node = questline;
            title = _node.name;
        }
    }

    public class QuestNodeFactory : NodeViewFactory<QuestNode>
    {
        public override string ContextMenuName => "Quest";

        protected override NodeView GenerateNodeView(QuestNode asset)
        {
            return new QuestNodeView(asset);
        }
    }
}

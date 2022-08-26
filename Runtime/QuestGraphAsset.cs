using ScriptableObjectGraph;
using System;
using System.Collections.Generic;
using UnityEngine;


namespace QuestGraph.Core
{
    [CreateAssetMenu(menuName = "RPG Tools/Quest Graph", order = 120)]
    public class QuestGraphAsset : NodeContainerAsset<Questline>
    {
        public override string EditorWindowPrefix => "Questline";

    }
}

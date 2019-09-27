using System;
using UnityEngine;
using XNode;

namespace CabinIcarus.IcSkillSystem.Runtime.xNode_Nodes
{
    [CreateNodeMenu("CabinIcarus/Nodes/UnityEngine/IMGUIModule/EventType Value")]
    public partial class EventTypeValueNode:ValueNode
    {
        [SerializeField]
        private UnityEngine.EventType _value;

        public override Type ValueType { get; } = typeof(UnityEngine.EventType);
        
        protected override object GetOutValue()
        {
            return _value;
        }
    }
}
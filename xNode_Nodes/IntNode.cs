﻿using System;
using CabinIcarus.IcSkillSystem.Runtime.xNode_NPBehave_Node.Attributes;
using UnityEngine;
using XNode;

namespace CabinIcarus.IcSkillSystem.Runtime.xNode_Nodes
{
    [CreateNodeMenu("CabinIcarus/Nodes/Int Value")]
    public class IntNode:ValueNode
    {
        [SerializeField]
        [PortTooltip("值出口")]
        private int _value;

        public override Type ValueType { get; } = typeof(int);
        protected override object GetOutValue()
        {
            return _value;
        }
    }
}
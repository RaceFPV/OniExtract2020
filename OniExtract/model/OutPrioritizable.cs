using System;
using UnityEngine;
using static OniExtract2.Patches;
using System.Collections.Generic;
using Klei.AI;
using STRINGS;

namespace OniExtract2
{
    public class OutPrioritizable
    {
        public Vector2 iconOffset;
        public float iconScale = 1f;
        public bool showIcon = true;


        public OutPrioritizable(Prioritizable tv)
        {
            this.iconOffset = tv.iconOffset;
            this.iconOffset = tv.iconOffset;
            this.showIcon = tv.showIcon;
        }
    }
}

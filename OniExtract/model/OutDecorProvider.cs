using System;
using UnityEngine;
using static OniExtract2.Patches;
using System.Collections.Generic;
using Klei.AI;
using STRINGS;

namespace OniExtract2
{
    public class OutDecorProvider
    {
        public float baseRadius;
        public float baseDecor;

        public OutDecorProvider(DecorProvider tv)
        {
            this.baseDecor = tv.baseDecor;
            this.baseRadius = tv.baseRadius;
        }
    }
}

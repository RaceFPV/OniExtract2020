using System;
using UnityEngine;
using static OniExtract2.Patches;
using System.Collections.Generic;
using Klei.AI;
using STRINGS;

namespace OniExtract2
{
    public class OutDrowningMonitor
    {
        public bool canDrownToDeath;
        public bool livesUnderWater;

        public OutDrowningMonitor(DrowningMonitor tv)
        {
            this.canDrownToDeath = tv.canDrownToDeath;
            this.livesUnderWater = tv.livesUnderWater;
        }
    }
}

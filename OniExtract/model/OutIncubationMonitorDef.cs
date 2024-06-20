using System;
using UnityEngine;
using static OniExtract2.Patches;
using System.Collections.Generic;
using Klei.AI;
using STRINGS;

namespace OniExtract2
{
    public class OutIncubationMonitorDef
    {
        public float baseIncubationRate;
        public Tag spawnedCreature;

        public OutIncubationMonitorDef(IncubationMonitor.Def tv)
        {
            this.baseIncubationRate = tv.baseIncubationRate;
            this.spawnedCreature = tv.spawnedCreature;
        }
    }
}

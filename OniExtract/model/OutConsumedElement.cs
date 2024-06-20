using System;
using UnityEngine;
using static OniExtract2.Patches;
using System.Collections.Generic;
using Klei.AI;
using STRINGS;
using static EnergyGenerator;

namespace OniExtract2
{
    public class OutConsumedElement
    {
        public HandleVector<int>.Handle Accumulator;
        public bool IsActive;
        public float MassConsumptionRate;
        public Tag Tag;

        public OutConsumedElement(ElementConverter.ConsumedElement tv)
        {
            this.Accumulator = tv.Accumulator;
            this.IsActive = tv.IsActive;
            this.MassConsumptionRate = tv.MassConsumptionRate;
            this.Tag = tv.Tag;
        }
    }
}
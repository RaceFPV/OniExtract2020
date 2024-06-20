﻿using System;
using UnityEngine;
using static OniExtract2.Patches;
using System.Collections.Generic;
using Klei.AI;
using STRINGS;
using static EnergyGenerator;

namespace OniExtract2
{
    public class OutEnergyGenerator
    {
        public bool hasMeter = true;
        public bool ignoreBatteryRefillPercent;
        public Formula formula;
        public Meter.Offset meterOffset;

        public OutEnergyGenerator(EnergyGenerator tv)
        {
            this.hasMeter = tv.hasMeter;
            this.ignoreBatteryRefillPercent = tv.ignoreBatteryRefillPercent;
            this.formula = tv.formula;
            this.meterOffset = tv.meterOffset;
        }
    }
}
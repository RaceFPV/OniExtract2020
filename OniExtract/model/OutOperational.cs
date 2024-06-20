﻿using System;
using UnityEngine;
using static OniExtract2.Patches;
using System.Collections.Generic;
using Klei.AI;
using STRINGS;
using static EnergyGenerator;
using static Operational;

namespace OniExtract2
{
    public class OutOperational
    {
        public float activeStartTime;
        public Dictionary<Flag, bool> flags;
        public float inactiveStartTime;

        public OutOperational(Operational tv)
        {
            this.flags = new Dictionary<Flag, bool>();
            this.activeStartTime = tv.activeStartTime;
            this.flags = tv.Flags;
            this.inactiveStartTime = tv.inactiveStartTime;
        }
    }
}
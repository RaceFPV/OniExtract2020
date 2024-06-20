﻿using System;
using UnityEngine;
using static OniExtract2.Patches;
using System.Collections.Generic;
using Klei.AI;
using STRINGS;
using static EnergyGenerator;

namespace OniExtract2
{
    public class OutConduitDispenser
    {
        public bool alwaysDispense;
        public bool blocked;
        public ConduitType conduitType;
        public SimHashes[] elementFilter;
        public bool empty = true;
        public bool invertElementFilter;
        public bool isOn = true;
        public OutStorage storage;
        public bool useSecondaryOutput;

        public OutConduitDispenser(ConduitDispenser tv)
        {
            this.alwaysDispense = tv.alwaysDispense;
            this.blocked = tv.blocked;
            this.conduitType = tv.conduitType;
            this.elementFilter = tv.elementFilter;
            this.empty = tv.empty;
            this.invertElementFilter = tv.invertElementFilter;
            this.isOn = tv.isOn;
            if(tv.storage != null)
            {
                this.storage = new OutStorage(tv.storage);
            }
            else
            {
                this.storage = null;
            }
            this.useSecondaryOutput = tv.useSecondaryOutput;
        }
    }
}
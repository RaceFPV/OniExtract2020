﻿using System;
using UnityEngine;
using static OniExtract2.Patches;
using System.Collections.Generic;
using Klei.AI;
using STRINGS;
using static EnergyGenerator;
using static ConduitConsumer;

namespace OniExtract2
{
    public class OutConduitConsumer
    {
        public bool alwaysConsume;
        public float capacityKG = float.PositiveInfinity;
        public Tag capacityTag = GameTags.Any;
        public ConduitType conduitType;
        public bool consumedLastTick = true;
        public float consumptionRate = float.PositiveInfinity;
        public bool forceAlwaysSatisfied;
        public bool ignoreMinMassCheck;
        public bool isConsuming = true;
        public bool isOn = true;
        public bool keepZeroMassObject = true;
        public SimHashes lastConsumedElement = SimHashes.Vacuum;
        public Operational.State OperatingRequirement;
        public OutOperational operational;
        public OutStorage storage;
        public ISecondaryInput targetSecondaryInput;
        public bool useSecondaryInput;
        public WrongElementResult wrongElementResult;

        public OutConduitConsumer(ConduitConsumer tv)
        {
            this.alwaysConsume = tv.alwaysConsume;
            this.capacityKG = tv.capacityKG;
            this.capacityTag = tv.capacityTag;
            this.conduitType = tv.conduitType;
            this.consumedLastTick = tv.consumedLastTick;
            this.consumptionRate = tv.consumptionRate;
            this.forceAlwaysSatisfied = tv.forceAlwaysSatisfied;
            this.ignoreMinMassCheck = tv.ignoreMinMassCheck;
            this.isConsuming = tv.isConsuming;
            this.isOn = tv.isOn;
            this.keepZeroMassObject = tv.keepZeroMassObject;
            this.lastConsumedElement = tv.lastConsumedElement;
            this.OperatingRequirement = tv.OperatingRequirement;
            this.operational = new OutOperational(tv.operational);
            if(tv.storage != null)
            {
                this.storage = new OutStorage(tv.storage);
            }
            else
            {
                this.storage = null;
            }            
            this.targetSecondaryInput = tv.targetSecondaryInput;
            this.useSecondaryInput = tv.useSecondaryInput;
            this.wrongElementResult = tv.wrongElementResult;
        }
    }
}
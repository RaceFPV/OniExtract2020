using System;
using UnityEngine;
using static OniExtract2.Patches;
using System.Collections.Generic;
using Klei.AI;
using STRINGS;
using KSerialization;

namespace OniExtract2
{
    public class OutElementConsumer
    {
        [HashedEnum]
        [SerializeField]
        public SimHashes elementToConsume = SimHashes.Vacuum;
        public float consumptionRate;
        public byte consumptionRadius = 1;
        public float minimumMass;
        public bool showInStatusPanel = true;
        public float capacityKG = float.PositiveInfinity;
        public ElementConsumer.Configuration configuration;
        public float consumedMass;
        public float consumedTemperature;
        public bool storeOnConsume;
        public OutStorage storage;
        public bool ignoreActiveChanged;
        public bool showDescriptor = true;
        public bool isRequired = true;

        public OutElementConsumer(ElementConsumer tv)
        {
            this.elementToConsume = tv.elementToConsume;
            this.consumptionRate = tv.consumptionRate;
            this.consumptionRadius = tv.consumptionRadius;
            this.minimumMass = tv.minimumMass;
            this.showInStatusPanel = tv.showInStatusPanel;
            this.capacityKG = tv.capacityKG;
            this.configuration = tv.configuration;
            this.consumedMass = tv.consumedMass;
            this.consumedTemperature = tv.consumedTemperature;
            this.storeOnConsume = tv.storeOnConsume;
            if(tv.storage != null)
            {
                this.storage = new OutStorage(tv.storage);
            }
            else
            {
                this.storage = null;
            }
            this.ignoreActiveChanged = tv.ignoreActiveChanged;
            this.showDescriptor = tv.showDescriptor;
            this.isRequired = tv.isRequired;
        }
    }
}

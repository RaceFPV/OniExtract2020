using System;
using UnityEngine;
using static OniExtract2.Patches;
using System.Collections.Generic;
using Klei.AI;
using STRINGS;
using static EnergyGenerator;

namespace OniExtract2
{
    public class OutOutputElement
    {
        public bool IsActive;
        public SimHashes elementHash;
        public float minOutputTemperature;
        public bool useEntityTemperature;
        public float massGenerationRate;
        public bool storeOutput;
        public Vector2 outputElementOffset;
        public HandleVector<int>.Handle accumulator;
        public float diseaseWeight;
        public byte addedDiseaseIdx;
        public int addedDiseaseCount;
        public string Name;

        public OutOutputElement(ElementConverter.OutputElement tv)
        {
            this.IsActive = tv.IsActive;
            this.elementHash = tv.elementHash;
            this.minOutputTemperature = tv.minOutputTemperature;
            this.useEntityTemperature = tv.useEntityTemperature;
            this.massGenerationRate = tv.massGenerationRate;
            this.storeOutput = tv.storeOutput;
            this.outputElementOffset = tv.outputElementOffset;
            this.accumulator = tv.accumulator;
            this.diseaseWeight = tv.diseaseWeight;
            this.addedDiseaseIdx = tv.addedDiseaseIdx;
            this.addedDiseaseCount = tv.addedDiseaseCount;
            this.Name = tv.Name;
        }
    }
}
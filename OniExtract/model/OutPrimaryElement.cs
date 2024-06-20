using System;
using UnityEngine;
using static OniExtract2.Patches;
using System.Collections.Generic;
using Klei.AI;
using STRINGS;

namespace OniExtract2
{
    public class OutPrimaryElement
    {
        public int DiseaseCount;
        public string Name;
        public float InternalTemperature;
        public float Mass;
        public float Temperature;
        public float Units;

        public OutPrimaryElement(PrimaryElement tv)
        {
            this.DiseaseCount = tv.DiseaseCount;
            this.Name = tv.Element.tag.Name;
            this.InternalTemperature = tv.InternalTemperature;
            this.Mass = tv.Mass;
            this.Temperature = tv.Temperature;
            this.Units = tv.Units;
        }
    }
}

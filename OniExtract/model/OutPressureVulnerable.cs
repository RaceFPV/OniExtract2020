using System;
using UnityEngine;
using static OniExtract2.Patches;
using System.Collections.Generic;
using Klei.AI;
using STRINGS;

namespace OniExtract2
{
    public class OutPressureVulnerable
    {
        public float pressureLethal_Low;
        public float pressureWarning_Low;
        public float pressureWarning_High;
        public float pressureLethal_High;
        public bool pressure_sensitive;
        public HashSet<string> safe_atmospheres;
        public bool testAreaElementSafe;

        public OutPressureVulnerable(PressureVulnerable tv)
        {
            this.pressureLethal_Low = tv.pressureLethal_Low;
            this.pressureWarning_Low = tv.pressureWarning_Low;
            this.pressureWarning_High = tv.pressureWarning_High;
            this.pressureLethal_High = tv.pressureLethal_High;
            this.pressure_sensitive = tv.pressure_sensitive;
            this.safe_atmospheres = new HashSet<string>();
            foreach (Element item in tv.safe_atmospheres)
            {
                this.safe_atmospheres.Add(item.tag.Name.ToString());
            }
            this.testAreaElementSafe = tv.testAreaElementSafe;
        }
    }
}

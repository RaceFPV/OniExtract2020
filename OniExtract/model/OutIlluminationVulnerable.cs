using System;
using UnityEngine;
using static OniExtract2.Patches;
using System.Collections.Generic;
using Klei.AI;
using STRINGS;

namespace OniExtract2
{
    public class OutIlluminationVulnerable
    {
        public bool prefersDarkness;
        public int LightIntensityThreshold;

        public OutIlluminationVulnerable(IlluminationVulnerable tv)
        {
            this.prefersDarkness = tv.prefersDarkness;
            this.LightIntensityThreshold = tv.LightIntensityThreshold;
        }
    }
}

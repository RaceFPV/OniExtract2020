using System;
using UnityEngine;
using static OniExtract2.Patches;
using System.Collections.Generic;
using Klei.AI;
using STRINGS;

namespace OniExtract2
{
    public class OutBlightVulnerable
    {
        public bool prefersDarkness;

        public OutBlightVulnerable(BlightVulnerable tv)
        {
            this.prefersDarkness = tv.prefersDarkness;
        }
    }
}

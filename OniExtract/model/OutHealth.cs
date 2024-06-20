using System;
using UnityEngine;
using static OniExtract2.Patches;
using System.Collections.Generic;
using Klei.AI;
using STRINGS;
using static Health;

namespace OniExtract2
{
    public class OutHealth
    {
        public HealthState State;
        public bool CanBeIncapacitated;
        public HealthBar healthBar;

        public OutHealth(Health tv)
        {
            this.State = tv.State;
            this.CanBeIncapacitated = tv.CanBeIncapacitated;
            this.healthBar = tv.healthBar;
        }
    }
}

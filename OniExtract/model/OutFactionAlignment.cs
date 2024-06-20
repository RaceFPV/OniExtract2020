using System;
using UnityEngine;
using static OniExtract2.Patches;
using System.Collections.Generic;
using Klei.AI;
using STRINGS;

namespace OniExtract2
{
    public class OutFactionAlignment
    {
        public FactionManager.FactionID Alignment;
        public bool canBePlayerTargeted = true;
        public bool updatePrioritizable = true;
        public Health health;
        public AttackableBase attackable;


        public OutFactionAlignment(FactionAlignment tv)
        {
            this.Alignment = tv.Alignment;
            this.canBePlayerTargeted = tv.canBePlayerTargeted;
            this.updatePrioritizable = tv.updatePrioritizable;
            this.health = tv.health;
            this.attackable = tv.attackable;
        }
    }
}

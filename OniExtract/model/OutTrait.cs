using System;
using UnityEngine;
using Klei.AI;
using static Database.Spice;
using System.Collections.Generic;

namespace OniExtract2
{
    public class OutTrait
    {
        public string Name;
        public string Id;
        public HashedString IdHash;
        public bool Disabled;
        public ResourceGuid Guid;
        public float Rating;
        public bool ShouldSave;
        public bool PositiveTrait;
        public bool ValidStarterTrait;
        public List<OutChoreGroup> disabledChoreGroups = new List<OutChoreGroup>();
        public bool isTaskBeingRefused;
        public List<string> ignoredEffects = new List<string>();
        public string description;
        public List<AttributeModifier> SelfModifiers = new List<AttributeModifier>();

        public OutTrait(Trait tv)
        {
            this.Name = tv.Name;
            this.Id = tv.Id;
            this.IdHash = tv.IdHash;
            this.Disabled = tv.Disabled;
            this.Guid = tv.Guid;
            this.Rating = tv.Rating;
            this.ShouldSave = tv.ShouldSave;
            this.PositiveTrait = tv.PositiveTrait;
            this.ValidStarterTrait = tv.ValidStarterTrait;
            if(tv.disabledChoreGroups != null)
            {
                foreach (var choreGroup in tv.disabledChoreGroups)
                {
                     this.disabledChoreGroups.Add(new OutChoreGroup(choreGroup));
                }
            }
            this.isTaskBeingRefused = tv.isTaskBeingRefused;
            foreach(string ignoredEffect in tv.ignoredEffects)
            {
                this.ignoredEffects.Add(ignoredEffect);
            }
            this.description = tv.description;
            this.SelfModifiers = tv.SelfModifiers;
        }
    }
}

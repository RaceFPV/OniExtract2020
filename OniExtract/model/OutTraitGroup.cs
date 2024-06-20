using System;
using UnityEngine;
using Klei.AI;
using static Database.Spice;
using System.Collections.Generic;

namespace OniExtract2
{
    public class OutTraitGroup
    {
        public string Name;
        public string Id;
        public HashedString IdHash;
        public bool Disabled;
        public ResourceGuid Guid;
        public bool IsSpawnTrait;
        public List<OutTrait> modifiers = new List<OutTrait>();
        public int Count => modifiers.Count;


        public OutTraitGroup(TraitGroup tv)
        {
            this.Name = tv.Name;
            this.Id = tv.Id;
            this.IdHash = tv.IdHash;
            this.Disabled = tv.Disabled;
            this.Guid = tv.Guid;
            this.IsSpawnTrait = tv.IsSpawnTrait;
            foreach(Trait trait in tv.modifiers)
            {
                this.modifiers.Add(new OutTrait(trait));
            }
        }
    }
}

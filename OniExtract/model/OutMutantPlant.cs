using System;
using UnityEngine;
using static OniExtract2.Patches;
using System.Collections.Generic;
using Klei.AI;
using STRINGS;

namespace OniExtract2
{
    public class OutMutantPlant
    {
        public Tag speciesID;
        public Tag cachedSubspeciesID;
        public List<string> mutationIDs;

        public OutMutantPlant(MutantPlant tv)
        {
            this.speciesID = tv.SpeciesID;
            this.cachedSubspeciesID = tv.SubSpeciesID;
            this.mutationIDs = tv.MutationIDs;
        }
    }
}

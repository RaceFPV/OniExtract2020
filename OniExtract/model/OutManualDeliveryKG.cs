using System;
using UnityEngine;
using static OniExtract2.Patches;
using System.Collections.Generic;
using Klei.AI;
using STRINGS;
using KSerialization;

namespace OniExtract2
{
    public class OutManualDeliveryKG
    {
        public OutStorage storage;        
        public Tag requestedItemTag;
        public Tag[] forbiddenTags;        
        public float capacity = 100f;        
        public float refillMass = 10f;        
        public float MinimumMass = 10f;        
        public bool RoundFetchAmountToInt;        
        public float MassPerUnit = 1f;        
        public Operational.State operationalRequirement;        
        public bool allowPause;        
        public bool paused;        
        public HashedString choreTypeIDHash;
        public bool ShowStatusItem = true;
        public FetchList2 fetchList;

        public OutManualDeliveryKG(ManualDeliveryKG tv)
        {
            if(tv.DebugStorage != null)
            {
                this.storage = new OutStorage(tv.DebugStorage);
            }
            else
            {
                this.storage = null;
            }
            this.requestedItemTag = tv.requestedItemTag;
            this.forbiddenTags = tv.ForbiddenTags;
            this.capacity = tv.Capacity;
            this.refillMass = tv.refillMass;
            this.MinimumMass = tv.MinimumMass;
            this.RoundFetchAmountToInt = tv.RoundFetchAmountToInt;
            this.MassPerUnit = tv.MassPerUnit;
            this.operationalRequirement = tv.operationalRequirement;
            this.allowPause = tv.allowPause;
            this.paused = tv.IsPaused;
            this.choreTypeIDHash = tv.choreTypeIDHash;
            this.ShowStatusItem = tv.ShowStatusItem;
            this.fetchList = tv.DebugFetchList;
        }
    }
}

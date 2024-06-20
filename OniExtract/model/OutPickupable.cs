using System;
using UnityEngine;
using static OniExtract2.Patches;
using System.Collections.Generic;
using Klei.AI;
using STRINGS;

namespace OniExtract2
{
    public class OutPickupable
    {
        public bool IsEntombed;
        public float MinTakeAmount;
        public bool prevent_absorb_until_store;
        public OutPrimaryElement PrimaryElement;
        public float ReservedAmount;
        public int sortOrder;
        public OutStorage storage;
        //public float TotalAmount;
        //public float UnreservedAmount;
        public bool wasAbsorbed;
        public bool absorbable;
        public bool isClearable;
        public bool deleteOffGrid = true;
        //public KPrefabID KPrefabID;
        public Workable targetWorkable;
        public bool trackOnPickup = true;
        public bool useGunforPickup = true;

        public OutPickupable(Pickupable tv)
        {
            this.IsEntombed = tv.IsEntombed;
            this.MinTakeAmount = tv.MinTakeAmount;
            this.prevent_absorb_until_store = tv.prevent_absorb_until_stored;
            if(tv.PrimaryElement != null )
            {
                this.PrimaryElement = new OutPrimaryElement(tv.PrimaryElement);
            }
            else
            {
                this.PrimaryElement=null;
            }
            this.ReservedAmount = tv.ReservedAmount;
            this.sortOrder = tv.sortOrder;
            if(tv.storage != null)
            {
                this.storage = new OutStorage(tv.storage);
            }
            else
            {
                this.storage = null;
            }
            //this.TotalAmount = tv.TotalAmount;
            //this.UnreservedAmount = tv.UnreservedAmount;
            this.wasAbsorbed = tv.wasAbsorbed;
            this.absorbable = tv.absorbable;
            this.isClearable = tv.Clearable != null;
            this.deleteOffGrid = tv.deleteOffGrid;
            //this.KPrefabID = tv.KPrefabID;
            this.targetWorkable = tv.targetWorkable;
            this.trackOnPickup = tv.trackOnPickup;
            this.useGunforPickup = tv.useGunforPickup;
        }
    }
}

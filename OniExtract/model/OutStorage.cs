using System;
using UnityEngine;
using static OniExtract2.Patches;
using System.Collections.Generic;
using Klei.AI;
using STRINGS;

namespace OniExtract2
{
    public class OutStorage
    {
        public bool allowItemRemoval;
        public bool ignoreSourcePriority;
        public bool onlyTransferFromLowerPriority;
        public float capacityKg = 20000f;
        public bool showDescriptor;
        public bool doDiseaseTransfer = true;
        public List<Tag> storageFilters;
        public bool useGunForDelivery = true;
        public bool sendOnStoreOnSpawn;
        public bool showInUI = true;
        public bool allowClearable;
        public bool showCapacityStatusItem;
        public bool showCapacityAsMainStatus;
        public bool showUnreachableStatus;
        public bool showSideScreenTitleBar;
        public bool useWideOffsets;

        public Storage.FetchCategory fetchCategory;
        public int storageNetworkID = -1;
        public float storageFullMargin;

        public List<GameObject> items = new List<GameObject>();

        public bool dropOnLoad;
        protected float maxKGPerItem = float.MaxValue;
        private bool endOfLife;
        public bool allowSettingOnlyFetchMarkedItems = true;
        private bool onlyFetchMarkedItems;
        public float storageWorkTime = 1.5f;

        public OutStorage(Storage tv)
        {
            this.onlyTransferFromLowerPriority = tv.onlyTransferFromLowerPriority;
            this.capacityKg = tv.capacityKg;
            this.showDescriptor = tv.showDescriptor;
            this.doDiseaseTransfer = tv.doDiseaseTransfer;
            this.storageFilters = tv.storageFilters;
            this.useGunForDelivery = tv.useGunForDelivery;
            this.sendOnStoreOnSpawn = tv.sendOnStoreOnSpawn;
            this.showInUI = tv.showInUI;
            this.allowClearable = tv.allowClearable;
            this.showCapacityStatusItem = tv.showCapacityStatusItem;
            this.showCapacityAsMainStatus = tv.showCapacityAsMainStatus;
            this.showUnreachableStatus = tv.showUnreachableStatus;
            this.showSideScreenTitleBar = tv.showSideScreenTitleBar;
            this.useWideOffsets = tv.useWideOffsets;
            this.fetchCategory = tv.fetchCategory;
            this.storageNetworkID = tv.storageNetworkID;
            this.storageFullMargin = tv.storageFullMargin;
            this.items = tv.items;
            this.dropOnLoad = tv.dropOnLoad;
            this.endOfLife = tv.IsEndOfLife();
            this.allowSettingOnlyFetchMarkedItems = tv.allowSettingOnlyFetchMarkedItems;
            this.onlyFetchMarkedItems = tv.GetOnlyFetchMarkedItems();
            this.storageWorkTime = tv.storageWorkTime;
        }
    }
}

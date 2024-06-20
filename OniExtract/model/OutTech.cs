using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace OniExtract2
{
    public class OutTech
    {
        public string Name;
        public string Id;
        public HashedString IdHash;
        public bool Disabled;
        public ResourceGuid Guid;
        public List<string> requiredTechIDs = new List<string>();
        public List<string> unlockedTechIDs = new List<string>();
        public List<OutTechItem> unlockedItems = new List<OutTechItem>();
        public List<string> unlockedItemIDs = new List<string>();
        public int tier;
        public Dictionary<string, float> costsByResearchTypeID;
        public string desc;
        public string category;
        public Tag[] tags;
        public float width;
        public float height;

        public OutTech(Tech tv)
        {
            this.Name = tv.Name;
            this.Id = tv.Id;
            this.IdHash = tv.IdHash;
            this.Disabled = tv.Disabled;
            this.Guid = tv.Guid;
            this.requiredTechIDs = getOutTechIDList(tv.requiredTech);
            this.unlockedTechIDs = getOutTechIDList(tv.unlockedTech);
            this.unlockedItems = getOutTechItemList(tv.unlockedItems);
            this.unlockedItemIDs = tv.unlockedItemIDs;
            this.tier = tv.tier;
            this.costsByResearchTypeID = tv.costsByResearchTypeID;
            this.desc = tv.desc;
            this.category = tv.category;
            this.tags = tv.tags;
            this.width = tv.width;
            this.height = tv.height;

        }

        private static List<string> getOutTechIDList(List<Tech> techList)
        {
            var result = new List<string>();
            foreach (Tech item in techList)
            {
                result.Add(item.Id);
            }

            return result;
        }

        private static List<OutTechItem> getOutTechItemList(List<TechItem> techItems)
        {
            var result = new List<OutTechItem>();
            foreach (TechItem item in techItems)
            {
                result.Add(new OutTechItem(item));
            }
            return result;
        }
    }
}

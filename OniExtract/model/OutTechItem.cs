using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace OniExtract2
{
    public class OutTechItem
    {
        public string Name;
        public string Id;
        public HashedString IdHash;
        public bool Disabled;
        public ResourceGuid Guid;
        public string description;
        public string parentTechId;
        public string[] dlcIds;

        public OutTechItem(TechItem tv)
        {
            this.Name = tv.Name;
            this.Id = tv.Id;
            this.IdHash = tv.IdHash;
            this.Disabled = tv.Disabled;
            this.Guid = tv.Guid;
            this.description = tv.description;
            this.parentTechId = tv.parentTechId;
            this.dlcIds = tv.dlcIds;
        }
    }
}

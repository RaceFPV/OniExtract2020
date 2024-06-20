using System;
using UnityEngine;
using Klei.AI;
using static Database.Spice;
using System.Collections.Generic;

namespace OniExtract2
{
    public class OutChoreType
    {
        public string Name;
        public string Id;
        public HashedString IdHash;
        public bool Disabled;
        public ResourceGuid Guid;
        public OutStatusItem statusItem;
        public HashSet<Tag> tags = new HashSet<Tag>();
        public HashSet<Tag> interruptExclusion;
        public string reportName;
        public Urge urge;
        public List<OutChoreGroup> groups = new List<OutChoreGroup>();
        public int priority;
        public int interruptPriority;
        public int explicitPriority;

        public OutChoreType(ChoreType tv)
        {
            this.Name = tv.Name;
            this.Id = tv.Id;
            this.IdHash = tv.IdHash;
            this.Disabled = tv.Disabled;
            this.Guid = tv.Guid;
            this.statusItem = new OutStatusItem(tv.statusItem);
            this.tags = tv.tags;
            this.interruptExclusion = tv.interruptExclusion;
            this.reportName = tv.reportName;
            this.urge = tv.urge;
            foreach (ChoreGroup choreGroup in tv.groups)
            {
                this.groups.Add(new OutChoreGroup(choreGroup));
            }
            this.priority = tv.priority;
            this.interruptPriority = tv.interruptPriority;
            this.explicitPriority = tv.explicitPriority;
        }
    }
}

using System;
using UnityEngine;
using System.Collections.Generic;

namespace OniExtract2
{
    public class OutChoreGroup
    {
        public string Name;
        public string Id;
        public HashedString IdHash;
        public bool Disabled;
        public ResourceGuid Guid;
        public List<string> choreTypeIDs = new List<string>();
        public Klei.AI.Attribute attribute;
        public string description;
        public string sprite;
        public bool userPrioritizable;
        public int DefaultPersonalPriority;

        public OutChoreGroup(ChoreGroup tv)
        {
            this.Name = tv.Name;
            this.Id = tv.Id;
            this.IdHash = tv.IdHash;
            this.Disabled = tv.Disabled;
            this.Guid = tv.Guid;
            foreach (ChoreType choreType in tv.choreTypes)
            {
                this.choreTypeIDs.Add(choreType.Id);
            }
            this.attribute = tv.attribute;
            this.description = tv.description;
            this.sprite = tv.sprite;
            this.userPrioritizable = tv.userPrioritizable;
            this.DefaultPersonalPriority = tv.DefaultPersonalPriority;


        }
    }
}

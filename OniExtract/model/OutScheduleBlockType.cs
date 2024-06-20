using System;
using UnityEngine;
using Klei.AI;
using static Database.Spice;
using System.Collections.Generic;

namespace OniExtract2
{
    public class OutScheduleBlockType
    {
        public string Name;
        public string Id;
        public HashedString IdHash;
        public bool Disabled;
        public ResourceGuid Guid;
        public BColor color;
        public string description;

        public OutScheduleBlockType(ScheduleBlockType tv)
        {
            this.Name = tv.Name;
            this.Id = tv.Id;
            this.IdHash = tv.IdHash;
            this.Disabled = tv.Disabled;
            this.Guid = tv.Guid;
            this.color = new BColor(tv.color);
            this.description = tv.description;
        }
    }
}

using System;
using UnityEngine;
using Klei.AI;
using static Database.Spice;
using System.Collections.Generic;

namespace OniExtract2
{
    public class OutScheduleGroup
    {
        public string Name;
        public string Id;
        public HashedString IdHash;
        public bool Disabled;
        public ResourceGuid Guid;
        public int defaultSegments;
        public string description;
        public string notificationTooltip;
        public List<OutScheduleBlockType> allowedTypes = new List<OutScheduleBlockType>();
        public bool alarm;

        public OutScheduleGroup(ScheduleGroup tv)
        {
            this.Name = tv.Name;
            this.Id = tv.Id;
            this.IdHash = tv.IdHash;
            this.Disabled = tv.Disabled;
            this.Guid = tv.Guid;
            this.defaultSegments = tv.defaultSegments;
            this.description = tv.description;
            this.notificationTooltip = tv.notificationTooltip;
            foreach (ScheduleBlockType type in tv.allowedTypes)
            {
                this.allowedTypes.Add(new OutScheduleBlockType(type));
            }
            this.alarm = tv.alarm;
        }
    }
}

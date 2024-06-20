using System;
using UnityEngine;
using Klei.AI;
using static Database.Spice;
using System.Collections.Generic;
using static StatusItem;

namespace OniExtract2
{
    public class OutStatusItem
    {
        public string Name;
        public string Id;
        public HashedString IdHash;
        public bool Disabled;
        public ResourceGuid Guid;
        public string tooltipText;
        public string notificationText;
        public string notificationTooltipText;
        public string soundPath;
        public string iconName;
        public bool unique;
        public TintedSprite sprite;
        public bool shouldNotify;
        public IconType iconType;
        public NotificationType notificationType;
        public Notification.ClickCallback notificationClickCallback;
        //public Func<string, object, string> resolveStringCallback;
        //public Func<string, object, string> resolveTooltipCallback;
        public bool resolveStringCallback_shouldStillCallIfDataIsNull;
        public bool resolveTooltipCallback_shouldStillCallIfDataIsNull;
        public bool allowMultiples;
        //public Func<HashedString, object, bool> conditionalOverlayCallback;
        public HashedString render_overlay;
        public int status_overlays;
        public Action<object> statusItemClickCallback;


        public OutStatusItem(StatusItem tv)
        {
            this.Name = tv.Name;
            this.Id = tv.Id;
            this.IdHash = tv.IdHash;
            this.Disabled = tv.Disabled;
            this.Guid = tv.Guid;
            this.tooltipText = tv.tooltipText;
            this.notificationText = tv.notificationText;
            this.notificationTooltipText = tv.notificationTooltipText;
            this.soundPath = tv.soundPath;
            this.iconName = tv.iconName;
            this.unique = tv.unique;
            this.sprite = tv.sprite;
            this.shouldNotify = tv.shouldNotify;
            this.iconType = tv.iconType;
            this.notificationType = tv.notificationType;
            this.notificationClickCallback = tv.notificationClickCallback;
            this.resolveStringCallback_shouldStillCallIfDataIsNull = tv.resolveStringCallback_shouldStillCallIfDataIsNull;
            this.resolveTooltipCallback_shouldStillCallIfDataIsNull = tv.resolveTooltipCallback_shouldStillCallIfDataIsNull;
            this.allowMultiples = tv.allowMultiples;
            this.render_overlay = tv.render_overlay;
            this.status_overlays = tv.status_overlays;
            this.statusItemClickCallback = tv.statusItemClickCallback;
        }
    }
}

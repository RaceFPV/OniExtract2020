using System;
using UnityEngine;
using Klei.AI;
using static Database.Spice;
using System.Collections.Generic;
using Database;
using ProcGen;

namespace OniExtract2
{
    public class OutStory
    {
        public string Name;
        public string Id;
        public HashedString IdHash;
        public bool Disabled;
        public ResourceGuid Guid;
        public int kleiUseOnlyCoordinateOffset;
        public bool autoStart;
        public string keepsakePrefabId;
        public readonly string worldgenStoryTraitKey;
        public string sandboxStampTemplateId;
        private WorldTrait StoryTrait;
        public int HashId;

        public OutStory(Story tv)
        {
            this.Name = tv.Name;
            this.Id = tv.Id;
            this.IdHash = tv.IdHash;
            this.Disabled = tv.Disabled;
            this.Guid = tv.Guid;
            this.kleiUseOnlyCoordinateOffset = tv.kleiUseOnlyCoordinateOffset;
            this.autoStart = tv.autoStart;
            this.keepsakePrefabId = tv.keepsakePrefabId;
            this.worldgenStoryTraitKey = tv.worldgenStoryTraitKey;
            this.sandboxStampTemplateId = tv.sandboxStampTemplateId;
            this.StoryTrait = tv.StoryTrait;
            this.HashId = tv.HashId;
        }
    }
}

using System;
using UnityEngine;
using static OniExtract2.Patches;
using System.Collections.Generic;
using Klei.AI;
using STRINGS;

namespace OniExtract2
{
    public class OutComet
    {
        public int addDiseaseCount;
        public int addTiles;
        public int addTilesMaxHeight;
        public int addTilesMinHeight;
        public float bunkerDamageMultiplier;
        public bool canHitDuplicants;
        public string[] craterPrefabs;
        public bool destroyOnExplode = true;
        public byte diseaseIdx = byte.MaxValue;
        public bool affectedByDifficulty = true;
        public Vector2 elementReplaceTileTemperatureRange = new Vector2(800f, 1000f);
        public int entityDamage = 1;
        public SimHashes EXHAUST_ELEMENT = SimHashes.CarbonDioxide;
        public float EXHAUST_RATE = 50f;
        public SpawnFXHashes explosionEffectHash;
        //public Vector2I explosionOreCount = new Vector2I(0, 0);
        public Vector2 explosionSpeedRange = new Vector2(8f, 14f);
        public Vector2 explosionTemperatureRange = new Vector2(500f, 700f);
        public string flyingSound;
        public int flyingSoundID;
        //public Ref<KPrefabID> ignoreObstacleForDamage = new Ref<KPrefabID>();
        public string impactSound;
        public string[] lootOnDestroyedByMissile;
        public Vector2 massRange;
        public System.Action OnImpact;
        public Vector2 spawnAngle = new Vector2(-100f, -80f);
        public Vector2 spawnVelocity = new Vector2(12f, 15f);
        public bool spawnWithOffset;
        public int splashRadius = 1;
        public bool Targeted;
        public Vector2 temperatureRange;
        public float totalTileDamage = 0.2f;
        public Tag typeID;
        public Vector2 velocity;
        public float windowDamageMultiplier = 5f;

        public OutComet(Comet tv)
        {
            this.addDiseaseCount = tv.addDiseaseCount;
            this.addTiles = tv.addTiles;
            this.addTilesMaxHeight = tv.addTilesMaxHeight;
            this.addTilesMinHeight = tv.addTilesMinHeight;
            this.bunkerDamageMultiplier = tv.bunkerDamageMultiplier;
            this.canHitDuplicants = tv.canHitDuplicants;
            this.craterPrefabs = tv.craterPrefabs;
            this.destroyOnExplode = tv.destroyOnExplode;
            this.diseaseIdx = tv.diseaseIdx;
            this.affectedByDifficulty = tv.affectedByDifficulty;
            this.elementReplaceTileTemperatureRange = tv.elementReplaceTileTemperatureRange;
            this.entityDamage = tv.entityDamage;
            this.EXHAUST_ELEMENT = tv.EXHAUST_ELEMENT;
            this.EXHAUST_RATE = tv.EXHAUST_RATE;
            this.explosionEffectHash = tv.explosionEffectHash;
            //this.explosionOreCount = tv.explosionOreCount;
            this.explosionSpeedRange = tv.explosionSpeedRange;
            this.explosionTemperatureRange = tv.explosionTemperatureRange;
            this.flyingSound = tv.flyingSound;
            this.flyingSoundID = tv.flyingSoundID;
            //this.ignoreObstacleForDamage = tv.ignoreObstacleForDamage;
            this.impactSound = tv.impactSound;
            this.lootOnDestroyedByMissile = tv.lootOnDestroyedByMissile;
            this.massRange = tv.massRange;
            this.OnImpact = tv.OnImpact;
            this.spawnAngle = tv.spawnAngle;
            this.spawnVelocity = tv.spawnVelocity;
            this.spawnWithOffset = tv.spawnWithOffset;
            this.splashRadius = tv.splashRadius;
            this.Targeted = tv.Targeted;
            this.temperatureRange = tv.temperatureRange;
            this.totalTileDamage = tv.totalTileDamage;
            this.typeID = tv.typeID;
            this.velocity = tv.Velocity;
            this.windowDamageMultiplier = tv.windowDamageMultiplier;
        }
    }
}

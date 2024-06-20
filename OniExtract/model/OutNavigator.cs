using System;
using UnityEngine;
using static OniExtract2.Patches;
using System.Collections.Generic;
using Klei.AI;
using STRINGS;
using static Health;
using static Navigator;

namespace OniExtract2
{
    public class OutNavigator
    {
        public NavType CurrentNavType;
        public bool DebugDrawPath;
        public float defaultSpeed = 1f;
        public Dictionary<NavType, int> distanceTravelledByNavType;
        public bool executePathProbeTaskAsync;
        public PathFinder.PotentialPath.Flags flags;
        public int maxProbingRadius;
        public string NavGridName;
        public PathFinder.Path path;
        public PathProber PathProber;
        public PathProbeTask pathProbeTask;
        public Grid.SceneLayer sceneLayer = Grid.SceneLayer.Move;
        public TransitionDriver transitionDriver;
        public bool updateProber;

        public OutNavigator(Navigator tv)
        {
            this.CurrentNavType = tv.CurrentNavType;
            this.DebugDrawPath  = tv.DebugDrawPath;
            this.defaultSpeed = tv.defaultSpeed;
            this.distanceTravelledByNavType = tv.distanceTravelledByNavType;
            this.executePathProbeTaskAsync = tv.executePathProbeTaskAsync;
            this.flags = tv.flags;
            this.maxProbingRadius = tv.maxProbingRadius;
            this.NavGridName = tv.NavGridName;
            this.path = tv.path;
            this.pathProbeTask = tv.pathProbeTask;
            this.sceneLayer = tv.sceneLayer;
            this.transitionDriver = tv.transitionDriver;
            this.updateProber = tv.updateProber;
        }
    }
}

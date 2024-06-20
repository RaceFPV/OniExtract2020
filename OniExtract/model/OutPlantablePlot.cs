﻿using System;
using UnityEngine;
using static OniExtract2.Patches;
using System.Collections.Generic;
using Klei.AI;
using STRINGS;
using static EnergyGenerator;

namespace OniExtract2
{
    public class OutPlantablePlot
    {
        public Grid.SceneLayer plantLayer = Grid.SceneLayer.BuildingBack;
        public Vector3 occupyingObjectVisualOffset = Vector3.zero;
        public bool has_liquid_pipe_input;
        public bool ValidPlant;
        public bool AcceptsIrrigation;
        public bool AcceptsFertilizer;

        public OutPlantablePlot(PlantablePlot tv)
        {
            this.plantLayer = tv.plantLayer;
            this.occupyingObjectVisualOffset = tv.occupyingObjectVisualOffset;
            this.has_liquid_pipe_input = tv.has_liquid_pipe_input;
            this.ValidPlant = tv.ValidPlant;
            this.AcceptsIrrigation = tv.AcceptsIrrigation;
            this.AcceptsFertilizer = tv.AcceptsFertilizer;
        }
    }
}
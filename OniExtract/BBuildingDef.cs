﻿using System;
using UnityEngine;
using static OniExtract2.Patches;
using System.Collections.Generic;
using Klei.AI;
using STRINGS;

namespace OniExtract2
{
    public class BBuildingDef
    {
        public string name;
        public OutEnergyGenerator energyGenerator;
        public OutConduitConsumer conduitConsumer;
        public OutConduitDispenser conduitDispenser;
        public OutPlantablePlot plantablePlot;
        public List<OutElementConverter> elementConverters = new List<OutElementConverter>();
        public List<OutElementConsumer> elementConsumers = new List<OutElementConsumer>();
        public List<OutPassiveElementConsumer> passiveElementConsumers = new List<OutPassiveElementConsumer>();
        public OutStorage storage = null;

        public BBuildingDef(string name)
        {
            this.name = name;
        }
    }
}
using System;
using UnityEngine;
using static OniExtract2.Patches;
using System.Collections.Generic;
using Klei.AI;
using STRINGS;

namespace OniExtract2
{
    public class OutTemperatureVulnerable
    {
        public float temperatureLethalLow;
        public float temperatureLethalHigh;
        public float temperatureWarningLow;
        public float temperatureWarningHigh;
        public OutTemperatureVulnerable(float temperatureLethalLow, float temperatureLethalHigh, float temperatureWarningLow, float temperatureWarningHigh)
        {
            this.temperatureLethalLow = temperatureLethalLow;
            this.temperatureLethalHigh = temperatureLethalHigh;
            this.temperatureWarningLow = temperatureWarningLow;
            this.temperatureWarningHigh = temperatureWarningHigh;
        }

        public OutTemperatureVulnerable(TemperatureVulnerable tv)
        {
            this.temperatureLethalLow = tv.TemperatureLethalLow;
            this.temperatureLethalHigh = tv.TemperatureLethalHigh;
            this.temperatureWarningLow = tv.TemperatureWarningLow;
            this.temperatureWarningHigh = tv.TemperatureWarningHigh;
        }
    }
}

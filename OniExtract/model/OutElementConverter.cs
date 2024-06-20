using System;
using UnityEngine;
using static OniExtract2.Patches;
using System.Collections.Generic;
using Klei.AI;
using STRINGS;
using static EnergyGenerator;
using static ElementConverter;

namespace OniExtract2
{
    public class OutElementConverter
    {
        public HashSet<OutConsumedElement> consumedElements;
        public HashSet<OutOutputElement> outputElements;
        public Action<float> onConvertMass;
        public Operational.State OperationalRequirement = Operational.State.Active;
        public bool showDescriptors = true;
        public bool ShowInUI = true;
        public float OutputMultiplier;

        public OutElementConverter(ElementConverter tv)
        {
            this.consumedElements = new HashSet<OutConsumedElement>();
            if (tv.consumedElements != null && tv.consumedElements.Length > 0)
            {
                foreach (var kv in tv.consumedElements)
                {
                    this.consumedElements.Add(new OutConsumedElement(kv));
                }
            }
            this.outputElements = new HashSet<OutOutputElement>();
            if (tv.outputElements != null && tv.outputElements.Length > 0)
            {
                foreach (var kv in tv.outputElements)
                {
                    this.outputElements.Add(new OutOutputElement(kv));
                }
            }


            this.onConvertMass = tv.onConvertMass;
            this.OperationalRequirement = tv.OperationalRequirement;
            this.showDescriptors = tv.showDescriptors;
            this.ShowInUI = tv.ShowInUI;
            this.OutputMultiplier = tv.OutputMultiplier;
        }
    }
}
using System;
using UnityEngine;
using Klei.AI;
using static Database.Spice;

namespace OniExtract2
{
    public class OutSpice
    {
        public string Name;
        public string Id;
        public HashedString IdHash;
        public bool Disabled;
        public ResourceGuid Guid;
        public Ingredient[] Ingredients;
        public float TotalKG;
        public AttributeModifier StatBonus;
        public AttributeModifier FoodModifier;
        public AttributeModifier CalorieModifier;
        public BColor PrimaryColor;
        public BColor SecondaryColor;
        public string Image;
        public string[] DlcIds;


        public OutSpice(Database.Spice tv)
        {
            this.Name = tv.Name;
            this.Id = tv.Id;
            this.IdHash = tv.IdHash;
            this.Disabled = tv.Disabled;
            this.Guid = tv.Guid;
            this.Ingredients = tv.Ingredients;
            this.TotalKG = tv.TotalKG;
            this.StatBonus = tv.StatBonus;
            this.FoodModifier = tv.FoodModifier;
            this.CalorieModifier = tv.CalorieModifier;
            this.PrimaryColor = new BColor(tv.PrimaryColor);
            this.SecondaryColor = new BColor(tv.SecondaryColor);
            this.Image = tv.Image;
            this.DlcIds = tv.DlcIds;
        }
    }
}

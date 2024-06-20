using OniExtract2;
using System;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using static EdiblesManager;

public class ExportFood : BaseExport
{
    public override string ExportFileName { get; set; } = "food";
    public List<FoodInfo> foodInfoList;

    public ExportFood()
	{
        foodInfoList = new List<FoodInfo>();
    }

    public static void ExportAllFood(ExportFood export)
    {
        foreach (var foodInfo in EdiblesManager.GetAllFoodTypes())
        {
            export.foodInfoList.Add(foodInfo);
        }
        export.ExportJsonFile();
    }
}

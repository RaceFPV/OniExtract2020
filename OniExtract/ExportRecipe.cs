using System.Collections.Generic;

public class ExportRecipe : BaseExport
{
    public override string ExportFileName { get; set; } = "recipe";
    public List<ComplexRecipe> recipes;

    public ExportRecipe()
	{
        recipes = new List<ComplexRecipe>();
    }

    public static void ExportComplexRecipes(ExportRecipe export)
    {
        foreach (var mRecipe in ComplexRecipeManager.Get().recipes)
        {
            export.recipes.Add(mRecipe);
        }
        export.ExportJsonFile();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Omegasis.Revitalize.Framework.Constants.CraftingIds;

namespace Omegasis.Revitalize.Framework.Constants.ItemIds.Objects
{
    public class CraftingStations
    {
        public const string Anvil_Id = "Revitalize.Objects.Crafting.CraftingStations.Anvil";
        public const string WorkStation_Id = "Revitalize.Objects.Crafting.CraftingStations.Workbench";

        public static string GetCraftingStationNameFromRecipeBookId(string RecipeBookId)
        {
            switch (RecipeBookId)
            {
                case CraftingRecipeBooks.AnvilCraftingRecipes:
                    return "Anvil";
                case CraftingRecipeBooks.WorkbenchCraftingRecipies:
                    return "Workbench";
                default:
                    return "{Invalid Crafting Book Name}";
            }

        }
    }
}

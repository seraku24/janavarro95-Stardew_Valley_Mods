using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Omegasis.Revitalize.Framework.World.Objects.Crafting;

namespace Omegasis.Revitalize.Framework.World.Objects.InformationFiles.Json.Crafting
{
    /// <summary>
    /// Holds information for blueprint items in json format.
    /// </summary>
    public class JsonCraftingBlueprint:JsonBasicItemInformation
    {
        public JsonItemReference itemToDraw;

        public Dictionary<string, string> recipesToUnlock;

        public JsonCraftingBlueprint()
        {
            this.itemToDraw = new JsonItemReference();
            this.recipesToUnlock = new Dictionary<string, string>()
            {
                { "BookIdHere","RecipeIdHere" }
            };
        }

        public virtual Blueprint toBlueprint()
        {
            return new Blueprint(this);
        }

    }
}

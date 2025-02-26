using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StardewValley;
using static Omegasis.Revitalize.Framework.Constants.Enums;

namespace Omegasis.Revitalize.Framework.World.WorldUtilities
{

    /// <summary>
    /// Utilities for playing various sounds for the game.
    /// </summary>
    public static class SoundUtilities
    {

        /// <summary>
        /// Gets the name of the StardewValley Sound.
        /// </summary>
        /// <param name="stardewSound"></param>
        /// <returns></returns>
        public static string GetSoundNameFromStardewSound(StardewSound stardewSound)
        {
            return Enum.GetName<StardewSound>(stardewSound);
        }

        public static void PlaySound(StardewSound stardewSound)
        {
            string soundName = GetSoundNameFromStardewSound(stardewSound);
            Game1.playSound(soundName);
        }

        public static void PlaySound(this GameLocation GameLocation, StardewSound stardewSound)
        {
            string soundName = GetSoundNameFromStardewSound(stardewSound);
            GameLocation.playSound(GetSoundNameFromStardewSound(stardewSound));
        }

    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegasis.Revitalize.Framework.Constants.PathConstants.Data
{
    public class DataPaths
    {


        public static string TemplatesPath = Path.Combine(RelativePaths.Content_Data_Folder, RelativePaths.TemplatesFoldersName);
        public static string AnimationTemplatesPath = Path.Combine(TemplatesPath, "Animations");

    }
}

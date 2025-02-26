using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Omegasis.Revitalize.Framework.World.Objects.InformationFiles;

namespace Omegasis.Revitalize.Framework.World.Objects.Interfaces
{
    public interface IBasicItemInfoProvider
    {
        public BasicItemInformation basicItemInformation { get; set; }

        public string Id { get; }
    }
}

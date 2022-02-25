using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceOfEquipment_Yakunin.HelpClass
{
    internal class AppData
    {
        public static EF.Entities Context { get; } = new EF.Entities();
    }
}

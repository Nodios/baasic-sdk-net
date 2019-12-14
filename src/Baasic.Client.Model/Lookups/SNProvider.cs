using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baasic.Client.Model.Lookups
{
    public class SNProvider : ModelBase
    {
        public string Abrv { get; set; }
        public bool HasEmail { get; set; }
        public string Name { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baasic.Client.Model.ACL
{
    public class ACLObjectBase : IACLObject
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}

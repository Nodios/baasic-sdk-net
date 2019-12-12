using System.Collections.Generic;

namespace Baasic.Client.Model.ACL
{
    public class ACLPolicy : ACLBase
    {
        public ACLAction Action { get; set; }
        public ACLRole Role { get; set; }
        public ACLUser User { get; set; }

        public IEnumerable<string> Embed { get; set; }
    }
}

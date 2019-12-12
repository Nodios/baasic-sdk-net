using System.Collections.Generic;

namespace Baasic.Client.Model.ACL
{
    public class ACLOptionsBase
    {
        public string Id { get; set; }
        public IEnumerable<ACLBase> ACL { get; set; }
    }
}

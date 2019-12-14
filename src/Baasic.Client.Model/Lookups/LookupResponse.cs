using System.Collections.Generic;

namespace Baasic.Client.Model.Lookups
{
    public class LookupResponse : ModelBase
    {
        public IEnumerable<AccessAction> AccessAction { get; set; }
        public IEnumerable<AccessSection> AccessSection { get; set; }
        public IEnumerable<Role> Role { get; set; }
        public IEnumerable<SNProvider> SNProvider { get; set; }
    }
}

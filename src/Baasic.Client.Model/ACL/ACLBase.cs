namespace Baasic.Client.Model.ACL
{
    public class ACLBase : IACL
    {
        public string ActionId { get; set; }
        public string RoleId { get; set; }
        public string UserId { get; set; }
    }
}

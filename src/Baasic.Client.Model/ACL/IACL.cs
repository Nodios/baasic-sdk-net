namespace Baasic.Client.Model.ACL
{
    public interface IACL
    {
        string ActionId { get; set; }
        string RoleId { get; set; }
        string UserId { get; set; }
    }
}

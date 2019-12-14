using Baasic.Client.Model.Lookups;
using System.Threading.Tasks;

namespace Baasic.Client.Clients.Lookups
{
    public interface ILookupClient
    {
        Task<LookupResponse> GetAsync(string embed = "");
    }
}

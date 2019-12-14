using Baasic.Client.Common.Configuration;
using Baasic.Client.Core;
using Baasic.Client.Model.Lookups;
using Baasic.Client.Utility;
using System;
using System.Threading.Tasks;

namespace Baasic.Client.Clients.Lookups
{
    public class LookupClient : ClientBase, ILookupClient
    {
        public LookupClient(IClientConfiguration configuration, IBaasicClientFactory baasicClientFactory) : base(configuration)
        {
            BaasicClientFactory = baasicClientFactory;
        }

        protected IBaasicClientFactory BaasicClientFactory { get; private set; }

        protected override string ModuleRelativePath => "lookups";

        public Task<LookupResponse> GetAsync(string embed = DefaultEmbed)
        {
            using (IBaasicClient client = BaasicClientFactory.Create(Configuration))
            {
                UrlBuilder urlBuilder = new UrlBuilder(client.GetApiUrl(ModuleRelativePath));
                InitializeQueryString(urlBuilder, embed, "");

                return client.GetAsync<LookupResponse>(urlBuilder.ToString());
            }
        }
    }
}

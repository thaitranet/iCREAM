using Contentful.Core;
using iCREAM.Domain.Models.ContentTypes;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace iCREAM.Service.Repositories
{
    public class HomePageRepository
    {
        private readonly HttpClient httpClient;
        private readonly IConfiguration configuration;

        public HomePageRepository(HttpClient httpClient, IConfiguration configuration)
        {
            this.httpClient = httpClient;
            this.configuration = configuration;
        }

        public async Task<HomePage> GetItemAsync()
        {
            var client = new ContentfulClient(httpClient, 
                configuration["ContentfulOptions:DeliveryApiKey"], 
                configuration["ContentfulOptions:PreviewApiKey"], 
                configuration["ContentfulOptions:SpaceId"]);

            return (await client.GetEntries<HomePage>()).FirstOrDefault();
        }
    }
}

using System.Net;

using CompaniesHouseCrawler.Models;

using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

using RestSharp;
using RestSharp.Authenticators;

namespace CompaniesHouseCrawler.Pages
{
    public class IndexModel : PageModel
    {
        private const string SearchUrlBase = "https://find-and-update.company-information.service.gov.uk/search?q=";

        private readonly ILogger<IndexModel> logger;
        private readonly IConfiguration configuration;

        public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration)
        {
            this.logger = logger;
            this.configuration = configuration;
        }

        public string Name { get; set; }

        public void OnGet()
        {
        }

        public void OnPostSubmit(SearchModel search)
        {
            this.Name = search.Name;

            var apiKey = this.configuration["APIKey"];

            var client = new RestClient("https://api.company-information.service.gov.uk")
            {
                Authenticator = new HttpBasicAuthenticator(apiKey, string.Empty)
            };

            var request = new RestRequest("search/officers", Method.GET).AddParameter("q", this.Name);
            var response = client.Execute(request);

            //https://api.company-information.service.gov.uk/search/officers?q=douglass+barrowman

            var json = response.Content;
        }
    }
}
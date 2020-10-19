using CompaniesHouseCrawler.Models;

using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CompaniesHouseCrawler.Pages
{
    public class IndexModel : PageModel
    {
        private const string SearchUrlBase = "https://find-and-update.company-information.service.gov.uk/search?q=";

        private readonly ILogger<IndexModel> logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            this.logger = logger;
        }

        public string Name { get; set; }

        public void OnGet()
        {
        }

        public void OnPostSubmit(SearchModel search)
        {
            this.Name = search.Name;
        }
    }
}
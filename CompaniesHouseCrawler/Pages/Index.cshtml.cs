// <copyright file="Index.cshtml.cs" company="Prime 23 Consultancy Limited">
// Copyright © 2016-2020 Prime 23 Consultancy Limited. All rights reserved.</copyright>

using CompaniesHouseCrawler.Models;

using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace CompaniesHouseCrawler.Pages
{
    public class IndexModel : PageModel
    {
        private readonly SearchEngine searchEngine;

        public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration)
        {
            //TODO DI this
            string apiKey = configuration["APIKey"];
            this.searchEngine = new SearchEngine(apiKey);
        }

        public string Name { get; set; }

        public void OnGet()
        {
        }

        public void OnPostSubmit(SearchModel model)
        {
            this.Name = model.Name;

            this.searchEngine.Execute(model);
        }
    }
}
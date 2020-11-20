// <copyright file="Index.cshtml.cs" company="Prime 23 Consultancy Limited">
// Copyright © 2016-2020 Prime 23 Consultancy Limited. All rights reserved.</copyright>

using System;
using System.Collections.Generic;
using System.Linq;

using CompaniesHouseCrawler.Models;

using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serialization.Json;

namespace CompaniesHouseCrawler.Pages
{
    public class IndexModel : PageModel
    {
        private const string BaseUrl = "https://api.company-information.service.gov.uk";
        private const string Resource = "search/officers";

        private readonly IConfiguration configuration;

        private readonly ILogger<IndexModel> logger;

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

            var applyBirthMonthFilter = search.Month >= 1 && search.Month <= 12;
            var applyBirthYearFilter = search.Year >= 1900 && search.Year <= DateTime.Now.Year;

            var apiKey = this.configuration["APIKey"];

            var client = new RestClient(BaseUrl)
            {
                Authenticator = new HttpBasicAuthenticator(apiKey, string.Empty)
            };

            var request = new RestRequest(Resource, Method.GET).AddParameter("q", this.Name);
            var response = client.Execute(request);

            if (!response.IsSuccessful)
            {
                return;
            }

            var jsonDeserializer = new JsonDeserializer();

            var officers = jsonDeserializer.Deserialize<OfficerSearch>(response);

            var results = new List<Officer>();
            var names = this.Name.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (var officer in
                from officer in officers.Items
                let count = names.Count(t => officer.Title.Contains(t, StringComparison.OrdinalIgnoreCase))
                where count == names.Length
                select officer)
            {
                if (applyBirthMonthFilter && applyBirthYearFilter)
                {
                    if (officer.DateOfBirth.Month == search.Month &&
                        officer.DateOfBirth.Year == search.Year)
                    {
                        results.Add(officer);
                    }
                }
                else if (applyBirthMonthFilter)
                {
                    if (officer.DateOfBirth.Month == search.Month)
                    {
                        results.Add(officer);
                    }
                }
                else if (applyBirthYearFilter)
                {
                    if (officer.DateOfBirth.Year == search.Year)
                    {
                        results.Add(officer);
                    }
                }
                else
                {
                    results.Add(officer);
                }
            }

            var appointmentsLinks = results.Select(officer => officer.Links);

            //TODO get all appointments into object model
        }
    }
}
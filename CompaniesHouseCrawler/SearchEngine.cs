// <copyright file="SearchEngine.cs" company="Prime 23 Consultancy Limited">
// Copyright © 2016-2020 Prime 23 Consultancy Limited. All rights reserved.</copyright>

using System;
using System.Collections.Generic;
using System.Linq;

using CompaniesHouseCrawler.Models;

using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serialization.Json;

namespace CompaniesHouseCrawler
{
    public class SearchEngine
    {
        private const string BaseUrl = "https://api.company-information.service.gov.uk";
        private const string Resource = "search/officers";
        private readonly string apiKey;

        public SearchEngine(string apiKey)
        {
            this.apiKey = apiKey;
        }

        public void Execute(SearchModel search)
        {
            bool applyBirthMonthFilter = search.Month >= 1 && search.Month <= 12;
            bool applyBirthYearFilter = search.Year >= 1900 && search.Year <= DateTime.Now.Year;

            var client = new RestClient(BaseUrl)
            {
                Authenticator = new HttpBasicAuthenticator(this.apiKey, string.Empty)
            };

            var request = new RestRequest(Resource, Method.GET).AddParameter("q", search.Name);
            var response = client.Execute(request);

            if (!response.IsSuccessful)
            {
                return;
            }

            var jsonDeserializer = new JsonDeserializer();

            var officers = jsonDeserializer.Deserialize<OfficerSearch>(response);

            var results = new List<Officer>();
            var names = search.Name.Split(' ', StringSplitOptions.RemoveEmptyEntries);

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
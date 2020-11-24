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
        private readonly JsonDeserializer jsonDeserializer;

        public SearchEngine(string apiKey)
        {
            this.apiKey = apiKey;

            this.jsonDeserializer = new JsonDeserializer();
        }

        public void Execute(SearchModel search)
        {
            bool applyBirthMonthFilter = search.Month >= 1 && search.Month <= 12;
            bool applyBirthYearFilter = search.Year >= 1900 && search.Year <= DateTime.Now.Year;

            var client = new RestClient(BaseUrl)
            {
                Authenticator = new HttpBasicAuthenticator(this.apiKey, string.Empty)
            };

            var officers = this.GetOfficers(client, search, applyBirthMonthFilter, applyBirthYearFilter);
            if (officers == null)
            {
                // TODO
                return;
            }

            var appointmentsLinks = officers.Select(officer => officer.Links).ToList();

            var appointments = this.GetAppointments(client, appointmentsLinks);
            if (appointments == null)
            {
                // TODO
                return;
            }

            //TODO get all appointments into object model
        }

        private List<Appointment> GetAppointments(IRestClient client, IEnumerable<Links> appointmentsLinks)
        {
            var results = new List<Appointment>();

            foreach (AppointmentList appointmentList in from appointment in appointmentsLinks
                select new RestRequest(appointment.Self, Method.GET)
                into request
                select client.Execute(request)
                into response
                where response.IsSuccessful
                select this.jsonDeserializer.Deserialize<AppointmentList>(response))
            {
                results.AddRange(appointmentList.Items);
            }

            return results;
        }

        private List<Officer> GetOfficers(
            IRestClient client,
            SearchModel search,
            bool applyBirthMonthFilter,
            bool applyBirthYearFilter)
        {
            var request = new RestRequest(Resource, Method.GET).AddParameter("q", search.Name);
            var response = client.Execute(request);

            if (!response.IsSuccessful)
            {
                return null;
            }

            var officers = this.jsonDeserializer.Deserialize<OfficerSearch>(response);

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

            return results;
        }
    }
}
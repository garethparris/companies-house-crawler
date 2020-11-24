// <copyright file="AppointedTo.cs" company="Prime 23 Consultancy Limited">
// Copyright © 2016-2020 Prime 23 Consultancy Limited. All rights reserved.</copyright>

using System.Text.Json.Serialization;

namespace CompaniesHouseCrawler.Models
{
    public class AppointedTo
    {
        [JsonPropertyName("company_name")]
        public string CompanyName { get; set; }

        [JsonPropertyName("company_number")]
        public string CompanyNumber { get; set; }

        [JsonPropertyName("company_status")]
        public string CompanyStatus { get; set; }
    }
}
// <copyright file="LinkCompany.cs" company="Prime 23 Consultancy Limited">
// Copyright © 2016-2020 Prime 23 Consultancy Limited. All rights reserved.</copyright>

using System.Text.Json.Serialization;

namespace CompaniesHouseCrawler.Models
{
    public class LinkCompany
    {
        public string Charges { get; set; }

        [JsonPropertyName("filing_history")]
        public string FilingHistory { get; set; }

        public string Insolvency { get; set; }

        public string Officers { get; set; }

        [JsonPropertyName("persons_with_significant_control")]
        public string PersonsWithSignificantControl { get; set; }

        [JsonPropertyName("persons_with_significant_control_statements")]
        public string PersonsWithSignificantControlStatements { get; set; }

        public string Registers { get; set; }

        public string Self { get; set; }
    }
}
// <copyright file="ForeignAccounts.cs" company="Prime 23 Consultancy Limited">
// Copyright © 2016-2020 Prime 23 Consultancy Limited. All rights reserved.</copyright>

using System.Text.Json.Serialization;

namespace CompaniesHouseCrawler.Models
{
    public class ForeignAccounts
    {
        [JsonPropertyName("account_period_from")]
        public DayMonth AccountPeriodFrom { get; set; }

        [JsonPropertyName("account_period_to")]
        public DayMonth AccountPeriodTo { get; set; }

        [JsonPropertyName("must_file_within")]
        public MustFileWithin MustFileWithin { get; set; }
    }
}
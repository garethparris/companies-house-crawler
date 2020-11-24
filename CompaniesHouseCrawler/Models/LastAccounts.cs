// <copyright file="LastAccounts.cs" company="Prime 23 Consultancy Limited">
// Copyright © 2016-2020 Prime 23 Consultancy Limited. All rights reserved.</copyright>

using System.Text.Json.Serialization;

namespace CompaniesHouseCrawler.Models
{
    public class LastAccounts
    {
        [JsonPropertyName("made_up_to")]
        public string MadeUpTo { get; set; }

        [JsonPropertyName("period_end_on")]
        public string PeriodEndOn { get; set; }

        [JsonPropertyName("period_start_on")]
        public string PeriodStartOn { get; set; }

        public string Type { get; set; }
    }
}
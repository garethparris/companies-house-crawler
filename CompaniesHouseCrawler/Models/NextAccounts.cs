// <copyright file="NextAccounts.cs" company="Prime 23 Consultancy Limited">
// Copyright © 2016-2020 Prime 23 Consultancy Limited. All rights reserved.</copyright>

using System.Text.Json.Serialization;

namespace CompaniesHouseCrawler.Models
{
    public class NextAccounts
    {
        [JsonPropertyName("due_on")]
        public string DueOn { get; set; }

        public bool Overdue { get; set; }

        [JsonPropertyName("period_end_on")]
        public string PeriodEndOn { get; set; }

        [JsonPropertyName("period_start_on")]
        public string PeriodStartOn { get; set; }
    }
}
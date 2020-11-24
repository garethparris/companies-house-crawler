// <copyright file="AnnualReturn.cs" company="Prime 23 Consultancy Limited">
// Copyright © 2016-2020 Prime 23 Consultancy Limited. All rights reserved.</copyright>

using System.Text.Json.Serialization;

namespace CompaniesHouseCrawler.Models
{
    public class AnnualReturn
    {
        [JsonPropertyName("last_made_up_to")]
        public string LastMadeUpTo { get; set; }

        [JsonPropertyName("next_due")]
        public string NextDue { get; set; }

        [JsonPropertyName("next_made_up_to")]
        public string NextMadeUpTo { get; set; }

        public bool Overdue { get; set; }
    }
}
// <copyright file="OfficerList.cs" company="Prime 23 Consultancy Limited">
// Copyright © 2016-2020 Prime 23 Consultancy Limited. All rights reserved.</copyright>

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CompaniesHouseCrawler.Models
{
    internal class OfficerList
    {
        [JsonPropertyName("active_count")]
        public int ActiveCount { get; set; }

        public string eTag { get; set; }

        [JsonPropertyName("inactive_count")]
        public int InactiveCount { get; set; }

        public List<OfficerListItem> Items { get; set; }

        [JsonPropertyName("items_per_page")]
        public int ItemsPerPage { get; set; }

        public string Kind { get; set; }

        [JsonPropertyName("resigned_count")]
        public int ResignedCount { get; set; }

        [JsonPropertyName("start_index")]
        public int StartIndex { get; set; }

        [JsonPropertyName("total_results")]
        public int TotalResults { get; set; }
    }
}
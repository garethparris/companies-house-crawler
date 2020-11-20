// <copyright file="OfficerSearch.cs" company="Prime 23 Consultancy Limited">
// Copyright © 2016-2020 Prime 23 Consultancy Limited. All rights reserved.</copyright>

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CompaniesHouseCrawler.Models
{
    public class OfficerSearch
    {
        public List<Officer> Items { get; set; }

        [JsonPropertyName("items_per_page")]
        public int ItemsPerPage { get; set; }

        public string Kind { get; set; }

        [JsonPropertyName("start_index")]
        public int StartIndex { get; set; }

        [JsonPropertyName("total_results")]
        public int TotalResults { get; set; }
    }
}
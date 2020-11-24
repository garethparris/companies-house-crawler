// <copyright file="AppointmentList.cs" company="Prime 23 Consultancy Limited">
// Copyright © 2016-2020 Prime 23 Consultancy Limited. All rights reserved.</copyright>

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CompaniesHouseCrawler.Models
{
    public class AppointmentList
    {
        [JsonPropertyName("date_of_birth")]
        public MonthYear MonthYear { get; set; }

        public string eTag { get; set; }

        [JsonPropertyName("is_corporate_officer")]
        public string IsCorporateOfficer { get; set; }

        public List<Appointment> Items { get; set; }

        [JsonPropertyName("items_per_page")]
        public int ItemsPerPage { get; set; }

        public string Kind { get; set; }

        public LinkSelf Links { get; set; }

        public string Name { get; set; }

        [JsonPropertyName("start_index")]
        public int StartIndex { get; set; }

        [JsonPropertyName("total_results")]
        public int TotalResults { get; set; }
    }
}
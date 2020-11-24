// <copyright file="BranchCompanyDetails.cs" company="Prime 23 Consultancy Limited">
// Copyright © 2016-2020 Prime 23 Consultancy Limited. All rights reserved.</copyright>

using System.Text.Json.Serialization;

namespace CompaniesHouseCrawler.Models
{
    public class BranchCompanyDetails
    {
        [JsonPropertyName("business_activity")]
        public string BusinessActivity { get; set; }

        [JsonPropertyName("parent_company_name")]
        public string ParentCompanyName { get; set; }

        [JsonPropertyName("parent_company_number")]
        public string ParentCompanyNumber { get; set; }
    }
}
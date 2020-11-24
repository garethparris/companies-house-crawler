// <copyright file="PreviousCompanyNames.cs" company="Prime 23 Consultancy Limited">
// Copyright © 2016-2020 Prime 23 Consultancy Limited. All rights reserved.</copyright>

using System.Text.Json.Serialization;

namespace CompaniesHouseCrawler.Models
{
    public class PreviousCompanyNames
    {
        [JsonPropertyName("ceased_on")]
        public string CeasedOn { get; set; }

        [JsonPropertyName("effective_from")]
        public string EffectiveFrom { get; set; }

        public string Name { get; set; }
    }
}
// <copyright file="NameElements.cs" company="Prime 23 Consultancy Limited">
// Copyright © 2016-2020 Prime 23 Consultancy Limited. All rights reserved.</copyright>

using System.Text.Json.Serialization;

namespace CompaniesHouseCrawler.Models
{
    public class NameElements
    {
        public string Forename { get; set; }

        public string Honours { get; set; }

        [JsonPropertyName("other_forenames")]
        public string OtherForenames { get; set; }

        public string Surname { get; set; }

        public string Title { get; set; }
    }
}
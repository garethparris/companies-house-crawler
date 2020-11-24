// <copyright file="Identification.cs" company="Prime 23 Consultancy Limited">
// Copyright © 2016-2020 Prime 23 Consultancy Limited. All rights reserved.</copyright>

using System.Text.Json.Serialization;

namespace CompaniesHouseCrawler.Models
{
    public class Identification
    {
        [JsonPropertyName("identification_type")]
        public string IdentificationType { get; set; }

        [JsonPropertyName("legal_authority")]
        public string LegalAuthority { get; set; }

        [JsonPropertyName("legal_form")]
        public string LegalForm { get; set; }

        [JsonPropertyName("place_registered")]
        public string PlaceRegistered { get; set; }

        [JsonPropertyName("registration_number")]
        public string RegistrationNumber { get; set; }
    }
}
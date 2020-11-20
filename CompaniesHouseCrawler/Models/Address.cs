// <copyright file="Address.cs" company="Prime 23 Consultancy Limited">
// Copyright © 2016-2020 Prime 23 Consultancy Limited. All rights reserved.</copyright>

using System.Text.Json.Serialization;

namespace CompaniesHouseCrawler.Models
{
    public class Address
    {
        [JsonPropertyName("address_line_1")]
        public string AddressLine1 { get; set; }

        [JsonPropertyName("address_line_2")]
        public string AddressLine2 { get; set; }

        [JsonPropertyName("care_of")]
        public string CareOf { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("locality")]
        public string Locality { get; set; }

        [JsonPropertyName("po_box")]
        public string PoBox { get; set; }

        [JsonPropertyName("postal_code")]
        public string PostalCode { get; set; }

        [JsonPropertyName("premises")]
        public string Premises { get; set; }

        [JsonPropertyName("region")]
        public string Region { get; set; }
    }
}
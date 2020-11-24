// <copyright file="OfficerListItem.cs" company="Prime 23 Consultancy Limited">
// Copyright © 2016-2020 Prime 23 Consultancy Limited. All rights reserved.</copyright>

using System.Collections.Generic;
using System.Diagnostics;
using System.Text.Json.Serialization;

namespace CompaniesHouseCrawler.Models
{
    [DebuggerDisplay("O: {" + nameof(Name) + "}")]
    public class OfficerListItem
    {
        public Address Address { get; set; }

        [JsonPropertyName("appointed_on")]
        public string AppointedOn { get; set; }

        [JsonPropertyName("country_of_residence")]
        public string CountryOfResidence { get; set; }

        [JsonPropertyName("date_of_birth")]
        public DayMonthYear DateOfBirth { get; set; }

        [JsonPropertyName("former_names")]
        public List<FormerNames> FormerNames { get; set; }

        public Identification Identification { get; set; }

        public LinkOfficerList Links { get; set; }

        public string Name { get; set; }

        public string Nationality { get; set; }

        public string Occupation { get; set; }

        [JsonPropertyName("officer_role")]
        public string OfficerRole { get; set; }

        [JsonPropertyName("resigned_on")]
        public string ResignedOn { get; set; }
    }
}
// <copyright file="Appointment.cs" company="Prime 23 Consultancy Limited">
// Copyright © 2016-2020 Prime 23 Consultancy Limited. All rights reserved.</copyright>

using System.Text.Json.Serialization;

namespace CompaniesHouseCrawler.Models
{
    public class Appointment
    {
        public Address Address { get; set; }

        [JsonPropertyName("appointed_before")]
        public string AppointedBefore { get; set; }

        [JsonPropertyName("appointed_on")]
        public string AppointedOn { get; set; }

        [JsonPropertyName("appointed_to")]
        public AppointedTo AppointedTo { get; set; }

        [JsonPropertyName("country_of_residence")]
        public string CountryOfResidence { get; set; }

        public Identification Identification { get; set; }

        [JsonPropertyName("is_pre_1992_appointment")]
        public string IsPre1992Appointment { get; set; }

        public LinkAppointment Links { get; set; }

        public string Name { get; set; }

        [JsonPropertyName("name_elements")]
        public NameElements NameElements { get; set; }

        public string Nationality { get; set; }

        public string Occupation { get; set; }

        [JsonPropertyName("officer_role")]
        public string OfficerRole { get; set; }

        [JsonPropertyName("resigned_on")]
        public string ResignedOn { get; set; }
    }
}
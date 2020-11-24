// <copyright file="Officer.cs" company="Prime 23 Consultancy Limited">
// Copyright © 2016-2020 Prime 23 Consultancy Limited. All rights reserved.</copyright>

using System.Diagnostics;
using System.Text.Json.Serialization;

namespace CompaniesHouseCrawler.Models
{
    [DebuggerDisplay("O: {" + nameof(Title) + "}")]
    public class Officer
    {
        public Address Address { get; set; }

        [JsonPropertyName("date_of_birth")]
        public MonthYear DateOfBirth { get; set; }

        public string Description { get; set; }

        public string Kind { get; set; }

        public LinkSelf Links { get; set; }

        public string Snippet { get; set; }

        public string Title { get; set; }
    }
}
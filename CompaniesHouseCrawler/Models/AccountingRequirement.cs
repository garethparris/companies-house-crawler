// <copyright file="AccountingRequirement.cs" company="Prime 23 Consultancy Limited">
// Copyright © 2016-2020 Prime 23 Consultancy Limited. All rights reserved.</copyright>

using System.Text.Json.Serialization;

namespace CompaniesHouseCrawler.Models
{
    public class AccountingRequirement
    {
        [JsonPropertyName("foreign_account_type")]
        public string ForeignAccountType { get; set; }

        [JsonPropertyName("terms_of_account_publication")]
        public string TermsOfAccountPublication { get; set; }
    }
}
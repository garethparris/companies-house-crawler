// <copyright file="Accounts.cs" company="Prime 23 Consultancy Limited">
// Copyright © 2016-2020 Prime 23 Consultancy Limited. All rights reserved.</copyright>

using System.Text.Json.Serialization;

namespace CompaniesHouseCrawler.Models
{
    public class Accounts
    {
        [JsonPropertyName("accounting_reference_date")]
        public DayMonth AccountingReferenceDate { get; set; }

        [JsonPropertyName("last_accounts")]
        public LastAccounts LastAccounts { get; set; }

        [JsonPropertyName("next_accounts")]
        public NextAccounts NextAccounts { get; set; }

        [JsonPropertyName("next_due")]
        public string NextDue { get; set; }

        [JsonPropertyName("next_made_up_to")]
        public string NextMadeUpTo { get; set; }

        public bool Overdue { get; set; }
    }
}
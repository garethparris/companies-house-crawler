// <copyright file="ForeignCompanyDetails.cs" company="Prime 23 Consultancy Limited">
// Copyright © 2016-2020 Prime 23 Consultancy Limited. All rights reserved.</copyright>

using System.Text.Json.Serialization;

namespace CompaniesHouseCrawler.Models
{
    public class ForeignCompanyDetails
    {
        [JsonPropertyName("accounting_requirement")]
        public AccountingRequirement AccountingRequirement { get; set; }

        public ForeignAccounts Accounts { get; set; }

        [JsonPropertyName("business_activity")]
        public string BusinessActivity { get; set; }

        [JsonPropertyName("company_type")]
        public string CompanyType { get; set; }

        [JsonPropertyName("governed_by")]
        public string GovernedBy { get; set; }

        [JsonPropertyName("is_a_credit_finance_institution")]
        public bool IsACreditFinanceInstitution { get; set; }

        [JsonPropertyName("company_name")]
        public string RegistrationNumber { get; set; }
    }
}
// <copyright file="CompanyProfile.cs" company="Prime 23 Consultancy Limited">
// Copyright © 2016-2020 Prime 23 Consultancy Limited. All rights reserved.</copyright>

using System.Collections.Generic;
using System.Diagnostics;
using System.Text.Json.Serialization;

namespace CompaniesHouseCrawler.Models
{
    [DebuggerDisplay("C: {" + nameof(CompanyName) + "}")]
    public class CompanyProfile
    {
        public Accounts Accounts { get; set; }

        [JsonPropertyName("annual_return")]
        public AnnualReturn AnnualReturn { get; set; }

        [JsonPropertyName("branch_company_details")]
        public BranchCompanyDetails BranchCompanyDetails { get; set; }

        [JsonPropertyName("can_file")]
        public bool CanFile { get; set; }

        [JsonPropertyName("company_name")]
        public string CompanyName { get; set; }

        [JsonPropertyName("company_number")]
        public string CompanyNumber { get; set; }

        [JsonPropertyName("company_status")]
        public string CompanyStatus { get; set; }

        [JsonPropertyName("company_status_detail")]
        public string CompanyStatusDetail { get; set; }

        [JsonPropertyName("date_of_cessation")]
        public string DateOfCessation { get; set; }

        [JsonPropertyName("date_of_creation")]
        public string DateOfCreation { get; set; }

        public string eTag { get; set; }

        [JsonPropertyName("foreign_company_details")]
        public ForeignCompanyDetails ForeignCompanyDetails { get; set; }

        [JsonPropertyName("has_been_liquidated")]
        public bool HasBeenLiquidated { get; set; }

        [JsonPropertyName("has_charges")]
        public bool HasCharges { get; set; }

        [JsonPropertyName("has_insolvency_history")]
        public bool HasInsolvencyHistory { get; set; }

        [JsonPropertyName("is_community_interest_company")]
        public bool IsCommunityInterestCompany { get; set; }

        public string Jurisdiction { get; set; }

        [JsonPropertyName("last_full_members_list_date")]
        public string LastFullMembersListDate { get; set; }

        public LinkCompany Links { get; set; }

        public List<OfficerListItem> Officers { get; } = new List<OfficerListItem>();

        [JsonPropertyName("partial_data_available")]
        public string PartialDataAvailable { get; set; }

        [JsonPropertyName("previous_company_names")]
        public List<PreviousCompanyNames> PreviousCompanyNames { get; set; }

        [JsonPropertyName("registered_office_address")]
        public Address RegisteredOfficeAddress { get; set; }

        [JsonPropertyName("registered_office_is_in_dispute")]
        public bool RegisteredOfficeIsInDispute { get; set; }

        [JsonPropertyName("sic_codes")]
        public List<string> SicCodes { get; set; }

        public string SubType { get; set; }

        public string Type { get; set; }

        [JsonPropertyName("undeliverable_registered_office_address")]
        public bool UndeliverableRegisteredOfficeAddress { get; set; }
    }
}
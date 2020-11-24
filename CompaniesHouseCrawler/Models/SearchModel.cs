// <copyright file="SearchModel.cs" company="Prime 23 Consultancy Limited">
// Copyright © 2016-2020 Prime 23 Consultancy Limited. All rights reserved.</copyright>

using System;

using Microsoft.AspNetCore.Mvc;

namespace CompaniesHouseCrawler.Models
{
    public class SearchModel
    {
        [BindProperty]
        public int Depth { get; set; }

        public bool IsValidMonth => this.Month >= 1 && this.Month <= 12;

        public bool IsValidYear => this.Year >= 1900 && this.Year <= DateTime.Now.Year;

        [BindProperty]
        public int Month { get; set; }

        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public int Year { get; set; }
    }
}
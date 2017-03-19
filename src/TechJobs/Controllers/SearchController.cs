﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechJobs.Models;

namespace TechJobs.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";
            return View();
        }

        // TODO #1 - Create a Results action method to process 
        // search request and display results

        public IActionResult Results (string searchType, string searchTerm)
        {
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";
            //look up search results via JobData class   
            //if user searches 'all'
            if (searchType == "all")
            {
                ViewBag.Jobs = JobData.FindByValue(searchTerm);
            }
            //if user searches by category
            else
            {
                ViewBag.Jobs = JobData.FindByColumnAndValue(searchType, searchTerm);
            }
            //pass them into Views/Search/index.cshtml 
            
            return View("~/Views/Search/Index.cshtml");

        }
    }
}

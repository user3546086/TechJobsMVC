using System.Collections.Generic;
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
            //look up search results via JobData class   

            //JobData.FindByValue(value);

            //pass them into Views/Search/index.cshtml 
            return View();

        }
    }
}

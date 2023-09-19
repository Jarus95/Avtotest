using System.Diagnostics;
using Avtotest.Data;
using Avtotest.Models;
using Avtotest.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.Logging;

namespace Avtotest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        AvtoTestDbContext dbContext;

        public HomeController(ILogger<HomeController> logger, AvtoTestDbContext dbContext )
        {
            _logger = logger;
            this.dbContext = dbContext;
        }

  

        public IActionResult Index()
        {
            JsonRepostiory json = new JsonRepostiory();
            ViewBag.QuestionsCount = json.GetAllQuestionsCount();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
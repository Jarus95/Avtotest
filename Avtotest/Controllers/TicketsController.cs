using Avtotest.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Avtotest.Controllers
{
    public class TicketsController : Controller
    {
        JsonRepostiory jsonRepostiory;
        public TicketsController()
        {
            jsonRepostiory = new JsonRepostiory();
        }
        public IActionResult Index()
        {
            return View(jsonRepostiory);
        }
        public IActionResult Question(int index)
        {
            return View();
        }
    }
}

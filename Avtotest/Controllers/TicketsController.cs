using Microsoft.AspNetCore.Mvc;

namespace Avtotest.Controllers
{
    public class TicketsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

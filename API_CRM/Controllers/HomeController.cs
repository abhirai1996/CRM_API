using Microsoft.AspNetCore.Mvc;

namespace API_CRM.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

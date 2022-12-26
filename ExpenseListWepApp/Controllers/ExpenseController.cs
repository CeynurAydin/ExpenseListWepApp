using Microsoft.AspNetCore.Mvc;

namespace ExpenseListWepApp.Controllers
{
    public class ExpenseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using ExpenseListWepApp.Data;
using ExpenseListWepApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseListWepApp.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly AppDbContext _db;

        public ExpenseController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Expense> ExpenseList = _db.Expenses.Select(e=>e);
            return View(ExpenseList);
        }

    }
}

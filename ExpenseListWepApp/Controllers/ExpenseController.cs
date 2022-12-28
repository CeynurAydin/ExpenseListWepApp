using ExpenseListWepApp.Data;
using ExpenseListWepApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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
        public IActionResult Upsert(int id)
        {
            Expense expense = new Expense();
            if (id==0)
            {
                return View(expense);
            }
            else
            {
                expense=_db.Expenses.Find(id);
                return View(expense);
            }

           
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Expense expense)
        {
            if (ModelState.IsValid)
            {
                if (expense.Id==0)
                {
                    _db.Expenses.Add(expense);
                }
                else 
                {
                    _db.Update(expense);
                
                }
                _db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(expense);


        }

        public IActionResult Delete(int id)
        {
            var i=_db.Expenses.Find(id);
            if (i == null)
            {
                return NotFound();
            }
            _db.Expenses.Remove(i);
            _db.SaveChanges();
            return RedirectToAction("Index");



        }
    }

}

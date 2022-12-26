using ExpenseListWepApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseListWepApp.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Expense> Expenses { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using NoelExpenseTracker.Models;

namespace NoelExpenseTracker.Data
{
    public class ApplicationDbContext : DbContext
    {
          public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
          {

          }

          public DbSet<Item> Items { get; set; }
          public DbSet<Expense> Expenses { get; set; }
     }
}

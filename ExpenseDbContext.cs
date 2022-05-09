using Microsoft.EntityFrameworkCore;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class ExpenseDbContext : DbContext
    {
        private string connectionString = @"server=(localdb)\MSSQLLocalDB;
                    Initial Catalog=PetsDB; Integrated Security=true";


        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Group> Groups{ get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}

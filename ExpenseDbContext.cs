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
                    Initial Catalog=ExpenseManagerDB; Integrated Security=true";


        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Group> Groups{ get; set; }
        public DbSet<User> Users { get; set; }
        public ExpenseDbContext() : base()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                        .HasMany(u => u.Expenses)
                        .WithMany(e => e.PaidFor);
            
            modelBuilder.Entity<User>()
                        .HasMany(u => u.ExpensesPaid)
                        .WithOne(e => e.Payer)
                        .OnDelete(DeleteBehavior.Restrict);
            
            modelBuilder.Entity<User>()
                        .HasMany(u => u.ManagedGroups)
                        .WithOne(g => g.Admin)
                        .OnDelete(DeleteBehavior.Restrict);
                

            modelBuilder.Entity<User>()
                        .HasMany(u => u.Groups)
                        .WithMany(g => g.Members);
            
           
        }

    }
}

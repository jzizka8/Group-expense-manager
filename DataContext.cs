using Microsoft.EntityFrameworkCore;
using Project.Models;
using Microsoft.EntityFrameworkCore.Proxies;
using System.Configuration;

namespace Project
{
    public class DataContext : DbContext
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["ExpenseManager"].ConnectionString;


        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<User> Users { get; set; }
        public DataContext() : base()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies()
                .UseSqlServer(connectionString);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                        .HasMany(u => u.Expenses)
                        .WithMany(e => e.Consumers);

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

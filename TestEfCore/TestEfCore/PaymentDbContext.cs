using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEfCore
{
    /// <summary>
    /// 这就是我逻辑上的数据库，连接到了真实的数据库上
    /// </summary>
    public class PaymentDbContext:DbContext
    {
        public DbSet<Payment> Payments { get; set; }

        public DbSet<ExpenseJournal> expenseJournals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connStr = "Server=localhost;Database=TestEF;User=sa;Password=123;Encrypt=false";
            optionsBuilder.UseSqlServer(connStr);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Payment>().Property(p => p.Amount).HasPrecision(18, 2);
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}

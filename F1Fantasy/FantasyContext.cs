using System;
using System.Collections.Generic;
using F1Fantasy.FantasyData;
using Microsoft.EntityFrameworkCore;
namespace F1Fantasy
{
    public class FantasyContext : DbContext
    {
        public DbSet<Team> Team { get; set; }

        public DbSet<Driver> Driver { get; set; }

        public string DbPath { get; private set; }

        public FantasyContext()
        {
            DbPath = @"C:\Users\Sindre Thompson\source\repos\F1Fantasy\fantasyFormulaone.db";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={ DbPath }");
    }
}

using F1Fantasy.FantasyData;
using Microsoft.EntityFrameworkCore;
namespace F1Fantasy
{
    public class FantasyContext : DbContext
    {
        public DbSet<Teams> Teams { get; set; }

        public DbSet<Driver> Driver { get; set; }

        public DbSet<Race> Race { get; set; }

        public DbSet<RaceResult> RaceResult { get; set;}

        public string DbPath { get; private set; }


        public FantasyContext()
        {
            DbPath = @"C:\Users\Sindre Thompson\source\repos\F1Fantasy\fantasyFormulaone.db";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={ DbPath }");
    }
}

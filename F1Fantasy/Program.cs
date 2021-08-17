using F1Fantasy.FantasyData;
using System;
using System.Linq;

namespace F1Fantasy
{
    internal class Program
    {
        static void Main()
        {
            using(var db = new FantasyContext())
            {

                var team = db.Teams.Where(x => x.Name == "Mercedes").First().Drivers;

                Race race = new Race
                {
                    No = 2,
                    Name = "Silverstone Grand Prix",
                    Location = "Silverstone",
                    Country = "Great Britain",
                    Length = 5
                };
                //db.Add(race);
                //db.SaveChanges();

                Console.ReadLine();
            }
        }
    }
}

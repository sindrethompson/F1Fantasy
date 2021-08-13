using F1Fantasy.FantasyData;
using Microsoft.EntityFrameworkCore;
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
                var driver = db.Driver.Where(driver => driver.Name.Contains("Lewis")).First().Position = 2;
                db.SaveChanges();

                Console.ReadLine();
            }
        }
    }
}

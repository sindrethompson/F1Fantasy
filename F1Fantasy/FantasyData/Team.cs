using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace F1Fantasy.FantasyData
{
    public class Team
    {
        [Key]
        public string Name { get; set; }

        public int Position { get; set; }

        public List<Driver> Drivers = new List<Driver>();
    }

    public class Driver
    {
        [Key]
        public string Name { get; set; }

        public int Position { get; set; }

        public string TeamName { get; set; }

        public Team Team { get; set; }
    }
}

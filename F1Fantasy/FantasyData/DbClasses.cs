using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace F1Fantasy.FantasyData
{
    /// <summary>
    /// Class representing a constructor team
    /// </summary>
    public class Teams
    {
        /// <summary>
        /// Name of the team
        /// Primary Key
        /// </summary>
        [Key]
        public string Name { get; set; }
        /// <summary>
        /// Current constructors position
        /// </summary>
        public int Position { get; set; }
        /// <summary>
        /// List of drivers in the team
        /// </summary>
        public List<Driver> Drivers = new List<Driver>();
    }

    /// <summary>
    /// Class representing a driver
    /// </summary>
    public class Driver
    {
        /// <summary>
        /// Name of the driver
        /// Primary Key
        /// </summary>
        [Key]
        public string Name { get; set; }
        /// <summary>
        /// Current position in the driver's championship
        /// </summary>
        public int Position { get; set; }
        /// <summary>
        /// Name of the team
        /// Use this to access all team data
        /// </summary>
        public string TeamName { get; set; }
        /// <summary>
        /// Access to team data
        /// </summary>
        public Teams Team { get; set; }
    }

    /// <summary>
    /// Class representing a race
    /// </summary>
    public class Race
    {
        /// <summary>
        /// Race number
        /// </summary>
        [Key]
        public int No { get; set; }
        /// <summary>
        /// Grand Prix Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Grand Prix Location
        /// Name of location
        /// </summary>
        public string Location { get; set; }
        /// <summary>
        /// Country
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// Race Length
        /// </summary>
        public int Length { get; set; }
    }

    /// <summary>
    /// Class representing a race result
    /// </summary>
    public class RaceResult
    {
        /// <summary>
        /// Name of the driver
        /// Use this to access driver table 
        /// </summary>
        [Key]
        public string DriverName { get; set; }
        /// <summary>
        /// Checkered-flag postion
        /// </summary>
        public int Position { get; set; }
        /// <summary>
        /// Race number, use this to identify Race
        /// </summary>
        public int RaceNo { get; set; }
        /// <summary>
        /// Access to all driver data
        /// </summary>
        public Driver Driver { get; set; }
        /// <summary>
        /// Access to all Race data
        /// </summary>
        public Race Race { get; set; }

    }
}

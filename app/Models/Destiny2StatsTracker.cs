using System;

namespace Destiny2StatsApiDotNet.Models
{
    public class Destiny2StatsTracker
    {
        public string Username { get; set; }

        public int KillDeath { get; set; }

        public DateTime creationDate { get; }

        public string favoriteWeapon { get; set; }

        public string hoursPlayed { get; set; }

        public string powerLevel { get; set; }
    }
}

using System;
using Contentful.Core.Models;

namespace Destiny2StatsApiDotNet.Models
{
    public class Destiny2StatsTracker
    {
        public string Username { get; set; }

        public float KillDeath { get; set; }

        public string favoriteWeapon { get; set; }

        public string hoursPlayed { get; set; }

        public string powerLevel { get; set; }

        public Asset profileImage { get; set; }

        public Asset userEmblem { get; set; }
    }
}

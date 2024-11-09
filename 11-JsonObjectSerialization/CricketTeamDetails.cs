using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _11_JsonObjectSerialization
{
    public class CricketTeamDetails
    {
        /// <summary>
        /// Team Full Name
        /// </summary>
        [JsonPropertyName("Name_Full")]
        public string TeamFullName { get; set; }

        /// <summary>
        /// Team Short Name
        /// </summary>
        [JsonPropertyName("Name_Short")]
        public string TeamShortName { get; set; }

        /// <summary>
        /// Players
        /// </summary>
        [JsonPropertyName("Players")]
        public Dictionary<int, Player> Players { get; set; }
    }
}

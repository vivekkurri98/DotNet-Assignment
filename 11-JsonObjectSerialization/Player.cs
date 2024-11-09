using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _11_JsonObjectSerialization
{
    public class Player
    {
        /// <summary>
        /// Position
        /// </summary>

        [JsonPropertyName("Position")]
        public string Position { get; set; }

        /// <summary>
        /// Full Name
        /// </summary>
        [JsonPropertyName("Name_Full")]
        public string FullName { get; set; }

        /// <summary>
        /// Is Captain
        /// </summary>
        [JsonPropertyName("IsCaption")]
        public bool IsCaptain { get; set; }
    }
}

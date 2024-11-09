using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _12_LineUpAndBowlingStats
{
    public class LineUp
    {
        [JsonPropertyName("PlayerId")]
        public int PlayerId { get; set; }

        [JsonPropertyName("PlayerName")]
        public string PlayerName { get; set; }
    }
}

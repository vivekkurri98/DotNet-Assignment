using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _12_LineUpAndBowlingStats
{
    public class LineUpDetails
    {
        [JsonPropertyName("Lineups")]
        public List<LineUp> LineUps {  get; set; }
    }
}

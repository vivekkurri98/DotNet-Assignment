using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _12_LineUpAndBowlingStats
{
    public class Details
    {
        public void GetDetails()
        {
            var lineUpString = "{\r\n    \"Lineups\": [\r\n        {\"PlayerId\": 21, \"PlayerName\": \"Y. Chahal\"},\r\n        {\"PlayerId\": 22, \"PlayerName\": \"Bhuvneshwar Kumar\"},\r\n        {\"PlayerId\": 23, \"PlayerName\": \"Jasprit Bumrah\"},\r\n        {\"PlayerId\": 24, \"PlayerName\": \"Hardik Pandya\"},\r\n        {\"PlayerId\": 25, \"PlayerName\": \"Ravindra Jadeja\"},\r\n        {\"PlayerId\": 26, \"PlayerName\": \"Mohammed Shami\"}\r\n    ]\r\n}\r\n";
            var bowlingStatsString = "{\"BowlingStats\":\r\n[\r\n{\"PlayerId\" : 21, \"Wickets\": 2},\r\n{\"PlayerId\" : 22, \"Wickets\": 1},\r\n{\"PlayerId\" : 23, \"Wickets\": 3},\r\n{\"PlayerId\" : 26, \"Wickets\": 1}\r\n]}";

            var lineUpModel = JsonSerializer.Deserialize<LineUpDetails>(lineUpString); 
            var bowlingStatsModel = JsonSerializer.Deserialize<BowlingStatsDetails>(bowlingStatsString); 
            
            if (lineUpModel != null && lineUpModel.LineUps != null && bowlingStatsModel != null && bowlingStatsModel.BowlingStats != null) 
            { 
                var players = from lineUp in lineUpModel.LineUps 
                               join bowlingStatus in bowlingStatsModel.BowlingStats on lineUp.PlayerId equals bowlingStatus.PlayerId into playerGroup 
                               from stats in playerGroup.DefaultIfEmpty() 
                               select new 
                               { 
                                   lineUp.PlayerId, 
                                   lineUp.PlayerName, 
                                   Wickets = stats?.Wickets ?? 0 
                               }; 

                foreach (var player in players) 
                { 
                    Console.WriteLine($"PlayerId: {player.PlayerId}, PlayerName: {player.PlayerName}, Wickets: {player.Wickets}"); 
                } 
            }
        }
    }
}

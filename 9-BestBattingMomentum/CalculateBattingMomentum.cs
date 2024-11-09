using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_BestBattingMomentum
{
    public class CalculateBattingMomentum
    {
        public void GetBatsManWithBestMomentum()
        {
            List<CricketStats> listOfcricketStats = new List<CricketStats>();

            listOfcricketStats.Add(
                new CricketStats
                {
                    Batsman = "Virat Kholi",
                    RunsScored = 50,
                    StrikeRate = 78.30
                });
            listOfcricketStats.Add(
                new CricketStats
                {
                    Batsman = "M.S Dhone",
                    RunsScored = 61,
                    StrikeRate = 58.90
                });
            listOfcricketStats.Add(
                 new CricketStats
                 {
                     Batsman = "Virat Kholi",
                     RunsScored = 13,
                     StrikeRate = 124.0
                 });
            
            string bestBatsMan = BestBatsMan(listOfcricketStats);
            Console.WriteLine();
            Console.WriteLine($"The batsman with the best batting momentum is {bestBatsMan}");
            Console.ReadLine();
        }

        private string BestBatsMan(List<CricketStats> listOfcricketStats)
        {
            var best = listOfcricketStats.Max(x => x.RunsScored * x.StrikeRate);

            foreach (var r in listOfcricketStats)
            {
                var momentum = r.RunsScored * r.StrikeRate;
                if (momentum == best)
                {
                    return r.Batsman;
                }
            }
            return string.Empty;
        }
    }
}

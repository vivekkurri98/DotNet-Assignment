using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_UpdateIsRetiredFlag
{
    public class UpdatePlayerDetails
    {
        public List<Player> GetPlayers()
        {
            List<Player> list = new List<Player>();
            list.Add(new Player { PlayerName = "Virat Kholi", IsRetired = 1});
            list.Add(new Player { PlayerName = "M.S. Dhoni", IsRetired = 1});
            list.Add(new Player { PlayerName = "Hardik Pandya", IsRetired = 1});
            list.Add(new Player { PlayerName = "Rohit Sharma", IsRetired = 1});
            list.Add(new Player { PlayerName = "Sachin Tendulkar", IsRetired = 0});
            list.Add(new Player { PlayerName = "Rahul Dravid", IsRetired = 0});
            list.Add(new Player { PlayerName = "Sourav Ganguly", IsRetired = 0});
            list.Add(new Player { PlayerName = "VVS Laxman", IsRetired = 0});

            return list;
        }

        public void PrintPlayersBeforeUpdate()
        {
            var list = GetPlayers();
            Console.WriteLine("Player details before updating IsRetired flag");
            foreach (Player player in list)
            {
                Console.WriteLine($"PlayerName = {player.PlayerName}, IsRetired = {player.IsRetired}");
            }
        }

        public List<Player> UpatedIsRetiredOfPlayers()
        {
            var list = GetPlayers();
            list = list.Select(p => { p.IsRetired = p.IsRetired == 0 ? 1 : 0; return p; }).ToList();
            return list;
        }

        public void PrintPlayersAfterUpdate()
        {
            Console.WriteLine();
            Console.WriteLine("Player details after updating IsRetired flag");
            var list = UpatedIsRetiredOfPlayers();
            foreach (Player player in list)
            {
                Console.WriteLine($"PlayerName = {player.PlayerName}, IsRetired = {player.IsRetired}");
            }
        }
    }
}

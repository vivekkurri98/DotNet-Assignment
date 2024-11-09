using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _11_JsonObjectSerialization
{
    public class CricketTeam
    {
        public CricketTeamDetails GetCricketTeamDetails() 
        {
            var jsonString = "{\r\n\"Name_Full\": \"Sunrisers Hyderabad\",\r\n\"Name_Short\": \"SRH\",\r\n\"Players\":\r\n{\r\n\"5380\": {\"Position\": \"1\", \"Name_Full\": \"David Warner\", \"IsCaptain\": true},\r\n\"3722\": {\"Position\": \"2\", \"Name_Full\": \"Shikhar Dhawan\", \"IsCaptain\": false}\r\n}\r\n}";
            var model = JsonSerializer.Deserialize<CricketTeamDetails>(jsonString);

            Console.WriteLine("Name_Full:" + model?.TeamFullName);
            Console.WriteLine("Name_Short : " + model?.TeamShortName);
            Console.WriteLine("Players:");
            foreach (var item in model.Players)
            {
                Console.WriteLine(item.Key);
                var value = item.Value;
                Console.WriteLine("Position: " + value?.Position + ", Name_Full: " + value?.FullName + ", IsCaption: " + value?.IsCaptain);
            }

            return model;
        }
    }
}

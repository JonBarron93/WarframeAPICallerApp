using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WarframeAPICallerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var newUser = new UserSettings();
            newUser.UsersSystem = "xb1";
            newUser.UserLanguage = "en";


            var client = new HttpClient();
            string worldURL = $"https://api.warframestat.us/";
            string wholeWorld = client.GetStringAsync(worldURL + $"{newUser.UsersSystem}/fissures").Result.ToString();
            var itemizedWorld = $"{{\"crackers\":{wholeWorld}}}";

            var missionList = JsonConvert.DeserializeObject<FissureMissionList>(itemizedWorld);
            
            foreach (var mission in missionList.crackers) 
            {
                if (mission.isStorm != false)
                {
                    var a = new WarframeWorldParser();
                    Console.WriteLine($"{mission.tier} {mission.missionType} mission available on {a.GetMissionPlanet(mission)} at {a.GetMissionNodeName(mission)} for {mission.eta}\n-");
                }

            }
            Console.ReadLine();
        }
    }
}

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
    public class WarframeWorldParser
    {
        public WarframeWorldParser()
            {}
        
        public string CallApi(string system)
        {
            var client = new HttpClient();
            string worldURL = $"https://api.warframestat.us/";
            var wholeWorld = client.GetStringAsync(worldURL + $"{system}/").Result.ToString();
            return wholeWorld;
        }
        public string CallApiOpenAreaCycle(string system, string openArea)
        {
            openArea.ToLower();
            if (openArea == "cetus" || openArea == "cambion")
            {
                var client = new HttpClient();
                string worldURL = $"https://api.warframestat.us/";
                var wholeWorld = client.GetStringAsync(worldURL + $"{system}/{openArea}cycle").Result.ToString();
                return wholeWorld;
            }
            else return "please choose an open world area, ie: cetus or cambion";
        }
        public string CallApiFissures(string system)
        {
            var client = new HttpClient();
            string worldURL = $"https://api.warframestat.us/";
            var wholeWorld = client.GetStringAsync(worldURL + $"{system}/fissures").Result;
            return wholeWorld; 
        }
        public FissureMissionList CreateFissureMissionList(string wholeWorld)
        {
            var itemizedWorld = $"{{\"crackers\":{wholeWorld}}}";
            var missionList = JsonConvert.DeserializeObject<FissureMissionList>(itemizedWorld);
            return missionList;
        }

        public string CallApiSortie(string system)
        {
            var client = new HttpClient();
            string worldURL = $"https://api.warframestat.us/";
            var wholeWorld = client.GetStringAsync(worldURL + $"{system}/sortie").Result.ToString();
            return wholeWorld;
        }
        public string GetMissionPlanet(FissureMisson a)
        {
            var node = a.node;
            int start = node.IndexOf("(") + 1;
            int end = node.IndexOf(")", start);
            var planet = node.Substring(start, end - start);
            return planet;
        }
        public string GetMissionNodeName(FissureMisson a)
        {
            var node = a.node;
            var end = node.IndexOf("(");
            var nodeName = node.Substring(0, end);
            return nodeName;
        }
    }
}

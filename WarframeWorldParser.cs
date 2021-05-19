using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
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
            var wholeWorld = client.GetStringAsync(worldURL + $"{system}/fissures").Result.ToString();
            return wholeWorld; // CHANGE TO ARRAY OF OBJECTS
        }
        public List<FissureMisson> CreateFissureMissionList(object j)
        {
            var nissionList = new List<FissureMisson>();

            return missionList;
        }

        public string CallApiSortie(string system)
        {
            var client = new HttpClient();
            string worldURL = $"https://api.warframestat.us/";
            var wholeWorld = client.GetStringAsync(worldURL + $"{system}/sortie").Result.ToString();
            return wholeWorld;
        }
    }
}

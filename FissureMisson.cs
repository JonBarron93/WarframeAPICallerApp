using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WarframeAPICallerApp
{
    public class FissureMisson
    {
        public FissureMisson() { }
        
        public string id { get; set; }
        public DateTime activation { get; set; }
        public string startString { get; set; }
        public DateTime expiry { get; set; }
        public bool active { get; set; }
        public string node { get; set; }
        public string missionType { get; set; }
        public string missionKey { get; set; }
        public string enemy { get; set; }
        public string enemyKey { get; set; }
        public string nodeKey { get; set; }
        public string tier { get; set; }
        public int tierNum { get; set; }
        public bool expired { get; set; }
        public string eta { get; set; }
        public bool isStorm { get; set; }
    }
    /* public string id { get; set; } This was all manually typed. The stuff above is copy pasted from json2csharp.com/
         public string activation { get; set; } // when it starts
         public string startString { get; set; } // when it started relative to now, is always negative on active missions
         public string expiry { get; set; } // when it ends
         public bool active { get; set; }
         public string node { get; set; } // where it's at on the star map, derive planet from it later.
         public string missionType { get; set; } // important to me: this is where the game says if it's a capture or exterminate
         public string missionKey { get; set; } // redundant with Type, in Json object, figure out why later.
         public string enemy { get; set; } // who you fight on mission
         public string enemyKey { get; set; }
         public string nodeKey { get; set; } //redundant with node
         public string tier { get; set; } //important: determines which relics you can open
         public int tierNum { get; set; }// 1 lith, 2 meso, 3 neo, 4 axi, 5 requiem
         public bool expired { get; set; } //opposite of is active
         public string eta { get; set; } // how much time is left, much more important than the other time count.
         public bool isStorm { get; set; }// is true for railjack, false for non-railjack. Exterminate missions can be either/or. Most players will prefer this to be false.

     }*/
}

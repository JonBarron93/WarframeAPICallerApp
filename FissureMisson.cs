using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeAPICallerApp
{
    public class FissureMisson
    {
        public FissureMisson() { }
        string ID { get; set; }
        string ActivationTime { get; set; } // when it starts
        string StartString { get; set; } // when it started relative to now, is always negative on active missions
        string ExpiryTime { get; set; } // when it ends
        bool IsActive { get; set; }
        string Node { get; set; } // where it's at on the star map, derive planet from it later.
        string Type { get; set; } // important to me: this is where the game says if it's a capture or exterminate
        string Key { get; set; } // redundant with Type, in Json object, figure out why later.
        string Enemy { get; set; } // who you fight on mission
        string EnemyKey { get; set; }
        string NodeKey { get; set; } //redundant with node
        string Tier { get; set; } //important: determines which relics you can open
        int TierNum { get; set; }// 1 lith, 2 meso, 3 neo, 4 axi, 5 requiem
        bool HasExpired { get; set; } //opposite of is active
        string Eta { get; set; } // how much time is left, much more important than the other time count.
        bool IsStorm { get; set; }// is true for railjack, false for non-railjack. Exterminate missions can be either/or. Most players will prefer this to be false.

    }
}

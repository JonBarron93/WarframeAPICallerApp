using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeAPICallerApp
{
    public class UserSettings : IUserSettings
    {
        public UserSettings()
            {}

        public string UsersSystem { get; set; } = "xb1";
        public string UserLanguage { get; set; } = "en";
        public bool NotificationsOn { get; set; } = false;
        public bool[] WhichNotifications { get; set; }
        public bool[] VoidFissurePreferences { get; set; }
        
    }
}

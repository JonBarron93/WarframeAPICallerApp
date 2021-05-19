using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace WarframeAPICallerApp
{
    interface IUserSettings
    {
        string UsersSystem { get; set; }
        string UserLanguage { get; set; }
        bool NotificationsOn { get; set; }
        bool[] WhichNotifications { get; set; }
        bool[] VoidFissurePreferences { get; set; }

    }
}

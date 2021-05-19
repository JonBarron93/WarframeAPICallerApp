using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeAPICallerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var newUser = new UserSettings();
            newUser.UsersSystem = "xb1";
            newUser.UserLanguage = "en";
            var newParse = new WarframeWorldParser();
            var newParseStr = newParse.CallApi(newUser.UsersSystem);
            //Console.WriteLine(newParseStr);
            //Console.ReadLine();
            
            

        }
    }
}

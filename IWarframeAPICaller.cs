﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace WarframeAPICallerApp
{
    interface IWarframeAPICaller
    {
        object CallApi();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontendTCC.Services
{
    public class DuvidasService
    {
         private readonly HttpClient _http;

        public DuvidasService(HttpClient http)
        {
            _http = http;
        }
    }
}
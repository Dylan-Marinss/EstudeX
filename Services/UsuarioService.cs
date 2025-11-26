using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontendTCC.Services
{
    public class UsuarioService
    {
        private readonly HttpClient _http;

        public UsuarioService(HttpClient http)
        {
            _http = http;
        }
    }
}
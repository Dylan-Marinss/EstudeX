using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontendTCC.Models
{
    public class AlunoViewModel
    {
        public int IdUtilizador { get; set; }

        public Utilizador Utilizador { get; set;}

        public string Nome { get; set; }

        public string CPF { get; set; }

        public string UF { get; set; }

        public string Cidade { get; set; }

        public string tipoUtilizador { get; set; }

        public string Serie { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBanco
{
    public class Usuario
    {
        public string Nome { get; set; }
        private string Cpf { get; }
        private string Rg { get; }

        public Usuario (string cpf, string rg)
        {
            Cpf = cpf;
            Rg = rg;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBanco
{
    public class Conta
    {
        public Usuario Usuario { get; set; }
        public int Agencia { get;}
        public int Numero { get;}
        private double _saldo;

    }
}
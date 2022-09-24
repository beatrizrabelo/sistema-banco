using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBanco
{
    public class SaldoInfuficienteException : Exception
    {
        public SaldoInfuficienteException() { }
        public SaldoInfuficienteException(string? message)
        : base(message) { }
    }
}
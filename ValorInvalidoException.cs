using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBanco
{
    public class ValorInvalidoException : ArgumentException
    {
        public double Valor { get; }        
        public ValorInvalidoException() { }

        public ValorInvalidoException(double valor)
        : this ("Valor R$ " + valor + " digitado inválido.")
        {
            Valor = valor;
        }

        public ValorInvalidoException (string? message, string? paramName)
        : base(message, paramName) {}

        public ValorInvalidoException(string? message)
        : base(message) {}
    }
}
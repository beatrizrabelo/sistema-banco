using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBanco
{
    public class ValorInvalidoException : Exception
    {
        public ValorInvalidoException() { }
        public ValorInvalidoException(string? message)
        : base(message) { }
    }
}
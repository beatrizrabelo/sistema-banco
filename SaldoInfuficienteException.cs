using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBanco
{
    public class SaldoInfuficienteException : OperacaoFinanceiraException
    {
        public double ValorSaque { get; }
        public double Saldo { get; }
        public SaldoInfuficienteException() { }
        public SaldoInfuficienteException(double valorSaque, double saldo)
        : this("Tentativa de saque R$ " + valorSaque + " inválida. Pois o saldo da conta é de R$ " + saldo + ".")
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }
        public SaldoInfuficienteException(string? message)
        : base(message) { }

        public SaldoInfuficienteException(string? message, Exception innerException)
        : base(message, innerException) { }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBanco
{
    public class Conta
    {
        public static double TaxaOperacao { get; private set; }
        public static int TotalDeContasCriadas { get; private set; }
        public Usuario Usuario { get; set; }
        public int Agencia { get; }
        public int Numero { get; }
        private double _saldo;

        public Conta(int agencia, int numero)
        {
            if (agencia <= 0)
            {
                throw new ArgumentException("O argumento agencia deve ser maior que 0.", nameof(agencia));
            }

            if (numero <= 0)
            {
                throw new ArgumentException("O argumento numero deve ser maior que 0.", nameof(numero));
            }

            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;

            TaxaOperacao = 30 / TotalDeContasCriadas;
        }

        public void consultarSaldo()
        {
            Console.WriteLine("Seu saldo é: R$ " + _saldo);
        }

        public bool sacarSaldo(double valor)
        {
            if (IsInvalid.isInvalid(valor))
            {
                throw new ValorInvalidoException("Valor inválido.");
            }

            if (IsInsufficient.isInsufficient(_saldo, valor))
            {
                throw new SaldoInfuficienteException("Saldo insuficiente.");
            }

            Console.WriteLine("Valor sacado de R$ " + valor);
            _saldo -= valor;
            return true;

        }

        public bool depositarValor(double valor)
        {
            if (IsInvalid.isInvalid(valor))
            {
                throw new ValorInvalidoException("Valor inválido.");
            }
            else
            {
                Console.WriteLine("Valor depositado de R$ " + valor);
                _saldo += valor;
                return true;
            }
        }

        public bool transferirValor(double valor, Conta contaDestino)
        {
            sacarSaldo(valor);

            contaDestino.depositarValor(valor);

            return true;
        }
    }
}
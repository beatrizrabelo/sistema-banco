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
            Agencia = agencia;
            Numero = numero;

            TaxaOperacao = 30 / TotalDeContasCriadas;

            TotalDeContasCriadas++;
        }

        public void consultarSaldo()
        {
            Console.WriteLine("Seu saldo é: R$ " + _saldo);
        }

        public bool sacarSaldo(double valor)
        {
            if (valor < 0)
            {
                Console.WriteLine("Valor inválido para o saque.");
            }

            if (_saldo < valor)
            {
                Console.WriteLine("Saldo indiponivel para saque.");
                return false;
            }

            Console.WriteLine("Valor sacado de: R$ " + valor);
            _saldo -= valor;

            return true;
        }

        public void depositarValor(double valor)
        {
            if (valor < 0)
            {
                Console.WriteLine("Valor inválido para o deposito.");

            }

            if (_saldo < valor)
            {
                Console.WriteLine("Saldo indiponivel para saque.");
            }

            Console.WriteLine("Valor depositado de R$ " + valor);
            _saldo += valor;

        }

        public bool transferirValor(double valor, Conta contaDestino)
        {
            if (valor < 0)
            {
                Console.WriteLine("Valor inválido para a transferência.");

                return false;
            }

            sacarSaldo(valor);

            contaDestino.depositarValor(valor);

            return true;
        }
    }
}
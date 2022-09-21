using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBanco
{
    public class Conta
    {
        public Usuario Usuario { get; set; }
        public int Agencia { get; }
        public int Numero { get; }
        private double _saldo;

        public Conta(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
        }

        public void consultarSaldo()
        {
            Console.WriteLine("Saldo: R$ " + _saldo);
        }

        public void sacarSaldo(double valor)
        {
            if (valor < 0)
            {
                Console.WriteLine("Valor inválido para o saque.");
            }

            if (_saldo < valor)
            {
                Console.WriteLine("Saldo indiponivel para saque.");
            }

            Console.WriteLine("Valor sacado de: R$ " + valor);
            _saldo -= valor;
        }

        public void depositarValor(double valor)
        {
            if (valor < 0)
            {
                Console.WriteLine("Valor inválido para o deposito.");
            }

            Console.WriteLine("Valor depositado de R$ " + valor);
            _saldo += valor;
        }

        public void transferirValor(double valor, Conta contaDestino)
        {
            if (valor < 0)
            {
                Console.WriteLine("Valor inválido para a transferência.");
            }

            sacarSaldo(valor);

            contaDestino.depositarValor(valor);
        }
    }
}
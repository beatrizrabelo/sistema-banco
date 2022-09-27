using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBanco
{

    /// <summary>
    /// Define uma conta no Sistema Banco.
    /// </summary>
    public class Conta
    {
        public static double TaxaOperacao { get; private set; }
        public static int TotalDeContasCriadas { get; private set; }
        public Usuario Usuario { get; set; }
        public int Agencia { get; }
        public int Numero { get; }
        private double _saldo;

        /// <summary>
        /// Cria uma instância de Conta com os argumentos agencia e numero.
        /// </summary>
        /// <param name="agencia"> Representa o valor da propriedade <see cref="Agencia"/> e deve possuir um valor maior que 0. </param>
        /// <param name="numero"> Representa o valor da propriedade <see cref="Numero"/> e deve possuir um valor maior que 0. </param>
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

        /// <summary>
        /// Exibe o saldo da conta.
        /// </summary>
        public void consultarSaldo()
        {
            Console.WriteLine("Seu saldo é: R$ " + _saldo);
        }

        /// <summary>
        /// Executa o saque do saldo. 
        /// </summary>
        /// <param name="valor"> Representa o argumento de <see cref= "Valor"/> para ser sacado. Deve ser maior ou igual ao saldo disponivel na conta.</param>
        public bool sacarSaldo(double valor)
        {
            if (Valor.isInvalid(valor))
            {
                throw new ValorInvalidoException(valor);
            }

            if (Saldo.isInsufficient(_saldo, valor))
            {
                throw new SaldoInfuficienteException(valor, _saldo);
            }

            Console.WriteLine("Valor sacado de R$ " + valor);
            _saldo -= valor;
            return true;

        }

        /// <summary>
        /// Executa o deposito de um valor na conta.
        /// </summary>
        /// <param name="valor"> Representa o argumento <see cref= "Valor"/> para ser depositado. </param>
        public bool depositarValor(double valor)
        {
            if (Valor.isInvalid(valor))
            {
                throw new ValorInvalidoException(valor);
            }
            else
            {
                Console.WriteLine("Valor depositado de R$ " + valor);
                _saldo += valor;
                return true;
            }
        }

        /// <summary>
        /// Executa a transferencia para uma outra conta destino.
        /// </summary>
        /// <param name="valor"> Representa o argumento <see cref= "valor" /> e deve possuir um valor maior ou igual a 0. </param>
        /// <param name="contaDestino"> Representa o argumento <see cref= "contaDestino" /> . </param>
        public bool transferirValor(double valor, Conta contaDestino)
        {
            try
            {
                sacarSaldo(valor);
            }
            catch (SaldoInfuficienteException ex)
            {
                throw new OperacaoFinanceiraException("Operação não realizada.", ex);
            }

            contaDestino.depositarValor(valor);
            return true;
        }
    }
}
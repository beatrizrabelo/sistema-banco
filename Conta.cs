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
        private double Saldos { get; set; }

        /// <summary>
        /// Cria uma instância de Conta.
        /// </summary>
        /// <exception cref="ArgumentException"> Exceção lançada quando os argumentos são menores que 0. </exception>
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
        /// Exibe a propriedade <see cref="Saldos"/> da classe <see cref="Conta"/>.
        /// </summary>
        public void consultarSaldo()
        {
            Console.WriteLine("Seu saldo é: R$ " + Saldos);
        }

        /// <summary>
        /// Realiza o saque e atualiza o valor da propriedade <see cref="Saldos"/>.
        /// </summary>
        /// <exception cref="ValorInvalidoException">Exceção lançada quando o <paramref name= "valor"/> é inválido. </exception>
        /// <exception cref="SaldoInfuficienteException">Exceção lançada quando o valor de <paramref name="valor"/> é maior que a propriedade <see cref="Saldo"/>.</exception>
        /// <param name="valor"> Representa o argumento de <paramref name= "valor"/> para ser sacado. Deve ser maior ou igual ao saldo disponivel na conta.</param>
        public bool sacarSaldo(double valor)
        {
            if (Valor.isInvalid(valor))
            {
                throw new ValorInvalidoException(valor);
            }

            if (Saldo.isInsufficient(Saldos, valor))
            {
                throw new SaldoInfuficienteException(valor, Saldos);
            }

            Console.WriteLine("Valor sacado de R$ " + valor);
            Saldos -= valor;
            return true;

        }

        /// <summary>
        /// Realiza o deposito de um <paramref name="valor"/>.
        /// </summary>
        /// <exception cref="ValorInvalidoException">Exceção lançada quando o <paramref name= "valor"/> é inválido. </exception>
        /// <param name="valor"> Representa o argumento <paramref name="valor"/> para ser depositado. </param>
        public bool depositarValor(double valor)
        {
            if (Valor.isInvalid(valor))
            {
                throw new ValorInvalidoException(valor);
            }
            else
            {
                Console.WriteLine("Valor depositado de R$ " + valor);
                Saldos += valor;
                return true;
            }
        }

        /// <summary>
        /// Realiza uma transferência de um <paramref name="valor"/> para uma <paramref name="contaDestino"/>.
        /// </summary>
        /// <exception cref="SaldoInfuficienteException">Exceção lançada quando o valor de <paramref name="valor"/> é maior que a propriedade <see cref="_saldo"/>.</exception>
        /// <param name="valor"> Representa o argumento <paramref name= "valor" /> e deve possuir um valor maior ou igual a 0. </param>
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
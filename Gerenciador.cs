using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBanco
{
    public class Gerenciador
    {
        public static void Main(String[] args)
        {

            try
            {
                Conta salario = new Conta(1900, 0990);
                Conta corrente = new Conta(1222, 02445);
                salario.sacarSaldo(200);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ValorInvalidoException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (SaldoInfuficienteException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
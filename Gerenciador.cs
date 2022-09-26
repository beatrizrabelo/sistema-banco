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
                Conta beatriz = new Conta(0222, 4555);
                Conta mario = new Conta(2090, 0888);
                beatriz.sacarSaldo(2000);
            }
            catch (OperacaoFinanceiraException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("\t");
                Console.WriteLine(ex.InnerException.Message);
                Console.WriteLine(ex.InnerException.StackTrace);
            }
        }
    }
}
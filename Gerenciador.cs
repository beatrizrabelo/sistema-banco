using SistemaBanco.Models;

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
                beatriz.Depositar(2000);
                beatriz.Sacar(10);
                beatriz.Transferir(200, mario);
                beatriz.Consultar();
            }
            catch (OperacaoFinanceiraException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("\t");
            }
        }
    }
}
namespace SistemaBanco.Models
{
    public class Saldo
    {
        public static bool isInsufficient(decimal saldo, decimal valor)
        {
            if (saldo < valor)
            {
                return true;
            }

            return false;
        }
    }
}
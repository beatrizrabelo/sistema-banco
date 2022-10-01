namespace SistemaBanco.Models
{
    public class Valor
    {
         public static bool isInvalid(decimal valor)
        {
            if (valor < 0)
            {
                return true;
            }

            return false;
        }
    }
}
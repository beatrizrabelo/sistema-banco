using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBanco
{
    public class Valor
    {
         public static bool isInvalid(double valor)
        {
            if (valor < 0)
            {
                return true;
            }

            return false;
        }
    }
}
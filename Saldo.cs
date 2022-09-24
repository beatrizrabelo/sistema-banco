using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBanco
{
    public class Saldo
    {
        public static bool isInsufficient(double saldo, double valor)
        {
            if (saldo < valor)
            {
                return true;
            }

            return false;
        }
    }
}
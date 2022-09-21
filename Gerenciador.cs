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

                Conta beatriz = new Conta(0555, 2900);
                Conta marcio = new Conta(0755, 1200);

                beatriz.transferirValor(500, marcio);
        }
    }
}
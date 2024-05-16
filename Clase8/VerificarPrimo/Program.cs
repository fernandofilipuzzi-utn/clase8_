using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificarPrimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el numero");

            int numero = Convert.ToInt32(Console.ReadLine());

            #region contar divisibilidades
            int divisibilidades = 0;
            for (int n = 1; n <= numero; n++)
            {
                if (numero % n == 0)
                {
                    divisibilidades++;
                }
            }
            #endregion

            #region verifico la condicion de primo e informo
            if (divisibilidades <= 2)
            {
                Console.WriteLine("es primo");
            }
            else 
            {
                Console.WriteLine("no es primo");
            }
            #endregion
        }
    }
}

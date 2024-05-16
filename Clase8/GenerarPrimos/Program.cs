using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerarPrimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Solicitar desde y hasta");
            int desde = Convert.ToInt32(Console.ReadLine());
            int hasta = Convert.ToInt32(Console.ReadLine());

            for (int m = desde; m <= hasta; m++)
            {

               
                int numero = m;
                #region evaluar si es primo y lo muestro si es
             
                int divisibilidades = 0;
                for (int n = 1; n <= numero; n++)
                {
                    if (numero % n == 0)
                    {
                        divisibilidades++;
                    }
                }

               
                if (divisibilidades <= 2)
                {
                    Console.WriteLine("{0}", numero);
                }
                #endregion


                Console.ReadKey();
            }
        }
    }
}

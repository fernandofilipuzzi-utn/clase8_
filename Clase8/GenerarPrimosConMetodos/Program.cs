using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerarPrimosConMetodos
{
    internal class Program
    {
        static bool VerificarPrimo(int numero)
        {
            int divisibilidades = 0;
            for (int n = 1; n <= numero; n++)
            {
                if (numero % n == 0)
                {
                    divisibilidades++;
                }
            }

             return divisibilidades <= 2;
           
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Solicitar desde y hasta");
            int desde = Convert.ToInt32(Console.ReadLine());
            int hasta = Convert.ToInt32(Console.ReadLine());

            for (int m = desde; m <= hasta; m++)
            {

                if(Program.VerificarPrimo(m))
                {
                    Console.WriteLine("{0}", m);
                }
                Console.ReadKey();
            }
    }
}

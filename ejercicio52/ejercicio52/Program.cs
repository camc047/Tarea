using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio52
{
    class Program
    {
        static int i, cuadrado, cubo;
        static double potencia;
        static void Main(string[] args)
        {
            i = 1;
            cuadrado = 0;
            cubo = 0;

            cuadradosCubosDel1al10();

            Console.ReadKey();
        }

        static private void cuadradosCubosDel1al10()
        {

            while (i <= 10)
            {
                potencia = Math.Pow(i, 2);
                cuadrado = Convert.ToInt32(potencia);

                potencia = Math.Pow(i, 3);
                cubo = Convert.ToInt32(potencia);

                Console.WriteLine(i + " ; " + cuadrado + " ; " + cubo);
                i = i + 1;
            }
        }
    }
}

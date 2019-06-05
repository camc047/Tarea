using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico47
{
    class Program
    {
        static int i, sumaImpar;
        static void Main(string[] args)
        {
            i = 1;
            sumaImpar = 0;

            sumaImparDel1Al1000();
            Console.ReadKey();
        }

        static private void sumaImparDel1Al1000()
        {

            while (i <= 1000)
            {
                Console.WriteLine(i);


                if (i % 2 == 1)
                {
                    sumaImpar = sumaImpar + i;
                }

                i = i + 1;
            }


            Console.WriteLine("La suma total de los números impares del 1 al 100 es de: " + sumaImpar);
        }
    }
}

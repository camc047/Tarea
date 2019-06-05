using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico19
{
    class Program
    {
        static int i, SumaPar, SumaImpar;
        static void Main(string[] args)
        {
            i = 1;
            SumaPar = 0;
            SumaImpar = 0;

            ParImpar();
            Console.ReadKey();
        }
        static private void ParImpar()
        {
            while(i<=100)
            {
                Console.WriteLine(i);

                if (i % 2 == 0)
                {
                    SumaPar = SumaPar + 1;
                }
                else
                {
                    SumaImpar = SumaImpar + 1;
                }
                i = i + 1;
            }
            Console.WriteLine("la suma de los numeros pares es de:" + SumaPar);
            Console.WriteLine("La suma de los numeros impares es de:" + SumaImpar);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico5
{
    class Program
    {
        static int i, conteo;
        static void Main(string[] args)
        {
            i = 1;
            conteo = 0;
            NumerosImparesYConteo();
            Console.ReadKey();
        }
        static private void NumerosImparesYConteo()
        {
            while (i <= 100)
            {
                Console.WriteLine(i);
                i = i + 2;
                conteo = conteo + 1;
            }
            Console.WriteLine("Existe un total de " + conteo + "numeros impares");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico14
{
    class Program
    {
        static int i, suma, potencia;
        static double numeros;
        static void Main(string[] args)
        {
            NumerosPares();
            Console.ReadKey();
        }
        static private void NumerosPares()
        {
            while (i <= 100)
            {
                numeros = Math.Pow(i, 2);
                potencia = Convert.ToInt32(numeros);
                suma = suma + potencia;
                i = i + 2;
            }
            Console.WriteLine("La suma de los cuadrados de los numeros pares es de:" + suma);
        }
    }
}

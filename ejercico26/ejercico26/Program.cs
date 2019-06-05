using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico26
{
    class Program
    {
        static int i, suma, multiplo;
        static float numero;
        static string ingreso;
        static void Main(string[] args)
        {
            i = 0;
            numero = 0;
            suma = 0;
            multiplo = 0;
            ingreso = "";

            Bucle();
            Console.ReadKey();
        }
        static private void Bucle()
        {
            Console.WriteLine("Ingrese un numero");
            ingreso = Console.ReadLine();
            numero = Convert.ToSingle(ingreso);

            while (i <= numero)
            {
                if (i % 5 == 0)
                {
                    multiplo = multiplo + i;
                    i = i + 1;
                }
                else
                {
                    Console.WriteLine(i);
                    suma = suma + i;
                    i = i + 1;
                }
            }
            Console.WriteLine("La suma de los numeros, excepto los multiplos de 5 es de:" + suma);
            Console.WriteLine("La suma de los multiplos de 5 es de:" + multiplo);
        }
    }
}

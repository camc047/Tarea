using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico12
{
    class Program
    {
        static int i, conteo, suma;
        static float numero;
        static string ingreso;
        static void Main(string[] args)
        {
            i = 10;
            conteo = 0;
            suma = 0;
            ingreso = "";

            ConteoySuma();
            Console.ReadKey();
        }
        static private void ConteoySuma()
        {
            Console.WriteLine("Ingrese un numero");
            ingreso = Console.ReadLine();

            numero = Convert.ToSingle(ingreso);

            while(i<= numero)
            {
                Console.WriteLine(i);
                suma = suma + i;
                i = i + 10;
                conteo = conteo + 1;
            }
            Console.WriteLine("Hay un total de" + conteo + "multiplos de 10");
            Console.WriteLine("La suma total es de:" + suma);
        }
    }
}

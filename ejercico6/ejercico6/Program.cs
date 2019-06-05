using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico6
{
    class NumerosNaturales

    {
        static int i;
        static float numero;
        static string ingresado;
        static void Main(string[] args)
        {
            i = 1;
            ingresado = "";
            numero = 0;

            NumerosNaturales1aIngresado();
            Console.ReadKey();
        }
        static private void NumerosNaturales1aIngresado()
        {
            Console.WriteLine("Ingrese un numero");
            ingresado = Console.ReadLine();
            numero = Convert.ToSingle(ingresado);

            while (i<=numero)
            {
                Console.WriteLine(i);
                i = i + 1;
            }
        }
    }
}

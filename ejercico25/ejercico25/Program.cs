using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico25
{
    class Program
    {
        static float numero;
        static int i;
        static string ingreso;
        static void Main(string[] args)
        {
            numero = 0;
            ingreso = "";
            i = 1;

            MayorMenor();
            Console.ReadKey();
        }
        static private void MayorMenor()
        {
            while (1 <= 5)
            {
                Console.WriteLine("Ingrese un numero");
                ingreso = Console.ReadLine();
                numero = Convert.ToSingle(ingreso);

                if (numero > 10)
                {
                    Console.WriteLine(numero + "Es mayor a 10");
                }
                else
                {
                    Console.WriteLine(numero + "Es menor a 10");
                }
                i = i + 1;
            }
        }
    }
}


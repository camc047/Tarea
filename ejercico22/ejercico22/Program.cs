using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico22
{
    class Program
    {
        static string ingreso;
        static float numero, mayor, menor;
        static int i;
        static void Main(string[] args)
        {
            i = 1;
            mayor = 0;
            menor = 9999;
            ingreso = "";

            MayorMenor();
            Console.ReadKey();
        }
        static private void MayorMenor()
        {
            while (i <= 5)
            {
                Console.WriteLine("Ingrese un numero");
                ingreso = Console.ReadLine();
                numero = Convert.ToSingle(ingreso);

                if (numero > mayor)
                {
                    mayor = numero;
                }

                if (numero < menor)
                {
                    menor = numero;
                }
                i = i + 1;
            }

            Console.WriteLine("El numero mayor es de:" + mayor);
            Console.WriteLine("El numero menor es de:" + menor);
    }
        
    }
}

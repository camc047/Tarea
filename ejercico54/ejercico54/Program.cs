using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico54
{
    class Program
    {
        static int i, contador;
        static float num1, num2;
        static string entrada;
        static void Main(string[] args)
        {
            i = 0;
            contador = 1;
            num1 = 0;
            num2 = 0;
            entrada = "";

            restasSucesivas();
            Console.ReadKey();
        }

        static private void restasSucesivas()
        {
            Console.WriteLine("Ingrese el primer número: ");
            entrada = Console.ReadLine();
            num1 = Convert.ToSingle(entrada);

            Console.WriteLine("Ingrese el segundo número: ");
            entrada = Console.ReadLine();
            num2 = Convert.ToSingle(entrada); 
            
            if ((num1 >= 0) && (num2 >= 0))
            {
                while (contador <= num1)
                {
                    contador = contador + 1;
                    i = i + Convert.ToInt32(num2);
                }

                Console.WriteLine("El producto de los dos números es de: " + i);
            }
            else
            {
                Console.WriteLine("Eror, Usted ha escrito un número negativo");
            }
        }
    }
}

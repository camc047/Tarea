using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico34
{
    class Program
    {
        static int i, contador;
        static float num1, num2;
        static string ingreso;
        static void Main(string[] args)
        {
            i = 0;
            contador = 1;
            num1 = 0;
            num2 = 0;
            ingreso = "";

            restasSucesivas();
            Console.ReadKey();
        }

        static private void restasSucesivas()
        {
            Console.WriteLine("Ingrese el primer número: ");  
            ingreso = Console.ReadLine();  
            num1 = Convert.ToSingle(ingreso); 

            Console.WriteLine("Ingrese el segundo número: ");  
            ingreso = Console.ReadLine();  
            num2 = Convert.ToSingle(ingreso);  

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
                Console.WriteLine("Error, Usted ha escrito un número negativo");  

            }
        }
    }
}

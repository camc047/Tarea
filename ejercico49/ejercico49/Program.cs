using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico49
{
    class Program
    {
        static int num1, num2, num3;
        static string ingreso;
        static void Main(string[] args)
        {
            num1 = 0;
            num2 = 0;
            num3 = 0;
            ingreso = "";


            Console.WriteLine("Ingrese el primer número");
            ingreso = Console.ReadLine();
            num1 = Convert.ToInt32(ingreso);

            Console.WriteLine("Ingrese el segundo número ");
            ingreso = Console.ReadLine();
            num2 = Convert.ToInt32(ingreso);

            comparacionDeNumeros();


            Console.WriteLine("La suma de los números es de: " + (num1 + num2 + num3));


            Console.WriteLine("La media aritmética de los números es de: " + ((num1 + num2 + num3) / 3));

            Console.ReadKey();
        }

        static private void comparacionDeNumeros()
        {

            if ((num1 > num2) && (num1 > num3))
            {
                Console.WriteLine("El número mayor es " + num1);
            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine("El número mayor es " + num2);
                }
                else
                {
                    Console.WriteLine("El número mayor es " + num3);

                }
            }


            if ((num1 < num2) && (num1 < num3))
            {
                Console.WriteLine("El número menor es " + num1);
            }
            else
            {
                if (num2 < num3)
                {
                    Console.WriteLine("El número menor es " + num2);
                }
                else
                {
                    Console.WriteLine("El número menor es " + num3);

                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico32
{
    class Program
    {
        static string ingreso;
        static float num1, num2, suma;
        static int i, conteo;
        static void Main(string[] args)
        {
            ingreso = "";
            i = 0;
            num1 = 0;
            num2 = 0;
            conteo = 0;
            suma = 0;

            ingresoDeNumeros();
            multiplosDe2();
            Console.ReadKey();
        }

        static private void ingresoDeNumeros()
        {
            Console.WriteLine("Ingrese un número: ");  
            ingreso = Console.ReadLine();  
            num1 = Convert.ToSingle(ingreso);  
            i = Convert.ToInt32(num1);  

            Console.WriteLine("Ingrese un número mayor que: " + num1);  
            ingreso = Console.ReadLine();  
            num2 = Convert.ToSingle(ingreso);  

            while (num2 < num1)
            {
                Console.WriteLine("El número ingresado es menor que: " + num1 + " ingrese nuevamente un número mayor ");   
                ingreso = Console.ReadLine();  
                num2 = Convert.ToSingle(ingreso);  
            }
        }

        static private void multiplosDe2()
        {
            while (i <= num2)  
            {
                if (i % 2 == 0)  
                {
                    Console.WriteLine(i);
                    suma = suma + i;  
                    conteo = conteo + 1; 
                }

                i = i + 1;  
            }

           
            Console.WriteLine("Hay un total de " + conteo );
            Console.WriteLine("La suma de los múltiplos de 2 es de: " + suma);
        }
    }
}

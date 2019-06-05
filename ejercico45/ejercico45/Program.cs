using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico45
{
    class Program
    {
        static float num1, num2, sumaImpar;
        static string entrada;
        static int conteoPar, conteo, i;
        static void Main(string[] args)
        {
            i = 0;
            num1 = 0;
            num2 = 0;
            sumaImpar = 0;
            conteoPar = 0;
            entrada = "";
            conteo = 0;

            MayorMenor();
            ConteoParSumaImpar();
            Console.ReadKey();
        }

        
        static private void MayorMenor()
        {
            Console.WriteLine("Ingrese un número: ");  
            entrada = Console.ReadLine();
            num1 = Convert.ToSingle(entrada);
            i = Convert.ToInt32(num1); 

            Console.WriteLine("Ingrese un número mayor que: " + num1); 
            entrada = Console.ReadLine();  
            num2 = Convert.ToSingle(entrada);

            while (num2 < num1)
            {
                Console.WriteLine("El número ingresado es menor que: " + num1 + " ingrese nuevamente un número mayor que " + num1);
                entrada = Console.ReadLine();
                num2 = Convert.ToSingle(entrada);
            }
        }

        static private void ConteoParSumaImpar()
        {
            while (i <= num2) 
            {
                Console.WriteLine(i);

                if (i % 2 == 0)
                {
                    conteoPar = conteoPar + 1;
                }
                else
                {
                    sumaImpar = sumaImpar + i;
                }
                conteo = conteo + 1;  
                i = i + 7; 
            }
            
            Console.WriteLine("Hay un total de: " + conteoPar + " números pares");
            Console.WriteLine("La suma de los números impares es de: " + sumaImpar);
            Console.WriteLine("Hay un total de: " + conteo + " números");
        }
    }
}

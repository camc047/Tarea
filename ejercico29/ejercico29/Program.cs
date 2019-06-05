using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico29
{
    class Program
    {
        static float num1, num2, impar;
        static string ingreso;
        static int conteoPar, conteo, i;
        static void Main(string[] args)
        {
            i = 0;
            num1 = 0;
            num2 = 0;
            impar = 0;
            conteoPar = 0;
            ingreso = "";
            conteo = 0;

            MayorMenor();
            ConteoParSumaImpar();
            Console.ReadKey();
        }
        static private void MayorMenor()
        {
            Console.WriteLine("Ingrese un numero");
            ingreso = Console.ReadLine();
            num1 = Convert.ToSingle(ingreso);

            while(num2<num1)
            {
                Console.WriteLine("El numero que ingreso es menor a" + num1 + "Ingrese un numero mayor");
                ingreso = Console.ReadLine();
                num2 = Convert.ToSingle(ingreso);

            }
        }
        static private void ConteoParSumaImpar()
        {
            while(i<=num2)
            {
                if (i % 2 == 0) 
                {
                    conteoPar = conteoPar + 1;  
                }
                else
                {
                    impar = impar + i;  
                }
                conteo = conteo + 1;  
                i = i + 7;
            }
            Console.WriteLine("Hay un tota de numeros pares" + conteoPar);
            Console.WriteLine("La suma de los numeros impares es de" + impar);
            Console.WriteLine("Hay un total de " + conteo + "numeros");
        }
    }
}

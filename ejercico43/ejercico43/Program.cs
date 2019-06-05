using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico43
{
    class Program
    {
        static int num1, num2, conteo, conteoPar, sumaImpar;
        static string ingreso;
        static void Main(string[] args)
        {
            num1 = 0;
            num2 = 0;
            conteo = 0;
            conteoPar = 0;
            sumaImpar = 0;
            ingreso = "";

            ingresoDeDatos();
            conteoSumaImparYConteoPar();
            Console.ReadKey();
        }

        static private void ingresoDeDatos()
        {
            Console.WriteLine("Ingrese el primer número: ");
            ingreso = Console.ReadLine();
            num1 = Convert.ToInt32(ingreso);

            Console.WriteLine("Ingrese el segundo número: ");
            ingreso = Console.ReadLine();
            num2 = Convert.ToInt32(ingreso);
        }

        static private void conteoSumaImparYConteoPar()
        {
            if (num1 < num2)
            {
                while (num1 <= num2)
                {
                    Console.WriteLine(num1);
                    if (num1 % 2 == 0)
                    {
                        conteoPar = conteoPar + 1;
                    }
                    else
                    {
                        sumaImpar = sumaImpar + num1;

                        conteo = conteo + 1;
                        num1 = num1 + 1;
                    }
            else
            {
                        while (num2 <= num1)
                        {
                            Console.WriteLine(num2);
                            if (num2 % 2 == 0)
                            {
                                conteoPar = conteoPar + 1;
                            }
                            else
                            {
                                sumaImpar = sumaImpar + num1;
                            }

                            conteo = conteo + 1;
                            num2 = num2 + 1;
                        }

                    }

                    Console.WriteLine("Hay un total de: " + conteo + " números naturales");
                    Console.WriteLine("Hay un total de: " + conteoPar + " números pares");
                    Console.WriteLine("La suma de los números impares es de: " + sumaImpar);
                }
            }
        }
    }
}

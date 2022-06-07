using System;

namespace ConsoleAppEjercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ver si un número es par o impar";
            Console.Write("Ingrese un número entero cualquiera:");
            int numero = int.Parse(Console.ReadLine());
            if (numero%2==0)
            {
                Console.WriteLine($"{numero} es par");
            }
            else
            {
                Console.WriteLine($"{numero} es impar");
            }

            Console.ReadLine();
        }
    }
}

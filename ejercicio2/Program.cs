using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de variables
            int N = 5;
            double A = 4.56;
            char C = 'a';

            // Mostrar el valor de cada variable
            Console.WriteLine($"Variable N = {N}");
            Console.WriteLine($"Variable A = {A}");
            Console.WriteLine($"Variable C = {C}");

            // Realizar operaciones
            double sum = N + A;
            double difference = A - N;
            int charValue = (int)C;

            // Mostrar resultados de las operaciones
            Console.WriteLine($"{N} + {A} = {sum}");
            Console.WriteLine($"{A} - {N} = {difference}");
            Console.WriteLine($"Valor numérico del carácter {C} = {charValue}");
        }
    }
}
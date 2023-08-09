using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de variables
            int num1 = 10;
            int num2 = 5;

            // Realizar operaciones matemáticas
            int suma = num1 + num2;
            int resta = num1 - num2;
            int multiplicacion = num1 * num2;
            int division = num1 / num2;
            int modulo = num1 % num2;

            // Mostrar resultados por consola
            Console.WriteLine($"Suma: {suma}");
            Console.WriteLine($"Resta: {resta}");
            Console.WriteLine($"Multiplicación: {multiplicacion}");
            Console.WriteLine($"División: {division}");
            Console.WriteLine($"Módulo: {modulo}");
        }
    }
}

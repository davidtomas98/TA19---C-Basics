using System;

namespace CalculadoraBasicaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declara dos variables numéricas
            int numero1 = 10;
            int numero2 = 5;

            // Realiza las operaciones y muestra los resultados por consola
            Console.WriteLine($"Suma: {numero1 + numero2}");
            Console.WriteLine($"Resta: {numero1 - numero2}");
            Console.WriteLine($"Multiplicación: {numero1 * numero2}");

            // Verifica si el divisor (numero2) no es cero antes de hacer la división
            if (numero2 != 0)
            {
                Console.WriteLine($"División: {numero1 / (double)numero2}"); // Usamos cast a double para obtener decimales
                Console.WriteLine($"Módulo (Resto): {numero1 % numero2}");
            }
            else
            {
                Console.WriteLine("No se puede dividir por cero.");
            }

            // Espera a que el usuario presione una tecla para finalizar
            Console.ReadKey();
        }
    }
}

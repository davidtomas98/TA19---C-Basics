namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de variables
            int X = 10;
            int Y = 5;
            double N = 7.5;
            double M = 2.5;

            // Mostrar el valor de cada variable
            Console.WriteLine($"Valor de X = {X}");
            Console.WriteLine($"Valor de Y = {Y}");
            Console.WriteLine($"Valor de N = {N}");
            Console.WriteLine($"Valor de M = {M}");

            // Realizar operaciones y mostrar resultados
            Console.WriteLine($"X + Y = {X + Y}");
            Console.WriteLine($"X - Y = {X - Y}");
            Console.WriteLine($"X * Y = {X * Y}");
            Console.WriteLine($"X / Y = {X / (double)Y}"); // Convertir Y a double para obtener un resultado decimal
            Console.WriteLine($"X % Y = {X % Y}");

            Console.WriteLine($"N + M = {N + M}");
            Console.WriteLine($"N - M = {N - M}");
            Console.WriteLine($"N * M = {N * M}");
            Console.WriteLine($"N / M = {N / M}");
            Console.WriteLine($"N % M = {N % M}");

            Console.WriteLine($"X + N = {X + N}");
            Console.WriteLine($"Y / M = {Y / (double)M}"); // Convertir Y a double para obtener un resultado decimal
            Console.WriteLine($"Y % M = {Y % (double)M}"); // Convertir Y a double para obtener un resultado decimal

            // Mostrar el doble de cada variable
            Console.WriteLine($"Doble de X = {2 * X}");
            Console.WriteLine($"Doble de Y = {2 * Y}");
            Console.WriteLine($"Doble de N = {2 * N}");
            Console.WriteLine($"Doble de M = {2 * M}");

            // Calcular y mostrar la suma y el producto de todas las variables
            double sumOfAll = X + Y + N + M;
            double productOfAll = X * Y * N * M;

            Console.WriteLine($"Suma de todas las variables = {sumOfAll}");
            Console.WriteLine($"Producto de todas las variables = {productOfAll}");
        }
    }
}
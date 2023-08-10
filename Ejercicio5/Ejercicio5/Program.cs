namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración e inicialización de variables
            int A = 1, B = 2, C = 3, D = 4;

            // Mostrar los valores iniciales de las variables
            Console.WriteLine($"Valores iniciales: A = {A}, B = {B}, C = {C}, D = {D}");

            // Realizar el intercambio de valores entre las variables
            int tempB = B;
            B = C;
            C = A;
            A = D;
            D = tempB;

            // Mostrar los nuevos valores de las variables después del intercambio
            Console.WriteLine($"Nuevos valores: A = {A}, B = {B}, C = {C}, D = {D}");
        }
    }
}
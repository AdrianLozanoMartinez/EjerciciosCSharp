namespace Ejercicio30
{
    class Program
    {
        /*
        Ejercicio 30.
        Crea un programa que le pida al usuario un número entero N y muestre por pantalla el
        triángulo de Pascal para las N primeras filas.
        Triángulo de Pascal:
        */

        static void Main()
        {
            Console.WriteLine("Introduce un número entero");
            int rows = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rows; i++) //FILAS 1 al número introducido
            {
                Console.Write(new string(' ', rows - i)); //Espacios según el número de filas menos i de cada vueltas, va disminuyendo los espacio a medida que avanza el for

                for (int j = 0; j <= i; j++) //COLUMNAS del 0 al número introducido. Se pone i porque sino te lo rellena con 0 al final cada filas
                {
                    Console.Write(Combinatorio(i, j) + " ");
                }
                Console.WriteLine();
            }
        }



        static int Combinatorio(int m, int n)
        {
            return Factorial(m) / (Factorial(n) * Factorial(m - n));
        }

        static int Factorial(int x)
        {
            int result = 1;

            for (int i = 2; i <= x; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
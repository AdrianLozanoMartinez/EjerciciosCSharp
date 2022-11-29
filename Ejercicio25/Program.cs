namespace Ejercicio25
{
    class Program
    {
        /*
        Ejercicio 25.
        Crea un programa que pida dos números enteros (n y m) al usuario y muestre por pantalla
        el resultado de n! - m!.
            */

        static void Main()
        {
            Console.WriteLine("Introduzca 1º número entero");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca 2º número entero");
            int m = int.Parse(Console.ReadLine());

            int result = Factorial(n) - Factorial(m);

            Show(result);
        }

        static int Factorial(int x)
        {
            int fact = 0;

            if (x <= 1)
            {
                fact = 1;
            }
            else
            {
                fact = x * Factorial(x - 1);
            }
            return fact;
        }

        static void Show(int result) 
        {
            Console.WriteLine(result);
        }
    }
}
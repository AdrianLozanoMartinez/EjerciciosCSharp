using System.Globalization;

namespace Ejercicio07
{
    class Program
    {
        /*Ejercicio 7.
            El programa pedirá al usuario que introduzca 3 números enteros. Cada número
            corresponderá a la dimensión de un lado de un triángulo. Por pantalla se mostrará si el
            triángulo es equilátero, isósceles o escaleno.
            */
        static void Main()
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Introduzca 1º número entero");
            double num1 = double.Parse(Console.ReadLine()); 
            Console.WriteLine("Introduzca 2º número entero");
            double num2 = double.Parse(Console.ReadLine()); 
            Console.WriteLine("Introduzca 3º número entero");
            double num3 = double.Parse(Console.ReadLine());

            if (num1 != num2 && num2 != num3 && num1 != num3)
            {
                Console.WriteLine("Escaleno");
            }
            else if (num1 == num2 && num2 == num3)
            {
                Console.WriteLine("Equilátero");
            }
            else
            {
                Console.WriteLine("Isósceles");
            }
        }
    }
}
using System.Globalization; //Para que coja . en lugar de , en decimales

namespace Ejercicio03
{
    class Program
    {
        /*Ejercicio 3
          El programa pedirá al usuario que introduzca una temperatura en grados Fahrenheit y, a continuación, mostrará esa 
          temperatura traducida a grados Celsius

          NOTA: Para pasar de ºF a ºC primero hemos de restar 32 y, a continuación, dividir entre 9 y multiplicar por 5.*/
        static void Main()
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture; //Para que coja . en lugar de , en decimales

            Console.WriteLine("Introduzca una temperatura en grados Fahrenheit");
            double num = double.Parse(Console.ReadLine());

            double celsius = (num-32)/9*5;

            Console.WriteLine($"{celsius}ºC");
        }
    }
}
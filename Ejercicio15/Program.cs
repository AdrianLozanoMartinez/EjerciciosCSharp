using System.Globalization; //Usar . en lugar de ,

namespace Ejercicio15
{
    class Program
    {
        /*Ejercicio 15.
        El programa pedirá al usuario un número entero que indicará la cantidad de números que
        tendrá que introducir posteriormente. Luego, mostrará la media aritmética de dichos
        números.*/

        static void Main()
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture; //Usar . en lugar de ,

            Console.WriteLine("Introduzca el número de veces que quiere que introduzca un número entero para hacer la media");
            int numberOfTimes = int.Parse(Console.ReadLine());

            double addition = 0;
            double result = 0;

            for (int i = 1; i <= numberOfTimes; i++)
            {
                Console.WriteLine($"Introduzca el {i}º/{numberOfTimes}");
                addition += double.Parse(Console.ReadLine());  
            }
            result = addition / numberOfTimes;

            Console.WriteLine(result);
        }
    }
}
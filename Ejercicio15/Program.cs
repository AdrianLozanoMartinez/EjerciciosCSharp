using System.Globalization; //Usar . en lugar de ,

namespace Ejercicio15
{
    class Program
    {
        static void Main()
        {
            /*Ejercicio 15.
            El programa pedirá al usuario un número entero que indicará la cantidad de números que
            tendrá que introducir posteriormente. Luego, mostrará la media aritmética de dichos
            números.*/

            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture; //Usar . en lugar de ,

            Console.WriteLine("Introduzca el número de veces que quiere que introduzca un número entero para hacer la media");
            int numberOfTimes = int.Parse(Console.ReadLine());

            double addition = 0;
            double result = 0;

            for (int i = 1; i <= numberOfTimes; i++)
            {
                Console.WriteLine($"Introduzca el {i}º/{numberOfTimes}");
                addition += double.Parse(Console.ReadLine());  //Sumamos cada dato introducido con el siguiente a
                                                               //medida que introducimos por teclado y lo almacenamos
                                                               //en la misma variable
            }
            result = addition / numberOfTimes;

            Console.WriteLine(result);
        }
    }
}
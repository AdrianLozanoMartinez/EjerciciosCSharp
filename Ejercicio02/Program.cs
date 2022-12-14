using System.Globalization;  //Para que funcione el . en lugar de la , en el decimal

namespace Ejercicio02
{
    class Program
    {
        /*Ejercicio 2
             El programa pedirá que se introduzca dos números reales y mostrará a continuación cuál es su suma.*/

        static void Main()
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;   //Para que funcione el . en lugar de la , en el decimal

            Console.WriteLine("Introduzca dos números reales");

            Console.WriteLine("1º número real");
            double num1 = double.Parse(Console.ReadLine());             

            Console.WriteLine("2º número real");
            double num2 = double.Parse(Console.ReadLine());

            double addition = num1 + num2;

            Console.WriteLine($"La suma es {addition}");
        }
    }
}
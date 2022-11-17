namespace Ejercicio20
{
    class Program
    {
        enum Month { January = 1, February, March, April, May, June, July, August, September, October, Nobember, December };

        static void Main()
        {
            /*
             Ejercicio 20.
             Crea un enumerado con los meses del año. El programa pedirá al usuario un número entero
             que indicará el mes escogido (1 - 12). Luego, mostrará el nombre del mes escogido por
             pantalla.
             */
            Console.WriteLine("Elija el número del mes que quieras ver");
            int num = int.Parse(Console.ReadLine());

            Month month = (Month)num; //No le quitamos -1 porque coge posición de Enero = 1 y así enero comienza por 1 y no por 0

            Console.WriteLine(month);
        }
    }
}
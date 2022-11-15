namespace Ejercicio04
{
    class Program
    {
        /*Ejercicio 4
            El programa pedirá al usuario que introduzca un número entero y mostrará el valor de las
            unidades.
            Ejemplo: Si se introduce 15 se mostrará 5 */
        static void Main()
        {
            Console.WriteLine("Introduzca un número entero de mínimo 2 cifras");
            int num = int.Parse(Console.ReadLine());   //Convertimos en entero el string

            int unit = num % 10; 

            Console.WriteLine($"La unidad es: {unit}");
        }
    }
}
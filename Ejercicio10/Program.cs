namespace Ejercicio10
{
    class Program
    {
        /*Ejercicio 10.
            El programa pedirá al usuario un número entero y mostrará todos los números divisibles por
            2 y 3 comprendidos dentro del rango de 1 y el número dado*/
        static void Main()
        {
            Console.WriteLine("Introduzca un número entero");
            int num = int.Parse(Console.ReadLine());

            for(int i = 1; i <= num; i++)
            {
                if((i % 2 == 0) && (i % 3 == 0)) //% busca el resto que de 0 para que sea divisible entre 2 y 3
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
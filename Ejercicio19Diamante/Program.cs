namespace Ejercicio19Diamante
{
    class Program
    {
        /*EL DIAMANTE.
        Crear un programa que muestre en pantalla un diamante formado por asteriscos, dado un
        valor de número de niveles de asteriscos máximo en el punto central del diamante o rombo.
        Ejemplo: si el valor en el punto central es 5 el rombo sería:*/

        static void Main()
        {
            Console.WriteLine("Introduzca el número de fila del diamante");
            int diamond = int.Parse(Console.ReadLine());

            for (int i = 0; i < diamond; i++) //Filas
            {
                Console.WriteLine();

                for (int j = diamond - i; j > 0; j--)//j= diamond - i es quien indica la cantidad de veces que aparece
                {
                    Console.Write(' ');
                }
                for (int k = i * 2 + 1; k > 0; k--)//k = i * 2 + 1 es quien indica la cantidad de veces que aparece
                {
                    Console.Write('*');
                }
            }

            for (int i = diamond - 2; i >= 0; i--) //Da la vuelta
            {
                Console.WriteLine();

                for (int j = diamond - i; j > 0; j--)
                {
                    Console.Write(' ');
                }
                for (int k = i * 2 + 1; k > 0; k--)
                {
                    Console.Write('*');
                }
            }
        }
    }
}
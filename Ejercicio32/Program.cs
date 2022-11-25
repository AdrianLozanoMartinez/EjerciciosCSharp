namespace Ejercicio32
{
    class Program
    {
        /*
         Ejercicio 32.
         Crea un array de 10 posiciones de números con valores pedidos por teclado. Muestra por
         consola el índice y el valor al que corresponde. Haz dos métodos, uno para rellenar valores
         y otro para mostrar.
         */

        static void Main()
        {
            int[] array = new int[10];

            //Introducir
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Introduzca {i+1}/10");
                array[i] = int.Parse(Console.ReadLine());
            }

            //Mostrar
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Indice {i}, valor {array[i]}");
            }
        }
    }
}
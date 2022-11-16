namespace Ejercicio14
{
    class Program
    {
        static void Main()
        {
            /*Ejercicio 14.
            El programa pedirá al usuario dos números enteros. El primer número será la semilla para el
            generador aleatorio y el segundo será la cantidad de caracteres que se van a generar. Se
            tendrá que pasar cada número generado a carácter ASCII y mostrarlo por pantalla.*/

            Console.WriteLine("Introduzca un número entero para la semilla");
            int seed = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca un número entero para la cantidad de caracteres");
            int amount = int.Parse(Console.ReadLine());

            Random random= new Random(seed);
            int randomNumber = 0;
            char ascii = ' ';

            for (int i = 0; i < amount; i++)
            {
                randomNumber = random.Next(256);
                ascii = (char)randomNumber;

                Console.WriteLine($"Número aleatorio: {randomNumber} - Número ASCII: {ascii}");
            }
        }
    }
}
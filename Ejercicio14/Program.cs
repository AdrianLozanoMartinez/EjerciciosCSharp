namespace Ejercicio14
{
    class Program
    {
        /*Ejercicio 14.
        El programa pedirá al usuario dos números enteros. El primer número será la semilla para el
        generador aleatorio y el segundo será la cantidad de caracteres que se van a generar. Se
        tendrá que pasar cada número generado a carácter ASCII y mostrarlo por pantalla.*/

        static void Main()
        {
            Console.WriteLine("Introduzca un número entero para la semilla");
            int seed = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca un número entero para la cantidad de caracteres");
            int amount = int.Parse(Console.ReadLine());

            Random random= new Random(seed);       //Metemos la semilla por teclado
            int randomNumber = 0;
            char ascii = ' ';
            const int ASCII = 256;                 //Valor que se usa abajo y no varía, por eso se pone constante

            for (int i = 0; i < amount; i++)       //Hasta el número de caracteres que queremos mostrar dado por usuario
            {
                randomNumber = random.Next(ASCII); //Añadimos 256 en lugar de 255 porque nunca coge el último número

                ascii = (char)randomNumber;

                Console.WriteLine($"Número aleatorio: {randomNumber} - Número ASCII: {ascii}");
            }
        }
    }
}
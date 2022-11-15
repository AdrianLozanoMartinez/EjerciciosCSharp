namespace Ejercicio01
{
    class Program
    {
        /*Ejercicio 1
            El programa preguntará el nombre al usuario y a continuación le saludará de la siguiente forma "Hola, NOMBRE" es el nombre del usuario.
            Intentar que aparezca con comillas*/

        static void Main()
        {
            Console.WriteLine("¿Cuál es su nombre?"); //Muestra: ¿Cuál es su nombre?
            string name = Console.ReadLine();         //Coge lo introducido por teclado en formato string.

            Console.WriteLine($"\"Hola, {name}\"");   //Muestra: "Hola, nombre_de_la_persona"
        }
    }
}
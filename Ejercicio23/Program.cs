namespace Ejercicio23
{
    class Program
    {
    /*
    Ejercicio 23.
    El programa pedirá al usuario 2 números enteros y mostrará el resultado de dividir el
    primero por el segundo. Si se genera una excepción hay que controlarla y notificar al usuario.
    */

        static void Main()
        {
            try 
            { 
                Console.WriteLine("Introduzca el 1º número");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduzca el 2º número");
                int num2 = int.Parse(Console.ReadLine());

                int addition = num1 / num2;
                Console.WriteLine(addition);
            }
            catch(Exception e) 
            {
               // Te devuelve todo, incluyendo la línea que se ha producido
                Console.WriteLine($"Se ha generado el error: {e}");
            }
        }
    }
}
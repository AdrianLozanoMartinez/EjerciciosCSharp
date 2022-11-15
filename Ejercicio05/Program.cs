namespace Ejercicio05
{
    class Program
    {
        /*Ejercicio5
 
            Pedir un número y decir si es par e impar*/
        static void Main()
        {
            Console.WriteLine("Introduzca un número");
            int pair = int.Parse(Console.ReadLine());

            if (pair % 2 == 0)  //Coge el resto, si da 0 entra
            {
                Console.WriteLine($"El número {pair} es par");
            }
            else  //Si da 1 entra
            {
                Console.WriteLine($"El número {pair} es impar");
            }
        }
    }
}
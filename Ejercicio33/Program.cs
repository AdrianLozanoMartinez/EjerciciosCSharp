namespace Ejercicio33
{
    class Program
    {
        /*
         Ejercicio 33.
         El usuario introducirá por consola una lista de varios números enteros separados por
         comas. El programa mostrará los números pares.
         Nota: Usar el método Split de los string
        */

        static void Main()
        {
            Console.WriteLine("Introduzca números enteros con coma (,)");
            string num = Console.ReadLine();

            string[] deleteCommas = num.Split(',');

            for (int i = 0; i< deleteCommas.Length; i++)
            {
                int numbers = int.Parse(deleteCommas[i]);

                if(numbers % 2 == 0)
                Console.WriteLine(numbers);
            }
        }
    }
}
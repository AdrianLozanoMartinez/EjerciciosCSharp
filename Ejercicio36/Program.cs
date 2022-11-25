namespace Ejercicio36
{
    class Program
    {
        /*
         Ejercicio 36.
         El usuario introducirá por consola una lista de varios números enteros separados por
         comas. El programa ordenará el array de números de menor a mayor y los mostrará por
         pantalla en dicho orden.
        */
        static void Main()
        {
            Console.WriteLine("Introduzca números separados por coma");
            string input = Console.ReadLine();

            string[] deleteCommas = input.Split(',');

            int[] number = new int[deleteCommas.Length];

            int aux = 0;

            //Metemos valores al array
            for (int i = 0; i < deleteCommas.Length; i++)
            {
                number[i] = int.Parse(deleteCommas[i]);
            }

            //Ordena - Método burbuja
            for (int i = 0; i < deleteCommas.Length; i++)
            {
                for (int j = 0; j < deleteCommas.Length; j++)
                {
                    if (number[j] > number[i])
                    {
                        aux = number[i];
                        number[i] = number[j];
                        number[j] = aux;
                    }
                }
            }
            //Muestra valores ordenados
            Console.WriteLine(string.Join(",", number));
        }
    }
}
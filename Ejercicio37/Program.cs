namespace Ejercicio37
{
    class Program
    {
        /*
         Ejercicio 37.
         El usuario introducirá por consola un número entero positivo que indicará el tamaño de un
         array. Rellena ese array con números enteros aleatorios no repetidos entre sí. Muestra por
         pantalla los números guardados.
        */
        static void Main()
        {
            Console.Write("Introduzca un número entero positivo: ");  
            int number = int.Parse(Console.ReadLine());

            int[] listnumbers = new int[number];  
            Random random= new Random();
            for (int i = 0; i < number; i++) 
            {
                int numberRandom = random.Next();
                do
                {
                    listnumbers[i] = numberRandom;
                }
                while (Contains(listnumbers, number));
            }
            Console.WriteLine(String.Join(", ", listnumbers));
        }  
        static bool Contains(int[] array, int item)
        {
            bool found = false;

            for (int i = 0; i < array.Length && !found; i++) 
            {
                int num = array[i]; 

                if (num == item) found = true;
            }

            return found;
        }
    }
}


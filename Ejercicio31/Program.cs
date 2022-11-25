namespace Ejercicio31
{
    class Program
    {
        /*
         Ejercicio 31.
         Crea un array de números de 100 posiciones, que contendrá los números del 1 al 100.
         Obtén la suma de todos ellos y la media.
        */

        static void Main()
        {
            int[] array = new int[100];
            double result = 0;

            //Creamos el array
            for (int i = 0; i < array.Length; i++) 
            {
                array[i] = i + 1;  //Sumamos 1 porque va de 0 a 99, al sumarle va de 1 a 100
                Console.WriteLine(array[i]);
            }

            //Mostramos el array
            foreach (int num in array) //Para mostrar puede ser foreach y for
            {
                result += num;
            }
            Console.WriteLine($"Media: {result / array.Length}");
        }
    }
}
namespace Ejercicio38
{
    class Program
    {
        /*
        Ejercicio 38.
        Crea un array de 10 números enteros aleatorios e imprima por pantalla aquellos números
        que estén en posiciones impares. (La posición 0 es par)
        */
        static void Main()
        {
            int[] array = new int[10];

            Random random= new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next();
            }

            for(int i = 1; i < array.Length; i += 2) //Opción sin if
            //for(int i = 0; i < array.Length; i++) //Opción con if
            {
                //if( i % 2 == 1) //Opción con for i +=2
                Console.WriteLine($"Posición {i} es el número: {array[i]}");
            }
        }
    }
}
namespace Ejercicio34
{
    class Program
    {
        /*
        Ejercicio 34.
        El usuario introducirá por consola una lista de varios números enteros separados por
        comas. El programa mostrará los números con mayor y menor valor.
        */
        static void Main()
        {
            Console.WriteLine("Introduzca números separados con coma (,)");
            string num = Console.ReadLine();

            string[] deleteCommas = num.Split(','); //Quitar las ,

            int[] number = new int[deleteCommas.Length]; //Metemos las posiciones del entero, el tamaño del array string

            for(int i=0; i< number.Length; i++)
            {
                number[i] = int.Parse(deleteCommas[i]);
            }

            int more = int.MinValue; //Para saber lo máximo (more) partimos desde lo mínimo (MinValue)
            int less = int.MaxValue; //Para saber lo mínimo (less) partimos desde lo máximo (MaxValue)

            //Opción profe
            foreach (int numero in number)
            {
                if (numero > more) //Si el número que evaluamos en mayor que el mínimo cuando empezamos a comparar int.MinValue, pero el siguiente
                {                  //número que comparamos es el siguiente mínimo ya que es el máximo de int.MinValue, sino es mayor se va al else
                    more = numero; //Cambia valor del mínimo por el número introducido
                }
                else if (numero < less) //Si el número es menor que el máximo, es decir al igual que en more, el primer número va a ser siempre
                {                       //mayor/menor que el mínimo/máximo y de ahí va comparando cada número que entra. Si es menor entra en else
                    less = numero;//Cambia valor del máximo por el número introducido
                }
            }
            Console.WriteLine("El menor " + less);
            Console.WriteLine("El mayor " + more);
        }
    }
}
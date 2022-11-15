namespace Ejercicio06
{
    class Program
    {
        /*Ejercicio 6
            Simplificar el siguiente segmento de algoritmo de forma que se necesiten menos comparaciones:

            if (age >= 65)
            {
                Console.WriteLine("Jubilado");
            }
            else
            {
                if(age < 18)
                {
                    Console.WriteLine("Menor de edad");
                }
                else
                {
                    if ((age >=18) && (age < 65))
                    {
                        Console.WriteLine("Activo");
                    }
                }
            }
             */

        static void Main()
        {
            Console.WriteLine("Introduzca una edad");
            int age = int.Parse(Console.ReadLine());

            if (age >= 65)
            {
                Console.WriteLine("Jubilado");
            }
            else if (age < 18)
            {
                Console.WriteLine("Menor de edad");
            }
            else
            {
              Console.WriteLine("Activo");
            }
        }
    }
}
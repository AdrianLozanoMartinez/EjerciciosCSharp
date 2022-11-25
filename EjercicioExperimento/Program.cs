namespace EjercicioExperimento
{
    class Program
    {
        //Crea un programa que le pida un número entero N al usuario e imprima por pantalla los N primeros números impares.
        static void Main()
        {
            Console.WriteLine("Introduzca un número");
            int num = int.Parse(Console.ReadLine());

            //for (int 0 = 1; i < num; i++) //Usando if
            for (int i = 1; i < num; i += 2) //Sin usar if y sumando 2 posiciones
            {
                //if(i % 2 != 0)
                //{
                    Console.WriteLine(i);
                //}
            }
        }
    }
}
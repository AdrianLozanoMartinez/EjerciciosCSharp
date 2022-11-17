namespace Ejercicio21
{
    class Program
    {
        enum Week { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
        static void Main()
        {
            /*Ejercicio 21.
            Crea un enumerado con los días de la semana, pide un día de la semana e indica si es
            laboral o no usando el enumerado ya creado.
            Nota: usar el método Parse de los enumerados (Enum.Parse)*/

            Console.WriteLine("Introduzca un día a la semana");
            string week = Console.ReadLine();

            Week weeks = (Week)Enum.Parse(typeof(Week), week, true);
                      //1.Week-Transforma a enumerak como (int)variable
                                             //2.Week-Coge el enumerado
                                                             //True-Ignora mayúscula y minúscula

            if (weeks == Week.Saturday || weeks == Week.Sunday)
            {
                Console.WriteLine("No laboral");
            }
            else
            {
                Console.WriteLine("Laboral");
            }
        }
    }
}
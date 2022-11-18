namespace Ejercicio09
{
    class Program
    {
        /*Ejercicio 9.
            El programa pedirá al usuario un carácter y mostrará el estado civil asociado a dicho
            carácter. Si introduce un carácter distinto se notificará al usuario de que dicho estado no
            existe. (Usando switch)
            C => Casado
            S => Soltero
            V => Viudo
            D => Divorciado*/

        static void Main()
        {
            Console.WriteLine("Introduzca un carácter");
            Console.WriteLine("C => Casado\nS => Soltero\nV => Viudo\nD => Divorciado");
            string letter = Console.ReadLine().ToLower(); 

            switch(letter) { 
                case "c":
                    Console.WriteLine("Usted está casado");
                    break;
                case "s":
                    Console.WriteLine("Usted está soltero");
                    break;
                case "v":
                    Console.WriteLine("Usted está viudo");
                    break;
                case "d":
                    Console.WriteLine("Usted está divorciado");
                    break;
                default:
                    Console.WriteLine("Por favor introduzca una de estas letras");
                    Console.WriteLine("C => Casado, S => Soltero, V => Viudo, D => Divorciado");
                    break;
            }
        }
    }
}
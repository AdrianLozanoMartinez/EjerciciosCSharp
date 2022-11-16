namespace Ejercicio11
{
    class Program
    {
        static void Main()
        {
            /*Ejercicio 11.
            El programa pedirá al usuario un número entero y mostrará todos los números primos
            dentro del rango 1 y el número dado*/

            Console.WriteLine("Introduzca un número entero");
            int num = int.Parse(Console.ReadLine());

            for (int i = 2; i <= num; i++) //El número 1 no es primo y por eso se omite
            {
                bool isPrime = true;

                //Comprobamos desde el 2 hasta i / 2 así como máximo un número se va a poder dividir entre su mitad
                for (int j = 2; j <= i / 2 && isPrime; j++)  //Dividimos /2 para coger el divisor. 
                {                                            //Mientras se pueda dividir por 2 y sea true, hará la comprobación
                    if (i % j == 0)
                    {
                        isPrime = false;  //Si da resto no es primo, ya que buscamos no dividir entre 1 y entre sí mismo (por eso dividimos entre 2)
                    }
                }

                if (isPrime) //Si es true se imprime número. 
                {
                    Console.WriteLine(i); //Muestra si no da resto 0 números que no sean 1 ni si mismo y por eso es primo
                }
            }
        }
    }
}
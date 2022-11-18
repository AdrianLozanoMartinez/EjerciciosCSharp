namespace Ejercicio26
{
    class Program
    {
        /*
        Ejercicio 26.
        Crea un programa que pida un número entero al usuario (n) y muestre el resultado de
        realizar la siguiente operación: Sumatorio*/

        static void Main()
        {
            int input = Input();

            int sumatorio = Sumatorio(input);

            Show(sumatorio);
        }

        static int Input()
        {
            Console.WriteLine("Introduzca número");
            int input = int.Parse(Console.ReadLine());
            return input;
        }

        static int Sumatorio(int x)
        {
            int result = 0;

            for (int i = 1; i <= x; i++)
            {
                result += Factorial(i) + i; 
            }
            return result;   
        }

        static int Factorial (int x)
        {
            int fact = 0;
            
            if(x < 1)
            {
                fact = 1;
            }
            else
            {
                fact = x * Factorial(x - 1);
            }
            return fact;    
        }

        static void Show(int sumatorio)
        {
            Console.WriteLine(sumatorio);
        }
    }
}
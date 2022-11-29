namespace Ejercicio27
{
    class Program
    {
         /*
         Ejercicio 27.
         Sea F(x) la sucesión de Fibonacci de un número x. Crea un programa que pida al usuario dos números enteros (a y b) y muestre 
         por pantalla el resultado de F(a) + F(b).
        */

        /*
         La Sucesión o Algoritmo de Fibonacci se caracteriza por el hecho de que cada número en ella es igual a la suma de los 
         anteriores: 0, 1, 1, 2, 3, 5, 8, 13, 21….. Es decir que: (0+1=1 / 1+1=2 / 1+2=3 / 2+3=5 / 3+5=8 / 5+8=13 / 8+13=21 / 13+21=34…)
         Así sucesivamente, hasta el infinito. Por regla, la sucesión de Fibonacci se escribe así:  n = n-1 + n-2.
         */

        static void Main()
        {
            int num = Input();
            int num2 = Input();

            //Suma Fibonacci
            int result = Fibonacci(num) + Fibonacci(num2);

            Show(result);
        }

        static int Input()
        {
            Console.WriteLine("Introduce número");
            int num = int.Parse(Console.ReadLine());
            return num;
        }

        static int Fibonacci(int n)
        {
            int result = 0;

            if(n <= 1)
                result = n; //Si lo que cogemos es menor o igual que 1 devolvemos dicho número.

            else
                result = Fibonacci(n - 1) + Fibonacci(n - 2);

            return result;
        }

        static void Show(int result)
        {
            Console.WriteLine($"Resultado de la suma de Fibonacci: {result}");
        }
    }
}
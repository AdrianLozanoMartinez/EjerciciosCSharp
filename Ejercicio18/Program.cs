namespace Ejercicio18
{
    class Program
    {
    /*Ejercicio 18.
    El programa pedirá al usuario un número entero que indicará la cantidad de números que
    tendrá que introducir posteriormente. Luego, mostrará la media cuadrática de dichos
    números.
    Fórmula media cuadrática:*/

        static void Main()
        {
            Console.WriteLine("Introduzca un número entero");
            int num = int.Parse(Console.ReadLine());

            double square = 0;
            double result = 0;

            for (int i = 1; i <= num; i++){

                Console.WriteLine($"Introduzca el número {i}/{num}");
                double numNew = int.Parse(Console.ReadLine());

                square += Math.Pow(numNew, 2);

            }
            square/= num;

            result = Math.Sqrt(square); 

            Console.WriteLine(result);
        }
    }
}
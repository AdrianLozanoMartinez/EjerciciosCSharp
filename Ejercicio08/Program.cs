namespace Ejercicio08
{
    class Program
    {
        /*Ejercicio 8.
            El programa pedirá al usuario que introduzca un número entero de dos cifras y mostrará por
            pantalla el número con las cifras invertidas. (Usando sólo operaciones matemáticas)
            Ejemplo: Si se introduce 15 se mostrará 51.*/
        static void Main()
        {
            Console.WriteLine("Introduzca dos´números consecutivos");
            int num = int.Parse(Console.ReadLine());

            int result = num % 10 * 10 + num / 10;  //num%10 -> Da el resto. De 53 el 3. Multiplicamos por 10, obtenemos 30.
                                                    //num/10 -> Elimina el número de atrás (unidad) de 53 el 5, cogemos decimal.
                                                    //Al sumar 30 + 5 = 35 de 53
            Console.WriteLine(result);
        }
    }
}
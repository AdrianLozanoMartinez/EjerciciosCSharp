namespace Ejercicio19Diamante
{
    class Program
    {
        /*EL DIAMANTE.
        Crear un programa que muestre en pantalla un diamante formado por asteriscos, dado un
        valor de número de niveles de asteriscos máximo en el punto central del diamante o rombo.
        Ejemplo: si el valor en el punto central es 5 el rombo sería:*/

        static void Main()
        {
            Console.WriteLine("Introduzca el número del tamaño que tendrá el diamante");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++) //Salto de línea, multiplicar filas de *
            {
                Console.WriteLine(new string(' ', num - i) + new string('*',2 * i + 1));  //2*i+1 porque si es 0, sería: 2*0+1= 1, 2*1+1=3, 2*2+1=5 y así formando la figura del diamante
                                            //Espacio,haya más espacio que * al principio y vaya habiendo menos espacio y más * a medida que crece
            }
            for (int i = num; i >= 0; i--) //Invertir en cantidad el diamante, de más a menos
            {
                Console.WriteLine(new string(' ', num - i) + new string('*', 2 * i + 1));
            }
        }
    }
}
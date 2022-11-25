
namespace Ejercicio16
{
    class Program
    {
    /*Ejercicio 16.
    Escriba un programa que efectúe la conversión de un número natural en base 10 a otra
    determinada base. El usuario introducirá primero el número en base 10 y después la base a
    la que convertirlo (el programa debe asegurarse de que la base no sea ni menor de 2 ni
    mayor de 9).
    Nota: Recordemos que para obtener la representación en una base b de un número en
    decimal, dividimos entre b primero el número y después sucesivamente los diferentes
    cocientes que se vayan obteniendo hasta que el cociente sea cero. Los diferentes restos
    obtenidos en esas sucesivas divisiones constituyen la representación en dicha base b (pero
    en orden inverso a como se han ido calculando). Por ejemplo, para el número decimal 26 en
    base 2 es 11010.*/

        static void Main()
        {
            Console.WriteLine("Introduzca el número en base 10");
            int base10 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca una base del 2 al 9 en la que se va a convertir");
            int otherBase = int.Parse(Console.ReadLine());

            int rest = 0;
            string result = "";
            string result2 = "";

            if (otherBase >= 2 && otherBase <= 9) 
            {
                for (int i = base10; base10 > 0; i--) //Ponemos que empiece por el número introducido para ir
                                                      //restando -1 en cada vuelta y poder dividir sobre la base elegida
                {
                    rest = base10 % otherBase;        //Metemos en rest el resto de lo introducido por la base
                                                      //elegida. En cada vuelta la base10 cambiará por el resultado
                                                      //de la división de abajo
                    base10 /= otherBase;              //En cada vuelta la base10 se va dividiento por la base elegida
                                                      //y el resultado se vuelve a dividir sobre la base elegida

                    result += Convert.ToString(rest); //Ejemplo: 4/2 = 0 de resto y 2 de divisor
                                                      //2/2 = 0 de resto y 1 de divisor
                                                      //1/2 = 0,5 de resto y 0 de divisor

                    //Console.WriteLine($"Resultado división: {base10}");

                    //Console.Write($"{result}"); //26/2 -> 01011
                }

                for (int j = result.Length - 1; j >= 0; j--)  //Cogemos el string result desde atrás 
                {
                    result2 += result[j];                     //Pasamos el string result carácter por carácter desde 
                                                              //atrás
                }
                Console.Write($"{result2}"); //26/2 -> 11010
            }
            else
            {
                Console.WriteLine("Introduzca una base de 2 a 9");
            }


        }
    }
}
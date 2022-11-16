namespace Ejercicio13
{
    class Program
    {
        static void Main()
        {
            /*Ejercicio 13.
            El programa pedirá al usuario un número entero, posteriormente sacará 5 números
            aleatorios dentro del rango de 1 y el número dado, cada número aleatorio se mostrará por
            pantalla y se indicará al usuario si el número que ha dado coincide con alguno de los
            generados (sólo se notificará al usuario de la coincidencia la primera vez, si coincide más
            veces no se notificará)*/

            Console.WriteLine("Introduzca un número entero");
            int num = int.Parse(Console.ReadLine());

            Random random= new Random();

            int numRandom = 0;

            bool exit = false;                         //Salir si coincide una vez

            for (int i = 0; i < 5; i++)                //Manejar solo 5 números aleatorios
            {
                numRandom = random.Next( 1, num + 1 ); //Números aleatorios desde el 1 hasta el número dado +1,
                                                       //ya que el random coge un número menos del que ponemos
                //Console.WriteLine(numRandom);

                                     //!exit //2º forma en lugar de exit == false
                if (numRandom == num && exit == false) //Si un número aleatorio coincide con el introducido y además
                {                                      //la condición es false como inicialmente marcado, hasta que 
                                                       //entre en el if que se cambia por true, para mostrar solo 1
                    Console.WriteLine("Coincide");

                    exit = true;                       //De este modo se muestra solo 1 vez el mensaje ya que no 
                                                       //puede entrar de nuevo en el if al ser exit=false
                }
            }

        }
    }
}
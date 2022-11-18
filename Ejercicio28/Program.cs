using System.Globalization;
namespace Ejercicio28
{
    class Program
    {
        /*
        Ejercicio 28.
        Crea una aplicación que nos calcule el área de un círculo, cuadrado o triángulo. Pediremos
        qué figura queremos calcular su área y según lo introducido pedirá los valores necesarios
        para calcular el área. Crea un método por cada figura para calcular cada área, este
        devolverá un número real. Muestra el resultado por pantalla.
        */

        enum Figures { Circle = 1, Square, Triangle }

        static void Main()
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            object option = ShowMenu();

            SelectMenu(option);
        }

        static object ShowMenu()
        {
            Console.WriteLine("Elija en número la opción");
            Console.WriteLine("1. Círculo");
            Console.WriteLine("2. Cuadrado");
            Console.WriteLine("3. Triángulo");

            Figures option = (Figures)int.Parse(Console.ReadLine());
            return option;
        }

        static object SelectMenu(object option)
        {
            switch (option)
            {
                case Figures.Circle:
                    Circle();
                    break;
                case Figures.Square:
                    Square();
                    break;
                case Figures.Triangle:
                    Triangle();
                    break;
            }
            return option;
        }

        static double ReadNumber()
        {
            Console.WriteLine("Introduzca número");
            double num = int.Parse(Console.ReadLine());
            return num;
        }

        static double Circle()
        {
            Console.WriteLine("Círculo");

            Console.WriteLine("Introduce el radio del círculo:");
            double r = ReadNumber();

            double result = Math.PI * Math.Pow(r, 2); 

            Show(result);

            return result;
        }

  
        static double Square()
        {
            Console.WriteLine("Cuadrado");

            double l = ReadNumber();

            double result = Math.Pow(l, 2); ;

            Show(result);

            return result;
        }

        static double Triangle()
        {
            Console.WriteLine("Triángulo");

            double b = ReadNumber();
            double a = ReadNumber();
            
            double result = (b * a)/2; 

            Show(result);

            return result;
        }

        static void Show(double num)
        {
            Console.WriteLine($"El área es: {num}");
        }
    }
}
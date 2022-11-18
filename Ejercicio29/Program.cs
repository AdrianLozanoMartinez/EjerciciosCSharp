namespace Ejercicio29
{
    class Program
    {
        /*
         Ejercicio 29.
         Crea un programa que nos convierta una cantidad de euros introducida por teclado a otra
         moneda, estas pueden ser a dólares, yenes o libras. El método tendrá como parámetros, la
         cantidad de euros y la moneda a pasar que será una cadena, este no devolverá ningún
         valor, mostrará un mensaje indicando el cambio (void).
         El cambio de divisas son:
         0.86 libras es 1 €
         1.28611 $ es 1 €
         129.852 yenes es 1 €
        */

        enum Money { Libra = 1, Dolar, Yen }

        const double EURO_A_LIBRA = 0.86;
        const double EURO_A_DOLAR = 1.28611;
        const double EURO_A_YEN = 129.852;

        static void Main()
        {
            Console.WriteLine("Elige opción (libra, dolar, yen:");
            string Money = Console.ReadLine();

            Console.WriteLine("Introduce la cantidad de euros");
            double euros = double.Parse(Console.ReadLine());

            Convertir(euros, Money);
        }

        static void Convertir(double euros, string moneda)
        {
            object currency;

            if (Enum.TryParse(typeof(Money), moneda, true, out currency))
            {
                double result = 0;
                switch ((Money)currency)
                {
                    case Money.Libra:
                        result = euros * EURO_A_LIBRA;
                        break;
                    case Money.Dolar:
                        result = euros * EURO_A_DOLAR;
                        break;
                    case Money.Yen:
                        result = euros * EURO_A_YEN;
                        break;
                }
                Console.WriteLine($"{euros} son {result} {currency}");
            }
            else
            {
                Console.WriteLine("No se que moneda es");
            }
        }
    }
}
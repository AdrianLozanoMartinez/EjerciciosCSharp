namespace Ejercicio35
{
    class Program
    {
        /*
        Ejercicio 35.
        Calcula la letra de un DNI, pediremos el DNI por teclado y nos devolverá el DNI completo.
        Para calcular la letra, cogeremos el resto de dividir nuestro dni entre 23, el resultado debe
        estar entre 0 y 22. Haz un método donde según el resultado de la anterior fórmula busque
        en un array de caracteres la posición que corresponda a la letra. Esta es la tabla de
        caracteres:
        */
        const string LETTERS = "trwagmyfpdxbnjzsqvhlcke";
        static void Main()
        {
            Console.WriteLine("Introduzca los números de su DNI");
            int number = int.Parse(Console.ReadLine());

            char letter = LETTERS[number % LETTERS.Length]; //Con el resto sacamos la posición del string y de ahí el nombre a mostrar
                                                            //Como cogemos una letra por [], por eso se pasa a char
            Console.WriteLine($"{number}{letter}");
        }
    }
}
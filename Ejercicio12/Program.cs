namespace Ejercicio12
{
    class Program
    {
    /*Ejercicio 12.
    El programa pedirá al usuario una palabra y mostrará si es un palíndromo o no*/

        static void Main()
        {
            Console.Write("Escriba una palabra: ");
            string word = Console.ReadLine();

            bool isPalindrome = true;

            for (int i = 0; i < word.Length && isPalindrome; i++) //Hasta que acabe la palabra y sea true el polindromo
            {
                if (word[i] != word[word.Length - i - 1])  //Te compara el 1 con ultimo. el 2 con el penultimo etc
                                                           //word[posición] si el primero es diferente != del último [lo que ocupa la palabra -1 y -i que se refiere a la posición cogida] Cogemos -1 por que length ocupa +1...cuando cuentas palabras empieza 1,2,3,4 y si miramos posición sería 0,1,2,3,...
                {
                    isPalindrome = false; //Cuando llegue sea diferente el inicio y el final pone false porque no es palindromo
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine($"La palabra {word} es un palíncromo");
            }
            else
            {
                Console.WriteLine($"La palabra {word} no es un palíncromo");
            }
        }
    }
}

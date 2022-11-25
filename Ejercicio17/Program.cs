namespace Ejercicio17
{
    class Program
    {
        /*Ejercicio 17.
        Diseña un algoritmo que lea un texto de longitud indefinida formado por letras y muestre por
        pantalla la frecuencia con la que aparece cada una de las letras del texto.
        Nota: Usa el método Contains(char) de los string*/

        static void Main()
        {
            Console.WriteLine("Introduzca un texto");
            string text = Console.ReadLine();

            string consulted = "";

            for (int i = 0; i < text.Length; i++)
            {
                if(char.IsLetter(text[i]) && !consulted.Contains(text[i]))
                {
                    consulted += text[i];

                    int count = 0;

                    for(int j = 0; j < text.Length; j++)
                    {
                        if (text[i] == text[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"{text[i]}: {count}");
                }
            }
        }
    }
}
namespace Ejercicio17
{
    class Program
    {
        static void Main()
        {
            /*Ejercicio 17.
            Diseña un algoritmo que lea un texto de longitud indefinida formado por letras y muestre por
            pantalla la frecuencia con la que aparece cada una de las letras del texto.
            Nota: Usa el método Contains(char) de los string*/

             Console.WriteLine("Introduzca un texto");
            string text = Console.ReadLine();

            int cont = 0;
            int contador = 0;
            char save = ' ';

            for (int i = text.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < text.Length; j++)
                {
                    if (text[i] == text[j] && text[i] != ' ')
                    {
                        save = text[i];
                        cont++;
                        contador = cont;
                    }
                }
                cont = 0;

                if (contador > 0)
                {
                    Console.WriteLine($"La letra {save} se repite {contador} veces");
                }
            }
        }
    }
}
namespace Ejercicio24
{
    class Program
    {
        /*
        Ejercicio 24.
        Crea una simulación de un reproductor multimedia. El reproductor tiene los siguientes
        estados: Inactivo, Reproduciendo, Pausado, Parado y Cerrado. El reproductor empieza con
        el estado Inactivo, el programa se ejecutará mientras el estado no sea Cerrado. El programa
        le pedirá al usuario que introduzca un carácter que indica una acción (p, s y q),
        posteriormente se ejecuta la acción acorde al diagrama de estados de abajo y se mostrará
        en pantalla el estado actual del reproductor y se volverá a pedir otra acción y así
        sucesivamente hasta que el estado sea Cerrado. Si se introduce una acción que no existe o
        que no se pueda ejecutar en el estado actual se lanzará una excepción con un mensaje de
        error indicando que la acción no está disponible, dicha excepción se tendrá que capturar
        para mostrarla al usuario. El lanzamiento y captura de la excepción no puede finalizar la
        ejecución del programa.
        */

        enum State { Idle, Playing, Paused, Stopped, Closed }
        static void Main()
        {
            State state = State.Idle;
        
            Console.WriteLine($"Estado actual: {state}");

            while(state != State.Closed)
            {
                try
                {
                    Console.WriteLine("Introduzca (p = playing/paused, s = stopped, q = closed)");
                    char input = Console.ReadLine()[0];

                    switch (input)
                    {
                    case 'p':
                         if (state == State.Idle || state == State.Paused)
                            state = State.Playing;

                         else if(state == State.Playing)
                            state = State.Paused;

                         else
                            throw new Exception("Acción no permitida");

                         break;

                    case 's':
                         if (state == State.Playing || state == State.Paused)
                            state = State.Stopped;

                         else
                            throw new Exception("Acción no permitida");

                         break;

                    case 'q':
                         state = State.Closed;
                         break;
                     default:
                            throw new Exception("Acción no permitida");
                }

             Console.WriteLine($"Estado actual: {state}");
            }
            catch(Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
        

        }
    }
}
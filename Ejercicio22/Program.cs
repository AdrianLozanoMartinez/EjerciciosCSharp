namespace Ejercicio22
{
    class Program
    {
        enum Lamp { ON, OFF }   

        static void Main()
        {
            /*
            Ejercicio 22.
            Vamos a simular una lámpara. Crea un enumerado para los estados encendido y apagado
            (ON y OFF). A continuación, crea un bucle infinito, en cada iteración se esperará una
            respuesta del usuario. Si el usuario indica ON y la lámpara está apagada, se pasará al
            estado encendido y se notificará al usuario. Si el usuario indica OFF y la lámpara está
            encendida, se pasará al estado apagado y se notificará al usuario. En cualquier otro caso se
            lanzará una excepción no controlada indicando que la acción no es válida.
            */
            Lamp state = Lamp.OFF;

            do
            {
                Console.WriteLine("Elija encender \"ON\" o apagar \"OFF\" la lámpara");
                string selection = Console.ReadLine();  

                Lamp selectionLamp = (Lamp)Enum.Parse(typeof(Lamp), selection,true);


                if (selectionLamp == Lamp.ON && state == Lamp.OFF)
                {
                    Console.WriteLine("Encendida");
                    state = Lamp.ON;
                }
                else if (selectionLamp == Lamp.OFF && state == Lamp.ON)
                {
                    Console.WriteLine("Apagada");
                    state = Lamp.OFF;
                }
                else
                {
                    throw new Exception("La acción no está permitida. Ya estaba encendida o apagada");
                }
            }
            while (true);


        }
    }
}
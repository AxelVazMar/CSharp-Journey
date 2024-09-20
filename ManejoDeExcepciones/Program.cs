class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Vamos a adivinar el número\nIntroduce un número entre 0 y 100");
        Random numero = new Random();
        int numeroAleatorio = numero.Next(0, 100);
        int intento = 0;
        int nAdivinar;


        do
        {
            intento++;
            // Este bloque try/catch valida y captura si el usuario ingresó un string en vez de un int
            try
            {
                nAdivinar = int.Parse(Console.ReadLine());
            }

            /* Si queremos capturar una excpeción en concreto y después queremos capturar excpeciones generales
               debemos de capturar antes la expeción en concreto y después las generales
            */
            // catch(FormatException e) 
            // {
            //     Console.WriteLine("Has introducido texto\nEl texto introducido se tomará como 0\n");
            //     nAdivinar = 0;
            // }

            //Capturando un número indeterminado de excepciones para hacer el programa tolerante a fallos
            // Cuando utilizamos una excpeción génrica podemos prescindir del catch(ErrorAAtrapar) => catch(), pero no es recomendable
            catch (Exception e) when (e.GetType() != typeof(FormatException))
            /* => Otra manera de darle un tratamineto específico a una excpeción es filtrar la expeción
            para que el primer catch no detecte algún tipo en concreto de expeción para después con otro
            catch ya podamos capturar esa expeción en concreto
            */
            {
                Console.WriteLine("\nHa habido un error.\nEl número se tomará como 0\n");
                // System.Console.WriteLine(e.Message); // Con esta línea imprimimos el error que nos dió
                nAdivinar = 0;
            }

            catch (FormatException e)
            {
                System.Console.WriteLine("\n¡¡¡Has introducido texto!!!\nEl texto se tomará como 0\n");
                nAdivinar = 0;
            }


            if (nAdivinar < numeroAleatorio)
            {
                Console.WriteLine($"El numero es mayor que {nAdivinar}");
            }

            if (nAdivinar > numeroAleatorio)
            {
                Console.WriteLine($"El número es menor que {nAdivinar}");
            }
        } while (nAdivinar != numeroAleatorio);

        Console.WriteLine($"Felicidades has encontrado el número secreto \nTu número de intentos fué de: " + intento);
    }
}
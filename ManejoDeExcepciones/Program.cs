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
            //Capturando un número indeterminado de excepciones para hacer el programa tolerante a fallos
            catch (Exception e) // Cuando utilizamos una excpeción génrica podemos prescindir del catch(ErrorAAtrapar), pero no es recomendable
            {
                Console.WriteLine("\nNo haz ingresado un valor númerico válido.\nEl número se tomará como 0\n");
                System.Console.WriteLine(e.Message); // Con esta línea imprimimos el error que nos dió
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
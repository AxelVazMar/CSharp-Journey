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
            catch (FormatException ex)
            {
                Console.WriteLine($"No haz ingresado un valor númerico.\nEl número se tomará como 0\n");
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
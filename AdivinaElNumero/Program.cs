class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Vamos a adivinar el número");
        Console.WriteLine("\nIngresa el número a adivinar\nSolo es permitido en un rango de 0 a 100");
        int nAdivinar = int.Parse(Console.ReadLine());
        Random numero = new Random();
        int numeroAleatorio = numero.Next(0, 100);
        int intento = 1;


        while (nAdivinar != numeroAleatorio)
        {
            if (nAdivinar < numeroAleatorio)
            {
                System.Console.WriteLine($"El numero es mayor que {nAdivinar}");
                nAdivinar = int.Parse(Console.ReadLine());
            }
            else if (nAdivinar > numeroAleatorio)
            {
                System.Console.WriteLine($"El número es menor que {nAdivinar}");
                nAdivinar = int.Parse(Console.ReadLine());
            }
            
            intento ++;
        }

        System.Console.WriteLine($"Felicidades has encontrado el número secreto \nTu número de intentos fué de: " + intento);
    }
}
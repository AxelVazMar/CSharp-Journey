class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("¿Quieres entrar al bucle While?");

        string respuesta = Console.ReadLine();

        while (respuesta != "no")
        {
            System.Console.WriteLine("Estás ejecutando el bucle While");

            System.Console.WriteLine("Introduce nombre porfavor");

            string nombre = Console.ReadLine();

            Console.WriteLine($"Saldrás del bucle, {nombre} cunado respondas 'no' a la pregunta");

            Console.WriteLine("¿Deseas repetir el bucle otra vez?");

            respuesta = Console.ReadLine();
        }

        Console.WriteLine("Estás fuera del bucle");

    }
}

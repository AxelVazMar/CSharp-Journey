class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Console.WriteLine(divisionNumeros(18, 7));
        Console.WriteLine(divisionNumeros2(3, 5));
    }

    static double divisionNumeros(double num1, int num2) // Un double con un int siempre dará double
    {
        // Cuando un programa lee un return, este automaticamente se sale del método
        return num1 / num2;
    }

    // Otra manera de declarar métodos cuando el cuerpod el método tiene una sola línea de código
    static double divisionNumeros2(double num1, double num2) => num1 / num2;
}
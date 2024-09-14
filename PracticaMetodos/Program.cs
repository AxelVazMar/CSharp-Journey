
class Program
{
    // int numero1 = 5;
    // int numero2 = 7;
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World!");
        // Console.WriteLine(divisionNumeros(18, 7));
        // Console.WriteLine(divisionNumeros2(3, 5));
        int valor1 = 7;
        double valor2 = 5.2;
        double valor3 = 8.3;
        
        System.Console.WriteLine(Suma4(valor1, valor2));

    }

    private static double Suma4(int num1, double num2, double num3 = 0)
    {
        return num1 + num2 + num3;
    }

    static double Suma4(int num1, double num2)
    {
        return num1 + num2;
    }

    static double divisionNumeros(double num1, int num2) // Un double con un int siempre dará double
    {
        // Cuando un programa lee un return, este automaticamente se sale del método
        return num1 / num2;
    }

    // Otra manera de declarar métodos cuando el cuerpod el método tiene una sola línea de código
    static double divisionNumeros2(double num1, double num2) => num1 / num2;

    void primerMetodo()
    {

        //int numero1 = 5;
        //int numero2 = 7;

        Console.WriteLine(numero1 + numero2);

    }

    void segundoMetodo()
    {

        Console.WriteLine(numero1 + numero2);

    }

    // Sobrecarga de métodos
    /*
    Para hacer una sobrecarga de métodos estos, deben de devolver diferentes 
    tipos de valores si uno devuelve o recibe int, el otro debe de 
    recibir y/o devolver double, string, etc...
    */
    static int suma(int operador1, int operador2) => operador1 + operador2;
    static int suma(int numero1, int numero2, int operador3) => numero1 + numero2;
    static int suma(int numero1, int numero2, double operador3) => numero1 + numero2;

    int numero1 = 7;
    int numero2 = 8;
}
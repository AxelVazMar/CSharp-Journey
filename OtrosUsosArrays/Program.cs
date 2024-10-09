class Program
{
    public static void Main(string[] args)
    {
        int[] numeros = new int[4];
        numeros[0] = 7;
        numeros[1] = 9;
        numeros[2] = 15;
        numeros[3] = 3;

        ProcesaDatos(numeros);

        foreach (int numero in numeros)
        {
            System.Console.WriteLine(numero);
        }

        System.Console.WriteLine();

        int[] arrayElementos = LeerDatos();

        System.Console.WriteLine("Imprimiendo el array ingresado...");

        foreach (int elemento in arrayElementos) Console.WriteLine(elemento);
    }

    // Método para pasarle un array y después este devuelve los datos
    static void ProcesaDatos(int[] datos)
    {
        for (int i = 0; i < 4; i++)
        {
            datos[i] += 10;
        }
    }

    // Método para devolver datos de tipo array
    static int[] LeerDatos()
    {
        Console.Write("¿Cuántos elementos quieres que tenga el array: ");
        string respuesta = Console.ReadLine();
        int numElementos = int.Parse(respuesta);
        int[] datos = new int[numElementos];

        for (int i = 0; i < numElementos; i++)
        {
            Console.Write($"Introduce el dato para la posición {i}: ");
            respuesta = Console.ReadLine();
            int datosElemento = int.Parse(respuesta);
            datos[i] = datosElemento;
        }

        return datos;
    }

}
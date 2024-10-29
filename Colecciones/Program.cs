class Program
{
    public static void Main(string[] args)
    {
        List<int> numeros = new List<int>(); // Declarando una lista (Colección de tipo lista)

        /*int[] listaNumeros = new int[] { 3, 6, 8, 10, 50 };
        for (int i = 0; i < 5; i++)
        {
            numeros.Add(listaNumeros[i]); // Este for alamcena los elementos del array en la lista
        }

        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine(numeros[i]); // Recorriendo una colección (lista)
        }*/

        

        /*Console.WriteLine("¿Cuántos elementos quieres introducir?");
        int elem = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < elem; i++)
        {

            Console.Write("Introduce el numero de elemento {0}: ", i+1);
            numeros.Add(Int32.Parse(Console.ReadLine()));
        }

        Console.WriteLine("Imprimiendo números...");
        

        for (int i = 0; i < numeros.Count; i++)
        {
            
            Console.WriteLine(numeros[i]);
            
        }*/

        /* Creando una colección hasta que el número ingresado sea 0 */
        Console.WriteLine("Introduce elementos en la colección (introduce '0' para salir)");
        int elem = 1;
        int contador = 1;
        int cont_for = 1;
        while (elem != 0)
        {
            Console.Write("Introduce el elemento {0}: ", contador++);
            elem = Int32.Parse(Console.ReadLine());
            numeros.Add(elem);
        }

        // Quitando el número de la última posición de la colección
        numeros.RemoveAt(numeros.Count - 1);

        // Otra manera de recorrer colecciones es con el bucle foreach
        Console.WriteLine("\nImprimiendo los elementos introducidos\n");
        
        foreach(int elemento in numeros)
        {
            Console.WriteLine("El elemento {0} tiene un valor de: {1}",cont_for++, elemento);
            
        }
    }
}
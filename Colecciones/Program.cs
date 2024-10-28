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

        Console.WriteLine("¿Cuántos elementos quieres introducir?");
        int elem = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < elem; i++)
        {

            Console.Write("Introduce el numero de elemento {0}: ", i+1);
            numeros.Add(Int32.Parse(Console.ReadLine()));
        }

        Console.WriteLine("Imprimiendo números...");
        

        for (int i = 0; i < elem; i++)
        {
            
            Console.WriteLine(numeros[i]);
            
        }
        
    }
}
namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numeros = new Queue<int>();
            // Rellenando o agregando elementos en la cola
            foreach (int numero in new int[5] { 2, 4, 6, 8, 10 })
            {
                numeros.Enqueue(numero);
            }

            // Recorriendo la cola
            Console.WriteLine("\nRecorriendo la QUEUE");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
            
            // Eliminando elementos de la cola
            Console.WriteLine("\nEliminando elementos de la Queue");
            numeros.Dequeue();
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
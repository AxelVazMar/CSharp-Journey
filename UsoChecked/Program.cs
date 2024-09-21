namespace UsoChecked
{
    class Program
    {
        static void Main(string[] args)
        {
            // Checked no sirve con doubles o floats, solo funciona con ints y longs
            int numero = int.MaxValue;
            int resultado = checked(numero + 20);
            System.Console.WriteLine(resultado);
        }
    }
}

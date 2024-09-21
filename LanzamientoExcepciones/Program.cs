class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Introduce número del mes");

        int numeroMes = int.Parse(System.Console.ReadLine());

        try
        {
            Console.WriteLine(NombreDelMes(numeroMes));
        }
        catch (Exception e)
        {
            System.Console.WriteLine("Mensaje de la excpeción: " + e.Message);
        }

        System.Console.WriteLine("\nAquí continuaría la ejecución del porgrama");
    }

    public static string NombreDelMes(int mes)
    {
        switch (mes)
        {
            case 1:
                return "Enero";
            case 2:
                return "Febrero";
            case 3:
                return "Marzo";
            case 4:
                return "Abril";
            case 5:
                return "Mayo";
            case 6:
                return "Junio";
            case 7:
                return "Julio";
            case 8:
                return "Agosto";
            case 9:
                return "Septiembre";
            case 10:
                return "Octubre";
            case 11:
                return "Noviembre";
            case 12:
                return "Diciembre";

            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
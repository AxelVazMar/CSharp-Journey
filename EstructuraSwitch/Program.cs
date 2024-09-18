class Program
{
    public static void Main(string[] args)
    {

        //Esta estructura solo funciona con constantes como int y char y no funciona con elementos de comparación

        Console.WriteLine("Elige un medio de transporte (coche, tren avión)");

        string medioTransporte = Console.ReadLine();

        switch (medioTransporte)
        {
            case "coche":
                Console.WriteLine("Velocidad nedua: 100 km/h");
                break;
            case "tren":
                Console.WriteLine("Velocidad media: 250 km/h");
                break;
            case "avión":
                Console.WriteLine("Velocidad media: 800 km/h");
                break;
            default:
                System.Console.WriteLine("El transporte no está en las opciones");
                break;
        }
        System.Console.WriteLine("El programa de transportes ha terminado");

        // Viendo el número del mes con la estructura SWITCH

        System.Console.WriteLine("\nIntroduce el número del mes");

        int nMes = int.Parse(Console.ReadLine());

        switch (nMes)
        {
            case 1:
                System.Console.WriteLine("Mes escogido: Enero");
                break;
            case 2:
                System.Console.WriteLine("Mes escogido: Febrero");
                break;
            case 3:
                System.Console.WriteLine("Mes escogido: Marzo");
                break;
            case 4:
                System.Console.WriteLine("Mes escogido: Abril");
                break;
            case 5:
                System.Console.WriteLine("Mes escogido: Mayo");
                break;
            case 6:
                System.Console.WriteLine("Mes escogido: Junio");
                break;
            case 7:
                System.Console.WriteLine("Mes escogido: Julio");
                break;
            case 8:
                System.Console.WriteLine("Mes escogido: Agosto");
                break;
            case 9:
                System.Console.WriteLine("Mes escogido: Septiembre");
                break;
            case 10:
                System.Console.WriteLine("Mes escogido: Octubre");
                break;
            case 11:
                System.Console.WriteLine("Mes escogido: Noviembre");
                break;
            case 12:
                System.Console.WriteLine("Mes escogido: Diciembre");
                break;
            default:
                System.Console.WriteLine("El mes elegido no existe");
                break;

        }
    }
}
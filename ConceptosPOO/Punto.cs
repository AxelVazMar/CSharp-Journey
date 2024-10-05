namespace ConceptosPOO;

public class Punto
{
    // Esta una clase del proyecto ConceptosPOO, esto nos ayudará para hacer modularización

    // Campos de clase
    private int x, y;
    public Punto(int x, int y)
    {
        //System.Console.WriteLine($"Coordenada X: {x}, Coordenada Y: {y}");
        this.x = x;
        this.y = y;
        contadorDeObjetos++;

    }

    public Punto()
    {
        // Constructor por defecto

        // Y esta sería la primera línea que se ejecutaría en el programa
        //System.Console.WriteLine("Este es el constructor por defecto");
        this.x = 0;
        this.y = 0;
        contadorDeObjetos++;
    }

    public double DistanciaHasta(Punto otroPunto)
    {
        int xDif = this.x - otroPunto.x; //this.x hace referencia al constructor por defecto por lo que x=0, y otroPunto.x hace referencia al constructor con parámetros en este caso x=128
        int yDif = this.y - otroPunto.y;
        double distanciaPuntos = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));
        return distanciaPuntos;
        //hola
    }

    public static int Contador()
    {
        // También podemos usar => "Contador() => CotadorDeObjetos;" si solo tiene una línea de código
        return contadorDeObjetos;
    }

    private static int contadorDeObjetos = 0;
}
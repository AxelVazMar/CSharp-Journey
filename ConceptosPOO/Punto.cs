namespace ConceptosPOO;

public class Punto
{
    // Esta una clase del proyecto ConceptosPOO, esto nos ayudará para hacer modularización

    public Punto(int x, int y)
    {
        System.Console.WriteLine($"Coordenada X: {x}, Coordenada Y: {y}");
    }

    public Punto()
    {
        // Y esta sería la primera línea que se ejecutaría en el programa
        System.Console.WriteLine("Este es el constructor por defecto");
    }
}

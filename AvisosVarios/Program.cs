using AvisosVarios;

class Program
{
    public static void Main(string[] args)
    {
        
        // Imprimiendo el constructor por defecto
        AvisosTrafico aviso1 = new AvisosTrafico();
        aviso1.MostrarAviso();

        // Imprimiendo mensaje personalizado
        AvisosTrafico aviso2 = new AvisosTrafico("Departameto de vialidad de Guadalajara","Sanción de velocidad: $500 MXN", "17-10-2024");
        aviso2.MostrarAviso();
    }
}
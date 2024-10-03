namespace ConceptosPOO
{

    class Program
    {
        public static void Main(string[] args)
        {
            RealizarTarea();
        }

        static void RealizarTarea()
        {
            // Comentarios TODO
            //TODO: con esta palabra podemos comentar las tareas que tenemos que realizar en un futuro
            
            // Aquí se llama al constructor sin parámetros/por defecto
            Punto origen = new Punto();
            // Aquí se llama al segudo constructor que recibe dos parámetros 
            Punto destino = new Punto(150, 90);

            double distancia = origen.DistanciaHasta(destino);

            System.Console.WriteLine($"La distancia entre los puntos es de: {distancia}");
        }
    }
}
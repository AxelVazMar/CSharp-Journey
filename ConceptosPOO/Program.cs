namespace ConceptosPOO
{

    class Program
    {
        public static void Main(string[] args)
        {
            //RealizarTarea();

            // Primera clase anonima. miVariable no es el nombre de la clase
            var miVariable = new { Nombre = "Axel", Edad = 24 };
            Console.Write(miVariable.Nombre + " " + miVariable.Edad);
            /* Esta variable también pertenece a la misma clase
            ya que en función a número de campos, tipo de los campos y el orden los campos
            C# determina si se trata de la mimsa clase o no.
            */
            var miOtraVariable = new { Nombre = "Evelin", Edad = 24 };

            miVariable = miOtraVariable;
            /*
            Requisitos de las clases anónimas:
            1-. Solo pueden contener campos públicos
            2-. Todos los campos deben de estar iniciados
            3-. Los campos no puede ser static
            4-. No se pueden definir métodos
            */
        }

        static void RealizarTarea()
        {
            // Comentarios TODO
            //TODO: con esta palabra podemos comentar las tareas que tenemos que realizar en un futuro

            // Aquí se llama al constructor sin parámetros/por defecto
            Punto origen = new Punto();
            // Aquí se llama al segudo constructor que recibe dos parámetros 
            Punto destino = new Punto(150, 90);

            Punto otroPunto = new Punto();

            double distancia = origen.DistanciaHasta(destino);

            System.Console.WriteLine($"La distancia entre los puntos es de: {distancia}");
            System.Console.WriteLine($"Número de objetos creados: {Punto.Contador()}");
        }
    }
}
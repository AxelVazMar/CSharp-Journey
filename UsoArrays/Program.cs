class Program
{
    static void Main(string[] args)
    {
        // Primer array
        // int[] edades;
        // edades = new int[4];
        // edades[0] = 15;
        // edades[1] = 27;
        // edades[2] = 19;
        // edades[3] = 80;
        // //edades[4] = 0; => error "IndexOutOfRangeException"
        // Console.Write(edades[2]);

        // Otra mandera de declar e inciar un Array en C#
        // int[] edades = { 15, 27, 19, 80 };
        // System.Console.Write(edades[2]);

        // Array implícito

        //var datos = new[] { "Axel", "Vazquez", "México", 15 }; => error No se encontró el mejor tipo para la matriz con tipo implícito

        var valores = new[] { 15, 28, 35, 75.5, 30.30, 90, 82.2 }; // Este array no da error ya que asigna un valor double a todos

        /* Array de objetos */

        Empleados Ana = new Empleados("Ana", 27);
        Empleados[] arrayEmpleados = new Empleados[3]; // Aquí estamos declarando cuantos elementos tendrá nuestro array
        arrayEmpleados[0] = new Empleados("Sara", 37); // Almacenando un objeto mientras creamos ese objeto
        arrayEmpleados[1] = Ana;
        arrayEmpleados[2] = new Empleados("Manuel", 51);


        /* Array de tripos o clases anónimas */

        var personas = new[]
        {
            new {Nombre = "Juan", Edad = 27}, // => Posición [0] del array
            new {Nombre = "María", Edad = 29}, // => Posiación [1] del array
            new {Nombre = "Diana", Edad = 35} // => Posición [2] del array
        };

        // Bucle para recorrer arrays de tipo objeto

        for (int i = 0; i < arrayEmpleados.Length; i++)
        {
            Console.WriteLine(arrayEmpleados[i].GetInfoEmpleado());
        }
        System.Console.WriteLine();

        /* Estructura de un bucle foreach:
        Declaramos una variable del tipo que vayamos a recorrer. Después le damos nombre a esa variable (Puede ser cualquier nombre)
        después usamos la palabra "in" seguido del array que queremos recorrer
        */
        foreach (Empleados i in arrayEmpleados)
        {
            Console.WriteLine(i.GetInfoEmpleado());
        }

        Console.WriteLine();

        // Recorriendo el array valores, usamos double porque lo que almacena valores son datos de tipo double
        foreach (double valor in valores)
        {
            System.Console.WriteLine(valor);
        }

        Console.WriteLine();

        // Recorriendo array personas

        foreach(var persona in personas)
        {
            System.Console.WriteLine(persona);
        }
    }

    class Empleados
    {
        public Empleados(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public String GetInfoEmpleado()
        {
            return "Nombre del empleado: " + nombre + " Edad: " + edad;
        }

        String nombre;
        int edad;
    }

}
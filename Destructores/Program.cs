using System.IO;

namespace Destructores
{
    class Program
    {
        static void Main(string[] args)
        {
            ManejoArchivos miArchivo = new ManejoArchivos();
            miArchivo.Mensaje();
        }
    }

    class ManejoArchivos
    {
        StreamReader archivo = null;
        int contandor = 0;
        string linea;

        public ManejoArchivos()
        {
            archivo = new StreamReader(@"/Users/axelvm/Documents/C#/CSharp-Journey/CSharp-Journey/hola.txt"); // abriendo el archivo
            while((linea = archivo.ReadLine()) != null)
            {
                Console.WriteLine(linea);
                contandor++;
            }
        }

        public void Mensaje()
        {
            Console.WriteLine("El archivo tiene {0} líneas", contandor);
            
        }

        /* CONSTRUYENDO UN MÉTODO DESTRUCTOR */
        ~ManejoArchivos()
        {
            archivo.Close(); // Aquí se cerraría el flujo de de datos del archivo o lo que es igual, deja de leer el archivo
        }
    }
}

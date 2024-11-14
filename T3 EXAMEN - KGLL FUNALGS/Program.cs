using System;

class Program
{
    static void Main(string[] args)
    {
        int opcion;

        do
        {
            Console.WriteLine("\nMenu de Opciones:");
            Console.WriteLine("1. Crear Cita");
            Console.WriteLine("2. Listar Citas");
            Console.WriteLine("3. Modificar Masivo");
            Console.WriteLine("4. Fin");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

        } while (opcion != 4);
    }
}
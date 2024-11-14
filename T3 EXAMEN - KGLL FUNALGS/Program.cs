using System;
using T3_EXAMEN___KGLL_FUNALGS;

class Program
{
    private static CITA[] citas = new CITA[100];
    private static int contadorCitas = 0;

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

            switch (opcion)
            {
                case 1:
                    CrearCita();
                    break;
                case 2:
                    ListarCitas();
                    break;
                case 3:
                    ModificarMasivo();
                    break;
                case 4:
                    Console.WriteLine("Fin del programa.");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        } while (opcion != 4);
    }

    private static void CrearCita()
    {
        do
        {
            if (contadorCitas >= citas.Length)
            {
                Console.WriteLine("No se pueden agregar más citas.");
                return;
            }
            ESTUDIANTE estudiante = new ESTUDIANTE();

            Console.Write("Ingrese el código del estudiante: ");
            estudiante.CODIGO = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el nombre del estudiante: ");
            estudiante.NOMBRE = Console.ReadLine();

            Console.Write("Ingrese la universidad del estudiante: ");
            estudiante.UNIVERSIDAD = Console.ReadLine();

            CITA cita = new CITA();
            cita.NUMERO = contadorCitas + 1; // Asignar número de cita
            cita.ESTUDIANTE = estudiante;

            Console.Write("Ingrese la enfermedad: ");
            cita.ENFERMEDAD = Console.ReadLine();

            Console.Write("Ingrese el precio de la consulta: ");
            cita.PRECIO = double.Parse(Console.ReadLine());

            citas[contadorCitas] = cita;
            contadorCitas++;

            Console.WriteLine("Cita creada exitosamente.");

            // Preguntar si desea seguir registrando
            Console.Write("¿Desea registrar otra cita? (s/n): ");
            char continuar = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Nueva línea para mejor legibilidad

            if (continuar != 's' && continuar != 'S')
            {
                Console.WriteLine("Regresando al menú principal.");
                break; // Salir del bucle de creación de citas
            }

        } while (true); // Mantener el bucle mientras se desee seguir agregando citas
    }

    private static void ListarCitas()
    {
        double sumaPrecios = 0;

        if (contadorCitas == 0)
        {
            Console.WriteLine("No hay citas registradas.");
            return;
        }

        for (int i = 0; i < contadorCitas; i++)
        {
            Console.WriteLine(citas[i]);
            sumaPrecios += citas[i].PRECIO;
        }

        Console.WriteLine($"Total de precios: {sumaPrecios:C}");
    }

    private static void ModificarMasivo()
    {
        Console.Write("Ingrese el texto a buscar: ");
        string buscar = Console.ReadLine();

        Console.Write("Ingrese el texto a reemplazar: ");
        string reemplazar = Console.ReadLine();

        for (int i = 0; i < contadorCitas; i++)
        {
            if (citas[i].ESTUDIANTE.UNIVERSIDAD.Contains(buscar))
            {
                citas[i].ESTUDIANTE.UNIVERSIDAD = citas[i].ESTUDIANTE.UNIVERSIDAD.Replace(buscar, reemplazar);
            }
        }

        Console.WriteLine("Modificación masiva completada.");
    }
}
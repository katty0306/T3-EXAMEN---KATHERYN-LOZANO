﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_EXAMEN___KGLL_FUNALGS
{
    internal class CITAUTIL
    {
        public static class CitaUtil
    {
        private static CITA[] citas = new CITA[100];
        private static int contadorCitas = 0;

        public static void CrearCita()
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
            cita.NUMERO = contadorCitas + 1;
            cita.ESTUDIANTE = estudiante;

            Console.Write("Ingrese la enfermedad: ");
            cita.ENFERMEDAD = Console.ReadLine();

            Console.Write("Ingrese el precio de la consulta: ");
            cita.PRECIO = double.Parse(Console.ReadLine());

            citas[contadorCitas] = cita;
            contadorCitas++;

            Console.WriteLine("Cita creada exitosamente.");


            Console.Write("¿Desea registrar otra cita? (s/n): ");
            char continuar = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (continuar == 's' || continuar == 'S')
            {
                CrearCita();
            }
            else
            {
                Console.WriteLine("Regresando al menú principal.");
            }
        }

        public static void ListarCitas()
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

        public static void ModificarMasivo()
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
}
}

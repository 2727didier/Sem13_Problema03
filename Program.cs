namespace Sem13_Problema03
{
    internal class Program
    {// Agrega esta función al código existente
        public static int cantidadRespuestas { get; private set; }

        static void VerDatosRegistrados()
        {
            if (cantidadRespuestas == 0)
            {
                Console.WriteLine("No hay datos registrados.");
            }
            else
            {
                Console.WriteLine("===============================");
                Console.WriteLine("Ver datos registrados");
                Console.WriteLine("===============================");

                for (int i = 0; i < cantidadRespuestas; i += 5)
                {
                    for (int j = i; j < Math.Min(i + 5, cantidadRespuestas); j++)
                    {
                        Console.Write($"[{"respuestasEncuesta"[j]}] ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();

                MostrarResumenRespuestas();
            }

            Console.WriteLine("\nPresione una tecla para regresar ...");
            Console.ReadKey();
        }

        // Agrega esta función al código existente
        static void MostrarResumenRespuestas()
        {
            Console.WriteLine();
            Console.WriteLine($"{ContarRespuestas(1)} personas: Nada satisfecho");
            Console.WriteLine($"{ContarRespuestas(2)} personas: No muy satisfecho");
            Console.WriteLine($"{ContarRespuestas(3)} personas: Tolerable");
            Console.WriteLine($"{ContarRespuestas(4)} personas: Satisfecho");
            Console.WriteLine($"{ContarRespuestas(5)} personas: Muy satisfecho");
        }

        // Agrega esta función al código existente
        static int ContarRespuestas(int opcion)
        {
            return "respuestasEncuesta".Count(r => r == opcion);
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- PRUEBA 1: Iniciar cerrado, Abrir() -> 100 -> "Abierto total (100%)" ---
            Console.WriteLine("--- PRUEBA 1 ---");
            PortonAutomatico porton = new PortonAutomatico(); // Inicia cerrado (0)
            porton.Abrir();
            Console.WriteLine(porton.MostrarEstado()); // Debería mostrar: Abierto total (100%)

            // --- PRUEBA 2: AbrirPeatonal() desde 100 -> pasar a 20 y mostrar "Abierto parcial (20%)" ---
            Console.WriteLine("\n--- PRUEBA 2 ---");
            porton.AbrirPeatonal();
            Console.WriteLine(porton.MostrarEstado()); // Debería mostrar: Abierto parcial (20%)

            // --- PRUEBA 3: Cerrar() -> 0 ---
            Console.WriteLine("\n--- PRUEBA 3 ---");
            porton.Cerrar();
            Console.WriteLine(porton.MostrarEstado()); // Debería mostrar: Cerrado

            // --- PRUEBA 4: Abrir(105) -> "Porcentaje inválido. Debe ser 1–99" ---
            Console.WriteLine("\n--- PRUEBA 4 ---");
            porton.Abrir(105); // Debe imprimir el mensaje de error por consola

            // --- PRUEBA 5: Simulaciones con un ciclo ---
            Console.WriteLine("\n--- PRUEBA 5 (Simulación) ---");
            PortonAutomatico portonSimulacion = new PortonAutomatico();

            // Abrir(10) inicial
            portonSimulacion.Abrir(10);

            // Simulamos el incremento con un ciclo (por ejemplo, subiendo de 10 en 10 hasta 60)
            for (int i = 10; i <= 60; i += 10)
            {
                portonSimulacion.Abrir(i);
                Console.WriteLine($"Estado actual: {portonSimulacion.MostrarEstado()}");

                // Cuando llegue a 50%, ejecutamos Stop() y terminamos
                if (portonSimulacion.Apertura == 50)
                {
                    portonSimulacion.Stop();
                    break; // Sale del ciclo
                }
            }
        }
    }
}

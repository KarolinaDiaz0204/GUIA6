using System;

namespace GUIA6
{
    public class Program1
    {
        static void Main(string[] args)
        {

            // Crear instancia de CambioAceite
            Servicio servicioAceite = new CambioAceite();
            servicioAceite.RealizarServicio(); // Output: Realizando cambio de aceite
            Console.WriteLine("Costo del cambio de aceite: $" + servicioAceite.CalcularCosto());

            // Crear instancia de ReparacionFrenos
            Servicio servicioFrenos = new ReparacionFrenos();
            servicioFrenos.RealizarServicio(); // Output: Realizando reparación en frenos
            Console.WriteLine("Costo de la reparación de frenos: $" + servicioFrenos.CalcularCosto());
            // Intentar crear una instancia de la clase abstracta Servicio

            Servicio servicio = new Servicio(); // Error: No se puede crear una instancia de la clase abstracta Servicio
        }
    }
}
using System;

namespace GUIA6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, worl:");

            Vehiculo miCoche = new Coche();
            miCoche.RealizarMantenimiento(); //Output: Realizando mantenimiento del coche: Cambio de aceite y revisión de frenos
            Console.WriteLine("Costo del mantenimiento del coche: $" + miCoche.ObtenerCostoMantenimiento());

            Vehiculo miMoto = new Moto();
            miMoto.RealizarMantenimiento(); //Output: Realizando mantenimiento de la moto: Lubricador de cadena y revisión de neumáticos
            Console.WriteLine("Costo del mantenimiento del coche: $" + miCoche.ObtenerCostoMantenimiento());

            miCoche.Lavar(); // Output: Lavando el vehículo

            Coche miCocheReal = new Coche();
            miCocheReal.Lavar(); // Output: Lavando el coche con cera y shampoo especial


            // Crear instancia de CambioAceite
            Servicio servicioAceite = new CambioAceite();
            servicioAceite.RealizarServicio(); // Output: Realizando cambio de aceite
            Console.WriteLine("Costo del cambio de aceite: $" + servicioAceite.CalcularCosto());

            // Crear instancia de ReparacionFrenos
            Servicio servicioFrenos = new ReparacionFrenos();
            servicioFrenos.RealizarServicio(); // Output: Realizando reparación en frenos
            Console.WriteLine("Costo de la reparación de frenos: $" + servicioFrenos.CalcularCosto());

            // Intentar crear una instancia de la clase abstracta Servicio como:
            //Servicio Ser = new Servicio();
            // No se puede crear una instancia de la clase abstracta o interfaz 'Servicio" porque resultará en un error de compilación
        }
    }

}
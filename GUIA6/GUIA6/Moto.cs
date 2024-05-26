using System;

namespace GUIA6
{
    public class Moto : Vehiculo
    {
        public override void RealizarMantenimiento()
        {
            Console.WriteLine("Realizando mantenimiento de la moto: Lubricador de cadena y revisión de neumáticos");
        }

        // Método para calcular el tiempo total de los servicios para una moto
        public override double CalcularTiempoTotalServicios()
        {
            // Suma del tiempo base más el tiempo adicional para los servicios específicos de una moto
            return base.CalcularTiempoTotalServicios() + 0.5; 
        }

        public override double ObtenerCostoMantenimiento()
        {
            return 100.0;//Costo del mantenimiento de la moto
        }
    }
}

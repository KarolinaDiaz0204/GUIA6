using System;

namespace GUIA6
{
    public class Vehiculo
    {
        public virtual void RealizarMantenimiento()
        {
            Console.WriteLine("Realizando mantenimiento geneal al vehículo");
        }

        public virtual double ObtenerCostoMantenimiento()
        {
            return 50.0;//Costo base de mantenimiento general
        }

        // Método para calcular el tiempo total de los servicios
        public virtual double CalcularTiempoTotalServicios()
        {
            return 0.5; 
        }

        //Método llamado Lavar.
        public void Lavar()
        {
            Console.WriteLine("Lavando el vehículo");
        }

    }
}

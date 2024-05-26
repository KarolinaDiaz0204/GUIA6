using System;


namespace GUIA6
{
    public class Coche : Vehiculo
    {
        public override void RealizarMantenimiento()
        {
            Console.WriteLine("Realizando mantenimiento del coche: Cambio de aceite y revisión de frenos");
        }

        public override double ObtenerCostoMantenimiento()
        {
            return 150.0;//Costo del mantenimiento del coche
        }

        // Método para calcular el tiempo total de los servicios para un coche
        public override double CalcularTiempoTotalServicios()
        {
            // Suma del tiempo base más el tiempo adicional para los servicios específicos de un coche
            return base.CalcularTiempoTotalServicios() + 1.5; 
        }

        //Ocultamiento del método Lavar.
        public new void Lavar()
        {
            Console.WriteLine("Lavando el coche con cera y shampoo especial");
        }

    }
}

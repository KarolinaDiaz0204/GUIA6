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

        //Ocultamiento del método Lavar.
        public new void Lavar()
        {
            Console.WriteLine("Lavando el coche con cera y shampoo especial");
        }

    }
}

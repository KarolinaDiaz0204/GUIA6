using System;

namespace GUIA6
{
    public class Moto : Vehiculo
    {
        public override void RealizarMantenimiento()
        {
            Console.WriteLine("Realizando mantenimiento de la moto: Lubricador de cadena y revisión de neumáticos");
        }

        public override double ObtenerCostoMantenimiento()
        {
            return 100.0;//Costo del mantenimiento de la moto
        }
    }
}

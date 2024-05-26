using System;

namespace GUIA6
{
    public class ReparacionFrenos : Servicio
    {
        public override void RealizarServicio()
        {
            Console.WriteLine("Realizando reparación en frenos");
        }

        public override double CalcularCosto()
        {
            return 100.0; //Costo de la reparación de frenos

        }

    }
}

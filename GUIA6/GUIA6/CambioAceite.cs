using System;

namespace GUIA6
{
    public class CambioAceite : Servicio
    {
        public override void RealizarServicio()
        {
            Console.WriteLine("Realizando cambio de aceite");
        }
        public override double CalcularCosto()
        {
           return 50.0; // Costo del cambio de aceite
        }

    }
}

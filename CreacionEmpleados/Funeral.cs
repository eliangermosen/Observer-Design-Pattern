using System;
using System.Collections.Generic;
using System.Text;

namespace CreacionEmpleados
{
    class Funeral : IObserver
    {
        public static double Descuento { get; set; }
        public void Actualizar()
        {
            if (Descuentos.Estado > 17500)
            {
                double recibe = Descuentos.Estado;
                double Proporcion = 0.02;
                double calculo = recibe * Proporcion;
                double sf = recibe - calculo;
                Console.WriteLine("\nHA SIDO ANADIDO AL PLAN FUNERAL.");
                Console.WriteLine($"SU SALARIO ES DE:{recibe}");
                Console.WriteLine($"EL DESCUENTO PARA EL PLAN FUNERAL SERA DE:{calculo}");
                Console.WriteLine($"SU SALRIO FINAL ES DE:{sf}\n");
                Descuento = calculo;
            }
            else
            {
                Console.WriteLine("\nNO SE LE APLICARA DESCUENTO PARA EL PLAN FUNERAL.\n");
            }
        }
    }
}

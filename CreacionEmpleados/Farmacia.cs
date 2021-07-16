using System;
using System.Collections.Generic;
using System.Text;

namespace CreacionEmpleados
{
    class Farmacia : IObserver
    {
        public static double Descuento { get; set; }
        public void Actualizar()
        {
            if (Descuentos.Estado != 0)
            {
                //double recibe;
                double recibe = Descuentos.Estado;
                double calculo = recibe / 2;
                double sf = recibe - calculo;
                Console.WriteLine("\nHA SIDO ANADIDO AL PLAN FARMACIA.");
                Console.WriteLine($"SU SALARIO ES DE:{recibe}");
                Console.WriteLine($"EL DESCUENTO PARA LA FARMACIA SERA DE:{calculo}");
                Console.WriteLine($"SU SALRIO FINAL ES DE:{sf}\n");
                Descuento = calculo;
            }
            else
            {
                Console.WriteLine("\nNO TIENE CONSUMOS.\n");
            }
        }
    }
}

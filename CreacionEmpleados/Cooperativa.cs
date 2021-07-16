using System;
using System.Collections.Generic;
using System.Text;

namespace CreacionEmpleados
{
    class Cooperativa : IObserver
    {
        public static double Descuento { get; set; }
        public void Actualizar()
        {
            double recibe = Descuentos.Estado;
            double Proporcion = 0.07;
            double calculo = recibe * Proporcion;
            double sf = recibe - calculo;
            Console.WriteLine("\nHA SIDO ANADIDO A LA COOPERATIVA.");
            Console.WriteLine($"SU SALARIO ES DE:{recibe}");
            Console.WriteLine($"EL DESCUENTO PARA LA COOPERATIVA SERA DE:{calculo}");
            Console.WriteLine($"SU SALRIO FINAL ES DE:{sf}\n");
            Descuento = calculo;
        }
    }
}

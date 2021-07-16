using System;
using System.Collections.Generic;
using System.Text;

namespace CreacionEmpleados
{
    class Descuentos
    {
        public static double Estado { get; set; }
        public static List<IObserver> listObserver = new List<IObserver>();
        public void Add(IObserver observador)
        {
            listObserver.Add(observador);
        }

        public void Delete(IObserver observador)
        {
            listObserver.Remove(observador);
        }

        public void Notify()
        {
            foreach (var elemento in listObserver)
            {
                elemento.Actualizar();
            }
        }

        public void Operations(double valor)
        {
            Estado = valor;
            Notify();
        }
    }
}

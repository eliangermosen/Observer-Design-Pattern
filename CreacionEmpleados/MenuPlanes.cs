using System;
using System.Collections.Generic;
using System.Text;

namespace CreacionEmpleados
{
    class MenuPlanes
    {
        Descuentos descuentos = new Descuentos();
        Cooperativa Coop = new Cooperativa();
        Farmacia farma = new Farmacia();
        Funeral fun = new Funeral();
        public void menuInscPlan(double salari)
        {
            int opcion;
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("                                INSCRIPCION DE PLAN:                              ");
            Console.WriteLine("----------------------------------------------------------------------------------\n");
            Console.WriteLine("1: COOPERATIVA");
            Console.WriteLine("2: PLAN FARMACIA");
            Console.WriteLine("3: PLAN FUNERARIO");
            opcion = int.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                descuentos.Add(Coop);
            }
            else if (opcion == 2)
            {
                descuentos.Add(farma);
            }
            else if (opcion == 3)
            {
                descuentos.Add(fun);
            }
            else
            {
                Console.WriteLine("\nINGRESE UNA OPCION VALIDA!\n");
            }
            descuentos.Operations(salari);
        }
        public void IngCedi()
        {
            Console.WriteLine("\nIngrese el codigo del empleado:");
            string cod = (Console.ReadLine());

            foreach (Empleadoss alm in Empleadoss.listDatosEmp)
            {
                if (alm.Codigo == cod)
                {
                    double s = alm.SalarioB;
                    menuInscPlan(s);
                }
                else
                {
                    Console.WriteLine("\nESTE CODIGO NO EXISTE. I");
                }
            }
        }
        public void menuCancelPlan()
        {
            int opcion;
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("                                CANCELACION DE PLAN:                              ");
            Console.WriteLine("----------------------------------------------------------------------------------\n");
            Console.WriteLine("1: COOPERATIVA");
            Console.WriteLine("2: PLAN FARMACIA");
            Console.WriteLine("3: PLAN FUNERARIO");
            opcion = int.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                descuentos.Delete(Coop);
            }
            else if (opcion == 2)
            {
                descuentos.Delete(farma);
            }
            else if (opcion == 3)
            {
                descuentos.Delete(fun);
            }
            else
            {
                Console.WriteLine("\nINGRESE UNA OPCION VALIDA!\n");
            }
        }
        public void IngCedC()
        {
            Console.WriteLine("\nIngrese el codigo del empleado:");
            string cod = (Console.ReadLine());

            foreach (Empleadoss alm in Empleadoss.listDatosEmp)
            {
                if (alm.Codigo == cod)
                {
                    menuCancelPlan();
                }
                else
                {
                    Console.WriteLine("\nESTE CODIGO NO EXISTE. C");
                }
            }
        }
    }
}

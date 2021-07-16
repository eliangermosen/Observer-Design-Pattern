using System;
using System.Collections.Generic;
using System.Text;

namespace CreacionEmpleados
{
    class Menu
    {
        Empleadoss empleadoss = new Empleadoss();
        MenuPlanes mplanes = new MenuPlanes();
        public void menu1()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("                                  EMPRESA GERMOSEN:                               ");
            Console.WriteLine("----------------------------------------------------------------------------------");
            int opcion;
            do
            {
                Console.WriteLine("                                        MENU:                                       ");
                Console.WriteLine("----------------------------------------------------------------------------------\n");
                Console.WriteLine("1: CREAR EMPLEADO");
                Console.WriteLine("2: INSCRIPCION PLAN");
                Console.WriteLine("3: CANCELACION PLAN");
                Console.WriteLine("4: REGISTRO CONSUMO DE LA FARMACIA");
                Console.WriteLine("5: CALCULO DE NOMINA");
                Console.WriteLine("6: CERRAR PROGRAMA.");
                opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    empleadoss.creandoE();
                }
                else if (opcion == 2)
                {
                    mplanes.IngCedi();
                }
                else if (opcion == 3)
                {
                    mplanes.IngCedC();
                }
                else if (opcion == 4)
                {
                    //Console.WriteLine("");

                }
                else if (opcion == 5)
                {
                    empleadoss.Nomina();
                }
                else if (opcion == 6)
                {
                    Console.WriteLine("\nPROGRAMA CERRADO CON EXITO.");
                }
                else
                {
                    Console.WriteLine("\nINGRESE UNA OPCION VALIDA!\n");
                    Console.WriteLine("----------------------------------------------------------------------------------");
                }

            } while (opcion != 6);
        }
    }
}

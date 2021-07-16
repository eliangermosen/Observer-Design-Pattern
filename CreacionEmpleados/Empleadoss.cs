using System;
using System.Collections.Generic;
using System.Text;

namespace CreacionEmpleados
{
    class Empleadoss
    {
        public static List<Empleadoss> listDatosEmp = new List<Empleadoss>();
        public double AFP { get; set; }
        public double SFS { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Licencia { get; set; }
        public string Email { get; set; }
        public double SalarioB { get; set; }
        public double SalarioN { get; set; }
        public string Codigo { get; set; }

        public void creandoE()
        {
            Empleadoss almacena = new Empleadoss();
            Console.WriteLine("\n----------------------------------------------------------------------------------");
            Console.WriteLine("                                CREACION DE EMPLEADO:                             ");
            Console.WriteLine("----------------------------------------------------------------------------------\n");
            Console.WriteLine("Ingrese el Nombre:");
            almacena.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el Apellido:");
            almacena.Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese la Cedula:");
            almacena.Cedula = Console.ReadLine();
            Console.WriteLine("Ingrese la Licencia:");
            almacena.Licencia = Console.ReadLine();
            Console.WriteLine("Ingrese el Email:");
            almacena.Email = Console.ReadLine();
            Console.WriteLine("Ingrese el Telefono:");
            almacena.Telefono = Console.ReadLine();
            Console.WriteLine("Ingrese el Salario:");
            almacena.SalarioB = double.Parse(Console.ReadLine());
            Random aleatorio = new Random();
            int numaleat = aleatorio.Next(1000, 10000);
            almacena.Codigo = "E-" + numaleat;
            Console.WriteLine("Su codigo es: " + almacena.Codigo);

            listDatosEmp.Add(almacena);
            Console.WriteLine("\nEMPLEADO CREADO.\n");
        }
        public void Nomina()
        {
            CAFP();
            CSFS();
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("                                  NOMINA EMPRESA GERMOSEN:                            ");
            Console.WriteLine($"Puerto Plata, R.D. | 809-970-3222                         Fecha: {DateTime.Now}      ");
            Console.WriteLine("--------------------------------------------------------------------------------------\n");
            foreach (Empleadoss alm in listDatosEmp)
            {
                Console.WriteLine($"Nonmbre del empleado: {alm.Nombre}");
                Console.WriteLine($"Salario Bruto del empleado: {alm.SalarioB}");
                Console.WriteLine($"Descuento de AFP del empleado: {alm.AFP}");
                Console.WriteLine($"Descuento de SFS del empleado: {alm.SFS}");
                Console.WriteLine($"Descuento de Cooperativa del empleado: {Cooperativa.Descuento}");
                Console.WriteLine($"Descuento de Farmacia del empleado: {Farmacia.Descuento}");
                Console.WriteLine($"Descuento de Plan Funeral del empleado: {Funeral.Descuento}");
                alm.SalarioN = alm.SalarioB - alm.AFP - alm.SFS - Cooperativa.Descuento - Farmacia.Descuento - Funeral.Descuento;
                Console.WriteLine($"Salario Neto del empleado: {alm.SalarioN}\n");
            }
        }
        public void CAFP()
        {
            foreach (Empleadoss alm in listDatosEmp)
            {
                alm.AFP = alm.SalarioB * 0.0287;
            }
        }
        public void CSFS()
        {
            foreach (Empleadoss alm in listDatosEmp)
            {
                alm.SFS = alm.SalarioB * 0.0304;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clsmenu.Menu();
            Clsmenu.InicializarVectores();
            ClsTransacciones.IngresarVehiculo();
            ClsTransacciones.Consultar();
            ClsTransacciones.Modificar();
            ClsTransacciones.Reporte();

            Console.ReadLine();
        }
    }
}

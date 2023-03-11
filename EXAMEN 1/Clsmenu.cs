using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_1
{
    internal class Clsmenu
    {

        public static int[] factura = new int[15];
        public static int[] placa = new int[15];
        public static string[] fecha = new string[15];
        public static string[] hora = new string[15];
        public static int[] tipovehiculo = new int[15];
        public static int[] numerocaseta = new int[15];   
        public static float[] montopagar = new float[15];
        public static float[] pago = new float[15];   
        public static float[] vuelto = new float[15];

        public static void Menu() {

            int opcion = 0;

            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Inicializar vectores");
                Console.WriteLine("2. Ingresar paso vehicular");
                Console.WriteLine("3. Consulta de vehiculo por numero de placa");
                Console.WriteLine("4. Modificar datos de vehiculo por numero de placa");
                Console.WriteLine("5. Reporte de todos los datos");
                Console.WriteLine("6. Salir");
                opcion = int.Parse(Console.ReadLine());

                switch ( opcion)
                {
                    case 1: Console.WriteLine("Iniciando vectores...");
                        InicializarVectores();
                    break;
                    case 2: Console.WriteLine("Ingresar Paso Vehicular");
                        ClsTransacciones.IngresarVehiculo();
                    break;
                    case 3: Console.WriteLine("Consultar vehiculo");
                        ClsTransacciones.Consultar();
                    break;
                    case 4: Console.WriteLine("Modificar datos");
                        ClsTransacciones.Modificar();
                    break;
                    case 5: Console.WriteLine("Reporte de datos");
                        ClsTransacciones.Reporte();
                    break;


                }

            }while (opcion != 6);

            Console.ReadLine();
        
        }

        public static void InicializarVectores() {

            for (int i = 0; i < 15; i++)
            {
                factura[i] = 0;
                placa[i] = 0;
                fecha[i] = "";
                hora[i] = "";
                tipovehiculo[i] = 0;
                numerocaseta[i] = 0;
                montopagar[i] = 0;
                pago[i] = 0;
                vuelto[i] = 0;
            }

            Console.WriteLine("Vectores inicializados.");

            Console.ReadLine();

        }

    }
}

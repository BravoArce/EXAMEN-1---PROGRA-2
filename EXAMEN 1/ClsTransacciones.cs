using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_1
{
    internal class ClsTransacciones
    {
        public static void IngresarVehiculo()
        {
            int i = 0;
            string respuesta = "";

            if (i != 15) {

                do {
                    i++;

                    Console.WriteLine("Ingrese el numero de factura");
                    Clsmenu.factura[i] = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el numero de placa");
                    Clsmenu.placa[i] = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese la fecha");
                    Clsmenu.fecha[i] = (Console.ReadLine());

                    Console.WriteLine("Ingrese la hora");
                    Clsmenu.hora[i] = (Console.ReadLine());

                    Console.WriteLine("Elija el tipo de vehiculo: \n 1. Moto \n 2. Vehiculo Liviano \n 3. Camion o Pesado \n 4. Autobus");
                    Clsmenu.tipovehiculo[i] = int.Parse(Console.ReadLine());

                    Console.WriteLine("Elija el numero de caseta: \n 1. caseta 1 \n 2. caseta 2 \n 3. caseta 3");
                    Clsmenu.numerocaseta[i] = int.Parse(Console.ReadLine());

                    if (Clsmenu.tipovehiculo[i] == 1) {

                        Clsmenu.montopagar[i] = 500;
                        Console.WriteLine("El monto a pagar es de: ¢"+Clsmenu.montopagar[i]);
                    }

                    if (Clsmenu.tipovehiculo[i] == 2)
                    {

                        Clsmenu.montopagar[i] = 700;
                        Console.WriteLine("El monto a pagar es de: ¢" + Clsmenu.montopagar[i]);
                    }

                    if (Clsmenu.tipovehiculo[i] == 3)
                    {

                        Clsmenu.montopagar[i] = 2700;
                        Console.WriteLine("El monto a pagar es de: ¢" + Clsmenu.montopagar[i]);
                    }

                    if (Clsmenu.tipovehiculo[i] == 4)
                    {

                        Clsmenu.montopagar[i] = 3700;
                        Console.WriteLine("El monto a pagar es de: ¢" + Clsmenu.montopagar[i]);
                    }

                    Console.WriteLine("Paga con: ");
                    Clsmenu.pago[i] = int.Parse(Console.ReadLine());

                    Clsmenu.vuelto[i] = Clsmenu.pago[i] - Clsmenu.montopagar[i];
                    Console.WriteLine("Su vuelto es de: ¢" + Clsmenu.vuelto[i]);

                    Console.WriteLine("Desea continuar? s/n");
                    respuesta = Console.ReadLine();

                } while (i < 15 && respuesta.Equals("s"));

            }

        }

        public static void Consultar(){

            int consultar = 0;
            Console.WriteLine("Digite el numero de placa del vehiculo a consultar");
            consultar = int.Parse(Console.ReadLine()); 

            for (int i = 0; i < Clsmenu.placa.Length; i++) {

                if (consultar == Clsmenu.placa[i]) {

                    Console.WriteLine("Numero de factura: " + Clsmenu.factura[i] + "\nFecha: " + Clsmenu.fecha[i] + "\nHora: " + Clsmenu.hora[i] + "\nTipo de vehiculo: " + Clsmenu.tipovehiculo[i] + "\nNumero de caseta: " + Clsmenu.numerocaseta[i] + "\nMonto a Pagar: " + Clsmenu.montopagar[i]);
                }
               
            }
        }


        public static void Modificar(){

            string modificar = Console.ReadLine();
            Console.WriteLine("Digite el numero de placa del vehiculo a modificar");
            modificar = Console.ReadLine();

            for (int i = 0; i < Clsmenu.placa.Length; i++)
            {

               
            }

        }

        public static void Reporte()
        {
            int cantidad = 0;
            float total = 0;

            Console.WriteLine(" Reporte  ");
            Console.WriteLine("N Factura  Placa  Tipo de vehículo  Caseta  Monto Pagar  Paga con  Vuelto");
            Console.WriteLine("---------------------------------------------------------------------------");

            for (int i = 0; i < Clsmenu.placa.Length; i++)
            {
                if (Clsmenu.montopagar[i] > 0)
                {
                    Console.WriteLine(Clsmenu.factura[i] + "   " + Clsmenu.placa[i] + "      " + Clsmenu.tipovehiculo[i] + "       " + Clsmenu.numerocaseta[i] + "       " + Clsmenu.montopagar[i] + "        " + Clsmenu.pago[i] + "       " + Clsmenu.vuelto[i]);
                    cantidad++;
                    total += Clsmenu.pago[i];

                }

            }

            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("Cantidad de vehículos: " + cantidad + "                                 Total: " + total);
            Console.WriteLine("------------------------------------------------------------------------------");
        }

    }
}

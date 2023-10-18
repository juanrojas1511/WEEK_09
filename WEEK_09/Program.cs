using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK_09
{
    internal class Program
    {
        private static int totalUnidadesVendidas = 0;
        private static int totalUnidadesdevueltos = 0;
        private static double total_limpieza = 0.0;
        private static double total_abarrotes = 0.0;
        private static double total_golosinas = 0.0;
        private static double total_electro = 0.0;
        static void Main()
        {
            string opcion_es;

            do
            {
                tabla_d_tienda();

                opcion_es = Console.ReadLine();
                switch (opcion_es)
                {
                    case "1":
                        Console.WriteLine("Registrar Venta");
                        Registrar_Venta();
                        break;
                    case "2":
                        Console.WriteLine("Registrar devolución");
                        Registrar_devolucion();
                        break;
                    case "3":
                        Console.WriteLine("Cerrar Caja");
                        cerrar_caja();
                        break;
                    case "4":
                        Console.WriteLine("Opcion mala");
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            } while (opcion_es != "4");
        
        }

        static void tabla_d_tienda()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Tienda de Don Lucas");
            Console.WriteLine("=================================");
            Console.WriteLine("1: Registrar venta");
            Console.WriteLine("2: Registrar devolución");
            Console.WriteLine("3: Cerrar Caja");
            Console.WriteLine("=================================");
            Console.WriteLine("Ingrese una opción:");
        }


        static void Registrar_Venta()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Registrar Venta de:");
            Console.WriteLine("=================================");
            Console.WriteLine("1: Limpieza");
            Console.WriteLine("2: Abarrotes");
            Console.WriteLine("3: Golosinas");
            Console.WriteLine("4: Electrónicos");
            Console.WriteLine("5 <- Regresar");
            Console.WriteLine("=================================");
            Console.WriteLine("Ingrese una opción");

            string regis_ve = Console.ReadLine();
            switch (regis_ve)
            {
                case "1":
                    Console.WriteLine("Limpieza");
                    registro_limpieza();
                    break;
                case "2":
                    Console.WriteLine("Abarrotes");
                    registro_abarrotes();
                    break;
                case "3":
                    Console.WriteLine("Golosinas");
                    registro_golosinas();
                    break;
                case "4":
                    Console.WriteLine("Electrónicos");
                    registro_electronicos();
                    break;
                case "5":
                    Console.WriteLine("Regresar");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
        static void registro_limpieza()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Registrar venta de Limpieza:");
            Console.WriteLine("=================================");
            Console.Write("Ingrese cantidad (unidades):");
            int cantidad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/");
            double precio = double.Parse(Console.ReadLine());
            double subtotal = cantidad * precio;

            Console.WriteLine("=================================");
            Console.WriteLine($"Se han ingresado {cantidad} unidades ");
            Console.WriteLine($"Sen han ingresado S/{subtotal} en caja");
            totalUnidadesVendidas += cantidad;
            total_limpieza += subtotal;

            Console.WriteLine("=================================");
            Console.WriteLine("1: Registrar más productos de limpieza");
            Console.WriteLine("2: <-Regresar");
            Console.WriteLine("Ingrese una opción");

            string opcion = Console.ReadLine();
            if (opcion == "1")
            {
                Registrar_Venta();
            }
            else if (opcion == "2")
            {

            }
        }
        static void registro_abarrotes()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Registrar venta de Abarrotes:");
            Console.WriteLine("=================================");
            Console.Write("Ingrese cantidad (unidades):");
            int cantidad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/");
            double precio = double.Parse(Console.ReadLine());
            double subtotal = cantidad * precio;
            Console.WriteLine("=================================");
            Console.WriteLine($"Se han ingresado {cantidad} unidades ");
            Console.WriteLine($"Sen han ingresado S/{subtotal} en caja");
            totalUnidadesVendidas += cantidad;
            total_abarrotes += subtotal;

            Console.WriteLine("=================================");
            Console.WriteLine("1: Registrar más productos de abarrotes");
            Console.WriteLine("2: <-Regresar");
            Console.WriteLine("Ingrese una opción");

            string opcion = Console.ReadLine();
            if (opcion == "1")
            {
                Registrar_Venta();
            }
            else if (opcion == "2")
            {

            }
        }
        static void registro_golosinas()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Registrar venta de Golosinas:");
            Console.WriteLine("=================================");
            Console.Write("Ingrese cantidad (unidades):");
            int cantidad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/");
            double precio = double.Parse(Console.ReadLine());
            double subtotal = cantidad * precio;
            Console.WriteLine("=================================");
            Console.WriteLine($"Se han ingresado {cantidad} unidades ");
            Console.WriteLine($"Sen han ingresado S/{subtotal} en caja");
            totalUnidadesVendidas += cantidad;
            total_golosinas += subtotal;

            Console.WriteLine("=================================");
            Console.WriteLine("1: Registrar más productos de golosinas");
            Console.WriteLine("2: <-Regresar");
            Console.WriteLine("Ingrese una opción");

            string opcion = Console.ReadLine();
            if (opcion == "1")
            {
                Registrar_Venta();
            }
            else if (opcion == "2")
            {

            }
        }
        static void registro_electronicos()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Registrar venta de Electrónicos:");
            Console.WriteLine("=================================");
            Console.Write("Ingrese cantidad (unidades):");
            int cantidad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/");
            double precio = double.Parse(Console.ReadLine());
            double subtotal = cantidad * precio;
            Console.WriteLine("=================================");
            Console.WriteLine($"Se han ingresado {cantidad} unidades ");
            Console.WriteLine($"Sen han ingresado S/{subtotal} en caja");
            totalUnidadesVendidas += cantidad;
            total_electro += subtotal;

            Console.WriteLine("=================================");
            Console.WriteLine("1: Registrar más productos de electrónicos");
            Console.WriteLine("2: <-Regresar");
            Console.WriteLine("Ingrese una opción");

            string opcion = Console.ReadLine();
            if (opcion == "1")
            {
                Registrar_Venta();
            }
            else if (opcion == "2")
            {

            }
        }






        static void Registrar_devolucion()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Registrar devolución de:");
            Console.WriteLine("=================================");
            Console.WriteLine("1: Limpieza");
            Console.WriteLine("2: Abarrotes");
            Console.WriteLine("3: Golosinas");
            Console.WriteLine("4: Electrónicos");
            Console.WriteLine("5 <- Regresar");
            Console.WriteLine("=================================");
            Console.WriteLine("Ingrese una opción");

            string regis_dev = Console.ReadLine();
            switch (regis_dev)
            {
                case "1":
                    Console.WriteLine("Limpieza");
                    registros_limpieza();
                    break;
                case "2":
                    Console.WriteLine("Abarrotes");
                    registros_abarrotes();
                    break;
                case "3":
                    Console.WriteLine("Golosinas");
                    registros_golosinas();
                    break;
                case "4":
                    Console.WriteLine("Electrónicos");
                    registros_electronicos();
                    break;
                case "5":
                    Console.WriteLine("Regresar");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }

        static void registros_limpieza()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Registrar devolución de Limpieza:");
            Console.WriteLine("=================================");
            Console.Write("Ingrese cantidad (unidades):");
            int cantidad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/");
            double precio = double.Parse(Console.ReadLine());
            double subtotal = cantidad * precio;

            Console.WriteLine("=================================");
            Console.WriteLine($"Se han ingresado {cantidad} unidades ");
            Console.WriteLine($"Sen han ingresado S/{subtotal} en caja");
            totalUnidadesdevueltos += cantidad;
            total_limpieza += subtotal;

            Console.WriteLine("=================================");
            Console.WriteLine("1: Registrar más productos de limpieza");
            Console.WriteLine("2: <-Regresar");
            Console.WriteLine("Ingrese una opción");

            string opcion = Console.ReadLine();
            if (opcion == "1")
            {
                Registrar_devolucion();
            }
            else if (opcion == "2")
            {

            }
        }
        static void registros_abarrotes()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Registrar devolución de Abarrotes:");
            Console.WriteLine("=================================");
            Console.Write("Ingrese cantidad (unidades):");
            int cantidad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/");
            double precio = double.Parse(Console.ReadLine());
            double subtotal = cantidad * precio;
            Console.WriteLine("=================================");
            Console.WriteLine($"Se han ingresado {cantidad} unidades ");
            Console.WriteLine($"Sen han ingresado S/{subtotal} en caja");
            totalUnidadesdevueltos += cantidad;
            total_abarrotes += subtotal;

            Console.WriteLine("=================================");
            Console.WriteLine("1: Registrar más productos de abarrotes");
            Console.WriteLine("2: <-Regresar");
            Console.WriteLine("Ingrese una opción");

            string opcion = Console.ReadLine();
            if (opcion == "1")
            {
                Registrar_devolucion();
            }
            else if (opcion == "2")
            {

            }
        }
        static void registros_golosinas()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Registrar devolución de Golosinas:");
            Console.WriteLine("=================================");
            Console.Write("Ingrese cantidad (unidades):");
            int cantidad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/");
            double precio = double.Parse(Console.ReadLine());
            double subtotal = cantidad * precio;
            Console.WriteLine("=================================");
            Console.WriteLine($"Se han ingresado {cantidad} unidades ");
            Console.WriteLine($"Sen han ingresado S/{subtotal} en caja");
            totalUnidadesdevueltos += cantidad;
            total_golosinas += subtotal;

            Console.WriteLine("=================================");
            Console.WriteLine("1: Registrar más productos de golosinas");
            Console.WriteLine("2: <-Regresar");
            Console.WriteLine("Ingrese una opción");

            string opcion = Console.ReadLine();
            if (opcion == "1")
            {
                Registrar_devolucion();
            }
            else if (opcion == "2")
            {

            }
        }
        static void registros_electronicos()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Registrar devolución de Electronicos:");
            Console.WriteLine("=================================");
            Console.Write("Ingrese cantidad (unidades):");
            int cantidad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/");
            double precio = double.Parse(Console.ReadLine());
            double subtotal = cantidad * precio;
            Console.WriteLine("=================================");
            Console.WriteLine($"Se han ingresado {cantidad} unidades ");
            Console.WriteLine($"Sen han ingresado S/{subtotal} en caja");
            totalUnidadesdevueltos += cantidad;
            total_electro += subtotal;

            Console.WriteLine("=================================");
            Console.WriteLine("1: Registrar más productos de electronicos");
            Console.WriteLine("2: <-Regresar");
            Console.WriteLine("Ingrese una opción");

            string opcion = Console.ReadLine();
            if (opcion == "1")
            {
                Registrar_devolucion();
            }
            else if (opcion == "2")
            {

            }

        }
        
        static void cerrar_caja()
        {

            int total = totalUnidadesVendidas - totalUnidadesdevueltos;
            double caja_general = total_limpieza + total_abarrotes + total_golosinas + total_electro;
            Console.WriteLine("=================================");
            Console.WriteLine("Totales");
            Console.WriteLine("=================================");
            Console.WriteLine($"                       |   {totalUnidadesVendidas} vendidos");
            Console.WriteLine($"Limpieza               |   {totalUnidadesdevueltos} devueltos");
            Console.WriteLine($"                       |   {total} en total");
            Console.WriteLine($"                       | S/{total_limpieza}  en caja");
            Console.WriteLine("=================================");
            Console.WriteLine($"                       |   {totalUnidadesVendidas} vendidos");
            Console.WriteLine($"Abarrotes              |   {totalUnidadesdevueltos} devueltos");
            Console.WriteLine($"                       |   {total} en total");
            Console.WriteLine($"                       | S/{total_abarrotes}  en caja");
            Console.WriteLine("=================================");
            Console.WriteLine($"                       |   {totalUnidadesVendidas} vendidos");
            Console.WriteLine($"Goglosinas             |   {totalUnidadesdevueltos} devueltos");
            Console.WriteLine($"                       |   {total} en total");
            Console.WriteLine($"                       | S/{total_golosinas}  en caja");
            Console.WriteLine("=================================");
            Console.WriteLine($"                       |   {totalUnidadesVendidas} vendidos");
            Console.WriteLine($"Electro                |   {totalUnidadesdevueltos} devueltos");
            Console.WriteLine($"                       |   {total} en total");
            Console.WriteLine($"                       | S/{total_electro}  en caja");
            Console.WriteLine("=================================");
            Console.WriteLine($"Queda en caja S/.{caja_general}");

        }
    }
}

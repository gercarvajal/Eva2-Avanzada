using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eva2
{
    internal class Vistas
    {
        public Vistas()
        {
        }

        public static void menuPrincipal()
        {

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(30, 9);
            Console.WriteLine("┌────────────────────────────────────────────────────────────────────────┐");
            Console.SetCursorPosition(30, 10);
            Console.WriteLine("|                           MENU PRINCIPAL                               |▓▓");
            Console.SetCursorPosition(30, 11);
            Console.WriteLine("|                                                                        |▓▓░░");
            Console.SetCursorPosition(30, 12);
            Console.WriteLine("| Ingrese 1 para Mantenedor de Usuarios                                  |▓▓░░");
            Console.SetCursorPosition(30, 13);
            Console.WriteLine("|                                                         ┌──────────┐   |▓▓░░");
            Console.SetCursorPosition(30, 14);
            Console.WriteLine("| Ingrese 2 para Mantenedor de familia de productos       |          |   |▓▓░░");
            Console.SetCursorPosition(30, 15);
            Console.WriteLine("|                                                         |          |   |▓▓░░");
            Console.SetCursorPosition(30, 16);
            Console.WriteLine("| Ingrese 3 para Mantenedor de productos                  |          |   |▓▓░░");
            Console.SetCursorPosition(30, 17);
            Console.WriteLine("|                                                         └──────────┘   |▓▓░░");
            Console.SetCursorPosition(30, 18);
            Console.WriteLine("| Ingrese 4 para Salir                                                   |▓▓░░");
            Console.SetCursorPosition(30, 19);
            Console.WriteLine("|                                                                        |▓▓░░");
            Console.SetCursorPosition(30, 20);
            Console.WriteLine("└────────────────────────────────────────────────────────────────────────┘▓▓░░");
            Console.SetCursorPosition(30, 21);
            Console.WriteLine(" ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░");
            Console.SetCursorPosition(30, 22);
            Console.WriteLine("  ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");

            Console.SetCursorPosition(79, 15);
            int opc;
            do
            {
                Console.SetCursorPosition(81, 15);
                String op = Console.ReadLine();
                int.TryParse(op, out opc);
            } while (opc < 0 || opc > 4);

            Console.Clear();

            switch (opc)
            {
                case 1:

                   // pedirdatos();


                    break;
                case 2:

                  //  modificar();

                    break;

                case 3:
                   // eliminar();
                    break;

                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    menuPrincipal();
                    break;
            }
        }

        public static void menuUsuaios()
        {

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(30, 9);
            Console.WriteLine("┌────────────────────────────────────────────────────────────────────────┐");
            Console.SetCursorPosition(30, 10);
            Console.WriteLine("|                           MENU USUARIOS                                |▓▓");
            Console.SetCursorPosition(30, 11);
            Console.WriteLine("|                                                                        |▓▓░░");
            Console.SetCursorPosition(30, 12);
            Console.WriteLine("| Ingrese 1 Para Ingresar de Usuarios                                    |▓▓░░");
            Console.SetCursorPosition(30, 13);
            Console.WriteLine("|                                                         ┌──────────┐   |▓▓░░");
            Console.SetCursorPosition(30, 14);
            Console.WriteLine("| Ingrese 2 Para Modificar datos Usuario                  |          |   |▓▓░░");
            Console.SetCursorPosition(30, 15);
            Console.WriteLine("|                                                         |          |   |▓▓░░");
            Console.SetCursorPosition(30, 16);
            Console.WriteLine("| Ingrese 3 Para Eliminar Usuario                         |          |   |▓▓░░");
            Console.SetCursorPosition(30, 17);
            Console.WriteLine("|                                                         └──────────┘   |▓▓░░");
            Console.SetCursorPosition(30, 18);
            Console.WriteLine("| Ingrese 4 Para Mostrar Usuarios                                        |▓▓░░");
            Console.SetCursorPosition(30, 19);
            Console.WriteLine("|                                                                        |▓▓░░");
            Console.SetCursorPosition(30, 20);
            Console.WriteLine("| Ingrese 5 Para Volver al Menu Principal                                |▓▓░░");
            Console.SetCursorPosition(30, 21);
            Console.WriteLine("|                                                                        |▓▓░░");
            Console.SetCursorPosition(30, 22);
            Console.WriteLine("| Ingrese 6 Para Salir al Escritorio                                     |▓▓░░");
            Console.SetCursorPosition(30, 23);
            Console.WriteLine("|                                                                        |▓▓░░");
            Console.SetCursorPosition(30, 24);
            Console.WriteLine("└────────────────────────────────────────────────────────────────────────┘▓▓░░");
            Console.SetCursorPosition(30, 25);
            Console.WriteLine(" ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░");
            Console.SetCursorPosition(30, 26);
            Console.WriteLine("  ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");

            Console.SetCursorPosition(79, 15);
            int opc;
            do
            {
                Console.SetCursorPosition(81, 15);
                String op = Console.ReadLine();
                int.TryParse(op, out opc);
            } while (opc < 0 || opc > 6);

            Console.Clear();

            switch (opc)
            {
                case 1:

                    // pedirdatos();


                    break;
                case 2:

                    //  modificar();

                    break;

                case 3:
                    // eliminar();
                    break;
                case 4:
                    // eliminar();
                    break;
                case 5:
                    menuPrincipal();
                    break;

                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    menuUsuaios();  
                    break;
            }

        }

        public static void menuFamilia()
        {

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(30, 9);
            Console.WriteLine("┌────────────────────────────────────────────────────────────────────────┐");
            Console.SetCursorPosition(30, 10);
            Console.WriteLine("|                           MENU FAMILIA DE PRODUCTOS                    |▓▓");
            Console.SetCursorPosition(30, 11);
            Console.WriteLine("|                                                                        |▓▓░░");
            Console.SetCursorPosition(30, 12);
            Console.WriteLine("| Ingrese 1 Para Ingresar de Familia de productos                        |▓▓░░");
            Console.SetCursorPosition(30, 13);
            Console.WriteLine("|                                                         ┌──────────┐   |▓▓░░");
            Console.SetCursorPosition(30, 14);
            Console.WriteLine("| Ingrese 2 Para Modificar Familia de productos           |          |   |▓▓░░");
            Console.SetCursorPosition(30, 15);
            Console.WriteLine("|                                                         |          |   |▓▓░░");
            Console.SetCursorPosition(30, 16);
            Console.WriteLine("| Ingrese 3 Para Eliminar Familia de productos            |          |   |▓▓░░");
            Console.SetCursorPosition(30, 17);
            Console.WriteLine("|                                                         └──────────┘   |▓▓░░");
            Console.SetCursorPosition(30, 18);
            Console.WriteLine("| Ingrese 4 Para Mostrar Familias de productos                           |▓▓░░");
            Console.SetCursorPosition(30, 19);
            Console.WriteLine("|                                                                        |▓▓░░");
            Console.SetCursorPosition(30, 20);
            Console.WriteLine("| Ingrese 5 Para Volver al Menu Principal                                |▓▓░░");
            Console.SetCursorPosition(30, 21);
            Console.WriteLine("|                                                                        |▓▓░░");
            Console.SetCursorPosition(30, 22);
            Console.WriteLine("| Ingrese 6 Para Salir al Escritorio                                     |▓▓░░");
            Console.SetCursorPosition(30, 23);
            Console.WriteLine("|                                                                        |▓▓░░");
            Console.SetCursorPosition(30, 24);
            Console.WriteLine("└────────────────────────────────────────────────────────────────────────┘▓▓░░");
            Console.SetCursorPosition(30, 25);
            Console.WriteLine(" ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░");
            Console.SetCursorPosition(30, 26);
            Console.WriteLine("  ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");

            Console.SetCursorPosition(79, 15);
            int opc;
            do
            {
                Console.SetCursorPosition(81, 15);
                String op = Console.ReadLine();
                int.TryParse(op, out opc);
            } while (opc < 0 || opc > 6);

            Console.Clear();

            switch (opc)
            {
                case 1:

                    // pedirdatos();


                    break;
                case 2:

                    //  modificar();

                    break;

                case 3:
                    // eliminar();
                    break;
                case 4:
                    // eliminar();
                    break;
                case 5:
                    menuPrincipal();
                    break;

                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    menuFamilia();
                    break;
            }
        }


        public static void menuProductos()
        {

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(30, 9);
            Console.WriteLine("┌────────────────────────────────────────────────────────────────────────┐");
            Console.SetCursorPosition(30, 10);
            Console.WriteLine("|                           MENU  PRODUCTOS                              |▓▓");
            Console.SetCursorPosition(30, 11);
            Console.WriteLine("|                                                                        |▓▓░░");
            Console.SetCursorPosition(30, 12);
            Console.WriteLine("| Ingrese 1 Para Ingresar Producto                                       |▓▓░░");
            Console.SetCursorPosition(30, 13);
            Console.WriteLine("|                                                         ┌──────────┐   |▓▓░░");
            Console.SetCursorPosition(30, 14);
            Console.WriteLine("| Ingrese 2 Para Modificar Producto                       |          |   |▓▓░░");
            Console.SetCursorPosition(30, 15);
            Console.WriteLine("|                                                         |          |   |▓▓░░");
            Console.SetCursorPosition(30, 16);
            Console.WriteLine("| Ingrese 3 Para Eliminar Productos                       |          |   |▓▓░░");
            Console.SetCursorPosition(30, 17);
            Console.WriteLine("|                                                         └──────────┘   |▓▓░░");
            Console.SetCursorPosition(30, 18);
            Console.WriteLine("| Ingrese 4 Para Mostrar Productos                                       |▓▓░░");
            Console.SetCursorPosition(30, 19);
            Console.WriteLine("|                                                                        |▓▓░░");
            Console.SetCursorPosition(30, 20);
            Console.WriteLine("| Ingrese 5 Para Volver al Menu Principal                                |▓▓░░");
            Console.SetCursorPosition(30, 21);
            Console.WriteLine("|                                                                        |▓▓░░");
            Console.SetCursorPosition(30, 22);
            Console.WriteLine("| Ingrese 6 Para Salir al Escritorio                                     |▓▓░░");
            Console.SetCursorPosition(30, 23);
            Console.WriteLine("|                                                                        |▓▓░░");
            Console.SetCursorPosition(30, 24);
            Console.WriteLine("└────────────────────────────────────────────────────────────────────────┘▓▓░░");
            Console.SetCursorPosition(30, 25);
            Console.WriteLine(" ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░");
            Console.SetCursorPosition(30, 26);
            Console.WriteLine("  ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");

            Console.SetCursorPosition(79, 15);
            int opc;
            do
            {
                Console.SetCursorPosition(81, 15);
                String op = Console.ReadLine();
                int.TryParse(op, out opc);
            } while (opc < 0 || opc > 6);

            Console.Clear();

            switch (opc)
            {
                case 1:

                    // pedirdatos();


                    break;
                case 2:

                    //  modificar();

                    break;

                case 3:
                    // eliminar();
                    break;
                case 4:
                    // eliminar();
                    break;
                case 5:
                    menuPrincipal();
                    break;

                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    menuProductos();
                    break;
            }
        }





    }


}

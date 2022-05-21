using eva2.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eva2.Vista
{
    public class Vistas
    {
        public int menuPrincipal()
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


            int opc;
            do
            {
                Console.SetCursorPosition(93, 15);
                String op = Console.ReadLine();
                int.TryParse(op, out opc);
            } while (opc < 0 || opc > 4);

            Console.Clear();

            return opc;


        }

        public int menuUsuarios()
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


            int opc;
            do
            {
                Console.SetCursorPosition(94, 15);
                String op = Console.ReadLine();
                int.TryParse(op, out opc);
            } while (opc < 0 || opc > 6);

            return opc;

            Console.Clear();


        }

        public int menuFamilia()
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

           
            int opc;
            do
            {
                Console.SetCursorPosition(93, 15);
                String op = Console.ReadLine();
                int.TryParse(op, out opc);
            } while (opc < 0 || opc > 6);

            return opc;

            Console.Clear();

           
        }


        public void menuProductos()
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
                    //  menuPrincipal();
                    break;

                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    menuProductos();
                    break;
            }
        }



       




        public int fin()
        {


            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(40, 9);
            Console.WriteLine("┌───────────────────────────────────────────────┐");
            Console.SetCursorPosition(40, 10);
            Console.WriteLine("|                 SELECCIONE                    |▓▓");
            Console.SetCursorPosition(40, 11);
            Console.WriteLine("|                                               |▓▓░░");
            Console.SetCursorPosition(40, 12);
            Console.WriteLine("|    Ingrese 1 para volver al menu principal    |▓▓░░");
            Console.SetCursorPosition(40, 13);
            Console.WriteLine("|    Ingrese 2 para Salir                       |▓▓░░");
            Console.SetCursorPosition(40, 14);
            Console.WriteLine("|                                               |▓▓░░");
            Console.SetCursorPosition(40, 15);
            Console.WriteLine("|                 ┌────────┐                    |▓▓░░");
            Console.SetCursorPosition(40, 16);
            Console.WriteLine("|                 |        |                    |▓▓░░");
            Console.SetCursorPosition(40, 17);
            Console.WriteLine("|                 └────────┘                    |▓▓░░");
            Console.SetCursorPosition(40, 18);
            Console.WriteLine("|                                               |▓▓░░");
            Console.SetCursorPosition(40, 19);
            Console.WriteLine("└───────────────────────────────────────────────┘▓▓░░");
            Console.SetCursorPosition(40, 20);
            Console.WriteLine(" ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░");
            Console.SetCursorPosition(40, 21);
            Console.WriteLine("   ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
            Console.SetCursorPosition(62, 16);

            // int opc = Convert.ToInt32(Console.ReadLine());

            int opc;
            do
            {
                String op = Console.ReadLine();
                int.TryParse(op, out opc);
                Console.SetCursorPosition(60, 16);
            } while (opc < 0 || opc > 2);

            return opc;


        }






    }


}

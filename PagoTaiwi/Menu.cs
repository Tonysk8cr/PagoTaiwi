using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoTaiwi
{

    //Constructor
    internal class Menu
    {

        //Se guarda la cantidad del producto
        int cantidadProducto = 0;
        float precioProducto = 0;  //se guarda el costo del producto
        string nombreProducto = ""; //Se guarda el nombre del producto


        //Este metodo nos va a ayudar a imprimir el menu Inicial
        //Metodo 
        public void MostrarMenu1()
        {
            //Se crea una variable srting la cual se va a imprimir despues
            string menu1 = "**********Comercial Taiwi**********\n";
            menu1 += "1. Ingresar datos del producto: \n";
            menu1 += "2. Calcular subtotal: \n";
            menu1 += "3. Calcular IVA: \n";
            menu1 += "4. Total Neto \n";
            menu1 += "5. Salir: \n";

            //Esta variable sirve para registar la opcion a la que el usuario quiere ir
            int opcion = 0;

            do
            {
                //Imprime el string de menu
                Console.WriteLine(menu1);
                opcion = int.Parse(Console.ReadLine()); //Guarda en la variable opcion la opcion del usuario

                //Nos permite evaluar la varible opcion
                switch (opcion)
                {
                    //Esto va a ejecutar las opciones o en este caso los metodos correspondientes
                    case 1:
                        MostrarMenu2();
                        break;
                    case 2:
                        //Agregar instancia de la clase Subtotal
                        break;
                    case 3:
                        //Agregar instancia de la clase Impuesto
                        break;
                    case 4:
                        //Agregar instancia de la clase PrecioVenta
                        break;
                    default:
                        Console.WriteLine("Opcion no valida \n");
                        break;

                }

            } while (opcion != 5);
            Console.WriteLine("Presione cualquier tecla para salir\n");
            Console.ReadKey();
            Environment.Exit(0);
            //Este codigo anterior sirve para salir de la ap
        }





        //Este nos va a servir para crear el menu auxiliar
        public void MostrarMenu2()
        {
            // Se crea una variable string que se va a imprimir después
            string menu2 = "**********Ingreso de datos**********\n";
            menu2 += "1. Nombre del producto: \n";
            menu2 += "2. Cantidad: \n";
            menu2 += "3. Precios sin IVA: \n";
            menu2 += "4. Regresar al menú principal \n";

            int opcion2 = 0;


            do
            {
                
                //Al igual que con el do while anterior esto evalua las opciones del menu 2
                Console.WriteLine(menu2);
                opcion2 = int.Parse(Console.ReadLine());

                switch (opcion2)
                {
                    case 1:
                        Console.Write("Ingrese el nombre del producto: \t");
                        nombreProducto = Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("Ingrese la cantidad del producto: \t");
                        cantidadProducto = int.Parse(Console.ReadLine()); 
                        break;
                    case 3:
                        Console.Write("Ingrese el precio sin IVA del producto: \t");
                        precioProducto = float.Parse(Console.ReadLine()); 
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.\n");
                        break;
                }

            } while (opcion2 != 4);
            Console.WriteLine("Regresando al menu principal...\n");
            MostrarMenu1 ();

        }
    }
}
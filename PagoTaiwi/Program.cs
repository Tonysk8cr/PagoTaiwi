using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoTaiwi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanciamos a la clase Menu
            //Esto no se debe de modificar ya que menu va a traerse las otras clases

            Menu varObjMenuPrincipal = new Menu();

            varObjMenuPrincipal.MostrarMenu1();
            varObjMenuPrincipal.MostrarMenu2();

        }
    }
}

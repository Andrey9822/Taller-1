using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TALLER_1__publicaciones_;

namespace Taller1
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();
            lista.imprimir();
            lista.Inf_Usuario();

            Menu menu = new Menu();
            menu.menu();
        }

    }
}

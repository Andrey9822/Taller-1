using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TALLER_1__publicaciones_
{
    class libros
    {
        internal static int Count;

        public int id { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha_de_publicacion { get; set; }
        public string Autor { get; set; }
        public string desarrollo { get; set; }

        //public libros(String Nombre, String Fecha_de_publicacion, string Autor)
        //{

        //    this.Nombre = Nombre;
        //    this.Fecha_de_publicacion = Fecha_de_publicacion;
        //    this.Autor = Autor;
        //}

        //public libros()
        //{
        //}
    }
}

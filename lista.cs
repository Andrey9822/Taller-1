using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TALLER_1__publicaciones_
{
    class Lista

    {
        List<Usuario> usuarios = new List<Usuario>();
        List<libros> libros = new List<libros>();
        List<Comentarios> comentarios = new List<Comentarios>();

        Boolean op = true;

        int id = 1; 
        string nombre, tel;

       public void imprimir()
        {
            for (int i = 0; i < libros.Count; i++)
            {
                Console.WriteLine("\n----------------PUBLICACIONES----------------");
                Console.WriteLine("Fecha de publicacion: " + libros[i].Fecha_de_publicacion);
                Console.WriteLine("Nombre del libro: " + libros[i].Nombre);
                Console.WriteLine("Por: " + libros[i].Autor);
                Console.WriteLine("         " + libros[i].desarrollo);
             

                for (int j = 0; j < comentarios.Count; j++)
                {
                    if (comentarios[j].Num_Publicacion == i + 1)
                    {
                        Console.WriteLine("Comentario el: " + comentarios[j].Fecha_de_publicacion);
                        Console.WriteLine("         " + comentarios[j].desarrollo);
                        Console.WriteLine("Por el invitado: " + comentarios[j].visitante);
                    }
                }
            }
        }

       public void Inf_Usuario()
        {
            Console.WriteLine("Favor de llenar unos datos personales:");
            id++;
            Console.WriteLine("Nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Telefono");
            tel = Console.ReadLine();

         
            usuarios.Add(new Usuario { id = id, Nombre = nombre, tel = tel });
        }
    }
}

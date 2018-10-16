using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TALLER_1__publicaciones_
{
    internal class Menu:Lista
    {
        List<Usuario> usuarios = new List<Usuario>();
        List<libros> libros = new List<libros>();
        List<Comentarios> comentarios = new List<Comentarios>();
        Boolean op = true;

        int id = 1, numPublicacion = 1, numComentario = 1;
        string nombre, tel;
        public void menu()
        {
            while (op)
            {
                Inf_Usuario();

                Console.WriteLine(
                    "\nQue desea  hacer: " +
                    "\n1.Editar \n2.Comentar " +
                    "\n3.Salir");
                string tipoUsuario = Console.ReadLine();

                if (tipoUsuario.Equals("1"))
                {
                    Boolean tip = true;
                    while (tip)
                    {
                        Console.WriteLine(
                            "\nSeleccione lo que desea hacer: " +
                            "\n1.Una nueva publicación " +
                            "\n2.Lista de publicaciones " +
                            "\n3.Salir");
                        string opcion = Console.ReadLine();
                        if (opcion.Equals("1"))
                        {
                            Console.WriteLine("\nCual es el contenido de la publicacion que desea agregar?");
                            string desarrollo = Console.ReadLine();

                            libros.Add(new libros { id = numPublicacion, Autor = nombre, Fecha_de_publicacion = DateTime.Now, desarrollo = desarrollo });
                            Console.WriteLine("Numero de  libro " + numPublicacion + " Se agrego correctamente\n");
                            numPublicacion++;
                        }
                        else
                        {
                            if (opcion.Equals("2"))
                            {


                                imprimir();
                            }
                            else
                            {
                                Console.WriteLine("\nMenú principal");
                                Console.ReadLine();
                                tip = false;
                            }
                        }
                    }
                }
                else
                {
                    if (tipoUsuario.Equals("2"))
                    {
                        Boolean tip = true;
                        while (tip)
                        {
                            Console.WriteLine(
                                "\nSeleccione lo que desea hacer: " +
                                "\n1.Nuevo comentario " +
                                "\n2.Lista de publicaciones " +
                                "\nOtro.Salir");
                            string opcion = Console.ReadLine();
                            if (opcion.Equals("1"))
                            {

                                Console.WriteLine("\nCual es el número del libro:");
                                id = Convert.ToInt32(Console.ReadLine());
                                Boolean exis = true;

                                for (int i = 0; i < libros.Count; i++)
                                {
                                    if (libros[i].id == id)
                                    {
                                        Console.WriteLine("\nCual es el comentario que desea agregar");
                                        string desarrollo = Console.ReadLine();
                                        comentarios.Add(new Comentarios { id = numComentario, visitante = nombre, Num_Publicacion = id, Fecha_de_publicacion = DateTime.Now, desarrollo = desarrollo });
                                        Console.WriteLine("Comentario " + numComentario + "se agrego correctamente a la publicacion: " + libros[i].id + "\n");
                                        numComentario++;
                                        exis = false;
                                    }
                                }


                                if (exis)
                                {
                                    Console.WriteLine("\nLa publicacion no existe");
                                    Console.ReadLine();
                                }
                            }
                            else
                            {
                                if (opcion.Equals("2"))
                                {
                                    imprimir();
                                }
                                else
                                {
                                    Console.WriteLine("\nMenú principal");
                                    Console.ReadLine();
                                    tip = false;
                                }
                            }
                        }
                    }
                    else
                    {
                        op = false;
                        Console.WriteLine("Gracias!!!");
                        Console.ReadLine();
                    }

                }

            }
        }


    }
}

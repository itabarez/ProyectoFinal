using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponenteDeNegocios
{
    public partial class Usuario
    {
        public static bool existeUsuario(string user)
        {
            using (Consultorios_TestingEntities2 en = new Consultorios_TestingEntities2())
            {
                return (from u in en.Usuario
                        where u.Nick == user 
                        select u).Count() > 0;
            }
        }

        public static bool existeClave(String pass)
        { 
            using (Consultorios_TestingEntities2 en = new Consultorios_TestingEntities2())
            {
                return (from p in en.Usuario
                        where p.Pass == pass
                        select p).Count() > 0;
            }
        }

        public static Usuario obtenerUsuario(String user, String pass)
        { 
            try
            {
                //if(Usuario.existeUsuario(user))
                  //  throw new Exception ("Ya existe")

                using (Consultorios_TestingEntities2 en = new Consultorios_TestingEntities2())
                { 
                    var usuario = from us in en.Usuario
                                      where us.Nick == user && us.Pass == pass
                                      select us;

                    if (usuario.Count() == 0)
                        throw new Exception("No se encontró Usuario con nombre" + user);
                    else
                        return usuario.First();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static bool guardarUsuario(Usuario user, out string errorMg)
        {
            try
            {
                bool error = false;
                /* Nos fijamos si la persona existe previamente */
                Persona pers = new Persona();
                //pers.ExistePersona(user.Cedula, out error);
                //if (error)
                 //   throw new Exception(errorMg);
                errorMg = "";

                if (Usuario.existeUsuario(user.Nick))
                    throw new Exception("Ya existe el usuario: " + user.Nick);

                using (Consultorios_TestingEntities2 en = new Consultorios_TestingEntities2())
                {
                    en.Usuario.Add(user);
                    en.SaveChanges();
                }
                return error;
            }
            catch (Exception ex)
            {
                errorMg = ex.Message;
                return false;
            }
        }

        /* Función que devuelve un string aleatorio para restarurar la contraseña */
        public static string GetRandom_String(int length)
        {
            Random obj = new Random();
            string posibles = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            int longitud = posibles.Length;
            char letra;
            string nuevacadena = "";
            for (int i = 0; i < length; i++)
            {
                letra = posibles[obj.Next(longitud)];
                nuevacadena += letra.ToString();
            }

            return nuevacadena;
        }
    }
}

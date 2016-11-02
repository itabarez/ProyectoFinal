using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ComponenteDeNegocios;

namespace WS_Consultorios
{
    public class Login : LoginUsuario
    {
        public Usuario Traer_Usuario (String Nick, String Password)
        {
            bool error = false;
            Usuario usu = new Usuario();

            try
            {
                usu = ComponenteDeNegocios.Usuario.obtenerUsuario(Nick, Password);
            }
            catch (Exception ex)
            {
                error = true;
            }
            return usu;
        }
    }

    /*[DataContract]
    public class Usuario
    {
        [DataMember]
        public string usuario;

        [DataMember]
        public string pass;
    }*/
}

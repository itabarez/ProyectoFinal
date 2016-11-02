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
    [ServiceContract]
    public interface LoginUsuario
    {
        [OperationContract]
        Usuario Traer_Usuario(String Nick, String Password);
    }

}

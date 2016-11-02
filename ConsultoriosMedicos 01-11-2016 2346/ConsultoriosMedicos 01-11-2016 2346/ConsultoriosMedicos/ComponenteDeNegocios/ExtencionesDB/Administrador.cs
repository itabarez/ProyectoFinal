using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponenteDeNegocios
{
    class Administrador : Persona
    {
        /*#region Atributos
        private int _id;


        #endregion


        #region Properties

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        #endregion

        #region Contructor

        public Administrador(string pNick, string pPassword, Rol pRol, bool pActivo, int pCedula, string pNombre, string pApellido, string pEmail, string pTelefono, char pSexo, DateTime pFechaNacimiento)
            : base(pNick, pPassword, pRol, pActivo, pCedula, pNombre, pApellido, pEmail, pTelefono, pSexo, pFechaNacimiento)
        {
            this._id = _id + 1;

        }

        #endregion

        public override string ToString()
        {
            return this.Nombre + " - " + this.Apellido + " - " + this.Email;
        }

        public override bool Equals(object obj)
        {
            return this._id == ((Administrador)obj).ID;
        }*/

    }
}

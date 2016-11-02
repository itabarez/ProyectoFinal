using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponenteDeNegocios
{
    class Tratamiento
    {
    #region Atributos
        private int _id;
        private DateTime _fecha;
        private String _nombre;
        private String _medicacion;
        private String _observacion;
        private Boolean _activo;

        #endregion


        #region Properties

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public DateTime Fecha 
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public String Medicacion
        {
            get { return _medicacion; }
            set { _medicacion = value; }
        }

        public String Observacion
        {
            get { return _observacion; }
            set { _observacion = value; }
        }

        public Boolean Activo
        {
            get { return _activo; }
            set { _activo = value; }
        }

        #endregion

        #region Contructor

        public Tratamiento(String pNombre, DateTime pFecha, String pNombreEstudio, String pMedicacion, String pObservacion, Boolean pActivo)
            
        {
            this._id = _id+1;
            this._fecha = pFecha;
            this._nombre = pNombreEstudio;
            this._medicacion = pMedicacion;
            this._observacion = pObservacion;
            this._activo = pActivo;
        }

        #endregion

        public override string ToString()
        {
            return this.Nombre + " - " + this.Fecha + " - " + this.Medicacion + " - " + this.Observacion;

        }

        public override bool Equals(object obj)
        {
            return this._id == ((Tratamiento)obj).ID;
        }

    }
}


//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoADatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Edificio
    {
        public int Id_Lugar { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Consultorio { get; set; }
        public int Nro_Consultorio { get; set; }
        public Nullable<bool> Activo { get; set; }
    
        public virtual Consultorio Consultorio1 { get; set; }
    }
}
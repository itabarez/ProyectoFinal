using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Consultorio.Models
{
    public class Usuarios
    {
        public int Cedula { get; set; }
        [Required]
        [Display(Name = "Nombre")]
        public string Nick { get; set; }
        public string Pass { get; set; }
        public int Rol { get; set; }
        public int Activo { get; set; }
    }
}
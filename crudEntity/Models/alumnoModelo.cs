using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace crudEntity.Models
{
    public class alumnoModelo
    {
        [Key]
        public int Id { get; set; }
        public string NombreAlumno { get; set; }
        public string ApellidoAlumno { get; set; }
        public string DireccionAlumno { get; set; }
        public string EmailAlumno { get; set; }
        public string TelefonoAlumno { get; set; }
    }
}
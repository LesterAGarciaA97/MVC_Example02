using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_Site.Models
{
    public class Alumno
    {
        public string nombreCompleto { get; set; }
        public int carne { get; set; }
        public DateTime fechaNacimiento { get; set; }
    }
}
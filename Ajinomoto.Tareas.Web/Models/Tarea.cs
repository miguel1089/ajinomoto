using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ajinomoto.Tareas.Web.Models
{
    public class Tarea
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public bool completada { get; set; }
        public bool activo { get; set; }
    }
}
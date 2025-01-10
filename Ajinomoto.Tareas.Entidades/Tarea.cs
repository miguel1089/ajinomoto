

namespace Ajinomoto.Tareas.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Tarea
    {
        [Key]
        public int IdTarea { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public Nullable<bool> Completada { get; set; }
    }
}

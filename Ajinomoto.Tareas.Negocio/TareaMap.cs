using Ajinomoto.Tareas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajinimoto.Tareas.Negocio
{
    public static class TareaMap
    {
        public static Tarea MaptoViewModel(Ajinomoto.Tareas.Data.Tarea dto)
        {
            return new Tarea()
            {
                IdTarea = dto.IdTarea,
                Titulo = dto.Titulo,
                Descripcion = dto.Descripcion,
                Completada = dto.Completada
            };
        }

        public static Ajinomoto.Tareas.Data.Tarea MaptoViewEntidad(Tarea dto)
        {
            return new Ajinomoto.Tareas.Data.Tarea()
            {
                IdTarea = dto.IdTarea,
                Titulo = dto.Titulo,
                Descripcion = dto.Descripcion,
                Completada = dto.Completada
            };
        }
    }
}

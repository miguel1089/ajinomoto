using Ajinomoto.Tareas.Data;
using System.Collections.Generic;
using System.Linq;

namespace Ajinimoto.Tareas.Negocio
{
    public class TareaNegocio
    {
        public List<Ajinomoto.Tareas.Entidades.Tarea> ListarTareas()
        {
            TareaDatos objTareaDatos = new TareaDatos();
            var responseMap = objTareaDatos.ListarTareas().Select(x => TareaMap.MaptoViewModel(x)).ToList();
            return responseMap;
            
        }

        public Ajinomoto.Tareas.Entidades.Tarea ObtenerTarea(int? id)
        {
            TareaDatos objTareaDatos = new TareaDatos();
            var tarea = objTareaDatos.ObtenerTarea(id);
            var responseMap =  TareaMap.MaptoViewModel(tarea);
            return responseMap;

        }

        public int CrearTarea(Ajinomoto.Tareas.Entidades.Tarea tarea)
        {
            TareaDatos objTareaDatos = new TareaDatos();
            var responseMap = TareaMap.MaptoViewEntidad(tarea);
            var id = objTareaDatos.CrearTarea(responseMap);
            return id;
        }
        public bool ModificarTarea(Ajinomoto.Tareas.Entidades.Tarea tarea)
        {
            TareaDatos objTareaDatos = new TareaDatos();
            var responseMap = TareaMap.MaptoViewEntidad(tarea);
            var result = objTareaDatos.ModificarTarea(responseMap);
            return result;
        }
        public bool EliminarTarea(int id)
        {
            TareaDatos objTareaDatos = new TareaDatos();
            var result = objTareaDatos.EliminarTarea(id);
            return result;
        }
    }
}

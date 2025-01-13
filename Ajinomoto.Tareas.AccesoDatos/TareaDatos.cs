using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Ajinomoto.Tareas.Data
{
    public class TareaDatos
    {
        private AppDbContext db = new AppDbContext();
        public List<Tarea> ListarTareas()
        {
            return db.Tareas.ToList();
        }

        public Tarea ObtenerTarea(int? id)
        {
            return db.Tareas.Find(id);
        }

        public int CrearTarea(Tarea tarea)
        {
            db.Tareas.Add(tarea);
            var id = db.SaveChanges();
            return id;
        }

        public bool ModificarTarea(Tarea tarea)
        {
            db.Entry(tarea).State = EntityState.Modified;
            var id = db.SaveChanges();
            return id >0;
        }
        public bool EliminarTarea(int id)
        {
            var tarea = db.Tareas.Find(id);
            db.Tareas.Remove(tarea);
            var result = db.SaveChanges();
            return result > 0;
        }

    }
}

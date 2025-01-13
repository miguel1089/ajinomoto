using System.Data.Entity;

namespace Ajinomoto.Tareas.Data
{
    public class AppDbContext: DbContext    
    {
        public AppDbContext():base("name=db_connection")
        {

        }
        public DbSet<Tarea> Tareas { get; set; }
    }
}

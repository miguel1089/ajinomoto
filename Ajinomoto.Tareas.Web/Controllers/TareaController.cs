using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;
using Ajinimoto.Tareas.Negocio;
using Ajinomoto.Tareas.Entidades;

namespace Ajinomoto.Tareas.Web.Controllers
{
    public class TareaController : Controller
    {
        private TareaNegocio negocio = new TareaNegocio();

        // GET: Tareas
        public ActionResult Index()
        {
            List<Tarea> data =  negocio.ListarTareas();
            return View(data);
        }

        // GET: Tareas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tarea tarea = negocio.ObtenerTarea(id);
            if (tarea == null)
            {
                return HttpNotFound();
            }
            return View(tarea);
        }

        // GET: Tareas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tareas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdTarea,Titulo,Descripcion,Completada")] Tarea tarea)
        {
            if (ModelState.IsValid)
            {
                tarea.Completada = tarea.Completada ?? false;
                var id = negocio.CrearTarea(tarea);
                return RedirectToAction("Index");
            }

            return View(tarea);
        }

        // GET: Tareas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tarea tarea = negocio.ObtenerTarea(id);
            if (tarea == null)
            {
                return HttpNotFound();
            }
            return View(tarea);
        }

        // POST: Tareas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdTarea,Titulo,Descripcion,Completada")] Tarea tarea)
        {
            if (ModelState.IsValid)
            {
                var id = negocio.ModificarTarea(tarea);
                return RedirectToAction("Index");
            }
            return View(tarea);
        }

        // GET: Tareas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tarea tarea = negocio.ObtenerTarea(id);
            if (tarea == null)
            {
                return HttpNotFound();
            }
            return View(tarea);
        }

        // POST: Tareas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var result = negocio.EliminarTarea(id);  
            return RedirectToAction("Index");
        }

    }
}

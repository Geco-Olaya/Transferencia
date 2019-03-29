using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Transferencia.Models;

namespace Transferencia.Controllers
{
    public class ClientesController : Controller
    {
        /// <summary>
        /// Referencia base de datos
        /// </summary>
        private ApplicationDbContext db = new ApplicationDbContext();

        /// <summary>
        /// Libera la conexión db
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        /// <summary>
        /// Metodo que lista los clientes existentes
        /// </summary>
        /// <returns>vista con el mismo nombre de la acción</returns>
        [HttpGet]
        public ActionResult Index()
        {
            var clientes = db.Clientes.ToList();

            return View(clientes);
        }

        [HttpGet]
        public ActionResult Detalle(int id)
        {
            var cliente = db.Clientes.Find(id);

            //var cliente = db.Clientes.FirstOrDefault(c => c.Id == id);
            //var cliente = (from s in db.Clientes
            //               where s.Id == id
            //               select s).FirstOrDefault<Cliente>();
            //var cliente = db.Clientes.Where(c => c.Id == id).FirstOrDefault();

            return View(cliente);
        }
    }
}
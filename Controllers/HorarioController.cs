using Cine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cine.Controllers
{
    public class HorarioController : Controller
    {
        readonly HorarioDBConection db = new HorarioDBConection();
        // GET: Horario
        public ActionResult Index()

        {

            var horarios = db.Horarios.ToList();
            return View(horarios);

        }
        public ActionResult Create()
        {
            return View();

        }
       [HttpPost]

        public ActionResult Create(Horarios horario)
        {
            db.Horarios.Add(horario);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
    }  


}
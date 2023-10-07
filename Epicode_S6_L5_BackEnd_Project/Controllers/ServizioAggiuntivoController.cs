using Epicode_S6_L5_BackEnd_Project.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Epicode_S6_L5_BackEnd_Project.Controllers
{
    public class ServizioAggiuntivoController : Controller
    {
        public ActionResult CreaServizioAggiuntivo()
        {
            ServizioAggiuntivo model = new ServizioAggiuntivo();
            model.ServiziAggiuntivi = ServizioAggiuntivo.GetListaServiziAggiuntivi();
            return View(model);
        }

        [HttpPost]
        public ActionResult CreaServizioAggiuntivo(ServizioAggiuntivo model)
        {
            if (ModelState.IsValid)
            {
                model.InserisciServizioAggiuntivo();
                return RedirectToAction("ListaServizioAggiuntivo");
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult DettaglioServizioAggiuntivo(int IdServizio)
        {
            var dettaglioServizio = new ServizioAggiuntivo().GetServizioAggiuntivoById(IdServizio);

            if (dettaglioServizio != null)
            {
                return View(dettaglioServizio);
            }
            return HttpNotFound();
        }
    }
}
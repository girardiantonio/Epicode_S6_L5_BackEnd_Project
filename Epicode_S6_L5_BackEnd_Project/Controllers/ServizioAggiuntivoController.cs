﻿using Epicode_S6_L5_BackEnd_Project.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
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
        public ActionResult CreaServizioAggiuntivo(ServizioAggiuntivo model, int IdPrenotazione)
        {
            model.IdPrenotazione = IdPrenotazione;
            
            if (ModelState.IsValid)
            {
                model.InserisciServizioAggiuntivo();
                return RedirectToAction("ListaServizioAggiuntivo", new { IdPrenotazione });
            }
            return View(model);
        }

        public ActionResult EliminaServizioAggiuntivo(ServizioAggiuntivo model, int IdServizio, int IdPrenotazione)
        {
            model.IdPrenotazione = IdPrenotazione;

            var servizio = new ServizioAggiuntivo().GetServizioAggiuntivoById(IdServizio);

            if (servizio != null)
            {
                servizio.EliminaServizioAggiuntivo();
            }

            return RedirectToAction("ListaServizioAggiuntivo", new { IdPrenotazione });
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

        [HttpGet]
        public ActionResult ListaServizioAggiuntivo(int IdPrenotazione)
        {
            List<ServizioAggiuntivo> serviziAggiuntivi = ServizioAggiuntivo.GetServiziAggiuntiviByIdPrenotazione(IdPrenotazione);

            return View(serviziAggiuntivi);
        }

    }
}
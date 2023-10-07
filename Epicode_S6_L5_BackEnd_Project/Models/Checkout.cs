using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Epicode_S6_L5_BackEnd_Project.Models
{
    public class Checkout
    {
        public string NomeTitolare { get; set; }
        public int NumeroStanza { get; set; }
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }
        public decimal TariffaApplicata { get; set; }
        public List<ServizioAggiuntivo> ServiziAggiuntivi { get; set; }
        public decimal ImportoDaSaldare { get; set; }
    }
}
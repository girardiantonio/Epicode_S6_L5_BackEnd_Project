using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Epicode_S6_L5_BackEnd_Project.Models
{
    public class Utente
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KisiselWebProjesi.Models.Classes
{
    public class Icons
    {
        [Key]
        public int id { get; set; }
        public string icon_name  { get; set; }
        public string icon_link { get; set; }
    }
}
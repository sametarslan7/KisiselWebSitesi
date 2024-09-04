using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KisiselWebProjesi.Models.Classes
{
    public class Sertificiate
    {
        [Key]
        public int id { get; set; }
        public String sertificiate_name { get; set; }
        public String sertificiate_description { get; set; }
    }
}
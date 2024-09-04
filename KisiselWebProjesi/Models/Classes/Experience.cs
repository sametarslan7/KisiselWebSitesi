using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KisiselWebProjesi.Models.Classes
{
    public class Experience
    {
        [Key]
        public int id { get; set; }
        public String experience_name { get; set; }
        public String experience_description { get; set; }
    }
}
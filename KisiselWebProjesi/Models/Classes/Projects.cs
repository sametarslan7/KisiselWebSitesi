using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace KisiselWebProjesi.Models.Classes
{
    public class Projects
    {
        [Key]
        public int id { get; set; }
        public String project_name { get; set; }
        public String project_photo { get; set; }
        public String project_link { get; set; }
    }
}
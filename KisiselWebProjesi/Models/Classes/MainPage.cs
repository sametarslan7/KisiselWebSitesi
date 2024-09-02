using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KisiselWebProjesi.Models.Classes
{
    public class MainPage
    {
        [Key]
        public int id { get; set; }
        public string profile_photo { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string contact { get; set; }
    }
}
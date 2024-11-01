﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KisiselWebProjesi.Models.Classes
{
    public class Context :DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<MainPage> MainPages { get; set; }
        public DbSet<Icons> Icons { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Sertificiate> Sertificiates { get; set; }
        public DbSet<Projects> Projects { get; set; }
    }
}
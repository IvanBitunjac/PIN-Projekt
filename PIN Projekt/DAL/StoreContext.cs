using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PIN_Projekt.Models;
using System.Data.Entity;

namespace PIN_Projekt.DAL
{
    public class StoreContext:DbContext
    {
        public DbSet<Proizvod> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
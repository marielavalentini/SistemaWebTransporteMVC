using SistemaWebTransporteMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SistemaWebTransporteMVC.Data
{
    public class DbContextTransporte : DbContext
    {
        public DbContextTransporte() : base("keyDbTransporte") { }

        public DbSet<Auto> Autos { get; set; }
    }
}
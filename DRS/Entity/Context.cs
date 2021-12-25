using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DRS.Entity
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Appointment> Appointment { get; set; }
    }
}
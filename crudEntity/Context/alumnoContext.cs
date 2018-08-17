using crudEntity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace crudEntity.Context
{
    public class alumnoContext:DbContext
    {
        public DbSet<alumnoModelo> alumnos { get; set; }
    }
}
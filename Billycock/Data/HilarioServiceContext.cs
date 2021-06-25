﻿using Billycock.Models;
using Billycock.Models.Hilario;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Billycock.Data
{
    public class HilarioServiceContext : DbContext
    {
        public HilarioServiceContext(DbContextOptions<HilarioServiceContext> options)
       : base(options)
        { }

        public DbSet<Producto> PRODUCTO { get; set; }
        public DbSet<Proveedor> PROVEEDOR { get; set; }
        public DbSet<Oferta> OFERTA { get; set; }
        public DbSet<Linea> LINEA { get; set; }
        public DbSet<Venta.Cabecera> VENTA_CABECERA { get; set; }
        public DbSet<Venta.Detalle> VENTA_DETALLE { get; set; }
        public DbSet<Historia> HISTORIA { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
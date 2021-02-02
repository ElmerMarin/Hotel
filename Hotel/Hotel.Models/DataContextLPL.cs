using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Models
{
    public class DataContextLPL:DbContext
    {
        public DataContextLPL(DbContextOptions<DataContextLPL> options):base(options)
        {
                
        }

        public DbSet<Blog> Blog { get; set; }
        public DbSet<Chat> Chat { get; set; }
        public DbSet<Caracteristicas> Caracteristicas { get; set; }
        public DbSet<Habitaciones> Habitaciones { get; set; }
        public DbSet<Hoteles> Hoteles { get; set; }
        public DbSet<HotelesHabitacionCaracteristica> HotelesHabitacionCaracteristica { get; set; }
        public DbSet<Imagenes> Imagenes { get; set; }
        public DbSet<ReservaDetalle> ReservaDetalle { get; set; }
        public DbSet<Reservas> Reservas { get; set; }
        public DbSet<Servicios> Servicios { get; set; }
        public DbSet<Suscripciones> Suscripciones { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }

    }
}

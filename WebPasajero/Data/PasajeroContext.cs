
using Microsoft.EntityFrameworkCore;
using System;
using WebPasajero.Models;

namespace EntityFrameworkExample.Data
{

    public class PasajeroContext : DbContext
    {
        public PasajeroContext(DbContextOptions<PasajeroContext> options)
            : base(options)
        {
        }

        public DbSet<Pasajero> Pasajeros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //OPCIONAL INICIALIZAR LA BASE DE DATOS CON 2 PERSONAS
            modelBuilder.Entity<Pasajero>().HasData(
               new Pasajero
               {
                   Id = 1,
                   Nombre = "Tara",
                   Apellido = "Brewer",
                   FechaDeNacimiento = new DateTime(2015, 7, 8, 6, 34, 53),
                   Ciudad = "LosAngeles"
               },
               new Pasajero
               {
                   Id = 2,
                   Nombre = "Andrew",
                   Apellido = "Tippett",
                   FechaDeNacimiento = new DateTime(2016, 6, 1, 6, 34, 53),
                   Ciudad = "NickelRoad"
               });
        }
    }
}
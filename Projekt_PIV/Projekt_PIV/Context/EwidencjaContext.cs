using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Projekt_PIV.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projekt_PIV.Context
{
    public class EwidencjaContext : DbContext
    {
        public EwidencjaContext()
        {
        }

        public EwidencjaContext(DbContextOptions<EwidencjaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Produkty> Produkty { get; set; }
        public virtual DbSet<Zamówienia> Zamówienia { get; set; }
        public virtual DbSet<DaneAdresowe> DaneAdresowe { get; set; }
        public virtual DbSet<Klienci> Klienci { get; set; }
        public virtual DbSet<Pracownicy> Pracownicy { get; set; }
        public virtual DbSet<Faktury> Faktury { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=COMPHT;Database=Ewidencja;Trusted_Connection=True;");
        }
    }
}
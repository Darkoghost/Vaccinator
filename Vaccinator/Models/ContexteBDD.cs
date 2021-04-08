using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vaccinator.Models;

namespace Vaccinator.Models
{
    public class ContexteBDD : DbContext
    {
        //public DbSet<Categorie> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //en vrai il ne faudrait pas mettre la chaine de connexion ici, mais dans les paramètres appsettings
            //todo mettre la chaine de connexion ailleurop
            options.UseSqlite("Data Source=vaccinator.db");
        }

        public DbSet<Personne> Personne { get; set; }

        public DbSet<Vaccinator.Models.Vaccin> Vaccin { get; set; }
    }
}

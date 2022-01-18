using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetarsConsole.Contexts
{
    public class MetarContext : DbContext
    {
        public DbSet<MetarsConsole.Models.Metar> Metars { get; set; }
        public DbSet<MetarsConsole.Models.SkyCondition> SkyConditions { get; set; }
        public DbSet<MetarsConsole.Models.QualityControlFlags> QualityFlags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=MetarData;Trusted_Connection=True;");
        }

    }
}
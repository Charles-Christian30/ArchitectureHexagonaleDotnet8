using Domaine.DataEntity.PersonneModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine.Context
{
    public class leSiteDbContext : DbContext
    {
        public leSiteDbContext(DbContextOptions<leSiteDbContext> options) : base(options)
        {
        }

        public DbSet<Personne> personnes { get; set; }
    }
}

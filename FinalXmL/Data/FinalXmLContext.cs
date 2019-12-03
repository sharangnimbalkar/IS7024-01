using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalXmL.Models;

namespace FinalXmL.Models
{
    public class FinalXmLContext : DbContext
    {
        public FinalXmLContext (DbContextOptions<FinalXmLContext> options)
            : base(options)
        {
        }

        public DbSet<FinalXmL.Models.MunicipalityJson> MunicipalityJson { get; set; }

        public DbSet<FinalXmL.Models.MunicipalityAdd> MunicipalityAdd { get; set; }
    }
}

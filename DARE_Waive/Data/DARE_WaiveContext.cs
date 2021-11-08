using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DARE_Waive.Models;

namespace DARE_Waive.Data
{
    public class DARE_WaiveContext : DbContext
    {
        public DARE_WaiveContext (DbContextOptions<DARE_WaiveContext> options)
            : base(options)
        {
        }

        public DbSet<DARE_Waive.Models.AktivierungsDokumente> AktivierungsDokumente { get; set; }

        public DbSet<DARE_Waive.Models.MasterData> MasterData { get; set; }

        public DbSet<DARE_Waive.Models.PlanungsDatenAnlagen> PlanungsDatenAnlagen { get; set; }

        public DbSet<DARE_Waive.Models.RedispatchingBedarfe> RedispatchingBedarfe { get; set; }
    }
}

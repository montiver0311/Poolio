using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poolio.Data.Entities;
using Poolio.Data.Interfaces;

namespace Poolio.Data
{
    public class PoolioContext :DbContext, IPoolioContext
    {
        public DbSet<Team> Teams { get; set; }

        public DbSet<Week> Weeks { get; set; }
    }
}

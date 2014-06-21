﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poolio.Data.Entities
{
    public class Team
    {
        public int Id { get; set; }
        
        public string City { get; set; }

        public string Name { get; set; }

        public int Wins { get; set; }

        public int Losses { get; set; }

       // public ICollection<Week> Weeks { get; set; }

    }
}

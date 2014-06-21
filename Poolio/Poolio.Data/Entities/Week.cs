using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poolio.Data.Entities
{
    public class Week
    {
        public int Id { get; set; }

        public DateTime WeekStart { get; set; }

        public DateTime WeekEnd { get; set; }

        //Game time start

       // public ICollection<Team> Teams { get; set; }


    }
}

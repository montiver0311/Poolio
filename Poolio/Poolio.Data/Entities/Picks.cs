using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poolio.Data.Entities
{
    public class Picks
    {
        public int Id { get; set; }

        public int PoolerId { get; set; }

        public Pooler Pooler { get; set; }  

        //refernce to poolers id will be configured in fluent configuration

        public DateTime PickEntryDateTime { get; set; }

        public int PickedTeamId { get; set; }
    }
}

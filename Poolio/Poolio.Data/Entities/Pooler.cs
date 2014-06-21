using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poolio.Data.Entities
{
    public class Pooler
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Wins { get; set; }

        public int Losses { get; set; }

    }
}

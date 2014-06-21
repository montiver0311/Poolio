using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poolio.Data.Entities
{
    public class Matchups
    {
        public int MatchupId { get; set; }

        public int HomeTeamId { get; set; }

        public int AwayTeamId { get; set; }

        public int WinningTeamId { get; set; }

        public int LosingTeamId { get; set; }

        public ICollection<Week> Weeks { get; set; }

        public ICollection<Team> Teams { get; set; }

    }
}

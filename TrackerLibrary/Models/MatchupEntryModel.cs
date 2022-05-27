using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel

    {
        /// <summary>
        /// The unique identifier for the matchupentry
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Repesent one team in the match
        ///
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        public double Score { get; set; }
        public MatchupModel ParentMatchup { get; set; }
    }
}

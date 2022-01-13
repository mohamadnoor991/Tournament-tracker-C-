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
        /// Repesent one team in the match
        ///
        /// </summary>
        public TeamModel Teamcompeting { get; set; }
        public double Score { get; set; }
        public MatchupModel ParentMatchup { get; set; }
    }
}

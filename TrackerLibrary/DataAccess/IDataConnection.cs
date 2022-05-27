using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess

{
    /// <summary>
    /// The contract that will be used to make the connection between the form and the data sourse.
    /// </summary>
  public  interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel model); /*Method to save and return the data from prizeForm*/

        PersonModel CreatePerson(PersonModel model); // Method to create the new members in the creat team form.
        void CreateTournament(TournamentModel model);
        TeamModel CreateTeam(TeamModel model);
        List<TeamModel> GetTeam_All();
        List<PersonModel> GetPerson_All();

    }
}

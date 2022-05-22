using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTourmamentForm : Form
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();

        public CreateTourmamentForm()
        {
            InitializeComponent();
            InitializeLists();
        }

        private void InitializeLists()
        {
            selectTeamRoundDropDown.DataSource = availableTeams;
            selectTeamRoundDropDown.DisplayMember = "TeamName";

            tournamentTeamsListBox.DataSource = selectedTeams;
            tournamentTeamsListBox.DisplayMember = "TeamName";

            PrizesListBox.DataSource = selectedPrizes;
            PrizesListBox.DisplayMember = "PlaceName";
        }
        private void RoundLabel_Click(object sender, EventArgs e)
        {

        }

        private void selectTeamRoundDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void createNewTeamLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void touemamentPlayersLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

﻿using System;
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
    public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();

        public CreateTournamentForm()
        {
            InitializeComponent();

            WireUpLists();
        }

        private void WireUpLists()
        {
            selectTeamDropDown.DataSource = null;
            selectTeamDropDown.DataSource = availableTeams;
            selectTeamDropDown.DisplayMember = "TeamName";

            tournamentTeamsListBox.DataSource = null;
            tournamentTeamsListBox.DataSource = selectedTeams;
            tournamentTeamsListBox.DisplayMember = "TeamName";

            PrizesListBox.DataSource = null;
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
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();
        }

        private void touemamentPlayersLabel_Click(object sender, EventArgs e)
        {

        }

        private void CreateTourmamentForm_Load(object sender, EventArgs e)
        {

        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {

            TeamModel t = (TeamModel)selectTeamDropDown.SelectedItem;

            if (t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);
                WireUpLists();
            }

        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            // call Createprizeform
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show();

            //
        }

        public void PrizeComplete(PrizeModel model)
        {
            // Get back from the form a PrizeModel 
            // Take the PrizeModel and put it into our list of selected prizes
            selectedPrizes.Add(model);
            WireUpLists();
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpLists();
        }


        private void removeSelectedPrizeButton_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)PrizesListBox.SelectedItem;
            if (p != null)
            {
                selectedPrizes.Remove(p);
                WireUpLists();

            }
        }

        private void removeSelectedPlayerButton_Click_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)tournamentTeamsListBox.SelectedItem;
            if (t != null)
            {
                selectedTeams.Remove(t);
                availableTeams.Add(t);
                WireUpLists();
            }
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            // Validate data
            decimal fee = 0;
            //convert the text to decimal and send it to fee or fee will be zero and 'feeAcceptable' be 0.
             bool feeAcceptable = decimal. TryParse(entryFeeValue.Text, out fee);
            if (!feeAcceptable) {
                 MessageBox.Show("You need to enter a valid Entry Fee.",
                "Invalid Fee", MessageBoxButtons.OK,
                MessageBoxIcon.Error); 
            return; } 
        // Create our tournament model
        TournamentModel tm = new TournamentModel(); 
        tm.TournamentName = tournamentNameValue.Text;
            tm.EntryFee = fee;
            tm.Prizes = selectedPrizes;
            tm.EnteredTeams = selectedTeams;

            // TODO - Wire our matchups
            TournamentLogic.CreateRounds(tm);

            //Create tournament entry
            // Create all of the prizes entries 
            // Create all of team entries 
            GlobalConfig.Connection.CreateTournament(tm);
            
        }
    }
};


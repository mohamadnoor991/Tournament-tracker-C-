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
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMember = new List<PersonModel>();
        

      
        
        public CreateTeamForm()
        {
            InitializeComponent();
            //CreatwSampleData();
            
            WireUpLists();
        }

        private void CreatwSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "mohamad", LastName = "badr" });
            availableTeamMembers.Add(new PersonModel { FirstName = "jone", LastName = "slime" });

            selectedTeamMember.Add(new PersonModel { FirstName = "nader", LastName = "tamma" });
            selectedTeamMember.Add(new PersonModel { FirstName = "saleem", LastName = "jone" });

        }
        private void WireUpLists()
        {
            selectTeamMemberDropDown.DataSource = null; //to refresh the list

            selectTeamMemberDropDown.DataSource = availableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName"; /* choice one property of list member to display it*/

            teamMemberListBox.DataSource = null; //to refresh the list

            teamMemberListBox.DataSource = selectedTeamMember;
            teamMemberListBox.DisplayMember = "FullName";
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {

            PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Remove(p);
            selectedTeamMember.Add(p);

            WireUpLists();}
        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.FirstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.EmailAddress = emailValue.Text;
                p.CellPhoneNumber = cellphoneValue.Text;

               p = GlobalConfig.Connection.CreatePerson(p);
                selectedTeamMember.Add(p);

                WireUpLists();

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellphoneValue.Text = "";

            }
            else
            {
                MessageBox.Show("Please checkout and fill the the fileds");
            }
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();

            t.TeamName = teamNameValue.Text;
            t.TeamMembers = selectedTeamMember;

            t = GlobalConfig.Connection.CreateTeam(t);

            //TODO - if we are not close the form after creation, reset the from.
        }

        private void deleteSelectedMemberButtonButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMemberListBox.SelectedItem;

            if(p != null) { 
            selectedTeamMember.Remove(p);
            availableTeamMembers.Add(p);

            WireUpLists();
            }
        }



        private void CreateTeamForm_Load(object sender, EventArgs e)
        {

        }

        private bool ValidateForm()
        {
            if (firstNameValue.Text.Length == 0)
            {
                return false;
            }

            if (lastNameValue.Text.Length == 0)
            {
                return false;
            }

            if (emailValue.Text.Length == 0)
            {
                return false;
            }

            if (cellphoneValue.Text.Length == 0)
            {
                return false;
            }

            return true;
        }

    }
}

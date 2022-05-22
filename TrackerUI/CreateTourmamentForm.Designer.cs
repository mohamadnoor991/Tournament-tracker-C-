
namespace TrackerUI
{
    partial class CreateTourmamentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTourmamentForm));
            this.tourmamentNameValue = new System.Windows.Forms.TextBox();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.createTournamentLabel = new System.Windows.Forms.Label();
            this.entryFeeValue = new System.Windows.Forms.TextBox();
            this.entryFeelabel = new System.Windows.Forms.Label();
            this.selectTeamRoundDropDown = new System.Windows.Forms.ComboBox();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.createNewTeamLinkLabel = new System.Windows.Forms.LinkLabel();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.touemamentPlayersLabel = new System.Windows.Forms.Label();
            this.tournamentTeamsListBox = new System.Windows.Forms.ListBox();
            this.deleteSelectedPlayerButtonButton = new System.Windows.Forms.Button();
            this.deleteSelectedPrizeButton = new System.Windows.Forms.Button();
            this.PrizesListBox = new System.Windows.Forms.ListBox();
            this.PrizesLabel = new System.Windows.Forms.Label();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tourmamentNameValue
            // 
            this.tourmamentNameValue.Location = new System.Drawing.Point(43, 166);
            this.tourmamentNameValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tourmamentNameValue.Name = "tourmamentNameValue";
            this.tourmamentNameValue.Size = new System.Drawing.Size(414, 43);
            this.tourmamentNameValue.TabIndex = 13;
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.ForeColor = System.Drawing.Color.Black;
            this.tournamentNameLabel.Location = new System.Drawing.Point(36, 105);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(247, 38);
            this.tournamentNameLabel.TabIndex = 12;
            this.tournamentNameLabel.Text = "Tournament Name";
            // 
            // createTournamentLabel
            // 
            this.createTournamentLabel.AutoSize = true;
            this.createTournamentLabel.Font = new System.Drawing.Font("Segoe UI Light", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentLabel.Location = new System.Drawing.Point(33, 24);
            this.createTournamentLabel.Name = "createTournamentLabel";
            this.createTournamentLabel.Size = new System.Drawing.Size(368, 59);
            this.createTournamentLabel.TabIndex = 11;
            this.createTournamentLabel.Text = "Create Tournament";
            // 
            // entryFeeValue
            // 
            this.entryFeeValue.Location = new System.Drawing.Point(185, 247);
            this.entryFeeValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.entryFeeValue.Name = "entryFeeValue";
            this.entryFeeValue.Size = new System.Drawing.Size(117, 43);
            this.entryFeeValue.TabIndex = 15;
            this.entryFeeValue.Text = "0";
            // 
            // entryFeelabel
            // 
            this.entryFeelabel.AutoSize = true;
            this.entryFeelabel.ForeColor = System.Drawing.Color.Black;
            this.entryFeelabel.Location = new System.Drawing.Point(47, 247);
            this.entryFeelabel.Name = "entryFeelabel";
            this.entryFeelabel.Size = new System.Drawing.Size(132, 38);
            this.entryFeelabel.TabIndex = 14;
            this.entryFeelabel.Text = "Entry Fee";
            // 
            // selectTeamRoundDropDown
            // 
            this.selectTeamRoundDropDown.FormattingEnabled = true;
            this.selectTeamRoundDropDown.Location = new System.Drawing.Point(43, 350);
            this.selectTeamRoundDropDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectTeamRoundDropDown.Name = "selectTeamRoundDropDown";
            this.selectTeamRoundDropDown.Size = new System.Drawing.Size(414, 45);
            this.selectTeamRoundDropDown.TabIndex = 17;
            this.selectTeamRoundDropDown.SelectedIndexChanged += new System.EventHandler(this.selectTeamRoundDropDown_SelectedIndexChanged);
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.ForeColor = System.Drawing.Color.Black;
            this.selectTeamLabel.Location = new System.Drawing.Point(47, 295);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(164, 38);
            this.selectTeamLabel.TabIndex = 16;
            this.selectTeamLabel.Text = "Select Team";
            this.selectTeamLabel.Click += new System.EventHandler(this.RoundLabel_Click);
            // 
            // createNewTeamLinkLabel
            // 
            this.createNewTeamLinkLabel.AutoSize = true;
            this.createNewTeamLinkLabel.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewTeamLinkLabel.Location = new System.Drawing.Point(258, 310);
            this.createNewTeamLinkLabel.Name = "createNewTeamLinkLabel";
            this.createNewTeamLinkLabel.Size = new System.Drawing.Size(210, 38);
            this.createNewTeamLinkLabel.TabIndex = 18;
            this.createNewTeamLinkLabel.TabStop = true;
            this.createNewTeamLinkLabel.Text = "create new team";
            this.createNewTeamLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createNewTeamLinkLabel_LinkClicked);
            // 
            // addTeamButton
            // 
            this.addTeamButton.AccessibleDescription = "Click here to add your team";
            this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeamButton.Location = new System.Drawing.Point(125, 426);
            this.addTeamButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(228, 51);
            this.addTeamButton.TabIndex = 19;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.AccessibleDescription = "Click here to add your team";
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizeButton.Location = new System.Drawing.Point(125, 509);
            this.createPrizeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(228, 51);
            this.createPrizeButton.TabIndex = 20;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // touemamentPlayersLabel
            // 
            this.touemamentPlayersLabel.AutoSize = true;
            this.touemamentPlayersLabel.ForeColor = System.Drawing.Color.Black;
            this.touemamentPlayersLabel.Location = new System.Drawing.Point(547, 105);
            this.touemamentPlayersLabel.Name = "touemamentPlayersLabel";
            this.touemamentPlayersLabel.Size = new System.Drawing.Size(181, 38);
            this.touemamentPlayersLabel.TabIndex = 21;
            this.touemamentPlayersLabel.Text = "Team/Players";
            this.touemamentPlayersLabel.Click += new System.EventHandler(this.touemamentPlayersLabel_Click);
            // 
            // tournamentTeamsListBox
            // 
            this.tournamentTeamsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentTeamsListBox.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentTeamsListBox.FormattingEnabled = true;
            this.tournamentTeamsListBox.ItemHeight = 41;
            this.tournamentTeamsListBox.Location = new System.Drawing.Point(535, 160);
            this.tournamentTeamsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tournamentTeamsListBox.Name = "tournamentTeamsListBox";
            this.tournamentTeamsListBox.Size = new System.Drawing.Size(395, 166);
            this.tournamentTeamsListBox.TabIndex = 22;
            // 
            // deleteSelectedPlayerButtonButton
            // 
            this.deleteSelectedPlayerButtonButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.deleteSelectedPlayerButtonButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.deleteSelectedPlayerButtonButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.deleteSelectedPlayerButtonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPlayerButtonButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedPlayerButtonButton.Location = new System.Drawing.Point(949, 207);
            this.deleteSelectedPlayerButtonButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteSelectedPlayerButtonButton.Name = "deleteSelectedPlayerButtonButton";
            this.deleteSelectedPlayerButtonButton.Size = new System.Drawing.Size(176, 69);
            this.deleteSelectedPlayerButtonButton.TabIndex = 23;
            this.deleteSelectedPlayerButtonButton.Text = "Delete";
            this.deleteSelectedPlayerButtonButton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedPrizeButton
            // 
            this.deleteSelectedPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.deleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.deleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.deleteSelectedPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedPrizeButton.Location = new System.Drawing.Point(949, 441);
            this.deleteSelectedPrizeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            this.deleteSelectedPrizeButton.Size = new System.Drawing.Size(176, 69);
            this.deleteSelectedPrizeButton.TabIndex = 26;
            this.deleteSelectedPrizeButton.Text = "Delete";
            this.deleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // PrizesListBox
            // 
            this.PrizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrizesListBox.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrizesListBox.FormattingEnabled = true;
            this.PrizesListBox.ItemHeight = 41;
            this.PrizesListBox.Location = new System.Drawing.Point(535, 394);
            this.PrizesListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PrizesListBox.Name = "PrizesListBox";
            this.PrizesListBox.Size = new System.Drawing.Size(395, 166);
            this.PrizesListBox.TabIndex = 25;
            // 
            // PrizesLabel
            // 
            this.PrizesLabel.AutoSize = true;
            this.PrizesLabel.ForeColor = System.Drawing.Color.Black;
            this.PrizesLabel.Location = new System.Drawing.Point(528, 350);
            this.PrizesLabel.Name = "PrizesLabel";
            this.PrizesLabel.Size = new System.Drawing.Size(90, 38);
            this.PrizesLabel.TabIndex = 24;
            this.PrizesLabel.Text = "Prizes";
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.AccessibleDescription = "Click here to add your team";
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentButton.Location = new System.Drawing.Point(367, 587);
            this.createTournamentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(306, 51);
            this.createTournamentButton.TabIndex = 27;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTourmamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1168, 679);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.deleteSelectedPrizeButton);
            this.Controls.Add(this.PrizesListBox);
            this.Controls.Add(this.PrizesLabel);
            this.Controls.Add(this.deleteSelectedPlayerButtonButton);
            this.Controls.Add(this.tournamentTeamsListBox);
            this.Controls.Add(this.touemamentPlayersLabel);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.createNewTeamLinkLabel);
            this.Controls.Add(this.selectTeamRoundDropDown);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.entryFeeValue);
            this.Controls.Add(this.entryFeelabel);
            this.Controls.Add(this.tourmamentNameValue);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.createTournamentLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTourmamentForm";
            this.Text = "Create Tourmament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tourmamentNameValue;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.Label createTournamentLabel;
        private System.Windows.Forms.TextBox entryFeeValue;
        private System.Windows.Forms.Label entryFeelabel;
        private System.Windows.Forms.ComboBox selectTeamRoundDropDown;
        private System.Windows.Forms.Label selectTeamLabel;
        private System.Windows.Forms.LinkLabel createNewTeamLinkLabel;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.Label touemamentPlayersLabel;
        private System.Windows.Forms.ListBox tournamentTeamsListBox;
        private System.Windows.Forms.Button deleteSelectedPlayerButtonButton;
        private System.Windows.Forms.Button deleteSelectedPrizeButton;
        private System.Windows.Forms.ListBox PrizesListBox;
        private System.Windows.Forms.Label PrizesLabel;
        private System.Windows.Forms.Button createTournamentButton;
    }
}
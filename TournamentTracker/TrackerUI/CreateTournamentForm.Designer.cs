namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentNameValue = new System.Windows.Forms.TextBox();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.entryFeeValue = new System.Windows.Forms.TextBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.selectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.createNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.tournamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.tournamentPlayersLabel = new System.Windows.Forms.Label();
            this.deleteSelectedPlayerButton = new System.Windows.Forms.Button();
            this.deleteSelectedPrizeBox = new System.Windows.Forms.Button();
            this.prizesLabel = new System.Windows.Forms.Label();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.headerLabel.Location = new System.Drawing.Point(39, 31);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(202, 50);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Izradi Turnir";
            // 
            // tournamentNameValue
            // 
            this.tournamentNameValue.Location = new System.Drawing.Point(48, 144);
            this.tournamentNameValue.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tournamentNameValue.Name = "tournamentNameValue";
            this.tournamentNameValue.Size = new System.Drawing.Size(230, 35);
            this.tournamentNameValue.TabIndex = 11;
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tournamentNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.tournamentNameLabel.Location = new System.Drawing.Point(43, 111);
            this.tournamentNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(110, 30);
            this.tournamentNameLabel.TabIndex = 10;
            this.tournamentNameLabel.Text = "Ime Turnira";
            // 
            // entryFeeValue
            // 
            this.entryFeeValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.entryFeeValue.Location = new System.Drawing.Point(186, 225);
            this.entryFeeValue.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.entryFeeValue.Name = "entryFeeValue";
            this.entryFeeValue.Size = new System.Drawing.Size(92, 29);
            this.entryFeeValue.TabIndex = 14;
            this.entryFeeValue.Text = "0";
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.entryFeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.entryFeeLabel.Location = new System.Drawing.Point(43, 221);
            this.entryFeeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(120, 30);
            this.entryFeeLabel.TabIndex = 13;
            this.entryFeeLabel.Text = "Cijena Ulaza";
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectTeamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.selectTeamLabel.Location = new System.Drawing.Point(43, 291);
            this.selectTeamLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(123, 30);
            this.selectTeamLabel.TabIndex = 15;
            this.selectTeamLabel.Text = "Odaberi Tim";
            // 
            // selectTeamDropDown
            // 
            this.selectTeamDropDown.FormattingEnabled = true;
            this.selectTeamDropDown.Location = new System.Drawing.Point(48, 335);
            this.selectTeamDropDown.Name = "selectTeamDropDown";
            this.selectTeamDropDown.Size = new System.Drawing.Size(230, 38);
            this.selectTeamDropDown.TabIndex = 16;
            // 
            // createNewTeamLink
            // 
            this.createNewTeamLink.AutoSize = true;
            this.createNewTeamLink.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createNewTeamLink.Location = new System.Drawing.Point(210, 301);
            this.createNewTeamLink.Name = "createNewTeamLink";
            this.createNewTeamLink.Size = new System.Drawing.Size(68, 17);
            this.createNewTeamLink.TabIndex = 17;
            this.createNewTeamLink.TabStop = true;
            this.createNewTeamLink.Text = "izradi novi";
            // 
            // addTeamButton
            // 
            this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addTeamButton.Location = new System.Drawing.Point(69, 405);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(188, 41);
            this.addTeamButton.TabIndex = 18;
            this.addTeamButton.Text = "Dodaj Tim";
            this.addTeamButton.UseVisualStyleBackColor = true;
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createPrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createPrizeButton.Location = new System.Drawing.Point(69, 481);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(188, 41);
            this.createPrizeButton.TabIndex = 19;
            this.createPrizeButton.Text = "Izradi Nagradu";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // tournamentPlayersListBox
            // 
            this.tournamentPlayersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentPlayersListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tournamentPlayersListBox.FormattingEnabled = true;
            this.tournamentPlayersListBox.ItemHeight = 21;
            this.tournamentPlayersListBox.Location = new System.Drawing.Point(424, 144);
            this.tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            this.tournamentPlayersListBox.Size = new System.Drawing.Size(287, 128);
            this.tournamentPlayersListBox.TabIndex = 20;
            // 
            // tournamentPlayersLabel
            // 
            this.tournamentPlayersLabel.AutoSize = true;
            this.tournamentPlayersLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tournamentPlayersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.tournamentPlayersLabel.Location = new System.Drawing.Point(419, 111);
            this.tournamentPlayersLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tournamentPlayersLabel.Name = "tournamentPlayersLabel";
            this.tournamentPlayersLabel.Size = new System.Drawing.Size(138, 30);
            this.tournamentPlayersLabel.TabIndex = 21;
            this.tournamentPlayersLabel.Text = "Timovi / Igrači";
            // 
            // deleteSelectedPlayerButton
            // 
            this.deleteSelectedPlayerButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedPlayerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedPlayerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPlayerButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteSelectedPlayerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.deleteSelectedPlayerButton.Location = new System.Drawing.Point(737, 190);
            this.deleteSelectedPlayerButton.Name = "deleteSelectedPlayerButton";
            this.deleteSelectedPlayerButton.Size = new System.Drawing.Size(111, 61);
            this.deleteSelectedPlayerButton.TabIndex = 22;
            this.deleteSelectedPlayerButton.Text = "Izbriši Odabrano";
            this.deleteSelectedPlayerButton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedPrizeBox
            // 
            this.deleteSelectedPrizeBox.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedPrizeBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedPrizeBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedPrizeBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPrizeBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteSelectedPrizeBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.deleteSelectedPrizeBox.Location = new System.Drawing.Point(737, 438);
            this.deleteSelectedPrizeBox.Name = "deleteSelectedPrizeBox";
            this.deleteSelectedPrizeBox.Size = new System.Drawing.Size(111, 61);
            this.deleteSelectedPrizeBox.TabIndex = 25;
            this.deleteSelectedPrizeBox.Text = "Izbriši Odabrano";
            this.deleteSelectedPrizeBox.UseVisualStyleBackColor = true;
            // 
            // prizesLabel
            // 
            this.prizesLabel.AutoSize = true;
            this.prizesLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prizesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.prizesLabel.Location = new System.Drawing.Point(419, 361);
            this.prizesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prizesLabel.Name = "prizesLabel";
            this.prizesLabel.Size = new System.Drawing.Size(138, 30);
            this.prizesLabel.TabIndex = 24;
            this.prizesLabel.Text = "Timovi / Igrači";
            // 
            // prizesListBox
            // 
            this.prizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizesListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 21;
            this.prizesListBox.Location = new System.Drawing.Point(424, 394);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(287, 128);
            this.prizesListBox.TabIndex = 23;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createTournamentButton.Location = new System.Drawing.Point(369, 584);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(188, 53);
            this.createTournamentButton.TabIndex = 26;
            this.createTournamentButton.Text = "Izradi Turnir";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(967, 672);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.deleteSelectedPrizeBox);
            this.Controls.Add(this.prizesLabel);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.deleteSelectedPlayerButton);
            this.Controls.Add(this.tournamentPlayersLabel);
            this.Controls.Add(this.tournamentPlayersListBox);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.createNewTeamLink);
            this.Controls.Add(this.selectTeamDropDown);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.entryFeeValue);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.tournamentNameValue);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox tournamentNameValue;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.TextBox entryFeeValue;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.Label selectTeamLabel;
        private System.Windows.Forms.ComboBox selectTeamDropDown;
        private System.Windows.Forms.LinkLabel createNewTeamLink;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.ListBox tournamentPlayersListBox;
        private System.Windows.Forms.Label tournamentPlayersLabel;
        private System.Windows.Forms.Button deleteSelectedPlayerButton;
        private System.Windows.Forms.Button deleteSelectedPrizeBox;
        private System.Windows.Forms.Label prizesLabel;
        private System.Windows.Forms.ListBox prizesListBox;
        private System.Windows.Forms.Button createTournamentButton;
    }
}
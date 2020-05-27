namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.teamNameValue = new System.Windows.Forms.TextBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.selectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.selectTeamMemberLabel = new System.Windows.Forms.Label();
            this.addNewMemberGroupBox = new System.Windows.Forms.GroupBox();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.cellphoneValue = new System.Windows.Forms.TextBox();
            this.cellphoneLabel = new System.Windows.Forms.Label();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.teamMembersListBox = new System.Windows.Forms.ListBox();
            this.deleteSelectedMemberButton = new System.Windows.Forms.Button();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.addNewMemberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamNameValue
            // 
            this.teamNameValue.Location = new System.Drawing.Point(47, 96);
            this.teamNameValue.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.teamNameValue.Name = "teamNameValue";
            this.teamNameValue.Size = new System.Drawing.Size(318, 35);
            this.teamNameValue.TabIndex = 14;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.teamNameLabel.Location = new System.Drawing.Point(159, 63);
            this.teamNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(94, 30);
            this.teamNameLabel.TabIndex = 13;
            this.teamNameLabel.Text = "Ime Tima";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.headerLabel.Location = new System.Drawing.Point(120, 9);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(173, 50);
            this.headerLabel.TabIndex = 12;
            this.headerLabel.Text = "Izradi Tim";
            // 
            // addMemberButton
            // 
            this.addMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addMemberButton.Location = new System.Drawing.Point(112, 247);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(188, 41);
            this.addMemberButton.TabIndex = 21;
            this.addMemberButton.Text = "Dodaj Člana";
            this.addMemberButton.UseVisualStyleBackColor = true;
            // 
            // selectTeamMemberDropDown
            // 
            this.selectTeamMemberDropDown.FormattingEnabled = true;
            this.selectTeamMemberDropDown.Location = new System.Drawing.Point(47, 184);
            this.selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            this.selectTeamMemberDropDown.Size = new System.Drawing.Size(318, 38);
            this.selectTeamMemberDropDown.TabIndex = 20;
            // 
            // selectTeamMemberLabel
            // 
            this.selectTeamMemberLabel.AutoSize = true;
            this.selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectTeamMemberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.selectTeamMemberLabel.Location = new System.Drawing.Point(113, 140);
            this.selectTeamMemberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.Size = new System.Drawing.Size(187, 30);
            this.selectTeamMemberLabel.TabIndex = 19;
            this.selectTeamMemberLabel.Text = "Odaberi Člana Tima";
            // 
            // addNewMemberGroupBox
            // 
            this.addNewMemberGroupBox.Controls.Add(this.createMemberButton);
            this.addNewMemberGroupBox.Controls.Add(this.cellphoneValue);
            this.addNewMemberGroupBox.Controls.Add(this.cellphoneLabel);
            this.addNewMemberGroupBox.Controls.Add(this.emailValue);
            this.addNewMemberGroupBox.Controls.Add(this.emailLabel);
            this.addNewMemberGroupBox.Controls.Add(this.lastNameValue);
            this.addNewMemberGroupBox.Controls.Add(this.lastNameLabel);
            this.addNewMemberGroupBox.Controls.Add(this.firstNameValue);
            this.addNewMemberGroupBox.Controls.Add(this.firstNameLabel);
            this.addNewMemberGroupBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addNewMemberGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addNewMemberGroupBox.Location = new System.Drawing.Point(47, 291);
            this.addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            this.addNewMemberGroupBox.Size = new System.Drawing.Size(318, 334);
            this.addNewMemberGroupBox.TabIndex = 22;
            this.addNewMemberGroupBox.TabStop = false;
            this.addNewMemberGroupBox.Text = "Dodaj Novog Člana";
            // 
            // createMemberButton
            // 
            this.createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createMemberButton.Location = new System.Drawing.Point(65, 266);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(188, 41);
            this.createMemberButton.TabIndex = 23;
            this.createMemberButton.Text = "Izradi Člana";
            this.createMemberButton.UseVisualStyleBackColor = true;
            // 
            // cellphoneValue
            // 
            this.cellphoneValue.Location = new System.Drawing.Point(132, 205);
            this.cellphoneValue.Name = "cellphoneValue";
            this.cellphoneValue.Size = new System.Drawing.Size(166, 35);
            this.cellphoneValue.TabIndex = 28;
            // 
            // cellphoneLabel
            // 
            this.cellphoneLabel.AutoSize = true;
            this.cellphoneLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cellphoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.cellphoneLabel.Location = new System.Drawing.Point(6, 208);
            this.cellphoneLabel.Name = "cellphoneLabel";
            this.cellphoneLabel.Size = new System.Drawing.Size(124, 30);
            this.cellphoneLabel.TabIndex = 27;
            this.cellphoneLabel.Text = "Broj telefona";
            // 
            // emailValue
            // 
            this.emailValue.Location = new System.Drawing.Point(132, 155);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(166, 35);
            this.emailValue.TabIndex = 26;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.emailLabel.Location = new System.Drawing.Point(6, 158);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(59, 30);
            this.emailLabel.TabIndex = 25;
            this.emailLabel.Text = "Email";
            // 
            // lastNameValue
            // 
            this.lastNameValue.Location = new System.Drawing.Point(132, 105);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(166, 35);
            this.lastNameValue.TabIndex = 26;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lastNameLabel.Location = new System.Drawing.Point(6, 108);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(84, 30);
            this.lastNameLabel.TabIndex = 25;
            this.lastNameLabel.Text = "Prezime";
            // 
            // firstNameValue
            // 
            this.firstNameValue.Location = new System.Drawing.Point(132, 55);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(166, 35);
            this.firstNameValue.TabIndex = 24;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.firstNameLabel.Location = new System.Drawing.Point(6, 58);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(46, 30);
            this.firstNameLabel.TabIndex = 23;
            this.firstNameLabel.Text = "Ime";
            // 
            // teamMembersListBox
            // 
            this.teamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamMembersListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamMembersListBox.FormattingEnabled = true;
            this.teamMembersListBox.ItemHeight = 21;
            this.teamMembersListBox.Location = new System.Drawing.Point(406, 98);
            this.teamMembersListBox.Name = "teamMembersListBox";
            this.teamMembersListBox.Size = new System.Drawing.Size(287, 527);
            this.teamMembersListBox.TabIndex = 23;
            // 
            // deleteSelectedMemberButton
            // 
            this.deleteSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteSelectedMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.deleteSelectedMemberButton.Location = new System.Drawing.Point(733, 291);
            this.deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
            this.deleteSelectedMemberButton.Size = new System.Drawing.Size(111, 61);
            this.deleteSelectedMemberButton.TabIndex = 24;
            this.deleteSelectedMemberButton.Text = "Izbriši Odabrano";
            this.deleteSelectedMemberButton.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createTeamButton.Location = new System.Drawing.Point(323, 631);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(188, 53);
            this.createTeamButton.TabIndex = 27;
            this.createTeamButton.Text = "Izradi Tim";
            this.createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(865, 696);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.deleteSelectedMemberButton);
            this.Controls.Add(this.teamMembersListBox);
            this.Controls.Add(this.addNewMemberGroupBox);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.selectTeamMemberDropDown);
            this.Controls.Add(this.selectTeamMemberLabel);
            this.Controls.Add(this.teamNameValue);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.addNewMemberGroupBox.ResumeLayout(false);
            this.addNewMemberGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox teamNameValue;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.ComboBox selectTeamMemberDropDown;
        private System.Windows.Forms.Label selectTeamMemberLabel;
        private System.Windows.Forms.GroupBox addNewMemberGroupBox;
        private System.Windows.Forms.Button createMemberButton;
        private System.Windows.Forms.TextBox cellphoneValue;
        private System.Windows.Forms.Label cellphoneLabel;
        private System.Windows.Forms.TextBox emailValue;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox lastNameValue;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.ListBox teamMembersListBox;
        private System.Windows.Forms.Button deleteSelectedMemberButton;
        private System.Windows.Forms.Button createTeamButton;
    }
}
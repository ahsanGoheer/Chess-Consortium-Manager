namespace Chess_Consortium_Manager
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.selectAnOperationGb = new System.Windows.Forms.GroupBox();
            this.searchAPlayerLbl = new System.Windows.Forms.Label();
            this.viewAllPlayersLbl = new System.Windows.Forms.Label();
            this.assignOutcomeLbl = new System.Windows.Forms.Label();
            this.showAllTablesLbl = new System.Windows.Forms.Label();
            this.assignTableLbl = new System.Windows.Forms.Label();
            this.registerPlayerLbl = new System.Windows.Forms.Label();
            this.searchAPlayerBtn = new System.Windows.Forms.Button();
            this.viewPlayersBtn = new System.Windows.Forms.Button();
            this.assignOutcomeBtn = new System.Windows.Forms.Button();
            this.showAllTablesBtn = new System.Windows.Forms.Button();
            this.assignTableBtn = new System.Windows.Forms.Button();
            this.registerPlayerBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.PictureBox();
            this.selectAnOperationGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // selectAnOperationGb
            // 
            this.selectAnOperationGb.Controls.Add(this.searchAPlayerLbl);
            this.selectAnOperationGb.Controls.Add(this.viewAllPlayersLbl);
            this.selectAnOperationGb.Controls.Add(this.assignOutcomeLbl);
            this.selectAnOperationGb.Controls.Add(this.showAllTablesLbl);
            this.selectAnOperationGb.Controls.Add(this.assignTableLbl);
            this.selectAnOperationGb.Controls.Add(this.searchAPlayerBtn);
            this.selectAnOperationGb.Controls.Add(this.viewPlayersBtn);
            this.selectAnOperationGb.Controls.Add(this.assignOutcomeBtn);
            this.selectAnOperationGb.Controls.Add(this.showAllTablesBtn);
            this.selectAnOperationGb.Controls.Add(this.assignTableBtn);
            this.selectAnOperationGb.Controls.Add(this.registerPlayerLbl);
            this.selectAnOperationGb.Controls.Add(this.registerPlayerBtn);
            this.selectAnOperationGb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectAnOperationGb.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectAnOperationGb.ForeColor = System.Drawing.Color.PaleGreen;
            this.selectAnOperationGb.Location = new System.Drawing.Point(253, 109);
            this.selectAnOperationGb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectAnOperationGb.Name = "selectAnOperationGb";
            this.selectAnOperationGb.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectAnOperationGb.Size = new System.Drawing.Size(848, 499);
            this.selectAnOperationGb.TabIndex = 0;
            this.selectAnOperationGb.TabStop = false;
            this.selectAnOperationGb.Text = "Select an Operation";
            // 
            // searchAPlayerLbl
            // 
            this.searchAPlayerLbl.AutoSize = true;
            this.searchAPlayerLbl.Location = new System.Drawing.Point(647, 249);
            this.searchAPlayerLbl.Name = "searchAPlayerLbl";
            this.searchAPlayerLbl.Size = new System.Drawing.Size(141, 25);
            this.searchAPlayerLbl.TabIndex = 11;
            this.searchAPlayerLbl.Text = "Search a Player";
            this.searchAPlayerLbl.Click += new System.EventHandler(this.SearchAPlayerLbl_Click);
            // 
            // viewAllPlayersLbl
            // 
            this.viewAllPlayersLbl.AutoSize = true;
            this.viewAllPlayersLbl.Location = new System.Drawing.Point(642, 390);
            this.viewAllPlayersLbl.Name = "viewAllPlayersLbl";
            this.viewAllPlayersLbl.Size = new System.Drawing.Size(143, 25);
            this.viewAllPlayersLbl.TabIndex = 10;
            this.viewAllPlayersLbl.Text = "View all Players";
            // 
            // assignOutcomeLbl
            // 
            this.assignOutcomeLbl.AutoSize = true;
            this.assignOutcomeLbl.Location = new System.Drawing.Point(275, 359);
            this.assignOutcomeLbl.Name = "assignOutcomeLbl";
            this.assignOutcomeLbl.Size = new System.Drawing.Size(149, 25);
            this.assignOutcomeLbl.TabIndex = 9;
            this.assignOutcomeLbl.Text = "Assign Outcome";
            // 
            // showAllTablesLbl
            // 
            this.showAllTablesLbl.AutoSize = true;
            this.showAllTablesLbl.Location = new System.Drawing.Point(51, 359);
            this.showAllTablesLbl.Name = "showAllTablesLbl";
            this.showAllTablesLbl.Size = new System.Drawing.Size(140, 25);
            this.showAllTablesLbl.TabIndex = 8;
            this.showAllTablesLbl.Text = "Show all Tables";
            // 
            // assignTableLbl
            // 
            this.assignTableLbl.AutoSize = true;
            this.assignTableLbl.Location = new System.Drawing.Point(280, 186);
            this.assignTableLbl.Name = "assignTableLbl";
            this.assignTableLbl.Size = new System.Drawing.Size(131, 25);
            this.assignTableLbl.TabIndex = 7;
            this.assignTableLbl.Text = "Assign a Table";
            // 
            // registerPlayerLbl
            // 
            this.registerPlayerLbl.AutoSize = true;
            this.registerPlayerLbl.Location = new System.Drawing.Point(48, 186);
            this.registerPlayerLbl.Name = "registerPlayerLbl";
            this.registerPlayerLbl.Size = new System.Drawing.Size(151, 25);
            this.registerPlayerLbl.TabIndex = 1;
            this.registerPlayerLbl.Text = "Register a Player";
            // 
            // searchAPlayerBtn
            // 
            this.searchAPlayerBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchAPlayerBtn.BackgroundImage = global::Chess_Consortium_Manager.Properties.Resources.Magnifying_Glass_512;
            this.searchAPlayerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchAPlayerBtn.Location = new System.Drawing.Point(639, 136);
            this.searchAPlayerBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchAPlayerBtn.Name = "searchAPlayerBtn";
            this.searchAPlayerBtn.Size = new System.Drawing.Size(109, 96);
            this.searchAPlayerBtn.TabIndex = 6;
            this.searchAPlayerBtn.UseVisualStyleBackColor = false;
            this.searchAPlayerBtn.Click += new System.EventHandler(this.SearchAPlayerBtn_Click);
            // 
            // viewPlayersBtn
            // 
            this.viewPlayersBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewPlayersBtn.BackgroundImage = global::Chess_Consortium_Manager.Properties.Resources._1_sport_team_game_players_sport_512;
            this.viewPlayersBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.viewPlayersBtn.Location = new System.Drawing.Point(639, 282);
            this.viewPlayersBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewPlayersBtn.Name = "viewPlayersBtn";
            this.viewPlayersBtn.Size = new System.Drawing.Size(109, 96);
            this.viewPlayersBtn.TabIndex = 5;
            this.viewPlayersBtn.UseVisualStyleBackColor = false;
            this.viewPlayersBtn.Click += new System.EventHandler(this.ViewPlayersBtn_Click);
            // 
            // assignOutcomeBtn
            // 
            this.assignOutcomeBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.assignOutcomeBtn.BackgroundImage = global::Chess_Consortium_Manager.Properties.Resources._Star_Trophy_512;
            this.assignOutcomeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.assignOutcomeBtn.Location = new System.Drawing.Point(275, 249);
            this.assignOutcomeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.assignOutcomeBtn.Name = "assignOutcomeBtn";
            this.assignOutcomeBtn.Size = new System.Drawing.Size(109, 96);
            this.assignOutcomeBtn.TabIndex = 4;
            this.assignOutcomeBtn.UseVisualStyleBackColor = false;
            this.assignOutcomeBtn.Click += new System.EventHandler(this.AssignOutcomeBtn_Click);
            // 
            // showAllTablesBtn
            // 
            this.showAllTablesBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.showAllTablesBtn.BackgroundImage = global::Chess_Consortium_Manager.Properties.Resources.People_01_2_512;
            this.showAllTablesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showAllTablesBtn.Location = new System.Drawing.Point(48, 249);
            this.showAllTablesBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showAllTablesBtn.Name = "showAllTablesBtn";
            this.showAllTablesBtn.Size = new System.Drawing.Size(109, 96);
            this.showAllTablesBtn.TabIndex = 3;
            this.showAllTablesBtn.UseVisualStyleBackColor = false;
            this.showAllTablesBtn.Click += new System.EventHandler(this.ShowAllTablesBtn_Click);
            // 
            // assignTableBtn
            // 
            this.assignTableBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.assignTableBtn.BackgroundImage = global::Chess_Consortium_Manager.Properties.Resources.Table_02;
            this.assignTableBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.assignTableBtn.Location = new System.Drawing.Point(226, 75);
            this.assignTableBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.assignTableBtn.Name = "assignTableBtn";
            this.assignTableBtn.Size = new System.Drawing.Size(186, 96);
            this.assignTableBtn.TabIndex = 2;
            this.assignTableBtn.UseVisualStyleBackColor = false;
            this.assignTableBtn.Click += new System.EventHandler(this.assignTableBtn_Click);
            // 
            // registerPlayerBtn
            // 
            this.registerPlayerBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.registerPlayerBtn.BackgroundImage = global::Chess_Consortium_Manager.Properties.Resources.male_shadow_circle_512;
            this.registerPlayerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.registerPlayerBtn.Location = new System.Drawing.Point(65, 62);
            this.registerPlayerBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerPlayerBtn.Name = "registerPlayerBtn";
            this.registerPlayerBtn.Size = new System.Drawing.Size(109, 96);
            this.registerPlayerBtn.TabIndex = 0;
            this.registerPlayerBtn.UseVisualStyleBackColor = false;
            this.registerPlayerBtn.Click += new System.EventHandler(this.registerPlayerBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.exitBtn.Image = global::Chess_Consortium_Manager.Properties.Resources.icons8_close_window_80;
            this.exitBtn.Location = new System.Drawing.Point(1062, 12);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(39, 39);
            this.exitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitBtn.TabIndex = 2;
            this.exitBtn.TabStop = false;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            this.exitBtn.MouseEnter += new System.EventHandler(this.ExitBtn_MouseEnter);
            this.exitBtn.MouseLeave += new System.EventHandler(this.ExitBtn_MouseLeave);
            // 
            // mainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1123, 622);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.selectAnOperationGb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.Text = "Chess Consortium Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.selectAnOperationGb.ResumeLayout(false);
            this.selectAnOperationGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox selectAnOperationGb;
        private System.Windows.Forms.Button registerPlayerBtn;
        private System.Windows.Forms.Button searchAPlayerBtn;
        private System.Windows.Forms.Button viewPlayersBtn;
        private System.Windows.Forms.Button assignOutcomeBtn;
        private System.Windows.Forms.Button showAllTablesBtn;
        private System.Windows.Forms.Button assignTableBtn;
        private System.Windows.Forms.Label registerPlayerLbl;
        private System.Windows.Forms.Label assignTableLbl;
        private System.Windows.Forms.Label showAllTablesLbl;
        private System.Windows.Forms.Label assignOutcomeLbl;
        private System.Windows.Forms.Label viewAllPlayersLbl;
        private System.Windows.Forms.Label searchAPlayerLbl;
        private System.Windows.Forms.PictureBox exitBtn;
    }
}


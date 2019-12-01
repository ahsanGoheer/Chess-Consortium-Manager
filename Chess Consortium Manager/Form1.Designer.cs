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
            this.operationsPanel = new System.Windows.Forms.Panel();
            this.searchAPlayerLbl = new System.Windows.Forms.Label();
            this.viewAllPlayersLbl = new System.Windows.Forms.Label();
            this.assignOutcomeLbl = new System.Windows.Forms.Label();
            this.showAllTablesLbl = new System.Windows.Forms.Label();
            this.assignTableLbl = new System.Windows.Forms.Label();
            this.registerPlayerLbl = new System.Windows.Forms.Label();
            this.Nextbtn = new System.Windows.Forms.PictureBox();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.searchAPlayerBtn = new System.Windows.Forms.Button();
            this.viewPlayersBtn = new System.Windows.Forms.Button();
            this.assignOutcomeBtn = new System.Windows.Forms.Button();
            this.showAllTablesBtn = new System.Windows.Forms.Button();
            this.assignTableBtn = new System.Windows.Forms.Button();
            this.registerPlayerBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.PictureBox();
            this.operationsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nextbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // operationsPanel
            // 
            this.operationsPanel.BackColor = System.Drawing.Color.GhostWhite;
            this.operationsPanel.Controls.Add(this.searchAPlayerLbl);
            this.operationsPanel.Controls.Add(this.viewAllPlayersLbl);
            this.operationsPanel.Controls.Add(this.assignOutcomeLbl);
            this.operationsPanel.Controls.Add(this.showAllTablesLbl);
            this.operationsPanel.Controls.Add(this.assignTableLbl);
            this.operationsPanel.Controls.Add(this.searchAPlayerBtn);
            this.operationsPanel.Controls.Add(this.viewPlayersBtn);
            this.operationsPanel.Controls.Add(this.assignOutcomeBtn);
            this.operationsPanel.Controls.Add(this.showAllTablesBtn);
            this.operationsPanel.Controls.Add(this.assignTableBtn);
            this.operationsPanel.Controls.Add(this.registerPlayerLbl);
            this.operationsPanel.Controls.Add(this.registerPlayerBtn);
            this.operationsPanel.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationsPanel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.operationsPanel.Location = new System.Drawing.Point(176, 43);
            this.operationsPanel.Name = "operationsPanel";
            this.operationsPanel.Size = new System.Drawing.Size(864, 574);
            this.operationsPanel.TabIndex = 3;
            this.operationsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OperationsPanel_Paint);
            // 
            // searchAPlayerLbl
            // 
            this.searchAPlayerLbl.AutoSize = true;
            this.searchAPlayerLbl.Location = new System.Drawing.Point(661, 245);
            this.searchAPlayerLbl.Name = "searchAPlayerLbl";
            this.searchAPlayerLbl.Size = new System.Drawing.Size(143, 26);
            this.searchAPlayerLbl.TabIndex = 23;
            this.searchAPlayerLbl.Text = "Search a Player";
            // 
            // viewAllPlayersLbl
            // 
            this.viewAllPlayersLbl.AutoSize = true;
            this.viewAllPlayersLbl.Location = new System.Drawing.Point(650, 535);
            this.viewAllPlayersLbl.Name = "viewAllPlayersLbl";
            this.viewAllPlayersLbl.Size = new System.Drawing.Size(145, 26);
            this.viewAllPlayersLbl.TabIndex = 22;
            this.viewAllPlayersLbl.Text = "View all Players";
            // 
            // assignOutcomeLbl
            // 
            this.assignOutcomeLbl.AutoSize = true;
            this.assignOutcomeLbl.Location = new System.Drawing.Point(360, 535);
            this.assignOutcomeLbl.Name = "assignOutcomeLbl";
            this.assignOutcomeLbl.Size = new System.Drawing.Size(151, 26);
            this.assignOutcomeLbl.TabIndex = 21;
            this.assignOutcomeLbl.Text = "Assign Outcome";
            // 
            // showAllTablesLbl
            // 
            this.showAllTablesLbl.AutoSize = true;
            this.showAllTablesLbl.Location = new System.Drawing.Point(70, 535);
            this.showAllTablesLbl.Name = "showAllTablesLbl";
            this.showAllTablesLbl.Size = new System.Drawing.Size(142, 26);
            this.showAllTablesLbl.TabIndex = 20;
            this.showAllTablesLbl.Text = "Show all Tables";
            // 
            // assignTableLbl
            // 
            this.assignTableLbl.AutoSize = true;
            this.assignTableLbl.Location = new System.Drawing.Point(369, 245);
            this.assignTableLbl.Name = "assignTableLbl";
            this.assignTableLbl.Size = new System.Drawing.Size(131, 26);
            this.assignTableLbl.TabIndex = 19;
            this.assignTableLbl.Text = "Assign a Table";
            // 
            // registerPlayerLbl
            // 
            this.registerPlayerLbl.AutoSize = true;
            this.registerPlayerLbl.Location = new System.Drawing.Point(58, 245);
            this.registerPlayerLbl.Name = "registerPlayerLbl";
            this.registerPlayerLbl.Size = new System.Drawing.Size(154, 26);
            this.registerPlayerLbl.TabIndex = 13;
            this.registerPlayerLbl.Text = "Register a Player";
            // 
            // Nextbtn
            // 
            this.Nextbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Nextbtn.Image = global::Chess_Consortium_Manager.Properties.Resources.right_arrow;
            this.Nextbtn.Location = new System.Drawing.Point(1070, 250);
            this.Nextbtn.Name = "Nextbtn";
            this.Nextbtn.Size = new System.Drawing.Size(79, 78);
            this.Nextbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Nextbtn.TabIndex = 5;
            this.Nextbtn.TabStop = false;
            this.Nextbtn.Click += new System.EventHandler(this.Nextbtn_Click);
            this.Nextbtn.MouseEnter += new System.EventHandler(this.Nextbtn_MouseEnter);
            this.Nextbtn.MouseLeave += new System.EventHandler(this.Nextbtn_MouseLeave);
            // 
            // LogoBox
            // 
            this.LogoBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LogoBox.Image = global::Chess_Consortium_Manager.Properties.Resources.icons8_knight_512;
            this.LogoBox.Location = new System.Drawing.Point(12, 12);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(79, 78);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoBox.TabIndex = 4;
            this.LogoBox.TabStop = false;
            this.LogoBox.Click += new System.EventHandler(this.LogoBox_Click);
            // 
            // searchAPlayerBtn
            // 
            this.searchAPlayerBtn.BackColor = System.Drawing.Color.FloralWhite;
            this.searchAPlayerBtn.BackgroundImage = global::Chess_Consortium_Manager.Properties.Resources.icons8_search_property_80;
            this.searchAPlayerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.searchAPlayerBtn.FlatAppearance.BorderSize = 3;
            this.searchAPlayerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchAPlayerBtn.Location = new System.Drawing.Point(632, 20);
            this.searchAPlayerBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchAPlayerBtn.Name = "searchAPlayerBtn";
            this.searchAPlayerBtn.Size = new System.Drawing.Size(186, 213);
            this.searchAPlayerBtn.TabIndex = 18;
            this.searchAPlayerBtn.UseVisualStyleBackColor = false;
            this.searchAPlayerBtn.Click += new System.EventHandler(this.SearchAPlayerBtn_Click_1);
            // 
            // viewPlayersBtn
            // 
            this.viewPlayersBtn.BackColor = System.Drawing.Color.FloralWhite;
            this.viewPlayersBtn.BackgroundImage = global::Chess_Consortium_Manager.Properties.Resources.icons8_people_50;
            this.viewPlayersBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.viewPlayersBtn.FlatAppearance.BorderSize = 3;
            this.viewPlayersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewPlayersBtn.Location = new System.Drawing.Point(632, 309);
            this.viewPlayersBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewPlayersBtn.Name = "viewPlayersBtn";
            this.viewPlayersBtn.Size = new System.Drawing.Size(186, 213);
            this.viewPlayersBtn.TabIndex = 17;
            this.viewPlayersBtn.UseVisualStyleBackColor = false;
            this.viewPlayersBtn.Click += new System.EventHandler(this.ViewPlayersBtn_Click_1);
            // 
            // assignOutcomeBtn
            // 
            this.assignOutcomeBtn.BackColor = System.Drawing.Color.FloralWhite;
            this.assignOutcomeBtn.BackgroundImage = global::Chess_Consortium_Manager.Properties.Resources.icons8_trophy_80;
            this.assignOutcomeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.assignOutcomeBtn.FlatAppearance.BorderSize = 3;
            this.assignOutcomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assignOutcomeBtn.Location = new System.Drawing.Point(339, 309);
            this.assignOutcomeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.assignOutcomeBtn.Name = "assignOutcomeBtn";
            this.assignOutcomeBtn.Size = new System.Drawing.Size(186, 213);
            this.assignOutcomeBtn.TabIndex = 16;
            this.assignOutcomeBtn.UseVisualStyleBackColor = false;
            this.assignOutcomeBtn.Click += new System.EventHandler(this.AssignOutcomeBtn_Click_1);
            // 
            // showAllTablesBtn
            // 
            this.showAllTablesBtn.BackColor = System.Drawing.Color.FloralWhite;
            this.showAllTablesBtn.BackgroundImage = global::Chess_Consortium_Manager.Properties.Resources.icons8_table_64;
            this.showAllTablesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.showAllTablesBtn.FlatAppearance.BorderSize = 3;
            this.showAllTablesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAllTablesBtn.Location = new System.Drawing.Point(43, 309);
            this.showAllTablesBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showAllTablesBtn.Name = "showAllTablesBtn";
            this.showAllTablesBtn.Size = new System.Drawing.Size(186, 213);
            this.showAllTablesBtn.TabIndex = 15;
            this.showAllTablesBtn.UseVisualStyleBackColor = false;
            this.showAllTablesBtn.Click += new System.EventHandler(this.ShowAllTablesBtn_Click_1);
            // 
            // assignTableBtn
            // 
            this.assignTableBtn.BackColor = System.Drawing.Color.FloralWhite;
            this.assignTableBtn.BackgroundImage = global::Chess_Consortium_Manager.Properties.Resources.icons8_restaurant_table_64;
            this.assignTableBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.assignTableBtn.FlatAppearance.BorderSize = 3;
            this.assignTableBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assignTableBtn.Location = new System.Drawing.Point(339, 20);
            this.assignTableBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.assignTableBtn.Name = "assignTableBtn";
            this.assignTableBtn.Size = new System.Drawing.Size(186, 213);
            this.assignTableBtn.TabIndex = 14;
            this.assignTableBtn.UseVisualStyleBackColor = false;
            this.assignTableBtn.Click += new System.EventHandler(this.AssignTableBtn_Click_1);
            // 
            // registerPlayerBtn
            // 
            this.registerPlayerBtn.BackColor = System.Drawing.Color.FloralWhite;
            this.registerPlayerBtn.BackgroundImage = global::Chess_Consortium_Manager.Properties.Resources.icons8_add_user_group_woman_man_80;
            this.registerPlayerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.registerPlayerBtn.FlatAppearance.BorderSize = 3;
            this.registerPlayerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerPlayerBtn.Location = new System.Drawing.Point(43, 20);
            this.registerPlayerBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerPlayerBtn.Name = "registerPlayerBtn";
            this.registerPlayerBtn.Size = new System.Drawing.Size(186, 213);
            this.registerPlayerBtn.TabIndex = 12;
            this.registerPlayerBtn.UseVisualStyleBackColor = false;
            this.registerPlayerBtn.Click += new System.EventHandler(this.RegisterPlayerBtn_Click_1);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.exitBtn.Image = global::Chess_Consortium_Manager.Properties.Resources.icons8_close_window_80;
            this.exitBtn.Location = new System.Drawing.Point(1134, 1);
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
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1175, 661);
            this.Controls.Add(this.Nextbtn);
            this.Controls.Add(this.LogoBox);
            this.Controls.Add(this.operationsPanel);
            this.Controls.Add(this.exitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.Text = "Chess Consortium Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.operationsPanel.ResumeLayout(false);
            this.operationsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nextbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox exitBtn;
        private System.Windows.Forms.Panel operationsPanel;
        private System.Windows.Forms.Label searchAPlayerLbl;
        private System.Windows.Forms.Label viewAllPlayersLbl;
        private System.Windows.Forms.Label assignOutcomeLbl;
        private System.Windows.Forms.Label showAllTablesLbl;
        private System.Windows.Forms.Label assignTableLbl;
        private System.Windows.Forms.Button searchAPlayerBtn;
        private System.Windows.Forms.Button viewPlayersBtn;
        private System.Windows.Forms.Button assignOutcomeBtn;
        private System.Windows.Forms.Button showAllTablesBtn;
        private System.Windows.Forms.Button assignTableBtn;
        private System.Windows.Forms.Label registerPlayerLbl;
        private System.Windows.Forms.Button registerPlayerBtn;
        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.PictureBox Nextbtn;
    }
}


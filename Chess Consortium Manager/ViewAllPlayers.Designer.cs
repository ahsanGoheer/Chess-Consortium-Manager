namespace Chess_Consortium_Manager
{
    partial class ViewAllPlayers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllPlayers));
            this.playerDataGB = new System.Windows.Forms.GroupBox();
            this.playersRtb = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.registeredPlayersLbl = new System.Windows.Forms.Label();
            this.registeredPlayersListBox = new System.Windows.Forms.ListBox();
            this.showAllPlayersBtn = new System.Windows.Forms.Button();
            this.topTenListBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.PictureBox();
            this.homeBtn = new System.Windows.Forms.PictureBox();
            this.playerDataGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // playerDataGB
            // 
            this.playerDataGB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.playerDataGB.Controls.Add(this.playersRtb);
            this.playerDataGB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerDataGB.Location = new System.Drawing.Point(358, 69);
            this.playerDataGB.Margin = new System.Windows.Forms.Padding(2);
            this.playerDataGB.Name = "playerDataGB";
            this.playerDataGB.Padding = new System.Windows.Forms.Padding(2);
            this.playerDataGB.Size = new System.Drawing.Size(503, 419);
            this.playerDataGB.TabIndex = 0;
            this.playerDataGB.TabStop = false;
            this.playerDataGB.Text = "Player Data";
            // 
            // playersRtb
            // 
            this.playersRtb.BackColor = System.Drawing.Color.FloralWhite;
            this.playersRtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playersRtb.Location = new System.Drawing.Point(2, 21);
            this.playersRtb.Margin = new System.Windows.Forms.Padding(2);
            this.playersRtb.Name = "playersRtb";
            this.playersRtb.ReadOnly = true;
            this.playersRtb.Size = new System.Drawing.Size(499, 396);
            this.playersRtb.TabIndex = 0;
            this.playersRtb.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(393, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 33);
            this.label2.TabIndex = 15;
            this.label2.Text = "Players";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InfoText;
            this.label3.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(94, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 17;
            // 
            // registeredPlayersLbl
            // 
            this.registeredPlayersLbl.AutoSize = true;
            this.registeredPlayersLbl.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registeredPlayersLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.registeredPlayersLbl.Location = new System.Drawing.Point(108, 69);
            this.registeredPlayersLbl.Name = "registeredPlayersLbl";
            this.registeredPlayersLbl.Size = new System.Drawing.Size(132, 19);
            this.registeredPlayersLbl.TabIndex = 18;
            this.registeredPlayersLbl.Text = "Registered Players";
            // 
            // registeredPlayersListBox
            // 
            this.registeredPlayersListBox.BackColor = System.Drawing.Color.FloralWhite;
            this.registeredPlayersListBox.FormattingEnabled = true;
            this.registeredPlayersListBox.Location = new System.Drawing.Point(24, 96);
            this.registeredPlayersListBox.Name = "registeredPlayersListBox";
            this.registeredPlayersListBox.Size = new System.Drawing.Size(311, 329);
            this.registeredPlayersListBox.TabIndex = 19;
            // 
            // showAllPlayersBtn
            // 
            this.showAllPlayersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAllPlayersBtn.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllPlayersBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.showAllPlayersBtn.Location = new System.Drawing.Point(24, 450);
            this.showAllPlayersBtn.Name = "showAllPlayersBtn";
            this.showAllPlayersBtn.Size = new System.Drawing.Size(148, 36);
            this.showAllPlayersBtn.TabIndex = 20;
            this.showAllPlayersBtn.Text = "Show All Players";
            this.showAllPlayersBtn.UseVisualStyleBackColor = true;
            this.showAllPlayersBtn.Click += new System.EventHandler(this.ShowAllPlayersBtn_Click);
            // 
            // topTenListBtn
            // 
            this.topTenListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topTenListBtn.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topTenListBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.topTenListBtn.Location = new System.Drawing.Point(187, 450);
            this.topTenListBtn.Name = "topTenListBtn";
            this.topTenListBtn.Size = new System.Drawing.Size(148, 36);
            this.topTenListBtn.TabIndex = 21;
            this.topTenListBtn.Text = "Top 10 Players";
            this.topTenListBtn.UseVisualStyleBackColor = true;
            this.topTenListBtn.Click += new System.EventHandler(this.TopTenListBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.exitBtn.Image = global::Chess_Consortium_Manager.Properties.Resources.icons8_close_window_80;
            this.exitBtn.Location = new System.Drawing.Point(852, 12);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(39, 39);
            this.exitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitBtn.TabIndex = 13;
            this.exitBtn.TabStop = false;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.homeBtn.Image = global::Chess_Consortium_Manager.Properties.Resources.icons8_home_801;
            this.homeBtn.Location = new System.Drawing.Point(12, 12);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(46, 37);
            this.homeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homeBtn.TabIndex = 12;
            this.homeBtn.TabStop = false;
            this.homeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // ViewAllPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(903, 621);
            this.Controls.Add(this.topTenListBtn);
            this.Controls.Add(this.showAllPlayersBtn);
            this.Controls.Add(this.registeredPlayersListBox);
            this.Controls.Add(this.registeredPlayersLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.playerDataGB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewAllPlayers";
            this.Text = "View all Players";
            this.Load += new System.EventHandler(this.ViewAllPlayers_Load);
            this.playerDataGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox playerDataGB;
        private System.Windows.Forms.RichTextBox playersRtb;
        private System.Windows.Forms.PictureBox homeBtn;
        private System.Windows.Forms.PictureBox exitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label registeredPlayersLbl;
        private System.Windows.Forms.ListBox registeredPlayersListBox;
        private System.Windows.Forms.Button showAllPlayersBtn;
        private System.Windows.Forms.Button topTenListBtn;
    }
}
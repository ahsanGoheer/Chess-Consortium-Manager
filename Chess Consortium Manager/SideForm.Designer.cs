namespace Chess_Consortium_Manager
{
    partial class SideForm
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
            this.operationsPanel = new System.Windows.Forms.Panel();
            this.registerPlayerLbl = new System.Windows.Forms.Label();
            this.showGamesBtn = new System.Windows.Forms.Button();
            this.Prevbtn = new System.Windows.Forms.PictureBox();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.exitBtn = new System.Windows.Forms.PictureBox();
            this.operationsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Prevbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // operationsPanel
            // 
            this.operationsPanel.BackColor = System.Drawing.Color.GhostWhite;
            this.operationsPanel.Controls.Add(this.registerPlayerLbl);
            this.operationsPanel.Controls.Add(this.showGamesBtn);
            this.operationsPanel.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationsPanel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.operationsPanel.Location = new System.Drawing.Point(166, 26);
            this.operationsPanel.Name = "operationsPanel";
            this.operationsPanel.Size = new System.Drawing.Size(864, 574);
            this.operationsPanel.TabIndex = 7;
            // 
            // registerPlayerLbl
            // 
            this.registerPlayerLbl.AutoSize = true;
            this.registerPlayerLbl.Location = new System.Drawing.Point(73, 245);
            this.registerPlayerLbl.Name = "registerPlayerLbl";
            this.registerPlayerLbl.Size = new System.Drawing.Size(123, 26);
            this.registerPlayerLbl.TabIndex = 13;
            this.registerPlayerLbl.Text = "Show Games";
            // 
            // showGamesBtn
            // 
            this.showGamesBtn.BackColor = System.Drawing.Color.FloralWhite;
            this.showGamesBtn.BackgroundImage = global::Chess_Consortium_Manager.Properties.Resources.chess_board;
            this.showGamesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showGamesBtn.FlatAppearance.BorderSize = 3;
            this.showGamesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showGamesBtn.Location = new System.Drawing.Point(43, 20);
            this.showGamesBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showGamesBtn.Name = "showGamesBtn";
            this.showGamesBtn.Size = new System.Drawing.Size(186, 213);
            this.showGamesBtn.TabIndex = 12;
            this.showGamesBtn.UseVisualStyleBackColor = false;
            this.showGamesBtn.Click += new System.EventHandler(this.ShowGamesBtn_Click);
            // 
            // Prevbtn
            // 
            this.Prevbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Prevbtn.Image = global::Chess_Consortium_Manager.Properties.Resources.left_arrow;
            this.Prevbtn.Location = new System.Drawing.Point(12, 229);
            this.Prevbtn.Name = "Prevbtn";
            this.Prevbtn.Size = new System.Drawing.Size(79, 78);
            this.Prevbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Prevbtn.TabIndex = 9;
            this.Prevbtn.TabStop = false;
            this.Prevbtn.Click += new System.EventHandler(this.Prevbtn_Click);
            this.Prevbtn.MouseEnter += new System.EventHandler(this.Prevbtn_MouseEnter);
            this.Prevbtn.MouseLeave += new System.EventHandler(this.Prevbtn_MouseLeave);
            // 
            // LogoBox
            // 
            this.LogoBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LogoBox.Image = global::Chess_Consortium_Manager.Properties.Resources.icons8_knight_512;
            this.LogoBox.Location = new System.Drawing.Point(12, 12);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(79, 78);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoBox.TabIndex = 8;
            this.LogoBox.TabStop = false;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.exitBtn.Image = global::Chess_Consortium_Manager.Properties.Resources.icons8_close_window_80;
            this.exitBtn.Location = new System.Drawing.Point(1117, 3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(39, 39);
            this.exitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitBtn.TabIndex = 6;
            this.exitBtn.TabStop = false;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            this.exitBtn.MouseEnter += new System.EventHandler(this.ExitBtn_MouseEnter);
            this.exitBtn.MouseLeave += new System.EventHandler(this.ExitBtn_MouseLeave);
            // 
            // SideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(1159, 622);
            this.Controls.Add(this.Prevbtn);
            this.Controls.Add(this.LogoBox);
            this.Controls.Add(this.operationsPanel);
            this.Controls.Add(this.exitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SideForm";
            this.Text = "SideForm";
            this.operationsPanel.ResumeLayout(false);
            this.operationsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Prevbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Prevbtn;
        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.Panel operationsPanel;
        private System.Windows.Forms.Label registerPlayerLbl;
        private System.Windows.Forms.Button showGamesBtn;
        private System.Windows.Forms.PictureBox exitBtn;
    }
}
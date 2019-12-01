namespace Chess_Consortium_Manager
{
    partial class RegisterPlayer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterPlayer));
            this.enterPlayerDetailsGb = new System.Windows.Forms.GroupBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.playerCnicTb = new System.Windows.Forms.TextBox();
            this.playerNameTb = new System.Windows.Forms.TextBox();
            this.playerCnicLbl = new System.Windows.Forms.Label();
            this.playerNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.homeBtn = new System.Windows.Forms.PictureBox();
            this.exitBtn = new System.Windows.Forms.PictureBox();
            this.playerLogoPb = new System.Windows.Forms.PictureBox();
            this.enterPlayerDetailsGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerLogoPb)).BeginInit();
            this.SuspendLayout();
            // 
            // enterPlayerDetailsGb
            // 
            this.enterPlayerDetailsGb.BackColor = System.Drawing.Color.GhostWhite;
            this.enterPlayerDetailsGb.Controls.Add(this.registerBtn);
            this.enterPlayerDetailsGb.Controls.Add(this.playerCnicTb);
            this.enterPlayerDetailsGb.Controls.Add(this.playerNameTb);
            this.enterPlayerDetailsGb.Controls.Add(this.playerLogoPb);
            this.enterPlayerDetailsGb.Controls.Add(this.playerCnicLbl);
            this.enterPlayerDetailsGb.Controls.Add(this.playerNameLbl);
            this.enterPlayerDetailsGb.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterPlayerDetailsGb.Location = new System.Drawing.Point(72, 88);
            this.enterPlayerDetailsGb.Name = "enterPlayerDetailsGb";
            this.enterPlayerDetailsGb.Size = new System.Drawing.Size(717, 350);
            this.enterPlayerDetailsGb.TabIndex = 0;
            this.enterPlayerDetailsGb.TabStop = false;
            this.enterPlayerDetailsGb.Text = "Enter Player Details";
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.FloralWhite;
            this.registerBtn.FlatAppearance.BorderSize = 2;
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBtn.Location = new System.Drawing.Point(286, 249);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(237, 62);
            this.registerBtn.TabIndex = 5;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            this.registerBtn.MouseEnter += new System.EventHandler(this.registerBtn_MouseEnter);
            this.registerBtn.MouseLeave += new System.EventHandler(this.registerBtn_MouseLeave);
            // 
            // playerCnicTb
            // 
            this.playerCnicTb.BackColor = System.Drawing.Color.FloralWhite;
            this.playerCnicTb.Location = new System.Drawing.Point(371, 150);
            this.playerCnicTb.Name = "playerCnicTb";
            this.playerCnicTb.Size = new System.Drawing.Size(266, 33);
            this.playerCnicTb.TabIndex = 4;
            // 
            // playerNameTb
            // 
            this.playerNameTb.BackColor = System.Drawing.Color.FloralWhite;
            this.playerNameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerNameTb.Location = new System.Drawing.Point(371, 61);
            this.playerNameTb.Name = "playerNameTb";
            this.playerNameTb.Size = new System.Drawing.Size(266, 33);
            this.playerNameTb.TabIndex = 3;
            // 
            // playerCnicLbl
            // 
            this.playerCnicLbl.AutoSize = true;
            this.playerCnicLbl.Location = new System.Drawing.Point(181, 157);
            this.playerCnicLbl.Name = "playerCnicLbl";
            this.playerCnicLbl.Size = new System.Drawing.Size(131, 26);
            this.playerCnicLbl.TabIndex = 1;
            this.playerCnicLbl.Text = "Player CNIC  : ";
            // 
            // playerNameLbl
            // 
            this.playerNameLbl.AutoSize = true;
            this.playerNameLbl.Location = new System.Drawing.Point(180, 64);
            this.playerNameLbl.Name = "playerNameLbl";
            this.playerNameLbl.Size = new System.Drawing.Size(132, 26);
            this.playerNameLbl.TabIndex = 0;
            this.playerNameLbl.Text = "Player Name :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider2.ContainerControl = this;
            this.errorProvider2.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider2.Icon")));
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.homeBtn.Image = global::Chess_Consortium_Manager.Properties.Resources.icons8_home_801;
            this.homeBtn.Location = new System.Drawing.Point(12, 12);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(46, 37);
            this.homeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homeBtn.TabIndex = 7;
            this.homeBtn.TabStop = false;
            this.homeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.exitBtn.Image = global::Chess_Consortium_Manager.Properties.Resources.icons8_close_window_80;
            this.exitBtn.Location = new System.Drawing.Point(808, 10);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(39, 39);
            this.exitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitBtn.TabIndex = 6;
            this.exitBtn.TabStop = false;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // playerLogoPb
            // 
            this.playerLogoPb.BackColor = System.Drawing.Color.FloralWhite;
            this.playerLogoPb.BackgroundImage = global::Chess_Consortium_Manager.Properties.Resources.iconfinder_user_add_216490;
            this.playerLogoPb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playerLogoPb.Location = new System.Drawing.Point(22, 46);
            this.playerLogoPb.Name = "playerLogoPb";
            this.playerLogoPb.Size = new System.Drawing.Size(153, 252);
            this.playerLogoPb.TabIndex = 2;
            this.playerLogoPb.TabStop = false;
            // 
            // RegisterPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(859, 477);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.enterPlayerDetailsGb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterPlayer";
            this.Text = "Register a Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterPlayer_FormClosing);
            
            this.enterPlayerDetailsGb.ResumeLayout(false);
            this.enterPlayerDetailsGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerLogoPb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox enterPlayerDetailsGb;
        private System.Windows.Forms.PictureBox playerLogoPb;
        private System.Windows.Forms.Label playerCnicLbl;
        private System.Windows.Forms.Label playerNameLbl;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.TextBox playerCnicTb;
        private System.Windows.Forms.TextBox playerNameTb;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.PictureBox exitBtn;
        private System.Windows.Forms.PictureBox homeBtn;
    }
}
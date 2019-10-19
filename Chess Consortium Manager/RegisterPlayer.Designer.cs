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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterPlayer));
            this.enterPlayerDetailsGb = new System.Windows.Forms.GroupBox();
            this.playerNameLbl = new System.Windows.Forms.Label();
            this.playerCnicLbl = new System.Windows.Forms.Label();
            this.playerLogoPb = new System.Windows.Forms.PictureBox();
            this.playerNameTb = new System.Windows.Forms.TextBox();
            this.playerCnicTb = new System.Windows.Forms.TextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.enterPlayerDetailsGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerLogoPb)).BeginInit();
            this.SuspendLayout();
            // 
            // enterPlayerDetailsGb
            // 
            this.enterPlayerDetailsGb.Controls.Add(this.registerBtn);
            this.enterPlayerDetailsGb.Controls.Add(this.playerCnicTb);
            this.enterPlayerDetailsGb.Controls.Add(this.playerNameTb);
            this.enterPlayerDetailsGb.Controls.Add(this.playerLogoPb);
            this.enterPlayerDetailsGb.Controls.Add(this.playerCnicLbl);
            this.enterPlayerDetailsGb.Controls.Add(this.playerNameLbl);
            this.enterPlayerDetailsGb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterPlayerDetailsGb.Location = new System.Drawing.Point(12, 12);
            this.enterPlayerDetailsGb.Name = "enterPlayerDetailsGb";
            this.enterPlayerDetailsGb.Size = new System.Drawing.Size(352, 223);
            this.enterPlayerDetailsGb.TabIndex = 0;
            this.enterPlayerDetailsGb.TabStop = false;
            this.enterPlayerDetailsGb.Text = "Enter Player Details";
            // 
            // playerNameLbl
            // 
            this.playerNameLbl.AutoSize = true;
            this.playerNameLbl.Location = new System.Drawing.Point(94, 64);
            this.playerNameLbl.Name = "playerNameLbl";
            this.playerNameLbl.Size = new System.Drawing.Size(75, 13);
            this.playerNameLbl.TabIndex = 0;
            this.playerNameLbl.Text = "Player Name :";
            // 
            // playerCnicLbl
            // 
            this.playerCnicLbl.AutoSize = true;
            this.playerCnicLbl.Location = new System.Drawing.Point(95, 98);
            this.playerCnicLbl.Name = "playerCnicLbl";
            this.playerCnicLbl.Size = new System.Drawing.Size(77, 13);
            this.playerCnicLbl.TabIndex = 1;
            this.playerCnicLbl.Text = "Player CNIC  : ";
            // 
            // playerLogoPb
            // 
            this.playerLogoPb.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.playerLogoPb.BackgroundImage = global::Chess_Consortium_Manager.Properties.Resources.iconfinder_user_add_216490;
            this.playerLogoPb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playerLogoPb.Location = new System.Drawing.Point(6, 46);
            this.playerLogoPb.Name = "playerLogoPb";
            this.playerLogoPb.Size = new System.Drawing.Size(83, 79);
            this.playerLogoPb.TabIndex = 2;
            this.playerLogoPb.TabStop = false;
            // 
            // playerNameTb
            // 
            this.playerNameTb.Location = new System.Drawing.Point(191, 55);
            this.playerNameTb.Name = "playerNameTb";
            this.playerNameTb.Size = new System.Drawing.Size(122, 22);
            this.playerNameTb.TabIndex = 3;
            // 
            // playerCnicTb
            // 
            this.playerCnicTb.Location = new System.Drawing.Point(191, 89);
            this.playerCnicTb.Name = "playerCnicTb";
            this.playerCnicTb.Size = new System.Drawing.Size(122, 22);
            this.playerCnicTb.TabIndex = 4;
            // 
            // registerBtn
            // 
            this.registerBtn.FlatAppearance.BorderSize = 2;
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBtn.Location = new System.Drawing.Point(98, 165);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(156, 43);
            this.registerBtn.TabIndex = 5;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            this.registerBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.registerBtn_MouseClick);
            this.registerBtn.MouseEnter += new System.EventHandler(this.registerBtn_MouseEnter);
            this.registerBtn.MouseLeave += new System.EventHandler(this.registerBtn_MouseLeave);
            // 
            // RegisterPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 247);
            this.Controls.Add(this.enterPlayerDetailsGb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterPlayer";
            this.Text = "Register a Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterPlayer_FormClosing);
            this.Load += new System.EventHandler(this.RegisterPlayer_Load);
            this.enterPlayerDetailsGb.ResumeLayout(false);
            this.enterPlayerDetailsGb.PerformLayout();
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
    }
}
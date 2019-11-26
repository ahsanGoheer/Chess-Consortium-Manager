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
            this.playerLogoPb = new System.Windows.Forms.PictureBox();
            this.playerCnicLbl = new System.Windows.Forms.Label();
            this.playerNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.enterPlayerDetailsGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerLogoPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
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
            this.enterPlayerDetailsGb.Location = new System.Drawing.Point(16, 15);
            this.enterPlayerDetailsGb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.enterPlayerDetailsGb.Name = "enterPlayerDetailsGb";
            this.enterPlayerDetailsGb.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.enterPlayerDetailsGb.Size = new System.Drawing.Size(469, 274);
            this.enterPlayerDetailsGb.TabIndex = 0;
            this.enterPlayerDetailsGb.TabStop = false;
            this.enterPlayerDetailsGb.Text = "Enter Player Details";
            // 
            // registerBtn
            // 
            this.registerBtn.FlatAppearance.BorderSize = 2;
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBtn.Location = new System.Drawing.Point(131, 203);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(208, 53);
            this.registerBtn.TabIndex = 5;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            this.registerBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.registerBtn_MouseClick);
            this.registerBtn.MouseEnter += new System.EventHandler(this.registerBtn_MouseEnter);
            this.registerBtn.MouseLeave += new System.EventHandler(this.registerBtn_MouseLeave);
            // 
            // playerCnicTb
            // 
            this.playerCnicTb.Location = new System.Drawing.Point(255, 110);
            this.playerCnicTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playerCnicTb.Name = "playerCnicTb";
            this.playerCnicTb.Size = new System.Drawing.Size(161, 26);
            this.playerCnicTb.TabIndex = 4;
            // 
            // playerNameTb
            // 
            this.playerNameTb.Location = new System.Drawing.Point(255, 68);
            this.playerNameTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playerNameTb.Name = "playerNameTb";
            this.playerNameTb.Size = new System.Drawing.Size(161, 26);
            this.playerNameTb.TabIndex = 3;
            // 
            // playerLogoPb
            // 
            this.playerLogoPb.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.playerLogoPb.BackgroundImage = global::Chess_Consortium_Manager.Properties.Resources.iconfinder_user_add_216490;
            this.playerLogoPb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playerLogoPb.Location = new System.Drawing.Point(8, 57);
            this.playerLogoPb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playerLogoPb.Name = "playerLogoPb";
            this.playerLogoPb.Size = new System.Drawing.Size(111, 97);
            this.playerLogoPb.TabIndex = 2;
            this.playerLogoPb.TabStop = false;
            // 
            // playerCnicLbl
            // 
            this.playerCnicLbl.AutoSize = true;
            this.playerCnicLbl.Location = new System.Drawing.Point(127, 121);
            this.playerCnicLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerCnicLbl.Name = "playerCnicLbl";
            this.playerCnicLbl.Size = new System.Drawing.Size(97, 19);
            this.playerCnicLbl.TabIndex = 1;
            this.playerCnicLbl.Text = "Player CNIC  : ";
            // 
            // playerNameLbl
            // 
            this.playerNameLbl.AutoSize = true;
            this.playerNameLbl.Location = new System.Drawing.Point(125, 79);
            this.playerNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerNameLbl.Name = "playerNameLbl";
            this.playerNameLbl.Size = new System.Drawing.Size(93, 19);
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
            // RegisterPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 304);
            this.Controls.Add(this.enterPlayerDetailsGb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegisterPlayer";
            this.Text = "Register a Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterPlayer_FormClosing);
            this.Load += new System.EventHandler(this.RegisterPlayer_Load);
            this.enterPlayerDetailsGb.ResumeLayout(false);
            this.enterPlayerDetailsGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerLogoPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
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
    }
}
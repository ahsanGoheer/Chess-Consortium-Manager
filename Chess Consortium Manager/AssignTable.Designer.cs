namespace Chess_Consortium_Manager
{
    partial class AssignTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignTable));
            this.playerDetailsGb = new System.Windows.Forms.GroupBox();
            this.assignBtn = new System.Windows.Forms.Button();
            this.playerTwoCnicTb = new System.Windows.Forms.TextBox();
            this.playerOneCnicTb = new System.Windows.Forms.TextBox();
            this.playerTwoCnicLbl = new System.Windows.Forms.Label();
            this.addSecondPlayerGb = new System.Windows.Forms.GroupBox();
            this.dontAddSecondPlayerRb = new System.Windows.Forms.RadioButton();
            this.addSecondPlayerRb = new System.Windows.Forms.RadioButton();
            this.playerOneCnicLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.homeBtn = new System.Windows.Forms.PictureBox();
            this.exitBtn = new System.Windows.Forms.PictureBox();
            this.playerDetailsGb.SuspendLayout();
            this.addSecondPlayerGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // playerDetailsGb
            // 
            this.playerDetailsGb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.playerDetailsGb.Controls.Add(this.assignBtn);
            this.playerDetailsGb.Controls.Add(this.playerTwoCnicTb);
            this.playerDetailsGb.Controls.Add(this.playerOneCnicTb);
            this.playerDetailsGb.Controls.Add(this.playerTwoCnicLbl);
            this.playerDetailsGb.Controls.Add(this.addSecondPlayerGb);
            this.playerDetailsGb.Controls.Add(this.playerOneCnicLbl);
            this.playerDetailsGb.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerDetailsGb.ForeColor = System.Drawing.SystemColors.ControlText;
            this.playerDetailsGb.Location = new System.Drawing.Point(48, 82);
            this.playerDetailsGb.Name = "playerDetailsGb";
            this.playerDetailsGb.Size = new System.Drawing.Size(755, 357);
            this.playerDetailsGb.TabIndex = 0;
            this.playerDetailsGb.TabStop = false;
            this.playerDetailsGb.Text = "Enter Player Details ";
            // 
            // assignBtn
            // 
            this.assignBtn.FlatAppearance.BorderSize = 2;
            this.assignBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assignBtn.Location = new System.Drawing.Point(257, 283);
            this.assignBtn.Name = "assignBtn";
            this.assignBtn.Size = new System.Drawing.Size(235, 56);
            this.assignBtn.TabIndex = 5;
            this.assignBtn.Text = "Assign";
            this.assignBtn.UseVisualStyleBackColor = true;
            this.assignBtn.Click += new System.EventHandler(this.assignBtn_Click);
            this.assignBtn.MouseEnter += new System.EventHandler(this.assignBtn_MouseEnter);
            this.assignBtn.MouseLeave += new System.EventHandler(this.assignBtn_MouseLeave);
            // 
            // playerTwoCnicTb
            // 
            this.playerTwoCnicTb.BackColor = System.Drawing.Color.FloralWhite;
            this.playerTwoCnicTb.Location = new System.Drawing.Point(327, 217);
            this.playerTwoCnicTb.Name = "playerTwoCnicTb";
            this.playerTwoCnicTb.Size = new System.Drawing.Size(251, 33);
            this.playerTwoCnicTb.TabIndex = 4;
            this.playerTwoCnicTb.Visible = false;
            // 
            // playerOneCnicTb
            // 
            this.playerOneCnicTb.BackColor = System.Drawing.Color.FloralWhite;
            this.playerOneCnicTb.Location = new System.Drawing.Point(327, 59);
            this.playerOneCnicTb.Name = "playerOneCnicTb";
            this.playerOneCnicTb.Size = new System.Drawing.Size(251, 33);
            this.playerOneCnicTb.TabIndex = 3;
            // 
            // playerTwoCnicLbl
            // 
            this.playerTwoCnicLbl.AutoSize = true;
            this.playerTwoCnicLbl.Location = new System.Drawing.Point(158, 217);
            this.playerTwoCnicLbl.Name = "playerTwoCnicLbl";
            this.playerTwoCnicLbl.Size = new System.Drawing.Size(163, 26);
            this.playerTwoCnicLbl.TabIndex = 2;
            this.playerTwoCnicLbl.Text = "Player Two CNIC :";
            this.playerTwoCnicLbl.Visible = false;
            // 
            // addSecondPlayerGb
            // 
            this.addSecondPlayerGb.Controls.Add(this.dontAddSecondPlayerRb);
            this.addSecondPlayerGb.Controls.Add(this.addSecondPlayerRb);
            this.addSecondPlayerGb.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSecondPlayerGb.Location = new System.Drawing.Point(215, 121);
            this.addSecondPlayerGb.Name = "addSecondPlayerGb";
            this.addSecondPlayerGb.Size = new System.Drawing.Size(341, 69);
            this.addSecondPlayerGb.TabIndex = 1;
            this.addSecondPlayerGb.TabStop = false;
            this.addSecondPlayerGb.Text = "Add Second Player";
            // 
            // dontAddSecondPlayerRb
            // 
            this.dontAddSecondPlayerRb.AutoSize = true;
            this.dontAddSecondPlayerRb.Location = new System.Drawing.Point(244, 21);
            this.dontAddSecondPlayerRb.Name = "dontAddSecondPlayerRb";
            this.dontAddSecondPlayerRb.Size = new System.Drawing.Size(51, 27);
            this.dontAddSecondPlayerRb.TabIndex = 1;
            this.dontAddSecondPlayerRb.TabStop = true;
            this.dontAddSecondPlayerRb.Text = "No";
            this.dontAddSecondPlayerRb.UseVisualStyleBackColor = true;
            this.dontAddSecondPlayerRb.CheckedChanged += new System.EventHandler(this.noRb_CheckedChanged);
            // 
            // addSecondPlayerRb
            // 
            this.addSecondPlayerRb.AutoSize = true;
            this.addSecondPlayerRb.Location = new System.Drawing.Point(22, 21);
            this.addSecondPlayerRb.Name = "addSecondPlayerRb";
            this.addSecondPlayerRb.Size = new System.Drawing.Size(55, 27);
            this.addSecondPlayerRb.TabIndex = 0;
            this.addSecondPlayerRb.TabStop = true;
            this.addSecondPlayerRb.Text = "Yes";
            this.addSecondPlayerRb.UseVisualStyleBackColor = true;
            this.addSecondPlayerRb.CheckedChanged += new System.EventHandler(this.yesRb_CheckedChanged);
            // 
            // playerOneCnicLbl
            // 
            this.playerOneCnicLbl.AutoSize = true;
            this.playerOneCnicLbl.Location = new System.Drawing.Point(159, 62);
            this.playerOneCnicLbl.Name = "playerOneCnicLbl";
            this.playerOneCnicLbl.Size = new System.Drawing.Size(162, 26);
            this.playerOneCnicLbl.TabIndex = 0;
            this.playerOneCnicLbl.Text = "Player One CNIC :";
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
            this.homeBtn.TabIndex = 8;
            this.homeBtn.TabStop = false;
            this.homeBtn.Click += new System.EventHandler(this.HomeBtn_Click_1);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.exitBtn.Image = global::Chess_Consortium_Manager.Properties.Resources.icons8_close_window_80;
            this.exitBtn.Location = new System.Drawing.Point(792, 10);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(39, 39);
            this.exitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitBtn.TabIndex = 9;
            this.exitBtn.TabStop = false;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click_1);
            // 
            // AssignTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(843, 488);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.playerDetailsGb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AssignTable";
            this.Text = "Assign Table";
           
           
            this.playerDetailsGb.ResumeLayout(false);
            this.playerDetailsGb.PerformLayout();
            this.addSecondPlayerGb.ResumeLayout(false);
            this.addSecondPlayerGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox playerDetailsGb;
        private System.Windows.Forms.TextBox playerTwoCnicTb;
        private System.Windows.Forms.TextBox playerOneCnicTb;
        private System.Windows.Forms.Label playerTwoCnicLbl;
        private System.Windows.Forms.GroupBox addSecondPlayerGb;
        private System.Windows.Forms.RadioButton dontAddSecondPlayerRb;
        private System.Windows.Forms.RadioButton addSecondPlayerRb;
        private System.Windows.Forms.Label playerOneCnicLbl;
        private System.Windows.Forms.Button assignBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.PictureBox homeBtn;
        private System.Windows.Forms.PictureBox exitBtn;
    }
}
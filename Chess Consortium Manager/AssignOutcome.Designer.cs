namespace Chess_Consortium_Manager
{
    partial class AssignOutcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignOutcome));
            this.selectOutcomeGb = new System.Windows.Forms.GroupBox();
            this.assignBtn = new System.Windows.Forms.Button();
            this.drawRb = new System.Windows.Forms.RadioButton();
            this.playerTwoRb = new System.Windows.Forms.RadioButton();
            this.playerOneRb = new System.Windows.Forms.RadioButton();
            this.tableIDLbl = new System.Windows.Forms.Label();
            this.tableIDCb = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.homeBtn = new System.Windows.Forms.PictureBox();
            this.exitBtn = new System.Windows.Forms.PictureBox();
            this.selectOutcomeGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // selectOutcomeGb
            // 
            this.selectOutcomeGb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.selectOutcomeGb.Controls.Add(this.assignBtn);
            this.selectOutcomeGb.Controls.Add(this.drawRb);
            this.selectOutcomeGb.Controls.Add(this.playerTwoRb);
            this.selectOutcomeGb.Controls.Add(this.playerOneRb);
            this.selectOutcomeGb.Controls.Add(this.tableIDLbl);
            this.selectOutcomeGb.Controls.Add(this.tableIDCb);
            this.selectOutcomeGb.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectOutcomeGb.Location = new System.Drawing.Point(62, 68);
            this.selectOutcomeGb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectOutcomeGb.Name = "selectOutcomeGb";
            this.selectOutcomeGb.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectOutcomeGb.Size = new System.Drawing.Size(525, 222);
            this.selectOutcomeGb.TabIndex = 0;
            this.selectOutcomeGb.TabStop = false;
            this.selectOutcomeGb.Text = "Select Outcome";
            // 
            // assignBtn
            // 
            this.assignBtn.FlatAppearance.BorderSize = 2;
            this.assignBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assignBtn.Location = new System.Drawing.Point(197, 160);
            this.assignBtn.Name = "assignBtn";
            this.assignBtn.Size = new System.Drawing.Size(189, 43);
            this.assignBtn.TabIndex = 6;
            this.assignBtn.Text = "Assign";
            this.assignBtn.UseVisualStyleBackColor = true;
            this.assignBtn.Click += new System.EventHandler(this.AssignBtn_Click);
            this.assignBtn.MouseEnter += new System.EventHandler(this.AssignBtn_MouseEnter);
            this.assignBtn.MouseLeave += new System.EventHandler(this.AssignBtn_MouseLeave);
            // 
            // drawRb
            // 
            this.drawRb.AutoSize = true;
            this.drawRb.Location = new System.Drawing.Point(398, 113);
            this.drawRb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.drawRb.Name = "drawRb";
            this.drawRb.Size = new System.Drawing.Size(70, 27);
            this.drawRb.TabIndex = 3;
            this.drawRb.TabStop = true;
            this.drawRb.Text = "Draw";
            this.drawRb.UseVisualStyleBackColor = true;
            // 
            // playerTwoRb
            // 
            this.playerTwoRb.AutoSize = true;
            this.playerTwoRb.Location = new System.Drawing.Point(231, 113);
            this.playerTwoRb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.playerTwoRb.Name = "playerTwoRb";
            this.playerTwoRb.Size = new System.Drawing.Size(155, 27);
            this.playerTwoRb.TabIndex = 2;
            this.playerTwoRb.TabStop = true;
            this.playerTwoRb.Text = "Player Two Wins";
            this.playerTwoRb.UseVisualStyleBackColor = true;
            // 
            // playerOneRb
            // 
            this.playerOneRb.AutoSize = true;
            this.playerOneRb.Location = new System.Drawing.Point(61, 113);
            this.playerOneRb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.playerOneRb.Name = "playerOneRb";
            this.playerOneRb.Size = new System.Drawing.Size(154, 27);
            this.playerOneRb.TabIndex = 1;
            this.playerOneRb.TabStop = true;
            this.playerOneRb.Text = "Player One Wins";
            this.playerOneRb.UseVisualStyleBackColor = true;
            // 
            // tableIDLbl
            // 
            this.tableIDLbl.AutoSize = true;
            this.tableIDLbl.Location = new System.Drawing.Point(136, 62);
            this.tableIDLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tableIDLbl.Name = "tableIDLbl";
            this.tableIDLbl.Size = new System.Drawing.Size(79, 23);
            this.tableIDLbl.TabIndex = 1;
            this.tableIDLbl.Text = "Table ID:";
            // 
            // tableIDCb
            // 
            this.tableIDCb.FormattingEnabled = true;
            this.tableIDCb.Location = new System.Drawing.Point(231, 59);
            this.tableIDCb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableIDCb.Name = "tableIDCb";
            this.tableIDCb.Size = new System.Drawing.Size(171, 31);
            this.tableIDCb.TabIndex = 0;
            this.tableIDCb.Text = "Select Table ID";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
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
            this.homeBtn.TabIndex = 13;
            this.homeBtn.TabStop = false;
            this.homeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.exitBtn.Image = global::Chess_Consortium_Manager.Properties.Resources.icons8_close_window_80;
            this.exitBtn.Location = new System.Drawing.Point(599, 12);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(39, 39);
            this.exitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitBtn.TabIndex = 14;
            this.exitBtn.TabStop = false;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // AssignOutcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(650, 338);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.selectOutcomeGb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AssignOutcome";
            this.Text = "Assign Outcome";
            
            this.Load += new System.EventHandler(this.AssignOutcome_Load);
            this.selectOutcomeGb.ResumeLayout(false);
            this.selectOutcomeGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox selectOutcomeGb;
        private System.Windows.Forms.ComboBox tableIDCb;
        private System.Windows.Forms.Label tableIDLbl;
        private System.Windows.Forms.RadioButton drawRb;
        private System.Windows.Forms.RadioButton playerTwoRb;
        private System.Windows.Forms.RadioButton playerOneRb;
        private System.Windows.Forms.Button assignBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.PictureBox homeBtn;
        private System.Windows.Forms.PictureBox exitBtn;
    }
}
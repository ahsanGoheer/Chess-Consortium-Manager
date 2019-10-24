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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignOutcome));
            this.selectOutcomeGb = new System.Windows.Forms.GroupBox();
            this.tableIDCb = new System.Windows.Forms.ComboBox();
            this.tableIDLbl = new System.Windows.Forms.Label();
            this.playerOneRb = new System.Windows.Forms.RadioButton();
            this.playerTwoRb = new System.Windows.Forms.RadioButton();
            this.drawRb = new System.Windows.Forms.RadioButton();
            this.assignBtn = new System.Windows.Forms.Button();
            this.selectOutcomeGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectOutcomeGb
            // 
            this.selectOutcomeGb.Controls.Add(this.assignBtn);
            this.selectOutcomeGb.Controls.Add(this.drawRb);
            this.selectOutcomeGb.Controls.Add(this.playerTwoRb);
            this.selectOutcomeGb.Controls.Add(this.playerOneRb);
            this.selectOutcomeGb.Controls.Add(this.tableIDLbl);
            this.selectOutcomeGb.Controls.Add(this.tableIDCb);
            this.selectOutcomeGb.Location = new System.Drawing.Point(27, 34);
            this.selectOutcomeGb.Name = "selectOutcomeGb";
            this.selectOutcomeGb.Size = new System.Drawing.Size(419, 202);
            this.selectOutcomeGb.TabIndex = 0;
            this.selectOutcomeGb.TabStop = false;
            this.selectOutcomeGb.Text = "Select Outcome";
            // 
            // tableIDCb
            // 
            this.tableIDCb.FormattingEnabled = true;
            this.tableIDCb.Location = new System.Drawing.Point(153, 43);
            this.tableIDCb.Name = "tableIDCb";
            this.tableIDCb.Size = new System.Drawing.Size(149, 24);
            this.tableIDCb.TabIndex = 0;
            this.tableIDCb.Text = "Select Table ID";
            // 
            // tableIDLbl
            // 
            this.tableIDLbl.AutoSize = true;
            this.tableIDLbl.Location = new System.Drawing.Point(66, 46);
            this.tableIDLbl.Name = "tableIDLbl";
            this.tableIDLbl.Size = new System.Drawing.Size(65, 17);
            this.tableIDLbl.TabIndex = 1;
            this.tableIDLbl.Text = "Table ID:";
            // 
            // playerOneRb
            // 
            this.playerOneRb.AutoSize = true;
            this.playerOneRb.Location = new System.Drawing.Point(22, 93);
            this.playerOneRb.Name = "playerOneRb";
            this.playerOneRb.Size = new System.Drawing.Size(135, 21);
            this.playerOneRb.TabIndex = 1;
            this.playerOneRb.TabStop = true;
            this.playerOneRb.Text = "Player One Wins";
            this.playerOneRb.UseVisualStyleBackColor = true;
            // 
            // playerTwoRb
            // 
            this.playerTwoRb.AutoSize = true;
            this.playerTwoRb.Location = new System.Drawing.Point(168, 93);
            this.playerTwoRb.Name = "playerTwoRb";
            this.playerTwoRb.Size = new System.Drawing.Size(134, 21);
            this.playerTwoRb.TabIndex = 2;
            this.playerTwoRb.TabStop = true;
            this.playerTwoRb.Text = "Player Two Wins";
            this.playerTwoRb.UseVisualStyleBackColor = true;
            // 
            // drawRb
            // 
            this.drawRb.AutoSize = true;
            this.drawRb.Location = new System.Drawing.Point(331, 93);
            this.drawRb.Name = "drawRb";
            this.drawRb.Size = new System.Drawing.Size(61, 21);
            this.drawRb.TabIndex = 3;
            this.drawRb.TabStop = true;
            this.drawRb.Text = "Draw";
            this.drawRb.UseVisualStyleBackColor = true;
            // 
            // assignBtn
            // 
            this.assignBtn.FlatAppearance.BorderSize = 2;
            this.assignBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assignBtn.Location = new System.Drawing.Point(153, 144);
            this.assignBtn.Margin = new System.Windows.Forms.Padding(4);
            this.assignBtn.Name = "assignBtn";
            this.assignBtn.Size = new System.Drawing.Size(133, 41);
            this.assignBtn.TabIndex = 6;
            this.assignBtn.Text = "Assign";
            this.assignBtn.UseVisualStyleBackColor = true;
            this.assignBtn.Click += new System.EventHandler(this.AssignBtn_Click);
            this.assignBtn.MouseEnter += new System.EventHandler(this.AssignBtn_MouseEnter);
            this.assignBtn.MouseLeave += new System.EventHandler(this.AssignBtn_MouseLeave);
            // 
            // AssignOutcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 266);
            this.Controls.Add(this.selectOutcomeGb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AssignOutcome";
            this.Text = "Assign Outcome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AssignOutcome_FormClosing);
            this.Load += new System.EventHandler(this.AssignOutcome_Load);
            this.selectOutcomeGb.ResumeLayout(false);
            this.selectOutcomeGb.PerformLayout();
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
    }
}
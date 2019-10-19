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
            this.playerDetailsGb = new System.Windows.Forms.GroupBox();
            this.playerOneCnicLbl = new System.Windows.Forms.Label();
            this.addSecondPlayerGb = new System.Windows.Forms.GroupBox();
            this.addSecondPlayerRb = new System.Windows.Forms.RadioButton();
            this.dontAddSecondPlayerRb = new System.Windows.Forms.RadioButton();
            this.playerTwoCnicLbl = new System.Windows.Forms.Label();
            this.playerOneCnicTb = new System.Windows.Forms.TextBox();
            this.playerTwoCnicTb = new System.Windows.Forms.TextBox();
            this.assignBtn = new System.Windows.Forms.Button();
            this.playerDetailsGb.SuspendLayout();
            this.addSecondPlayerGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // playerDetailsGb
            // 
            this.playerDetailsGb.Controls.Add(this.assignBtn);
            this.playerDetailsGb.Controls.Add(this.playerTwoCnicTb);
            this.playerDetailsGb.Controls.Add(this.playerOneCnicTb);
            this.playerDetailsGb.Controls.Add(this.playerTwoCnicLbl);
            this.playerDetailsGb.Controls.Add(this.addSecondPlayerGb);
            this.playerDetailsGb.Controls.Add(this.playerOneCnicLbl);
            this.playerDetailsGb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerDetailsGb.Location = new System.Drawing.Point(12, 12);
            this.playerDetailsGb.Name = "playerDetailsGb";
            this.playerDetailsGb.Size = new System.Drawing.Size(368, 280);
            this.playerDetailsGb.TabIndex = 0;
            this.playerDetailsGb.TabStop = false;
            this.playerDetailsGb.Text = "Enter Player Details ";
            // 
            // playerOneCnicLbl
            // 
            this.playerOneCnicLbl.AutoSize = true;
            this.playerOneCnicLbl.Location = new System.Drawing.Point(46, 53);
            this.playerOneCnicLbl.Name = "playerOneCnicLbl";
            this.playerOneCnicLbl.Size = new System.Drawing.Size(96, 13);
            this.playerOneCnicLbl.TabIndex = 0;
            this.playerOneCnicLbl.Text = "Player One CNIC :";
            // 
            // addSecondPlayerGb
            // 
            this.addSecondPlayerGb.Controls.Add(this.dontAddSecondPlayerRb);
            this.addSecondPlayerGb.Controls.Add(this.addSecondPlayerRb);
            this.addSecondPlayerGb.Location = new System.Drawing.Point(90, 90);
            this.addSecondPlayerGb.Name = "addSecondPlayerGb";
            this.addSecondPlayerGb.Size = new System.Drawing.Size(201, 56);
            this.addSecondPlayerGb.TabIndex = 1;
            this.addSecondPlayerGb.TabStop = false;
            this.addSecondPlayerGb.Text = "Add Second Player";
            // 
            // addSecondPlayerRb
            // 
            this.addSecondPlayerRb.AutoSize = true;
            this.addSecondPlayerRb.Location = new System.Drawing.Point(22, 21);
            this.addSecondPlayerRb.Name = "addSecondPlayerRb";
            this.addSecondPlayerRb.Size = new System.Drawing.Size(40, 17);
            this.addSecondPlayerRb.TabIndex = 0;
            this.addSecondPlayerRb.TabStop = true;
            this.addSecondPlayerRb.Text = "Yes";
            this.addSecondPlayerRb.UseVisualStyleBackColor = true;
            this.addSecondPlayerRb.CheckedChanged += new System.EventHandler(this.yesRb_CheckedChanged);
            // 
            // dontAddSecondPlayerRb
            // 
            this.dontAddSecondPlayerRb.AutoSize = true;
            this.dontAddSecondPlayerRb.Location = new System.Drawing.Point(129, 21);
            this.dontAddSecondPlayerRb.Name = "dontAddSecondPlayerRb";
            this.dontAddSecondPlayerRb.Size = new System.Drawing.Size(40, 17);
            this.dontAddSecondPlayerRb.TabIndex = 1;
            this.dontAddSecondPlayerRb.TabStop = true;
            this.dontAddSecondPlayerRb.Text = "No";
            this.dontAddSecondPlayerRb.UseVisualStyleBackColor = true;
            this.dontAddSecondPlayerRb.CheckedChanged += new System.EventHandler(this.noRb_CheckedChanged);
            // 
            // playerTwoCnicLbl
            // 
            this.playerTwoCnicLbl.AutoSize = true;
            this.playerTwoCnicLbl.Location = new System.Drawing.Point(46, 172);
            this.playerTwoCnicLbl.Name = "playerTwoCnicLbl";
            this.playerTwoCnicLbl.Size = new System.Drawing.Size(94, 13);
            this.playerTwoCnicLbl.TabIndex = 2;
            this.playerTwoCnicLbl.Text = "Player Two CNIC :";
            this.playerTwoCnicLbl.Visible = false;
            // 
            // playerOneCnicTb
            // 
            this.playerOneCnicTb.Location = new System.Drawing.Point(159, 50);
            this.playerOneCnicTb.Name = "playerOneCnicTb";
            this.playerOneCnicTb.Size = new System.Drawing.Size(132, 22);
            this.playerOneCnicTb.TabIndex = 3;
            // 
            // playerTwoCnicTb
            // 
            this.playerTwoCnicTb.Location = new System.Drawing.Point(159, 169);
            this.playerTwoCnicTb.Name = "playerTwoCnicTb";
            this.playerTwoCnicTb.Size = new System.Drawing.Size(132, 22);
            this.playerTwoCnicTb.TabIndex = 4;
            this.playerTwoCnicTb.Visible = false;
            // 
            // assignBtn
            // 
            this.assignBtn.FlatAppearance.BorderSize = 2;
            this.assignBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assignBtn.Location = new System.Drawing.Point(136, 216);
            this.assignBtn.Name = "assignBtn";
            this.assignBtn.Size = new System.Drawing.Size(100, 44);
            this.assignBtn.TabIndex = 5;
            this.assignBtn.Text = "Assign";
            this.assignBtn.UseVisualStyleBackColor = true;
            this.assignBtn.Click += new System.EventHandler(this.assignBtn_Click);
            this.assignBtn.MouseEnter += new System.EventHandler(this.assignBtn_MouseEnter);
            this.assignBtn.MouseLeave += new System.EventHandler(this.assignBtn_MouseLeave);
            // 
            // AssignTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 307);
            this.Controls.Add(this.playerDetailsGb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AssignTable";
            this.Text = "Assign Table";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AssignTable_FormClosing);
            this.playerDetailsGb.ResumeLayout(false);
            this.playerDetailsGb.PerformLayout();
            this.addSecondPlayerGb.ResumeLayout(false);
            this.addSecondPlayerGb.PerformLayout();
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
    }
}
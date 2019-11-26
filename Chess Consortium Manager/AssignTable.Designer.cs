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
            this.playerDetailsGb.SuspendLayout();
            this.addSecondPlayerGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
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
            this.playerDetailsGb.Location = new System.Drawing.Point(16, 15);
            this.playerDetailsGb.Margin = new System.Windows.Forms.Padding(4);
            this.playerDetailsGb.Name = "playerDetailsGb";
            this.playerDetailsGb.Padding = new System.Windows.Forms.Padding(4);
            this.playerDetailsGb.Size = new System.Drawing.Size(491, 345);
            this.playerDetailsGb.TabIndex = 0;
            this.playerDetailsGb.TabStop = false;
            this.playerDetailsGb.Text = "Enter Player Details ";
            // 
            // assignBtn
            // 
            this.assignBtn.FlatAppearance.BorderSize = 2;
            this.assignBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assignBtn.Location = new System.Drawing.Point(181, 266);
            this.assignBtn.Margin = new System.Windows.Forms.Padding(4);
            this.assignBtn.Name = "assignBtn";
            this.assignBtn.Size = new System.Drawing.Size(133, 54);
            this.assignBtn.TabIndex = 5;
            this.assignBtn.Text = "Assign";
            this.assignBtn.UseVisualStyleBackColor = true;
            this.assignBtn.Click += new System.EventHandler(this.assignBtn_Click);
            this.assignBtn.MouseEnter += new System.EventHandler(this.assignBtn_MouseEnter);
            this.assignBtn.MouseLeave += new System.EventHandler(this.assignBtn_MouseLeave);
            // 
            // playerTwoCnicTb
            // 
            this.playerTwoCnicTb.Location = new System.Drawing.Point(212, 208);
            this.playerTwoCnicTb.Margin = new System.Windows.Forms.Padding(4);
            this.playerTwoCnicTb.Name = "playerTwoCnicTb";
            this.playerTwoCnicTb.Size = new System.Drawing.Size(175, 26);
            this.playerTwoCnicTb.TabIndex = 4;
            this.playerTwoCnicTb.Visible = false;
            // 
            // playerOneCnicTb
            // 
            this.playerOneCnicTb.Location = new System.Drawing.Point(212, 62);
            this.playerOneCnicTb.Margin = new System.Windows.Forms.Padding(4);
            this.playerOneCnicTb.Name = "playerOneCnicTb";
            this.playerOneCnicTb.Size = new System.Drawing.Size(175, 26);
            this.playerOneCnicTb.TabIndex = 3;
            // 
            // playerTwoCnicLbl
            // 
            this.playerTwoCnicLbl.AutoSize = true;
            this.playerTwoCnicLbl.Location = new System.Drawing.Point(61, 212);
            this.playerTwoCnicLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerTwoCnicLbl.Name = "playerTwoCnicLbl";
            this.playerTwoCnicLbl.Size = new System.Drawing.Size(117, 19);
            this.playerTwoCnicLbl.TabIndex = 2;
            this.playerTwoCnicLbl.Text = "Player Two CNIC :";
            this.playerTwoCnicLbl.Visible = false;
            // 
            // addSecondPlayerGb
            // 
            this.addSecondPlayerGb.Controls.Add(this.dontAddSecondPlayerRb);
            this.addSecondPlayerGb.Controls.Add(this.addSecondPlayerRb);
            this.addSecondPlayerGb.Location = new System.Drawing.Point(120, 111);
            this.addSecondPlayerGb.Margin = new System.Windows.Forms.Padding(4);
            this.addSecondPlayerGb.Name = "addSecondPlayerGb";
            this.addSecondPlayerGb.Padding = new System.Windows.Forms.Padding(4);
            this.addSecondPlayerGb.Size = new System.Drawing.Size(268, 69);
            this.addSecondPlayerGb.TabIndex = 1;
            this.addSecondPlayerGb.TabStop = false;
            this.addSecondPlayerGb.Text = "Add Second Player";
            // 
            // dontAddSecondPlayerRb
            // 
            this.dontAddSecondPlayerRb.AutoSize = true;
            this.dontAddSecondPlayerRb.Location = new System.Drawing.Point(172, 26);
            this.dontAddSecondPlayerRb.Margin = new System.Windows.Forms.Padding(4);
            this.dontAddSecondPlayerRb.Name = "dontAddSecondPlayerRb";
            this.dontAddSecondPlayerRb.Size = new System.Drawing.Size(48, 23);
            this.dontAddSecondPlayerRb.TabIndex = 1;
            this.dontAddSecondPlayerRb.TabStop = true;
            this.dontAddSecondPlayerRb.Text = "No";
            this.dontAddSecondPlayerRb.UseVisualStyleBackColor = true;
            this.dontAddSecondPlayerRb.CheckedChanged += new System.EventHandler(this.noRb_CheckedChanged);
            // 
            // addSecondPlayerRb
            // 
            this.addSecondPlayerRb.AutoSize = true;
            this.addSecondPlayerRb.Location = new System.Drawing.Point(29, 26);
            this.addSecondPlayerRb.Margin = new System.Windows.Forms.Padding(4);
            this.addSecondPlayerRb.Name = "addSecondPlayerRb";
            this.addSecondPlayerRb.Size = new System.Drawing.Size(50, 23);
            this.addSecondPlayerRb.TabIndex = 0;
            this.addSecondPlayerRb.TabStop = true;
            this.addSecondPlayerRb.Text = "Yes";
            this.addSecondPlayerRb.UseVisualStyleBackColor = true;
            this.addSecondPlayerRb.CheckedChanged += new System.EventHandler(this.yesRb_CheckedChanged);
            // 
            // playerOneCnicLbl
            // 
            this.playerOneCnicLbl.AutoSize = true;
            this.playerOneCnicLbl.Location = new System.Drawing.Point(61, 65);
            this.playerOneCnicLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerOneCnicLbl.Name = "playerOneCnicLbl";
            this.playerOneCnicLbl.Size = new System.Drawing.Size(119, 19);
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
            // AssignTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 378);
            this.Controls.Add(this.playerDetailsGb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AssignTable";
            this.Text = "Assign Table";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AssignTable_FormClosing);
            this.Load += new System.EventHandler(this.AssignTable_Load);
            this.playerDetailsGb.ResumeLayout(false);
            this.playerDetailsGb.PerformLayout();
            this.addSecondPlayerGb.ResumeLayout(false);
            this.addSecondPlayerGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
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
    }
}
namespace Chess_Consortium_Manager
{
    partial class SearchAPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchAPlayer));
            this.searchGb = new System.Windows.Forms.GroupBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.playerIDTb = new System.Windows.Forms.TextBox();
            this.playerIDLbl = new System.Windows.Forms.Label();
            this.resultGb = new System.Windows.Forms.GroupBox();
            this.resultRtb = new System.Windows.Forms.RichTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.deleteBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.PictureBox();
            this.exitBtn = new System.Windows.Forms.PictureBox();
            this.searchByGB = new System.Windows.Forms.GroupBox();
            this.byNameRB = new System.Windows.Forms.RadioButton();
            this.byIDRB = new System.Windows.Forms.RadioButton();
            this.searchGb.SuspendLayout();
            this.resultGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            this.searchByGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchGb
            // 
            this.searchGb.BackColor = System.Drawing.Color.GhostWhite;
            this.searchGb.Controls.Add(this.searchByGB);
            this.searchGb.Controls.Add(this.searchBtn);
            this.searchGb.Controls.Add(this.playerIDTb);
            this.searchGb.Controls.Add(this.playerIDLbl);
            this.searchGb.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchGb.Location = new System.Drawing.Point(43, 105);
            this.searchGb.Margin = new System.Windows.Forms.Padding(2);
            this.searchGb.Name = "searchGb";
            this.searchGb.Padding = new System.Windows.Forms.Padding(2);
            this.searchGb.Size = new System.Drawing.Size(378, 236);
            this.searchGb.TabIndex = 0;
            this.searchGb.TabStop = false;
            this.searchGb.Text = "Search";
            // 
            // searchBtn
            // 
            this.searchBtn.FlatAppearance.BorderSize = 2;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Location = new System.Drawing.Point(98, 195);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(185, 33);
            this.searchBtn.TabIndex = 7;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            this.searchBtn.MouseEnter += new System.EventHandler(this.SearchBtn_MouseEnter);
            this.searchBtn.MouseLeave += new System.EventHandler(this.SearchBtn_MouseLeave);
            // 
            // playerIDTb
            // 
            this.playerIDTb.Location = new System.Drawing.Point(148, 38);
            this.playerIDTb.Margin = new System.Windows.Forms.Padding(2);
            this.playerIDTb.Name = "playerIDTb";
            this.playerIDTb.Size = new System.Drawing.Size(187, 27);
            this.playerIDTb.TabIndex = 2;
            // 
            // playerIDLbl
            // 
            this.playerIDLbl.AutoSize = true;
            this.playerIDLbl.Location = new System.Drawing.Point(32, 41);
            this.playerIDLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerIDLbl.Name = "playerIDLbl";
            this.playerIDLbl.Size = new System.Drawing.Size(112, 19);
            this.playerIDLbl.TabIndex = 1;
            this.playerIDLbl.Text = "Enter Player ID:";
            // 
            // resultGb
            // 
            this.resultGb.BackColor = System.Drawing.Color.GhostWhite;
            this.resultGb.Controls.Add(this.resultRtb);
            this.resultGb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resultGb.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultGb.Location = new System.Drawing.Point(447, 105);
            this.resultGb.Margin = new System.Windows.Forms.Padding(2);
            this.resultGb.Name = "resultGb";
            this.resultGb.Padding = new System.Windows.Forms.Padding(2);
            this.resultGb.Size = new System.Drawing.Size(310, 180);
            this.resultGb.TabIndex = 1;
            this.resultGb.TabStop = false;
            this.resultGb.Text = "Result";
            // 
            // resultRtb
            // 
            this.resultRtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultRtb.Location = new System.Drawing.Point(2, 22);
            this.resultRtb.Margin = new System.Windows.Forms.Padding(2);
            this.resultRtb.Name = "resultRtb";
            this.resultRtb.ReadOnly = true;
            this.resultRtb.Size = new System.Drawing.Size(306, 156);
            this.resultRtb.TabIndex = 0;
            this.resultRtb.Text = "";
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
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.deleteBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.deleteBtn.FlatAppearance.BorderSize = 5;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(542, 300);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(143, 41);
            this.deleteBtn.TabIndex = 8;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.homeBtn.Image = global::Chess_Consortium_Manager.Properties.Resources.icons8_home_801;
            this.homeBtn.Location = new System.Drawing.Point(12, 12);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(46, 37);
            this.homeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homeBtn.TabIndex = 9;
            this.homeBtn.TabStop = false;
            this.homeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.exitBtn.Image = global::Chess_Consortium_Manager.Properties.Resources.icons8_close_window_80;
            this.exitBtn.Location = new System.Drawing.Point(741, 12);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(39, 39);
            this.exitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitBtn.TabIndex = 10;
            this.exitBtn.TabStop = false;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // searchByGB
            // 
            this.searchByGB.Controls.Add(this.byIDRB);
            this.searchByGB.Controls.Add(this.byNameRB);
            this.searchByGB.Location = new System.Drawing.Point(36, 85);
            this.searchByGB.Name = "searchByGB";
            this.searchByGB.Size = new System.Drawing.Size(299, 81);
            this.searchByGB.TabIndex = 8;
            this.searchByGB.TabStop = false;
            this.searchByGB.Text = "Search By";
            // 
            // byNameRB
            // 
            this.byNameRB.AutoSize = true;
            this.byNameRB.Location = new System.Drawing.Point(21, 37);
            this.byNameRB.Name = "byNameRB";
            this.byNameRB.Size = new System.Drawing.Size(88, 23);
            this.byNameRB.TabIndex = 0;
            this.byNameRB.TabStop = true;
            this.byNameRB.Text = "By Name";
            this.byNameRB.UseVisualStyleBackColor = true;
            // 
            // byIDRB
            // 
            this.byIDRB.AutoSize = true;
            this.byIDRB.Location = new System.Drawing.Point(196, 37);
            this.byIDRB.Name = "byIDRB";
            this.byIDRB.Size = new System.Drawing.Size(63, 23);
            this.byIDRB.TabIndex = 1;
            this.byIDRB.TabStop = true;
            this.byIDRB.Text = "By ID";
            this.byIDRB.UseVisualStyleBackColor = true;
            // 
            // SearchAPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(792, 382);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.resultGb);
            this.Controls.Add(this.searchGb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SearchAPlayer";
            this.Text = "Search Player";
            this.searchGb.ResumeLayout(false);
            this.searchGb.PerformLayout();
            this.resultGb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            this.searchByGB.ResumeLayout(false);
            this.searchByGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox searchGb;
        private System.Windows.Forms.TextBox playerIDTb;
        private System.Windows.Forms.Label playerIDLbl;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.GroupBox resultGb;
        private System.Windows.Forms.RichTextBox resultRtb;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.PictureBox homeBtn;
        private System.Windows.Forms.PictureBox exitBtn;
        private System.Windows.Forms.GroupBox searchByGB;
        private System.Windows.Forms.RadioButton byIDRB;
        private System.Windows.Forms.RadioButton byNameRB;
    }
}
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
            this.searchGb.SuspendLayout();
            this.resultGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // searchGb
            // 
            this.searchGb.Controls.Add(this.searchBtn);
            this.searchGb.Controls.Add(this.playerIDTb);
            this.searchGb.Controls.Add(this.playerIDLbl);
            this.searchGb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchGb.Location = new System.Drawing.Point(57, 59);
            this.searchGb.Name = "searchGb";
            this.searchGb.Size = new System.Drawing.Size(364, 162);
            this.searchGb.TabIndex = 0;
            this.searchGb.TabStop = false;
            this.searchGb.Text = "Search";
            // 
            // searchBtn
            // 
            this.searchBtn.FlatAppearance.BorderSize = 2;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Location = new System.Drawing.Point(128, 105);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(133, 41);
            this.searchBtn.TabIndex = 7;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            this.searchBtn.MouseEnter += new System.EventHandler(this.SearchBtn_MouseEnter);
            this.searchBtn.MouseLeave += new System.EventHandler(this.SearchBtn_MouseLeave);
            // 
            // playerIDTb
            // 
            this.playerIDTb.Location = new System.Drawing.Point(164, 56);
            this.playerIDTb.Name = "playerIDTb";
            this.playerIDTb.Size = new System.Drawing.Size(167, 27);
            this.playerIDTb.TabIndex = 2;
            // 
            // playerIDLbl
            // 
            this.playerIDLbl.AutoSize = true;
            this.playerIDLbl.Location = new System.Drawing.Point(33, 59);
            this.playerIDLbl.Name = "playerIDLbl";
            this.playerIDLbl.Size = new System.Drawing.Size(109, 20);
            this.playerIDLbl.TabIndex = 1;
            this.playerIDLbl.Text = "Enter Player ID:";
            // 
            // resultGb
            // 
            this.resultGb.Controls.Add(this.resultRtb);
            this.resultGb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultGb.Location = new System.Drawing.Point(57, 297);
            this.resultGb.Name = "resultGb";
            this.resultGb.Size = new System.Drawing.Size(364, 168);
            this.resultGb.TabIndex = 1;
            this.resultGb.TabStop = false;
            this.resultGb.Text = "Result";
            // 
            // resultRtb
            // 
            this.resultRtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultRtb.Location = new System.Drawing.Point(3, 23);
            this.resultRtb.Name = "resultRtb";
            this.resultRtb.ReadOnly = true;
            this.resultRtb.Size = new System.Drawing.Size(358, 142);
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
            // SearchAPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 489);
            this.Controls.Add(this.resultGb);
            this.Controls.Add(this.searchGb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchAPlayer";
            this.Text = "Search Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchAPlayer_FormClosing);
            this.Load += new System.EventHandler(this.SearchAPlayer_Load);
            this.searchGb.ResumeLayout(false);
            this.searchGb.PerformLayout();
            this.resultGb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
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
    }
}
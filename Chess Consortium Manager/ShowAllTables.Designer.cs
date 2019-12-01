namespace Chess_Consortium_Manager
{
    partial class ShowAllTables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowAllTables));
            this.tablesGb = new System.Windows.Forms.GroupBox();
            this.showTablesRtb = new System.Windows.Forms.RichTextBox();
            this.exitBtn = new System.Windows.Forms.PictureBox();
            this.homeBtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showAllTablesBtn = new System.Windows.Forms.Button();
            this.tableSelectionPanel = new System.Windows.Forms.Panel();
            this.tablesCB = new System.Windows.Forms.ComboBox();
            this.tablesGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).BeginInit();
            this.tableSelectionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablesGb
            // 
            this.tablesGb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tablesGb.Controls.Add(this.showTablesRtb);
            this.tablesGb.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablesGb.ForeColor = System.Drawing.Color.Black;
            this.tablesGb.Location = new System.Drawing.Point(383, 93);
            this.tablesGb.Margin = new System.Windows.Forms.Padding(2);
            this.tablesGb.Name = "tablesGb";
            this.tablesGb.Padding = new System.Windows.Forms.Padding(2);
            this.tablesGb.Size = new System.Drawing.Size(577, 426);
            this.tablesGb.TabIndex = 0;
            this.tablesGb.TabStop = false;
            this.tablesGb.Text = "Tables";
            // 
            // showTablesRtb
            // 
            this.showTablesRtb.BackColor = System.Drawing.Color.FloralWhite;
            this.showTablesRtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showTablesRtb.Location = new System.Drawing.Point(2, 26);
            this.showTablesRtb.Margin = new System.Windows.Forms.Padding(2);
            this.showTablesRtb.Name = "showTablesRtb";
            this.showTablesRtb.ReadOnly = true;
            this.showTablesRtb.Size = new System.Drawing.Size(573, 398);
            this.showTablesRtb.TabIndex = 1;
            this.showTablesRtb.Text = "";
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.exitBtn.Image = global::Chess_Consortium_Manager.Properties.Resources.icons8_close_window_80;
            this.exitBtn.Location = new System.Drawing.Point(959, 12);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(39, 39);
            this.exitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitBtn.TabIndex = 12;
            this.exitBtn.TabStop = false;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.homeBtn.Image = global::Chess_Consortium_Manager.Properties.Resources.icons8_home_801;
            this.homeBtn.Location = new System.Drawing.Point(12, 12);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(46, 37);
            this.homeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homeBtn.TabIndex = 11;
            this.homeBtn.TabStop = false;
            this.homeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(443, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 33);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tables";
            // 
            // showAllTablesBtn
            // 
            this.showAllTablesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAllTablesBtn.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllTablesBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.showAllTablesBtn.Location = new System.Drawing.Point(78, 473);
            this.showAllTablesBtn.Name = "showAllTablesBtn";
            this.showAllTablesBtn.Size = new System.Drawing.Size(243, 46);
            this.showAllTablesBtn.TabIndex = 14;
            this.showAllTablesBtn.Text = "Show All Tables";
            this.showAllTablesBtn.UseVisualStyleBackColor = true;
            this.showAllTablesBtn.Click += new System.EventHandler(this.ShowAllTablesBtn_Click);
            // 
            // tableSelectionPanel
            // 
            this.tableSelectionPanel.Controls.Add(this.tablesCB);
            this.tableSelectionPanel.Location = new System.Drawing.Point(78, 119);
            this.tableSelectionPanel.Name = "tableSelectionPanel";
            this.tableSelectionPanel.Size = new System.Drawing.Size(243, 100);
            this.tableSelectionPanel.TabIndex = 15;
            // 
            // tablesCB
            // 
            this.tablesCB.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablesCB.FormattingEnabled = true;
            this.tablesCB.Items.AddRange(new object[] {
            "T-1",
            "T-2",
            "T-3",
            "T-4",
            "T-5",
            "T-6",
            "T-7",
            "T-8",
            "T-9"});
            this.tablesCB.Location = new System.Drawing.Point(42, 38);
            this.tablesCB.Name = "tablesCB";
            this.tablesCB.Size = new System.Drawing.Size(169, 23);
            this.tablesCB.TabIndex = 0;
            this.tablesCB.Text = "Select a Table";
            // 
            // ShowAllTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(1010, 641);
            this.Controls.Add(this.tableSelectionPanel);
            this.Controls.Add(this.showAllTablesBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.tablesGb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ShowAllTables";
            this.Text = "Show all Tables";
            this.tablesGb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).EndInit();
            this.tableSelectionPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox tablesGb;
        private System.Windows.Forms.RichTextBox showTablesRtb;
        private System.Windows.Forms.PictureBox exitBtn;
        private System.Windows.Forms.PictureBox homeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showAllTablesBtn;
        private System.Windows.Forms.Panel tableSelectionPanel;
        private System.Windows.Forms.ComboBox tablesCB;
    }
}
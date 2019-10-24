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
            this.tablesGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablesGb
            // 
            this.tablesGb.Controls.Add(this.showTablesRtb);
            this.tablesGb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablesGb.ForeColor = System.Drawing.Color.Black;
            this.tablesGb.Location = new System.Drawing.Point(30, 36);
            this.tablesGb.Name = "tablesGb";
            this.tablesGb.Size = new System.Drawing.Size(481, 637);
            this.tablesGb.TabIndex = 0;
            this.tablesGb.TabStop = false;
            this.tablesGb.Text = "Tables";
            // 
            // showTablesRtb
            // 
            this.showTablesRtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showTablesRtb.Location = new System.Drawing.Point(3, 26);
            this.showTablesRtb.Name = "showTablesRtb";
            this.showTablesRtb.ReadOnly = true;
            this.showTablesRtb.Size = new System.Drawing.Size(475, 608);
            this.showTablesRtb.TabIndex = 1;
            this.showTablesRtb.Text = "";
            // 
            // ShowAllTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 703);
            this.Controls.Add(this.tablesGb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowAllTables";
            this.Text = "Show all Tables";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShowAllTables_FormClosing);
            this.Load += new System.EventHandler(this.ShowAllTables_Load);
            this.tablesGb.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox tablesGb;
        private System.Windows.Forms.RichTextBox showTablesRtb;
    }
}
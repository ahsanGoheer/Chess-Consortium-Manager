namespace Chess_Consortium_Manager
{
    partial class GameDetailsForm
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
            this.homeBtn = new System.Windows.Forms.PictureBox();
            this.exitBtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gameDataGB = new System.Windows.Forms.GroupBox();
            this.GamesRtb = new System.Windows.Forms.RichTextBox();
            this.showAllGameBtn = new System.Windows.Forms.Button();
            this.gameDatePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            this.gameDataGB.SuspendLayout();
            this.SuspendLayout();
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
            this.exitBtn.Location = new System.Drawing.Point(917, 10);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(39, 39);
            this.exitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitBtn.TabIndex = 14;
            this.exitBtn.TabStop = false;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(413, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 33);
            this.label1.TabIndex = 15;
            this.label1.Text = "Games";
            // 
            // gameDataGB
            // 
            this.gameDataGB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gameDataGB.Controls.Add(this.GamesRtb);
            this.gameDataGB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameDataGB.Location = new System.Drawing.Point(328, 63);
            this.gameDataGB.Margin = new System.Windows.Forms.Padding(2);
            this.gameDataGB.Name = "gameDataGB";
            this.gameDataGB.Padding = new System.Windows.Forms.Padding(2);
            this.gameDataGB.Size = new System.Drawing.Size(594, 419);
            this.gameDataGB.TabIndex = 16;
            this.gameDataGB.TabStop = false;
            this.gameDataGB.Text = "Games Data";
            // 
            // GamesRtb
            // 
            this.GamesRtb.BackColor = System.Drawing.Color.FloralWhite;
            this.GamesRtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GamesRtb.Location = new System.Drawing.Point(2, 21);
            this.GamesRtb.Margin = new System.Windows.Forms.Padding(2);
            this.GamesRtb.Name = "GamesRtb";
            this.GamesRtb.ReadOnly = true;
            this.GamesRtb.Size = new System.Drawing.Size(590, 396);
            this.GamesRtb.TabIndex = 0;
            this.GamesRtb.Text = "";
            // 
            // showAllGameBtn
            // 
            this.showAllGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAllGameBtn.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllGameBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.showAllGameBtn.Location = new System.Drawing.Point(90, 444);
            this.showAllGameBtn.Name = "showAllGameBtn";
            this.showAllGameBtn.Size = new System.Drawing.Size(148, 36);
            this.showAllGameBtn.TabIndex = 21;
            this.showAllGameBtn.Text = "Show All Games";
            this.showAllGameBtn.UseVisualStyleBackColor = true;
            this.showAllGameBtn.Click += new System.EventHandler(this.ShowAllGameBtn_Click);
            // 
            // gameDatePicker
            // 
            this.gameDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.gameDatePicker.Location = new System.Drawing.Point(69, 129);
            this.gameDatePicker.Name = "gameDatePicker";
            this.gameDatePicker.Size = new System.Drawing.Size(200, 20);
            this.gameDatePicker.TabIndex = 22;
            this.gameDatePicker.Value = new System.DateTime(2019, 11, 27, 0, 0, 0, 0);
            this.gameDatePicker.ValueChanged += new System.EventHandler(this.GameDatePicker_ValueChanged);
            this.gameDatePicker.Enter += new System.EventHandler(this.GameDatePicker_Enter);
            // 
            // GameDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(968, 502);
            this.Controls.Add(this.gameDatePicker);
            this.Controls.Add(this.showAllGameBtn);
            this.Controls.Add(this.gameDataGB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.homeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameDetailsForm";
            this.Text = "GameDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            this.gameDataGB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox homeBtn;
        private System.Windows.Forms.PictureBox exitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gameDataGB;
        private System.Windows.Forms.RichTextBox GamesRtb;
        private System.Windows.Forms.Button showAllGameBtn;
        private System.Windows.Forms.DateTimePicker gameDatePicker;
    }
}
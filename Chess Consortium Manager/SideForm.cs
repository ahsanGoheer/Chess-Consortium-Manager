using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess_Consortium_Manager
{
    public partial class SideForm : Form
    {
        public SideForm()
        {
            InitializeComponent();
        }

        private void Prevbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Prevbtn_MouseEnter(object sender, EventArgs e)
        {
            Prevbtn.BackColor = Color.Firebrick;
        }

        private void Prevbtn_MouseLeave(object sender, EventArgs e)
        {
            Prevbtn.BackColor = Color.WhiteSmoke;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void ExitBtn_MouseEnter(object sender, EventArgs e)
        {
            exitBtn.BackColor = Color.Firebrick;

        }

        private void ExitBtn_MouseLeave(object sender, EventArgs e)
        {
            exitBtn.BackColor = Color.WhiteSmoke;
        }

        private void ShowGamesBtn_Click(object sender, EventArgs e)
        {
            GameDetailsForm newForm = new GameDetailsForm();
            this.Hide();
            newForm.Show();
            newForm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(showMe);
        }
        private void showMe(object sender,EventArgs e)
        {
            this.Show();
        }
    }
}

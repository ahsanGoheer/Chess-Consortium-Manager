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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void registerPlayerBtn_Click(object sender, EventArgs e)
        {
            RegisterPlayer newForm = new RegisterPlayer();
            newForm.Show();
        }

        private void assignTableBtn_Click(object sender, EventArgs e)
        {
            AssignTable newForm = new AssignTable();
            newForm.Show();
        }

        private void ShowAllTablesBtn_Click(object sender, EventArgs e)
        {
            ShowAllTables newForm = new ShowAllTables();
            newForm.Show();
        }

        private void AssignOutcomeBtn_Click(object sender, EventArgs e)
        {
            AssignOutcome newForm = new AssignOutcome();
            newForm.Show();
        }

        private void ViewPlayersBtn_Click(object sender, EventArgs e)
        {
            ViewAllPlayers newForm = new ViewAllPlayers();
            newForm.Show();
        }

        private void SearchAPlayerBtn_Click(object sender, EventArgs e)
        {
            SearchAPlayer newForm = new SearchAPlayer();
            newForm.Show();
        }
    }
}

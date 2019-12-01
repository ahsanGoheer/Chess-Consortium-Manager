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
            registerMouseEvent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void showMe(object sender, EventArgs e)
        {
            this.Show();
        }
     
        private void ExitBtn_Click(object sender, EventArgs e)
        {
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
        private void RegisterPlayerBtn_Click_1(object sender, EventArgs e)
        {
            RegisterPlayer newForm = new RegisterPlayer();
            newForm.Show();
            this.Hide();
            newForm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(showMe);
        }

        private void AssignTableBtn_Click_1(object sender, EventArgs e)
        {

            AssignTable newForm = new AssignTable();
            newForm.Show();
            this.Hide();
            newForm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(showMe);
        }

        private void SearchAPlayerBtn_Click_1(object sender, EventArgs e)
        {
            SearchAPlayer newForm = new SearchAPlayer();
            newForm.Show();
            this.Hide();
            newForm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(showMe);
        }

        private void ShowAllTablesBtn_Click_1(object sender, EventArgs e)
        {
            ShowAllTables newForm = new ShowAllTables();
            newForm.Show();
            this.Hide();
            newForm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(showMe);
        }

        private void AssignOutcomeBtn_Click_1(object sender, EventArgs e)
        {
            AssignOutcome newForm = new AssignOutcome();
            newForm.Show();
            this.Hide();
            newForm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(showMe);
        }

        private void ViewPlayersBtn_Click_1(object sender, EventArgs e)
        {
            ViewAllPlayers newForm = new ViewAllPlayers();
            newForm.Show();
            this.Hide();
            newForm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(showMe);
        }

        private void registerMouseEvent()
        {
            foreach(Button temp in operationsPanel.Controls.OfType<Button>())
            {
                temp.MouseEnter += (object sender, EventArgs e) => colorChangeOnEnter(sender, e, temp);
                temp.MouseLeave += (object sender, EventArgs e) => colorChangeOnLeave(sender, e, temp);
            }
         
        }

        private void colorChangeOnEnter(object sender,EventArgs e,Button selectedBtn)
        {
            selectedBtn.ForeColor = Color.SeaGreen;
        }
        private void colorChangeOnLeave(object sender, EventArgs e, Button selectedBtn)
        {
            selectedBtn.ForeColor = Color.DarkSlateGray;
        }

        private void Nextbtn_MouseEnter(object sender, EventArgs e)
        {
            Nextbtn.BackColor = Color.Firebrick;
        }

        private void Nextbtn_MouseLeave(object sender, EventArgs e)
        {
            Nextbtn.BackColor = Color.WhiteSmoke;

        }

        private void Nextbtn_Click(object sender, EventArgs e)
        {
            SideForm newForm = new SideForm();
            newForm.Show();
            this.Hide();
            newForm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(showMe);


        }

        private void OperationsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LogoBox_Click(object sender, EventArgs e)
        {

        }
    }//End Class.
}//End Namespace.

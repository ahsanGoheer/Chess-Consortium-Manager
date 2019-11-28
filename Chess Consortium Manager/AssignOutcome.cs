using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
namespace Chess_Consortium_Manager
{
    public partial class AssignOutcome : Form
    {
        Manager consortiumManager = Manager.Instance;

        public AssignOutcome()
        {
            InitializeComponent();
        }

        private void AssignOutcome_Load(object sender, EventArgs e)
        {
            List<string> tableIds = consortiumManager.tableIDs();
            foreach(string Id in tableIds)
            {
                tableIDCb.Items.Add(Id);

            }

        }

        private void AssignOutcome_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void AssignBtn_MouseEnter(object sender, EventArgs e)
        {
            assignBtn.BackColor = Color.Green;
            assignBtn.ForeColor = Color.White;
        }

        private void AssignBtn_MouseLeave(object sender, EventArgs e)
        {
            assignBtn.BackColor = DefaultBackColor;
            assignBtn.ForeColor = DefaultForeColor;
        }

        private void AssignBtn_Click(object sender, EventArgs e)
        {

            try
            {
                string tableID = tableIDCb.SelectedItem.ToString();
                if (consortiumManager.isOccupied(tableID))
                {
                    if (playerOneRb.Checked)
                    {
                        consortiumManager.assignOutcome(tableID, 1);
                    }
                    else if (playerTwoRb.Checked)
                    {
                        consortiumManager.assignOutcome(tableID, 2);
                    }
                    else if (drawRb.Checked)
                    {
                        consortiumManager.assignOutcome(tableID, 3);
                    }
                    //consortiumManager.UpdateStats();
                    errorProvider2.SetError(tableIDCb,"Correct");
                    MessageBox.Show("Outcome has been assigned.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tableIDCb.ResetText();
                    drawRb.Checked = true;
                }
                else
                {
                    MessageBox.Show("This table does not have a second player.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(System.NullReferenceException)
            {
                errorProvider1.SetError(tableIDCb,"Select a valid table id.");
                MessageBox.Show("Please enter a valid table id.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
            
            
    }
}

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
    public partial class SearchAPlayer : Form
    {
        public SearchAPlayer()
        {
            InitializeComponent();
            playerIDTb.TextChanged += new System.EventHandler(checkCNIC);
        }

        private void SearchBtn_MouseEnter(object sender, EventArgs e)
        {
            searchBtn.BackColor = Color.Green;
            searchBtn.ForeColor = Color.White;
        }

        private void SearchBtn_MouseLeave(object sender, EventArgs e)
        {
            searchBtn.BackColor = DefaultBackColor;
            searchBtn.ForeColor = DefaultForeColor;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            Manager consortiumManager = Manager.Instance;
            string playerCnic = playerIDTb.Text.Trim();
            string playerData = consortiumManager.searchPlayer(playerCnic);
            try
            {
                if (playerData != null)
                {
                    resultRtb.Text = playerData;

                }
                else
                {

                    throw new NoDataToShowException("Player Not Found!");
                }
            }
            catch(NoDataToShowException)
            {
                MessageBox.Show("No Player Found!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                playerIDTb.Text = "";
            }
            errorProvider1.SetError(playerIDTb, "");
            errorProvider2.SetError(playerIDTb, "");
           
        }

        private void SearchAPlayer_Load(object sender, EventArgs e)
        {

        }

        private void checkCNIC(object sender,EventArgs e)
        {
            if(InputValidator.isValidCnic(playerIDTb.Text.Trim()))
            {
                errorProvider1.SetError(playerIDTb,"");
                errorProvider2.SetError(playerIDTb,"Correct!");
            }
            else
            {
                errorProvider2.SetError(playerIDTb,"");
                errorProvider1.SetError(playerIDTb,"Incorrect!");
            }
        }


        private void SearchAPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}

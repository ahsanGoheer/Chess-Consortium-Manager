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
            string playerCnic = playerIDTb.Text;
            string playerData = consortiumManager.searchPlayer(playerCnic);
            if(playerData!=null)
            {
                resultRtb.Text = playerData;

            }
            else
            {
                resultRtb.Text = "Player not found!";
            }
            playerIDTb.Text = "";
        }

        private void SearchAPlayer_Load(object sender, EventArgs e)
        {

        }

        private void SearchAPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}

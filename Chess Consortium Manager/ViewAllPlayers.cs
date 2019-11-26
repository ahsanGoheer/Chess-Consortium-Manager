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
    public partial class ViewAllPlayers : Form
    {
        Manager consortiumManager = Manager.Instance;
        public ViewAllPlayers()
        {
            InitializeComponent();
            
        }

        private void ViewAllPlayers_Load(object sender, EventArgs e)
        {
            string playersData = consortiumManager.viewAllRegisteredPlayer();
            if(playersData==null)
            {
                playersRtb.Text = "No player data to show.";
            }
            else
            {
                playersRtb.Text = "\t\t PLAYERS \n";
                playersRtb.Text += playersData;
            }
        }

        private void ViewAllPlayers_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}

using System;
using System.Collections;
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
        //Attributes.
        ArrayList fetchedPlayers;
        //Constructor.
        public ViewAllPlayers()
        {
            InitializeComponent();
            registerMouseEvent();
            
        }
        //----------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------

        //Method to load all players.
        private void ViewAllPlayers_Load(object sender, EventArgs e)
        {
           Manager consortiumManager = Manager.Instance;

            fetchedPlayers = consortiumManager.fetchRegisteredPlayers();

            foreach (Player temp in fetchedPlayers)
            {
                registeredPlayersListBox.Items.Add(temp.CNIC);
            }
        }
        //----------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------

        //Mouse Enter and Leave Events.
        private void registerMouseEvent()
        {
            this.homeBtn.MouseEnter += (object sender, EventArgs e) => onEnterColorChange(sender, e, this.homeBtn);
            this.homeBtn.MouseLeave += (object sender, EventArgs e) => onLeaveColorChange(sender, e, this.homeBtn);
            this.exitBtn.MouseEnter += (object sender, EventArgs e) => onEnterColorChange(sender, e, this.exitBtn);
            this.exitBtn.MouseLeave += (object sender, EventArgs e) => onLeaveColorChange(sender, e, this.exitBtn);
            this.registeredPlayersListBox.SelectedIndexChanged += new System.EventHandler(getPlayerInfo);
        }
        //----------------------------------------------------------------------------------------------------------

        private void onEnterColorChange(object sender, EventArgs e, PictureBox temp)
        {
            temp.BackColor = Color.Firebrick;
        }
        //----------------------------------------------------------------------------------------------------------

        private void onLeaveColorChange(object sender, EventArgs e, PictureBox temp)
        {
            temp.BackColor = Color.WhiteSmoke;
        }
        //----------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------

        //Form Closing Method.
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //----------------------------------------------------------------------------------------------------------

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void ShowAllPlayersBtn_Click(object sender, EventArgs e)
        {
            Manager consortiumManager = Manager.Instance;
            string playersData = consortiumManager.viewAllRegisteredPlayer();
            if (playersData == null)
            {
                playersRtb.Text = "No player data to show.";
            }
            else
            {
                playersRtb.Text = "\t\t\t\t PLAYERS \n";
                playersRtb.Text += playersData;
            }
        }

        //----------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------
        //ListBox Method.
        private void getPlayerInfo(object sender,EventArgs e)
        {
            try
            {
                Manager consortiumManager = Manager.Instance;
                string fetchedInfo = consortiumManager.searchPlayer(registeredPlayersListBox.SelectedItem.ToString());
                if (fetchedInfo != null)
                {
                    playersRtb.Text = fetchedInfo;
                }
                else
                {
                    throw new NoDataToShowException("Player Data Could Not Be Found!");
                }
            }
            catch(NoDataToShowException error)
            {
                MessageBox.Show(error.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void TopTenListBtn_Click(object sender, EventArgs e)
        {
            Manager consortiumManager = Manager.Instance;
            ArrayList ranksList = consortiumManager.RankPlayers();
            string rankInfo = "";
            foreach(string[] temp in ranksList)
            {
                rankInfo += $"PLAYER NAME : { consortiumManager.fetchName(temp[0])}";
                rankInfo += "\n";
                rankInfo += temp[1];
                rankInfo += "\n";
                rankInfo += $"Total Games Won : {temp[2]}";
                rankInfo += "\n";
                rankInfo += "*************************************\n";
            }
            playersRtb.Text = rankInfo;
        }
    }//End Class.
}//End Namespace.

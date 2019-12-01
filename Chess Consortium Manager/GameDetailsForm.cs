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
    public partial class GameDetailsForm : Form
    {
        public GameDetailsForm()
        {
            InitializeComponent();
            registerMouseEvent();
        }

        private void ShowAllGameBtn_Click(object sender, EventArgs e)
        {
            GamesRtb.Text = "";
            Manager ConsortiumManager = Manager.Instance;
            string gamesData = ConsortiumManager.getAllGames();
            if(gamesData!=null)
            {
                GamesRtb.Text = gamesData;
            }
            else
            {
                GamesRtb.Text = "No games in database.";
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void GameDatePicker_ValueChanged(object sender, EventArgs e)
        {
            GamesRtb.Text = "";
            Manager ConsortiumManager = Manager.Instance;
            DateTime gamedate = gameDatePicker.Value;
            string gamesData = ConsortiumManager.getGame(gamedate);
            if (gamesData != null)
            {
                GamesRtb.Text = gamesData;
            }
            else
            {
                GamesRtb.Text = "No games for the specified date.";
            }
        }

        private void GameDatePicker_Enter(object sender, EventArgs e)
        {
            GamesRtb.Text = "";
        }

        private void registerMouseEvent()
        {
            exitBtn.MouseEnter += (object sender, EventArgs e) => mouseEnter(sender, e, exitBtn);
            homeBtn.MouseEnter += (object sender, EventArgs e) => mouseEnter(sender, e, homeBtn);
            exitBtn.MouseLeave += (object sender, EventArgs e) => mouseLeave(sender, e, exitBtn);
            homeBtn.MouseLeave += (object sender, EventArgs e) => mouseLeave(sender, e, homeBtn);

        }
        private void mouseEnter(object sender,EventArgs e,PictureBox selectedBox)
        {
            selectedBox.BackColor = Color.Firebrick;
        }
        private void mouseLeave(object sender,EventArgs e,PictureBox selectedBox)
        {
            selectedBox.BackColor = Color.WhiteSmoke;
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

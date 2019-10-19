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
    public partial class RegisterPlayer : Form
    {
        public RegisterPlayer()
        {
            InitializeComponent();
        }

        private void RegisterPlayer_Load(object sender, EventArgs e)
        {

        }

        private void RegisterPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            bool alreadyRegistered = false;
            Manager consortiumManager = new Manager();
            string playerName = playerNameTb.Text;
            string CNIC = playerCnicTb.Text;
            Player newPlayer = new Player(playerName, CNIC);
            alreadyRegistered = consortiumManager.registerNewPlayer(newPlayer);
            if (InputValidator.isValidName(newPlayer.PlayerName) && InputValidator.isValidCnic(newPlayer.CNIC))
            {
                if (alreadyRegistered)
                {
                    MessageBox.Show("Player is already registered!", "Error");
                }
                else
                {
                    MessageBox.Show("New player has been registered!", "Confirmation");
                    consortiumManager.UpdatePlayers();
                    consortiumManager.UpdateStats();
                }
            }
            else
            {
                MessageBox.Show("Please Enter Valid Name and CNIC!", "Error");
            }
            playerNameTb.Text = "";
            playerCnicTb.Text = "";
           
        }

        private void registerBtn_MouseEnter(object sender, EventArgs e)
        {
            registerBtn.BackColor = Color.Green;
            registerBtn.ForeColor = Color.White;
        }

        private void registerBtn_MouseLeave(object sender, EventArgs e)
        {
            registerBtn.BackColor = DefaultBackColor;
            registerBtn.ForeColor = DefaultForeColor;
        }

        private void registerBtn_MouseClick(object sender, MouseEventArgs e)
        {
            

        }
    }
}


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
            playerCnicTb.TextChanged += new System.EventHandler(checkCnic);
            playerNameTb.TextChanged += new System.EventHandler(checkName);
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
            Manager consortiumManager = Manager.Instance;
            string playerName = playerNameTb.Text.Trim();
            string CNIC = playerCnicTb.Text.Trim();
            Player newPlayer = new Player(playerName, CNIC);
            alreadyRegistered = consortiumManager.registerNewPlayer(newPlayer);
            if (InputValidator.isValidName(newPlayer.PlayerName) && InputValidator.isValidCnic(newPlayer.CNIC))
            {
                if (alreadyRegistered)
                {
                    MessageBox.Show("Player is already registered!", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("New player has been registered!", "Confirmation",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    consortiumManager.UpdatePlayers();
                    consortiumManager.UpdateStats();
                }
            }
            else
            {
                MessageBox.Show("Please Enter Valid Name and CNIC!", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            playerNameTb.Text = "";
            playerCnicTb.Text = "";
            errorProvider1.SetError(playerCnicTb,"");
            errorProvider2.SetError(playerCnicTb,"");
            errorProvider1.SetError(playerNameTb,"");
            errorProvider2.SetError(playerNameTb,"");

            
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
        private void checkCnic(object sender,EventArgs e)
        {
            if(InputValidator.isValidCnic(playerCnicTb.Text.ToString().Trim()))
            {
                errorProvider1.SetError(playerCnicTb,"");
                errorProvider2.SetError(playerCnicTb,"Correct!");
            }
            else
            {
                errorProvider2.SetError(playerCnicTb,"");
                errorProvider1.SetError(playerCnicTb,"Incorrect!");
            }
        }
        private void checkName(object sender,EventArgs e )
        {
            if (InputValidator.isValidName(playerNameTb.Text.ToString().Trim()))
            {
                errorProvider1.SetError(playerNameTb, "");
                errorProvider2.SetError(playerNameTb, "Correct!");
            }
            else
            {
                errorProvider2.SetError(playerNameTb, "");
                errorProvider1.SetError(playerNameTb, "Incorrect!");
            }
        }

        private void registerBtn_MouseClick(object sender, MouseEventArgs e)
        {
            

        }
    }
}


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
    public partial class AssignTable : Form
    {
        Manager gameManger = Manager.Instance;
        public AssignTable()
        {
            InitializeComponent();
            playerOneCnicTb.TextChanged += new System.EventHandler(checkPlayerOneCNIC);
            playerTwoCnicTb.TextChanged += new System.EventHandler(checkPlayerTwoCnic);
        }

        private void assignBtn_MouseEnter(object sender, EventArgs e)
        {
            assignBtn.BackColor = Color.Green;
            assignBtn.ForeColor = Color.White;
        }

        private void assignBtn_MouseLeave(object sender, EventArgs e)
        {
            assignBtn.BackColor = DefaultBackColor;
            assignBtn.ForeColor = DefaultForeColor;
        }

        private void assignBtn_Click(object sender, EventArgs e)
        {
            if(InputValidator.isValidCnic(playerOneCnicTb.Text))
            {
                bool assigned = false;
               
                string playerOneCnic = null;
                string playerTwoCnic = null;
                if (dontAddSecondPlayerRb.Checked)
                {
                    playerOneCnic = playerOneCnicTb.Text;
                    Game newGame = new Game(playerOneCnic, playerTwoCnic, DateTime.Now);
                    assigned=gameManger.assignGame(newGame);
                    if (assigned)
                    {
                        
                        MessageBox.Show($"Table Id : {newGame.TableID} has been assigned!", "Confirmation",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    }
                    else
                    {
                       
                        MessageBox.Show("Table could not be assigned. Please check if table capacity isn't full or Player isn't already playing the game.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                else if (addSecondPlayerRb.Checked)
                {
                    if (InputValidator.isValidCnic(playerTwoCnicTb.Text.Trim()))
                    {
                        playerOneCnic = playerOneCnicTb.Text.Trim();
                        playerTwoCnic = playerTwoCnicTb.Text.Trim();
                        Game newGame = new Game(playerOneCnic, playerTwoCnic, DateTime.Now);
                        assigned=gameManger.assignGame(newGame);
                        if(assigned)
                        {
                            MessageBox.Show($"Table Id : {newGame.TableID} has been assigned!", "Confirmation",MessageBoxButtons.OK,MessageBoxIcon.Information);

                        }
                        else
                        {
                            
                            MessageBox.Show("Table could not be assigned. Please check if table capacity isn't full or Player isn't already playing the game.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        
                        MessageBox.Show($"{playerTwoCnicTb.Text} isn't an incorrect CNIC!", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

                    }

                }
               
            }
            else
            {
                
                MessageBox.Show($"Please Enter A Valid CNIC!", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }

        }

        private void yesRb_CheckedChanged(object sender, EventArgs e)
        {
            playerTwoCnicLbl.Visible = true;
            playerTwoCnicTb.Visible = true;
        }

        private void noRb_CheckedChanged(object sender, EventArgs e)
        {
            playerTwoCnicLbl.Visible = false;
            playerTwoCnicTb.Visible = false;
        }

        private void AssignTable_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        public void checkPlayerOneCNIC(object sender,EventArgs e)
        {

            if (InputValidator.isValidCnic(playerOneCnicTb.Text.Trim()))
            {
                errorProvider1.SetError(playerOneCnicTb,"");
                errorProvider2.SetError(playerOneCnicTb,"Correct!");
            }
            else
            {
                errorProvider2.SetError(playerOneCnicTb, "");
                errorProvider1.SetError(playerOneCnicTb,"Incorrect!");
            }
           
        }
        public void checkPlayerTwoCnic(object sender,EventArgs e)
        {
            if (InputValidator.isValidCnic(playerTwoCnicTb.Text.Trim()))
            {
                errorProvider1.SetError(playerTwoCnicTb,"");
                errorProvider2.SetError(playerTwoCnicTb, "Correct!");
            }
            else
            {
                errorProvider2.SetError(playerTwoCnicTb, "");
                errorProvider1.SetError(playerTwoCnicTb, "Incorrect!");
            }
        }

        private void AssignTable_Load(object sender, EventArgs e)
        {

        }
    }
}

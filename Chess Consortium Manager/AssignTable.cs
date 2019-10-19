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
        Manager gameManger = new Manager();
        public AssignTable()
        {
            InitializeComponent();
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
             
                        MessageBox.Show($"Table Id : {newGame.TableID} has been assigned!", "Confirmation");

                    }
                    else
                    {
                        MessageBox.Show("Table could not be assigned. Please check if table capacity isn't full or Player isn't already playing the game.", "Error");
                    }
                }
                else if (addSecondPlayerRb.Checked)
                {
                    if (InputValidator.isValidCnic(playerTwoCnicTb.Text))
                    {
                        playerOneCnic = playerOneCnicTb.Text;
                        playerTwoCnic = playerTwoCnicTb.Text;
                        Game newGame = new Game(playerOneCnic, playerTwoCnic, DateTime.Now);
                        assigned=gameManger.assignGame(newGame);
                        if(assigned)
                        {
                            MessageBox.Show($"Table Id : {newGame.TableID} has been assigned!", "Confirmation");

                        }
                        else
                        {
                            MessageBox.Show("Table could not be assigned. Please check if table capacity isn't full or Player isn't already playing the game.", "Error");
                        }

                    }
                    else
                    {
                        MessageBox.Show($"{playerTwoCnicTb.Text} isn't an incorrect CNIC!", "Error");

                    }

                }
               
            }
            else
            {
                MessageBox.Show($"{playerOneCnicTb.Text} isn't an incorrect CNIC!", "Error");

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
    }
}

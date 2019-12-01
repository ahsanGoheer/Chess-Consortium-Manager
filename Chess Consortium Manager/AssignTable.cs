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
        public AssignTable()
        {
            InitializeComponent();
            registerMouseEvent();
            playerOneCnicTb.TextChanged += new System.EventHandler(checkPlayerOneCNIC);
            playerTwoCnicTb.TextChanged += new System.EventHandler(checkPlayerTwoCnic);
        }


        //Code to Assign Table to Players.
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

            Manager gameManger = Manager.Instance;

            if (InputValidator.isValidCnic(playerOneCnicTb.Text.Trim()))
            {
                bool assigned = false;
               
                string playerOneCnic = null;
                string playerTwoCnic = null;
                if (dontAddSecondPlayerRb.Checked)
                {
                    playerOneCnic = playerOneCnicTb.Text.Trim();
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
                        if(playerTwoCnicTb.Text.Trim()=="")
                        {
                            MessageBox.Show($"Player Two Cnic is missing!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                            MessageBox.Show($"{playerTwoCnicTb.Text.Trim()} isn't a correct CNIC!", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

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

       
        //----------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------

        //Set Error Providers.
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
        //----------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------

        //Mouse Enter and Leave Events.
        private void registerMouseEvent()
        {
            this.homeBtn.MouseEnter += (object sender, EventArgs e) => onEnterColorChange(sender, e, this.homeBtn);
            this.homeBtn.MouseLeave += (object sender, EventArgs e) => onLeaveColorChange(sender, e, this.homeBtn);
            this.exitBtn.MouseEnter += (object sender, EventArgs e) => onEnterColorChange(sender, e, this.exitBtn);
            this.exitBtn.MouseLeave += (object sender, EventArgs e) => onLeaveColorChange(sender, e, this.exitBtn);
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

        //Form Exit Methods
        private void HomeBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        //----------------------------------------------------------------------------------------------------------
        private void ExitBtn_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }
        //----------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------
    }//End Class.
}//End Namespace.

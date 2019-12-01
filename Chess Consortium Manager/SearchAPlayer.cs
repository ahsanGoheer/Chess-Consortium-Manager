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
        string cnic;
        //Constructor.
        public SearchAPlayer()
        {
            cnic = null;
            InitializeComponent();
            registerMouseEvent();
            RegisterRadioButtonEvent();
            playerIDTb.TextChanged += new System.EventHandler(checkCNIC);
        }
        //----------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------

        //Code to search Player.
        private void SearchBtn_MouseEnter(object sender, EventArgs e)
        {
            searchBtn.BackColor = Color.Green;
            searchBtn.ForeColor = Color.White;
        }
        //----------------------------------------------------------------------------------------------------------

        private void SearchBtn_MouseLeave(object sender, EventArgs e)
        {
            searchBtn.BackColor = DefaultBackColor;
            searchBtn.ForeColor = DefaultForeColor;
        }
        //----------------------------------------------------------------------------------------------------------

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            Manager consortiumManager = Manager.Instance;
            string playerCred = playerIDTb.Text.Trim();
            if(byIDRB.Checked)
            {
                cnic = playerCred;
                string playerData = consortiumManager.searchPlayer(playerCred);
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
                catch (NoDataToShowException)
                {
                    resultRtb.Text = "No Results!";
                    MessageBox.Show("No Player Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultRtb.Text = "";

                }
                finally
                {
                    playerIDTb.Text = "";
                }
                errorProvider1.SetError(playerIDTb, "");
                errorProvider2.SetError(playerIDTb, "");
            }
            else if(byNameRB.Checked)
            {
                string playerData = consortiumManager.searchPlayerByName(playerCred);
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
                catch (NoDataToShowException)
                {
                    resultRtb.Text = "No Results!";
                    MessageBox.Show("No Player Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultRtb.Text = "";

                }
                finally
                {
                    playerIDTb.Text = "";
                }
                errorProvider1.SetError(playerIDTb, "");
                errorProvider2.SetError(playerIDTb, "");
            }
           
        }
        //----------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------

        //Setting error providers.
        private void checkCNIC(object sender,EventArgs e)
        {
            if(byIDRB.Checked)
            {
                if (InputValidator.isValidCnic(playerIDTb.Text.Trim()))
                {
                    errorProvider1.SetError(playerIDTb, "");
                    errorProvider2.SetError(playerIDTb, "Correct!");
                }
                else
                {
                    errorProvider2.SetError(playerIDTb, "");
                    errorProvider1.SetError(playerIDTb, "Incorrect!");
                }
            }
            else if(byNameRB.Checked)
            {
                if (InputValidator.isValidName(playerIDTb.Text.Trim()))
                {
                    errorProvider1.SetError(playerIDTb, "");
                    errorProvider2.SetError(playerIDTb, "Correct!");
                }
                else
                {
                    errorProvider2.SetError(playerIDTb, "");
                    errorProvider1.SetError(playerIDTb, "Incorrect!");
                }
            }
            
        }
        //----------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------
        //Radio Button Events.
        private void RadioButtonEvent(object sender,EventArgs e)
        {
            if(this.byNameRB.Checked)
            {
                playerIDLbl.Text = "Player Name :";
                deleteBtn.Visible = false;
                resultRtb.Text = "";
            }
            else if(this.byIDRB.Checked)
            {
                deleteBtn.Visible = true;
                playerIDLbl.Text = "Player ID :";
                resultRtb.Text = "";
            }
        }
        //----------------------------------------------------------------------------------------------------------

        private void RegisterRadioButtonEvent()
        {
            this.byIDRB.CheckedChanged += new System.EventHandler(RadioButtonEvent);
            this.byNameRB.CheckedChanged += new System.EventHandler(RadioButtonEvent);
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

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Manager manager = Manager.Instance;
                manager.deleteAPlayer(cnic);
                resultRtb.Text = "PLAYER DELETED!";
                MessageBox.Show("Player has been deleted!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(NoDataToShowException)
            {
                MessageBox.Show("Player ID is not valid!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        //----------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------
    }//End Class.
}//End Namespace.

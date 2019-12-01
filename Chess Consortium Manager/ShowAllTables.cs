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
    public partial class ShowAllTables : Form
    {
        //Constructor.
        public ShowAllTables()
        {
            InitializeComponent();
            registerMouseEvent();
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
            this.tablesCB.SelectedIndexChanged += new System.EventHandler(getTable);
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
        //----------------------------------------------------------------------------------------------------------

        private void ShowAllTablesBtn_Click(object sender, EventArgs e)
        {
            string showTableData = "\t\t\t\t\t TABLES \n";
            Manager consortiumManager = Manager.Instance;
            string info = consortiumManager.showTableInfo();
            if (info!="")
            {
                showTableData += consortiumManager.showTableInfo();
            }
            else
            {
                showTableData += "Tables have not been assigned yet.";

            }

            showTablesRtb.Text = showTableData;
        }
        //----------------------------------------------------------------------------------------------------------
        private void getTable(object sender,EventArgs e)
        {
            string fetchedData = tablesCB.SelectedItem.ToString();
            try
            {
                Manager consortiumManager = Manager.Instance;
                fetchedData += "\n-----------------------------------\n";
                if (consortiumManager.getTableData(tablesCB.SelectedItem.ToString()) == null)
                {
                    throw new NoDataToShowException("Table is not occupied!");
                }
                else
                {
                    fetchedData += consortiumManager.getTableData(tablesCB.SelectedItem.ToString());

                }
            }
            catch(NoDataToShowException)
            {
                fetchedData += "THIS TABLE IS NOT OCCUPIED!";
            }
            finally
            {
                showTablesRtb.Text = fetchedData;
            }

        }


        //----------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------

    }//End Class.
}//End Namespace.

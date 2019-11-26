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
        public ShowAllTables()
        {
            InitializeComponent();
        }

        private void ShowAllTables_Load(object sender, EventArgs e)
        {
            
            string showTableData = "\t\t\t TABLES \n";
            Manager consortiumManager = Manager.Instance;
            showTableData+=consortiumManager.showTableInfo();
            showTablesRtb.Text = showTableData;
        }

        private void ShowAllTables_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void TablesGb_Enter(object sender, EventArgs e)
        {

        }
    }
}

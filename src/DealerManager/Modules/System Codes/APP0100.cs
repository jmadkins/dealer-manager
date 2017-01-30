using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace DealerManager.Forms.System_Codes
{
    public partial class APP0100 : Telerik.WinControls.UI.RadForm
    {
        public APP0100()
        {
            InitializeComponent();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            string query = sqlCommand.Text;
            
            SqlCeConnection DMDatabase = new SqlCeConnection();
            DMDatabase.ConnectionString = Properties.Settings.Default.DMConnectionString;
            DMDatabase.Open();

            SqlCeCommand cmd = new SqlCeCommand(query);
            
        }
    }
}

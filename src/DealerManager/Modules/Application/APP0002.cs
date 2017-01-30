using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using DealerManager.Forms;
using System.IO;
using DealerManager.Modules;
using DealerManager.Modules.Customers;
using DealerManager.Dialogs;

namespace DealerManager
{
    public partial class APP0002 : Telerik.WinControls.UI.RadForm
    {
        public APP0002()
        {
            InitializeComponent();

        }

        private void APP0002_Load(object sender, EventArgs e)
        {           
            
        }

        private void radTreeView1_NodeMouseClick(object sender, Telerik.WinControls.UI.RadTreeViewEventArgs e)
        {
            if (e.Node.Name.Equals("EMP0002RChild"))
            {
                EMP0002R frm = new EMP0002R();
                frm.Show();                
            }
            
            if (e.Node.Text.Equals("Customer Information"))
            {
                MessageBox.Show("The report that you requested was not found.", "Sorry");
            }
            
            //MessageBox.Show("Report not found", "Error");
        }
    }
}

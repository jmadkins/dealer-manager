using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace DealerManager.Dialogs
{
    public partial class ExitApplication : Telerik.WinControls.UI.RadForm
    {
        public ExitApplication()
        {
            InitializeComponent();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}

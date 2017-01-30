using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DealerManager.Forms.System_Codes;
using DealerManager.Forms.Customers;
using DealerManager.Forms.Employees;
using DealerManager.Forms.Inventory;
using DealerManager.Modules.Application;
using DealerManager.Modules.Employees;
using DealerManager.Dialogs;

namespace DealerManager
{
    public partial class DMParent : Form
    {
       public DMParent()
        {
            InitializeComponent();

            applicationStatus.Text = "Application Ready";
            companyStatus.Text = "Location: <NOT ACTIVE>";
            usernameStatus.Text = "User: " + Properties.Settings.Default.app_connectedUser + " (" + Properties.Settings.Default.app_connectedUserID + ")";
            dataStatus.Text = "Data: " + Properties.Settings.Default.DMConnectionString;
            resultsLabel.Text = "";
        }

       public void dataStatusChange(string Text)
       {
           resultsLabel.Text = Text;
       }

        public void applicationStatusChange(string Text)
       {
           applicationStatus.Text = Text;
       }

        public void returnFromLock(string Text, bool Show)
       {
           this.applicationStatus.Text = Text;
           this.menuStrip.Visible = true;

           Start frm = new Start();
           frm.MdiParent = this;
           frm.Size = new System.Drawing.Size(1211, 782);
           frm.Show();
       }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitApplication frm = new ExitApplication();
            frm.ShowDialog();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            APP0001 frm = new APP0001();
            frm.ShowDialog();
        }

        private void DMParent_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            
            //Open START Screen
            Start frm = new Start();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
                
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            APP0002 frm = new APP0002();
            frm.ShowDialog();
        }

        private void systemCodesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SYSCODES frm = new SYSCODES();
            frm.ShowDialog();
        }

        private void lockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }

            this.menuStrip.Visible = false;
            this.applicationStatus.Text = "Appliction locked";

            Lock frm = new Lock();
            frm.MdiParent = this;
            frm.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CUS0002(null, 0, true).Show();
        }

        private void inventoryItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new INV0002(null, 0, true).Show();
        }

        private void reportBugsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Opens Internet Explorer and opens MantisBT

            System.Diagnostics.Process proc = new System.Diagnostics.Process();

            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = "http://apps.adkinssd.com/bugs";

            proc.Start();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Opens Internet Explorer and opens DealerManager Wiki

            System.Diagnostics.Process proc = new System.Diagnostics.Process();

            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = "http://apps.adkinssd.com/dm/wiki";

            proc.Start();
        }

        private void aPP0010ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Release Notes
        }

        private void dsoplayPreferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            APP0004 frm = new APP0004();
            frm.MdiParent = this;
            frm.Show();
        }

        private void displayPreferencesAPP0004ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            APP0004 frm = new APP0004();
            frm.MdiParent = this;
            frm.Show();
        }

        private void userNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EMP0004 frm = new EMP0004();
            frm.MdiParent = this;
            frm.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

            Login frm = new Login();
            frm.Show();
        }

        private void lockToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }

            this.menuStrip.Visible = false;
            this.applicationStatus.Text = "Appliction locked";

            Lock frm = new Lock();
            frm.MdiParent = this;
            frm.Show();
        }

        private void userPreferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            APP0003 frm = new APP0003();
            this.MdiParent = this;
            frm.ShowDialog();
        }

        private void systemCodesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SYSCODES frm = new SYSCODES();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}

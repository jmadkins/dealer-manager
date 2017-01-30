using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace DealerManager.Modules.Employees
{
    public partial class EMP0004 : Telerik.WinControls.UI.RadForm
    {
        
        public EMP0004()
        {
            InitializeComponent();           
        }

        private void employeeNotesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeNotesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dMDataSetEmployeeNotes);
        }

        private void EMP0004_Load(object sender, EventArgs e)
        {
            try
            {
                this.employeeNotesTableAdapter.Fill(this.dMDataSetEmployeeNotes.employeeNotes, Properties.Settings.Default.app_connectedUserID, 0);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if (this.checkBox1.Checked == true)
            //{
            //    try
            //    {
            //        this.employeeNotesTableAdapter.FillByEmpIDDefault(this.dMDataSetEmployeeNotes.employeeNotes, Properties.Settings.Default.app_connectedUserID);
            //    }
            //    catch (System.Exception ex)
            //    {
            //        System.Windows.Forms.MessageBox.Show(ex.Message);
            //    }
            //}
            //else
            //{
            //    try
            //    {
            //        this.employeeNotesTableAdapter.FillByEmpIDCompleted(this.dMDataSetEmployeeNotes.employeeNotes, Properties.Settings.Default.app_connectedUserID);
            //    }
            //    catch (System.Exception ex)
            //    {
            //        System.Windows.Forms.MessageBox.Show(ex.Message);
            //    }
            //}
        }

        private void qryEmployeeNotesToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.employeeNotesTableAdapter.qryEmployeeNotes(this.dMDataSetEmployeeNotes.employeeNotes);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }
    }
}

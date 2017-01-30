using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using DealerManager.Data;

namespace DealerManager.Forms.Employees
{
    public partial class EMP0002 : Telerik.WinControls.UI.RadForm
    {
        public EMP0002(DMDataSetEmployees dmdse, int position, bool newRecord)
        {
            InitializeComponent();

            if (dmdse == null)
            {
                dmdse = dMDataSetEmployees;
            }
            else
            {
                this.dMDataSetEmployees = dmdse;
                this.employeesBindingSource.DataSource = this.dMDataSetEmployees;
                int newPosition = position;

                if (newRecord == true)
                {
                    this.employeesBindingSource.AddNew();
                }
                else
                {
                    this.employeesBindingSource.Position = position;
                }
            }
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.employeesTableAdapter.Update(this.dMDataSetEmployees.employees);

            this.Close();
        }

        private void EMP0002_Load(object sender, EventArgs e)
        {
            this.securityprofilesTableAdapter.Fill(this.dMDataSetSecurity.securityprofiles);
        }
    }
}

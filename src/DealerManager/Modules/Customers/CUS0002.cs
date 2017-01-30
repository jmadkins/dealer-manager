using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using DealerManager.Data;
using System.Data.SqlServerCe;

namespace DealerManager.Forms.Customers
{
    public partial class CUS0002 : Telerik.WinControls.UI.RadForm
    {
        public CUS0002(DMDataSetCustomers dmdsc, int position, bool newRecord)
        {
            InitializeComponent();

            if (dmdsc == null)
            {
                dmdsc = this.dMDataSetCustomers;
            }
            else
            {
                this.dMDataSetCustomers = dmdsc;
                this.customersBindingSource.DataSource = this.dMDataSetCustomers;
                int newPosition = position;

                if (newRecord == true)
                {
                    this.customersBindingSource.AddNew();
                }
                else
                {
                    this.customersBindingSource.Position = position;
                }
            }
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dMDataSetCustomers);
        }

        private void CUS0002_Load(object sender, EventArgs e)
        {
            this.sys_ReferenceRelationshipTableAdapter.Fill(this.dMDataSetSystemCodes.sys_ReferenceRelationship);
            this.referencesTableAdapter.Fill(this.dMDataSetCustomers.references);
            this.sys_customerSourceTableAdapter.Fill(this.dMDataSetSystemCodes.sys_customerSource);            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.customerReferencesBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.customerReferencesBindingSource.RemoveCurrent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerReferencesBindingSource.EndEdit();
            this.referencesTableAdapter.Update(this.dMDataSetCustomers.references);
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            //View Invoices for this Customer
        }
    }
}

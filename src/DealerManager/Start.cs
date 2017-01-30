using DealerManager.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using DealerManager.Forms.Customers;
using DealerManager.Forms.Inventory;
using DealerManager.Forms.System_Codes;
using DealerManager.Data;

namespace DealerManager
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dMDataSetDeals.dealsdetails' table. You can move, or remove it, as needed.
            this.dealsdetailsTableAdapter.Fill(this.dMDataSetDeals.dealsdetails);
            
            //Automatically set the customerPage as the default page            
            this.radPageView1.SelectedPage = this.radCustomerPage;

            //Resize the gridViews so they look pretty :)
            this.radGridView1.BestFitColumns();
            this.inventoryGridView.BestFitColumns();
            this.dealsGridView.BestFitColumns();

            //Check to see if user wants the application to automatically load the data            
            if (Properties.Settings.Default.app_autodata == true)
            {
                this.customersTableAdapter.Fill(this.dMDataSetCustomers.customers);
                this.inventoryTableAdapter.Fill(this.dMDataSetInventory.inventory);
            }

            this.Text = "Start Screen - Instance: " + Properties.Settings.Default.app_productionStatus;

            #region UI Features
            
            //Theme
            ThemeResolutionService.ApplicationThemeName = "TelerikMetroBlue";

            #endregion                    
        }

        private void Start_FormClosing(object sender, FormClosingEventArgs e)
        {
            //
        }

        //

        #region Customer
        
        private void radGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (radGridView1.SelectedRows.Count > 0)
            {
                DataRowView _rowItemView = (DataRowView)this.radGridView1.SelectedRows[0].DataBoundItem;
                DMDataSetCustomers.customersRow _customersRow = (DMDataSetCustomers.customersRow)_rowItemView.Row;
                int _position = this.dMDataSetCustomers.customers.Rows.IndexOf(_customersRow);
                

                new CUS0002(this.dMDataSetCustomers, _position, false).Show();
            }
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.customersTableAdapter.Update(this.dMDataSetCustomers);

            //if (this.customersTableAdapter.Update(this.dMDataSetCustomers.customers) > 0)
            //{
            //    MessageBox.Show("Customers record(s) were updated");
            //}
            //else
            //{
            //    MessageBox.Show("No records were updated");
            //}
        }

        private void radButton6_Click(object sender, EventArgs e)
        {
            this.radGridView1.BestFitColumns();
            this.customersTableAdapter.Fill(this.dMDataSetCustomers.customers);
        }
        
        private void radButton7_Click(object sender, EventArgs e)
        {
            if (radGridView1.SelectedRows.Count > 0)
            {
                DataRowView _rowItemView = (DataRowView)this.radGridView1.SelectedRows[0].DataBoundItem;
                DMDataSetCustomers.customersRow _customersRow = (DMDataSetCustomers.customersRow)_rowItemView.Row;
                int _position = this.dMDataSetCustomers.customers.Rows.IndexOf(_customersRow);


                new CUS0002(this.dMDataSetCustomers, _position, true).Show();
            }
        }

        #endregion

        //

        #region Inventory

        private void inventoryGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (inventoryGridView.SelectedRows.Count > 0)
            {
                DataRowView _rowItemView = (DataRowView)this.inventoryGridView.SelectedRows[0].DataBoundItem;
                DMDataSetInventory.inventoryRow _inventoryRow = (DMDataSetInventory.inventoryRow)_rowItemView.Row;
                int _position = this.dMDataSetInventory.inventory.Rows.IndexOf(_inventoryRow);

                new INV0002(this.dMDataSetInventory, _position, false).Show();
            }
        }

        private void RadButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inventoryBindingSource.EndEdit();
            this.inventoryTableAdapter.Update(this.dMDataSetInventory);
        }

        private void RadButton_Click_1(object sender, EventArgs e)
        {
            this.inventoryTableAdapter.Fill(this.dMDataSetInventory.inventory);
            this.inventoryGridView.BestFitColumns();
        }

        private void radButton8_Click(object sender, EventArgs e)
        {
            new INV0002(this.dMDataSetInventory, 0, true).Show();
        }

        #endregion



        //

        #region Deals

        #endregion

        //
    }
}

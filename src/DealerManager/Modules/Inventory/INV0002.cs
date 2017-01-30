using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using DealerManager.Data;

namespace DealerManager.Forms.Inventory
{
    public partial class INV0002 : Telerik.WinControls.UI.RadForm
    {
        public INV0002(DMDataSetInventory dmdsi, int position, bool newRecord)
        {
            InitializeComponent();
            this.dMDataSetInventory = dmdsi;
            this.inventoryBindingSource.DataSource = this.dMDataSetInventory;
            int newPosition = position;

            if (newRecord == true)
            {
                this.inventoryBindingSource.AddNew();
            }
            else
            {
                this.inventoryBindingSource.Position = position;
            }

        }

        private void inventoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inventoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dMDataSetInventory);

        }

        private void INV0002_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dMDataSetSystemCodes.sys_inventoryType' table. You can move, or remove it, as needed.
            this.sys_inventoryTypeTableAdapter.Fill(this.dMDataSetSystemCodes.sys_inventoryType);
            // TODO: This line of code loads data into the 'dMDataSetSystemCodes.sys_inventoryFuel' table. You can move, or remove it, as needed.
            this.sys_inventoryFuelTableAdapter.Fill(this.dMDataSetSystemCodes.sys_inventoryFuel);
            // TODO: This line of code loads data into the 'dMDataSetSystemCodes.sys_inventoryTransmission' table. You can move, or remove it, as needed.
            this.sys_inventoryTransmissionTableAdapter.Fill(this.dMDataSetSystemCodes.sys_inventoryTransmission);
            // TODO: This line of code loads data into the 'dMDataSetSystemCodes.sys_inventoryColors' table. You can move, or remove it, as needed.
            this.sys_inventoryColorsTableAdapter.Fill(this.dMDataSetSystemCodes.sys_inventoryColors);
            this.inventoryTableAdapter.Fill(this.dMDataSetInventory.inventory);

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace DealerManager.Modules.Customers
{
    public partial class EMP0002R : Telerik.WinControls.UI.RadForm
    {
        public EMP0002R()
        {
            InitializeComponent();
        }

        private void CUS0002R_Load(object sender, EventArgs e)
        {
            this.companyTableAdapter.Fill(this.dMDataSetCompanyLocations.company);
            this.employeesTableAdapter.Fill(this.dMDataSetEmployees.employees);

            reportViewer1.RefreshReport();
        }
    }
}

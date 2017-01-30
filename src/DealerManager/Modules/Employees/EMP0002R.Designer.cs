namespace DealerManager.Modules.Customers
{
    partial class EMP0002R
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EMP0002R));
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dMDataSetEmployees = new DealerManager.Data.DMDataSetEmployees();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dMDataSetCompanyLocations = new DealerManager.Data.DMDataSetCompanyLocations();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.employeesTableAdapter = new DealerManager.Data.DMDataSetEmployeesTableAdapters.employeesTableAdapter();
            this.companyTableAdapter = new DealerManager.Data.DMDataSetCompanyLocationsTableAdapters.companyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMDataSetEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMDataSetCompanyLocations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "employees";
            this.employeesBindingSource.DataSource = this.dMDataSetEmployees;
            // 
            // dMDataSetEmployees
            // 
            this.dMDataSetEmployees.DataSetName = "DMDataSetEmployees";
            this.dMDataSetEmployees.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "company";
            this.companyBindingSource.DataSource = this.dMDataSetCompanyLocations;
            // 
            // dMDataSetCompanyLocations
            // 
            this.dMDataSetCompanyLocations.DataSetName = "DMDataSetCompanyLocations";
            this.dMDataSetCompanyLocations.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "EmployeesDataSet";
            reportDataSource1.Value = this.employeesBindingSource;
            reportDataSource2.Name = "CompanyDataSet";
            reportDataSource2.Value = this.companyBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DealerManager.Modules.Employees.EMP0002R.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(891, 601);
            this.reportViewer1.TabIndex = 1;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // EMP0002R
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 601);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EMP0002R";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "CUS0002R - Customer Information Report";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.CUS0002R_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMDataSetEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMDataSetCompanyLocations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Data.DMDataSetEmployees dMDataSetEmployees;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private Data.DMDataSetEmployeesTableAdapters.employeesTableAdapter employeesTableAdapter;
        private Data.DMDataSetCompanyLocations dMDataSetCompanyLocations;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private Data.DMDataSetCompanyLocationsTableAdapters.companyTableAdapter companyTableAdapter;
    }
}

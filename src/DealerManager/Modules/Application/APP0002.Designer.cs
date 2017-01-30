namespace DealerManager
{
    partial class APP0002
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
            Telerik.WinControls.UI.RadTreeNode radTreeNode1 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode2 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode3 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode4 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode5 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode6 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode7 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode8 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode9 = new Telerik.WinControls.UI.RadTreeNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APP0002));
            this.radTreeView1 = new Telerik.WinControls.UI.RadTreeView();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radTreeView1
            // 
            this.radTreeView1.BackColor = System.Drawing.Color.White;
            this.radTreeView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radTreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radTreeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTreeView1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radTreeView1.LineStyle = Telerik.WinControls.UI.TreeLineStyle.DashDotDot;
            this.radTreeView1.Location = new System.Drawing.Point(0, 0);
            this.radTreeView1.Name = "radTreeView1";
            radTreeNode1.Name = "AppParent";
            radTreeNode1.Text = "Application";
            radTreeNode2.Expanded = true;
            radTreeNode2.Name = "CustomerParent";
            radTreeNode3.Name = "CUS0002RChild";
            radTreeNode3.Text = "Customer Information";
            radTreeNode2.Nodes.AddRange(new Telerik.WinControls.UI.RadTreeNode[] {
            radTreeNode3});
            radTreeNode2.Text = "Customers";
            radTreeNode4.Expanded = true;
            radTreeNode4.Name = "EmployeeParent";
            radTreeNode5.Name = "CUS0002RChild";
            radTreeNode5.Text = "Employee Information";
            radTreeNode4.Nodes.AddRange(new Telerik.WinControls.UI.RadTreeNode[] {
            radTreeNode5});
            radTreeNode4.Text = "Employees";
            radTreeNode6.Expanded = true;
            radTreeNode6.Name = "InventoryParent";
            radTreeNode7.Name = "INV0002RChild";
            radTreeNode7.Text = "Inventory Information";
            radTreeNode6.Nodes.AddRange(new Telerik.WinControls.UI.RadTreeNode[] {
            radTreeNode7});
            radTreeNode6.Text = "Inventory";
            radTreeNode8.Expanded = true;
            radTreeNode8.Name = "BillingParent";
            radTreeNode9.Name = "BIL0002RChild";
            radTreeNode9.Text = "Invoices";
            radTreeNode8.Nodes.AddRange(new Telerik.WinControls.UI.RadTreeNode[] {
            radTreeNode9});
            radTreeNode8.Text = "Billing";
            this.radTreeView1.Nodes.AddRange(new Telerik.WinControls.UI.RadTreeNode[] {
            radTreeNode1,
            radTreeNode2,
            radTreeNode4,
            radTreeNode6,
            radTreeNode8});
            this.radTreeView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radTreeView1.ShowLines = true;
            this.radTreeView1.Size = new System.Drawing.Size(333, 445);
            this.radTreeView1.SpacingBetweenNodes = -1;
            this.radTreeView1.TabIndex = 0;
            this.radTreeView1.Text = "radTreeView1";
            this.radTreeView1.ThemeName = "ControlDefault";
            this.radTreeView1.NodeMouseClick += new Telerik.WinControls.UI.RadTreeView.TreeViewEventHandler(this.radTreeView1_NodeMouseClick);
            // 
            // APP0002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 445);
            this.Controls.Add(this.radTreeView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "APP0002";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "APP0002 - Report Selecter";
            this.ThemeName = "TelerikMetroBlue";
            this.Load += new System.EventHandler(this.APP0002_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTreeView radTreeView1;

    }
}

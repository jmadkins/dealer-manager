namespace DealerManager.Forms.Customers
{
    partial class CUS0002
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
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label lastnameLabel;
            System.Windows.Forms.Label firstnameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label zipLabel;
            System.Windows.Forms.Label homephoneLabel;
            System.Windows.Forms.Label cellphoneLabel;
            System.Windows.Forms.Label workphoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label dobLabel;
            System.Windows.Forms.Label ssnLabel;
            System.Windows.Forms.Label sourceLabel;
            System.Windows.Forms.Label driverslicenseLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CUS0002));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn17 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn18 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn19 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn20 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn21 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn22 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn23 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn3 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn24 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.sysReferenceRelationshipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dMDataSetSystemCodes = new DealerManager.Data.DMDataSetSystemCodes();
            this.syscustomerSourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dMDataSetCustomers = new DealerManager.Data.DMDataSetCustomers();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new DealerManager.Data.DMDataSetCustomersTableAdapters.customersTableAdapter();
            this.tableAdapterManager = new DealerManager.Data.DMDataSetCustomersTableAdapters.TableAdapterManager();
            this.customersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.customersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.homephoneTextBox = new System.Windows.Forms.TextBox();
            this.cellphoneTextBox = new System.Windows.Forms.TextBox();
            this.workphoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.dobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ssnTextBox = new System.Windows.Forms.TextBox();
            this.driverslicenseTextBox = new System.Windows.Forms.TextBox();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.sourceComboBox = new System.Windows.Forms.ComboBox();
            this.sys_customerSourceTableAdapter = new DealerManager.Data.DMDataSetSystemCodesTableAdapters.sys_customerSourceTableAdapter();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.customerReferencesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.referencesTableAdapter = new DealerManager.Data.DMDataSetCustomersTableAdapters.referencesTableAdapter();
            this.sys_ReferenceRelationshipTableAdapter = new DealerManager.Data.DMDataSetSystemCodesTableAdapters.sys_ReferenceRelationshipTableAdapter();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radButton5 = new Telerik.WinControls.UI.RadButton();
            customerIDLabel = new System.Windows.Forms.Label();
            lastnameLabel = new System.Windows.Forms.Label();
            firstnameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            zipLabel = new System.Windows.Forms.Label();
            homephoneLabel = new System.Windows.Forms.Label();
            cellphoneLabel = new System.Windows.Forms.Label();
            workphoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            dobLabel = new System.Windows.Forms.Label();
            ssnLabel = new System.Windows.Forms.Label();
            sourceLabel = new System.Windows.Forms.Label();
            driverslicenseLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sysReferenceRelationshipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMDataSetSystemCodes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.syscustomerSourceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMDataSetCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).BeginInit();
            this.customersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerReferencesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(420, 28);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(65, 13);
            customerIDLabel.TabIndex = 1;
            customerIDLabel.Text = "Customer ID";
            // 
            // lastnameLabel
            // 
            lastnameLabel.AutoSize = true;
            lastnameLabel.Location = new System.Drawing.Point(211, 28);
            lastnameLabel.Name = "lastnameLabel";
            lastnameLabel.Size = new System.Drawing.Size(58, 13);
            lastnameLabel.TabIndex = 3;
            lastnameLabel.Text = "Last Name";
            // 
            // firstnameLabel
            // 
            firstnameLabel.AutoSize = true;
            firstnameLabel.Location = new System.Drawing.Point(5, 28);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new System.Drawing.Size(57, 13);
            firstnameLabel.TabIndex = 5;
            firstnameLabel.Text = "First Name";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(5, 67);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(45, 13);
            addressLabel.TabIndex = 7;
            addressLabel.Text = "Address";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(5, 106);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(24, 13);
            cityLabel.TabIndex = 9;
            cityLabel.Text = "City";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(175, 106);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(32, 13);
            stateLabel.TabIndex = 11;
            stateLabel.Text = "State";
            // 
            // zipLabel
            // 
            zipLabel.AutoSize = true;
            zipLabel.Location = new System.Drawing.Point(289, 106);
            zipLabel.Name = "zipLabel";
            zipLabel.Size = new System.Drawing.Size(50, 13);
            zipLabel.TabIndex = 13;
            zipLabel.Text = "Zip Code";
            // 
            // homephoneLabel
            // 
            homephoneLabel.AutoSize = true;
            homephoneLabel.Location = new System.Drawing.Point(5, 145);
            homephoneLabel.Name = "homephoneLabel";
            homephoneLabel.Size = new System.Drawing.Size(69, 13);
            homephoneLabel.TabIndex = 15;
            homephoneLabel.Text = "Home Phone";
            // 
            // cellphoneLabel
            // 
            cellphoneLabel.AutoSize = true;
            cellphoneLabel.Location = new System.Drawing.Point(211, 145);
            cellphoneLabel.Name = "cellphoneLabel";
            cellphoneLabel.Size = new System.Drawing.Size(58, 13);
            cellphoneLabel.TabIndex = 17;
            cellphoneLabel.Text = "Cell Phone";
            // 
            // workphoneLabel
            // 
            workphoneLabel.AutoSize = true;
            workphoneLabel.Location = new System.Drawing.Point(8, 184);
            workphoneLabel.Name = "workphoneLabel";
            workphoneLabel.Size = new System.Drawing.Size(67, 13);
            workphoneLabel.TabIndex = 19;
            workphoneLabel.Text = "Work Phone";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(214, 184);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(32, 13);
            emailLabel.TabIndex = 21;
            emailLabel.Text = "Email";
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Location = new System.Drawing.Point(417, 106);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new System.Drawing.Size(66, 13);
            dobLabel.TabIndex = 23;
            dobLabel.Text = "Date of Birth";
            // 
            // ssnLabel
            // 
            ssnLabel.AutoSize = true;
            ssnLabel.Location = new System.Drawing.Point(420, 145);
            ssnLabel.Name = "ssnLabel";
            ssnLabel.Size = new System.Drawing.Size(77, 13);
            ssnLabel.TabIndex = 25;
            ssnLabel.Text = "Social Security";
            // 
            // sourceLabel
            // 
            sourceLabel.AutoSize = true;
            sourceLabel.Location = new System.Drawing.Point(5, 223);
            sourceLabel.Name = "sourceLabel";
            sourceLabel.Size = new System.Drawing.Size(41, 13);
            sourceLabel.TabIndex = 27;
            sourceLabel.Text = "Source";
            // 
            // driverslicenseLabel
            // 
            driverslicenseLabel.AutoSize = true;
            driverslicenseLabel.Location = new System.Drawing.Point(420, 67);
            driverslicenseLabel.Name = "driverslicenseLabel";
            driverslicenseLabel.Size = new System.Drawing.Size(80, 13);
            driverslicenseLabel.TabIndex = 29;
            driverslicenseLabel.Text = "Drivers License";
            // 
            // sysReferenceRelationshipBindingSource
            // 
            this.sysReferenceRelationshipBindingSource.DataMember = "sys_ReferenceRelationship";
            this.sysReferenceRelationshipBindingSource.DataSource = this.dMDataSetSystemCodes;
            // 
            // dMDataSetSystemCodes
            // 
            this.dMDataSetSystemCodes.DataSetName = "DMDataSetSystemCodes";
            this.dMDataSetSystemCodes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // syscustomerSourceBindingSource
            // 
            this.syscustomerSourceBindingSource.DataMember = "sys_customerSource";
            this.syscustomerSourceBindingSource.DataSource = this.dMDataSetSystemCodes;
            // 
            // dMDataSetCustomers
            // 
            this.dMDataSetCustomers.DataSetName = "DMDataSetCustomers";
            this.dMDataSetCustomers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "customers";
            this.customersBindingSource.DataSource = this.dMDataSetCustomers;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.referencesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DealerManager.Data.DMDataSetCustomersTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customersBindingNavigator
            // 
            this.customersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.customersBindingNavigator.BindingSource = this.customersBindingSource;
            this.customersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.customersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.customersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.customersBindingNavigatorSaveItem});
            this.customersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.customersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.customersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.customersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.customersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.customersBindingNavigator.Name = "customersBindingNavigator";
            this.customersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.customersBindingNavigator.Size = new System.Drawing.Size(580, 25);
            this.customersBindingNavigator.TabIndex = 0;
            this.customersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // customersBindingNavigatorSaveItem
            // 
            this.customersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customersBindingNavigatorSaveItem.Image")));
            this.customersBindingNavigatorSaveItem.Name = "customersBindingNavigatorSaveItem";
            this.customersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.customersBindingNavigatorSaveItem.Text = "Save Data";
            this.customersBindingNavigatorSaveItem.Click += new System.EventHandler(this.customersBindingNavigatorSaveItem_Click);
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "customerID", true));
            this.customerIDTextBox.Location = new System.Drawing.Point(420, 44);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.ReadOnly = true;
            this.customerIDTextBox.Size = new System.Drawing.Size(130, 20);
            this.customerIDTextBox.TabIndex = 2;
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "lastname", true));
            this.lastnameTextBox.Location = new System.Drawing.Point(214, 44);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(200, 20);
            this.lastnameTextBox.TabIndex = 2;
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "firstname", true));
            this.firstnameTextBox.Location = new System.Drawing.Point(8, 44);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(200, 20);
            this.firstnameTextBox.TabIndex = 1;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(8, 83);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(406, 20);
            this.addressTextBox.TabIndex = 3;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "city", true));
            this.cityTextBox.Location = new System.Drawing.Point(8, 122);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(161, 20);
            this.cityTextBox.TabIndex = 4;
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "state", true));
            this.stateTextBox.Location = new System.Drawing.Point(175, 122);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(111, 20);
            this.stateTextBox.TabIndex = 5;
            // 
            // zipTextBox
            // 
            this.zipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "zip", true));
            this.zipTextBox.Location = new System.Drawing.Point(292, 122);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(122, 20);
            this.zipTextBox.TabIndex = 6;
            // 
            // homephoneTextBox
            // 
            this.homephoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "homephone", true));
            this.homephoneTextBox.Location = new System.Drawing.Point(8, 161);
            this.homephoneTextBox.Name = "homephoneTextBox";
            this.homephoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.homephoneTextBox.TabIndex = 7;
            // 
            // cellphoneTextBox
            // 
            this.cellphoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "cellphone", true));
            this.cellphoneTextBox.Location = new System.Drawing.Point(214, 161);
            this.cellphoneTextBox.Name = "cellphoneTextBox";
            this.cellphoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.cellphoneTextBox.TabIndex = 8;
            // 
            // workphoneTextBox
            // 
            this.workphoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "workphone", true));
            this.workphoneTextBox.Location = new System.Drawing.Point(8, 200);
            this.workphoneTextBox.Name = "workphoneTextBox";
            this.workphoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.workphoneTextBox.TabIndex = 9;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(214, 200);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(336, 20);
            this.emailTextBox.TabIndex = 10;
            // 
            // dobDateTimePicker
            // 
            this.dobDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.customersBindingSource, "dob", true));
            this.dobDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobDateTimePicker.Location = new System.Drawing.Point(420, 122);
            this.dobDateTimePicker.Name = "dobDateTimePicker";
            this.dobDateTimePicker.Size = new System.Drawing.Size(130, 20);
            this.dobDateTimePicker.TabIndex = 14;
            // 
            // ssnTextBox
            // 
            this.ssnTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "ssn", true));
            this.ssnTextBox.Location = new System.Drawing.Point(420, 161);
            this.ssnTextBox.Name = "ssnTextBox";
            this.ssnTextBox.Size = new System.Drawing.Size(130, 20);
            this.ssnTextBox.TabIndex = 15;
            // 
            // driverslicenseTextBox
            // 
            this.driverslicenseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "driverslicense", true));
            this.driverslicenseTextBox.Location = new System.Drawing.Point(420, 83);
            this.driverslicenseTextBox.Name = "driverslicenseTextBox";
            this.driverslicenseTextBox.Size = new System.Drawing.Size(130, 20);
            this.driverslicenseTextBox.TabIndex = 13;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(firstnameLabel);
            this.radGroupBox1.Controls.Add(this.sourceComboBox);
            this.radGroupBox1.Controls.Add(sourceLabel);
            this.radGroupBox1.Controls.Add(emailLabel);
            this.radGroupBox1.Controls.Add(this.workphoneTextBox);
            this.radGroupBox1.Controls.Add(this.emailTextBox);
            this.radGroupBox1.Controls.Add(workphoneLabel);
            this.radGroupBox1.Controls.Add(cellphoneLabel);
            this.radGroupBox1.Controls.Add(this.homephoneTextBox);
            this.radGroupBox1.Controls.Add(this.cellphoneTextBox);
            this.radGroupBox1.Controls.Add(homephoneLabel);
            this.radGroupBox1.Controls.Add(this.ssnTextBox);
            this.radGroupBox1.Controls.Add(ssnLabel);
            this.radGroupBox1.Controls.Add(this.dobDateTimePicker);
            this.radGroupBox1.Controls.Add(dobLabel);
            this.radGroupBox1.Controls.Add(zipLabel);
            this.radGroupBox1.Controls.Add(stateLabel);
            this.radGroupBox1.Controls.Add(this.cityTextBox);
            this.radGroupBox1.Controls.Add(this.stateTextBox);
            this.radGroupBox1.Controls.Add(this.zipTextBox);
            this.radGroupBox1.Controls.Add(cityLabel);
            this.radGroupBox1.Controls.Add(this.driverslicenseTextBox);
            this.radGroupBox1.Controls.Add(driverslicenseLabel);
            this.radGroupBox1.Controls.Add(this.addressTextBox);
            this.radGroupBox1.Controls.Add(addressLabel);
            this.radGroupBox1.Controls.Add(customerIDLabel);
            this.radGroupBox1.Controls.Add(this.firstnameTextBox);
            this.radGroupBox1.Controls.Add(this.customerIDTextBox);
            this.radGroupBox1.Controls.Add(this.lastnameTextBox);
            this.radGroupBox1.Controls.Add(lastnameLabel);
            this.radGroupBox1.HeaderText = "Basic Information";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 28);
            this.radGroupBox1.Name = "radGroupBox1";
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox1.Size = new System.Drawing.Size(556, 272);
            this.radGroupBox1.TabIndex = 45;
            this.radGroupBox1.Text = "Basic Information";
            this.radGroupBox1.ThemeName = "TelerikMetroBlue";
            // 
            // sourceComboBox
            // 
            this.sourceComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "source", true));
            this.sourceComboBox.DataSource = this.syscustomerSourceBindingSource;
            this.sourceComboBox.DisplayMember = "title";
            this.sourceComboBox.FormattingEnabled = true;
            this.sourceComboBox.Location = new System.Drawing.Point(8, 239);
            this.sourceComboBox.Name = "sourceComboBox";
            this.sourceComboBox.Size = new System.Drawing.Size(200, 21);
            this.sourceComboBox.TabIndex = 46;
            this.sourceComboBox.ValueMember = "title";
            // 
            // sys_customerSourceTableAdapter
            // 
            this.sys_customerSourceTableAdapter.ClearBeforeFill = true;
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.radGridView1);
            this.radGroupBox2.HeaderText = "References";
            this.radGroupBox2.Location = new System.Drawing.Point(12, 306);
            this.radGroupBox2.Name = "radGroupBox2";
            // 
            // 
            // 
            this.radGroupBox2.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox2.Size = new System.Drawing.Size(556, 250);
            this.radGroupBox2.TabIndex = 46;
            this.radGroupBox2.Text = "References";
            this.radGroupBox2.ThemeName = "TelerikMetroBlue";
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Location = new System.Drawing.Point(2, 18);
            // 
            // radGridView1
            // 
            gridViewTextBoxColumn17.FieldName = "lastname";
            gridViewTextBoxColumn17.HeaderText = "Last Name";
            gridViewTextBoxColumn17.IsAutoGenerated = true;
            gridViewTextBoxColumn17.Name = "lastname";
            gridViewTextBoxColumn17.Width = 76;
            gridViewTextBoxColumn18.FieldName = "firstname";
            gridViewTextBoxColumn18.HeaderText = "First Name";
            gridViewTextBoxColumn18.IsAutoGenerated = true;
            gridViewTextBoxColumn18.Name = "firstname";
            gridViewTextBoxColumn18.Width = 78;
            gridViewTextBoxColumn19.FieldName = "address";
            gridViewTextBoxColumn19.HeaderText = "Address";
            gridViewTextBoxColumn19.IsAutoGenerated = true;
            gridViewTextBoxColumn19.Name = "address";
            gridViewTextBoxColumn19.Width = 60;
            gridViewTextBoxColumn20.FieldName = "city";
            gridViewTextBoxColumn20.HeaderText = "City";
            gridViewTextBoxColumn20.IsAutoGenerated = true;
            gridViewTextBoxColumn20.Name = "city";
            gridViewTextBoxColumn20.Width = 33;
            gridViewTextBoxColumn21.FieldName = "state";
            gridViewTextBoxColumn21.HeaderText = "State";
            gridViewTextBoxColumn21.IsAutoGenerated = true;
            gridViewTextBoxColumn21.Name = "state";
            gridViewTextBoxColumn21.Width = 41;
            gridViewTextBoxColumn22.FieldName = "zipcode";
            gridViewTextBoxColumn22.HeaderText = "Zip Code";
            gridViewTextBoxColumn22.IsAutoGenerated = true;
            gridViewTextBoxColumn22.Name = "zipcode";
            gridViewTextBoxColumn22.Width = 67;
            gridViewTextBoxColumn23.FieldName = "phonenumber";
            gridViewTextBoxColumn23.HeaderText = "Phone Number";
            gridViewTextBoxColumn23.IsAutoGenerated = true;
            gridViewTextBoxColumn23.Name = "phonenumber";
            gridViewTextBoxColumn23.Width = 106;
            gridViewComboBoxColumn3.DataSource = this.sysReferenceRelationshipBindingSource;
            gridViewComboBoxColumn3.DisplayMember = "Text";
            gridViewComboBoxColumn3.FieldName = "relation";
            gridViewComboBoxColumn3.HeaderText = "Relationship";
            gridViewComboBoxColumn3.Name = "relation";
            gridViewComboBoxColumn3.Width = 87;
            gridViewTextBoxColumn24.FieldName = "notes";
            gridViewTextBoxColumn24.HeaderText = "Notes";
            gridViewTextBoxColumn24.Multiline = true;
            gridViewTextBoxColumn24.Name = "notes";
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn17,
            gridViewTextBoxColumn18,
            gridViewTextBoxColumn19,
            gridViewTextBoxColumn20,
            gridViewTextBoxColumn21,
            gridViewTextBoxColumn22,
            gridViewTextBoxColumn23,
            gridViewComboBoxColumn3,
            gridViewTextBoxColumn24});
            this.radGridView1.MasterTemplate.DataSource = this.customerReferencesBindingSource;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(552, 230);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.ThemeName = "TelerikMetroBlue";
            // 
            // customerReferencesBindingSource
            // 
            this.customerReferencesBindingSource.DataMember = "CustomerReferences";
            this.customerReferencesBindingSource.DataSource = this.customersBindingSource;
            // 
            // customersBindingSource1
            // 
            this.customersBindingSource1.DataMember = "customers";
            this.customersBindingSource1.DataSource = this.dMDataSetCustomers;
            // 
            // referencesTableAdapter
            // 
            this.referencesTableAdapter.ClearBeforeFill = true;
            // 
            // sys_ReferenceRelationshipTableAdapter
            // 
            this.sys_ReferenceRelationshipTableAdapter.ClearBeforeFill = true;
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(14, 562);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(206, 24);
            this.radButton1.TabIndex = 47;
            this.radButton1.Text = "View Invoices for this Customer";
            this.radButton1.ThemeName = "TelerikMetroBlue";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radButton5
            // 
            this.radButton5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radButton5.Image = global::DealerManager.Properties.Resources.exit;
            this.radButton5.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButton5.Location = new System.Drawing.Point(518, 562);
            this.radButton5.Name = "radButton5";
            this.radButton5.Size = new System.Drawing.Size(50, 51);
            this.radButton5.TabIndex = 48;
            this.radButton5.ThemeName = "TelerikMetroBlue";
            this.radButton5.Click += new System.EventHandler(this.radButton5_Click);
            // 
            // CUS0002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 625);
            this.Controls.Add(this.radButton5);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.customersBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CUS0002";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "CUS0002 - Customer Information";
            this.ThemeName = "TelerikMetroBlue";
            this.Load += new System.EventHandler(this.CUS0002_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sysReferenceRelationshipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMDataSetSystemCodes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.syscustomerSourceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMDataSetCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).EndInit();
            this.customersBindingNavigator.ResumeLayout(false);
            this.customersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerReferencesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Data.DMDataSetCustomers dMDataSetCustomers;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private Data.DMDataSetCustomersTableAdapters.customersTableAdapter customersTableAdapter;
        private Data.DMDataSetCustomersTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator customersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton customersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.TextBox homephoneTextBox;
        private System.Windows.Forms.TextBox cellphoneTextBox;
        private System.Windows.Forms.TextBox workphoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.DateTimePicker dobDateTimePicker;
        private System.Windows.Forms.TextBox ssnTextBox;
        private System.Windows.Forms.TextBox driverslicenseTextBox;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.ComboBox sourceComboBox;
        private Data.DMDataSetSystemCodes dMDataSetSystemCodes;
        private System.Windows.Forms.BindingSource syscustomerSourceBindingSource;
        private Data.DMDataSetSystemCodesTableAdapters.sys_customerSourceTableAdapter sys_customerSourceTableAdapter;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private System.Windows.Forms.BindingSource customersBindingSource1;
        private System.Windows.Forms.BindingSource customerReferencesBindingSource;
        private Data.DMDataSetCustomersTableAdapters.referencesTableAdapter referencesTableAdapter;
        private System.Windows.Forms.BindingSource sysReferenceRelationshipBindingSource;
        private Data.DMDataSetSystemCodesTableAdapters.sys_ReferenceRelationshipTableAdapter sys_ReferenceRelationshipTableAdapter;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton radButton5;
    }
}

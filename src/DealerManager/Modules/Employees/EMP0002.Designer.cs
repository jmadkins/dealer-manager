using DealerManager.Data;
namespace DealerManager.Forms.Employees
{
    partial class EMP0002
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
            System.Windows.Forms.Label empidLabel;
            System.Windows.Forms.Label firstnameLabel;
            System.Windows.Forms.Label lastnameLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label profileLabel;
            System.Windows.Forms.Label departmentLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label zipLabel;
            System.Windows.Forms.Label homephoneLabel;
            System.Windows.Forms.Label cellphoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label driverslicenseLabel;
            System.Windows.Forms.Label dobLabel;
            System.Windows.Forms.Label ssnLabel;
            System.Windows.Forms.Label datehiredLabel;
            System.Windows.Forms.Label datefiredLabel;
            System.Windows.Forms.Label payment_commissionLabel;
            System.Windows.Forms.Label payment_flatrateLabel;
            System.Windows.Forms.Label profileLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EMP0002));
            this.dMDataSetEmployees = new DealerManager.Data.DMDataSetEmployees();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new DealerManager.Data.DMDataSetEmployeesTableAdapters.employeesTableAdapter();
            this.tableAdapterManager = new DealerManager.Data.DMDataSetEmployeesTableAdapters.TableAdapterManager();
            this.employeesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.employeesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.empidTextBox = new System.Windows.Forms.TextBox();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.homephoneTextBox = new System.Windows.Forms.TextBox();
            this.cellphoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.driverslicenseTextBox = new System.Windows.Forms.TextBox();
            this.dobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ssnTextBox = new System.Windows.Forms.TextBox();
            this.datehiredDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.datefiredDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.payment_commissionTextBox = new System.Windows.Forms.TextBox();
            this.payment_flatrateTextBox = new System.Windows.Forms.TextBox();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGroupBox4 = new Telerik.WinControls.UI.RadGroupBox();
            this.profileComboBox = new System.Windows.Forms.ComboBox();
            this.securityprofilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dMDataSetSecurity = new DealerManager.Data.DMDataSetSecurity();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.securityprofilesTableAdapter = new DealerManager.Data.DMDataSetSecurityTableAdapters.securityprofilesTableAdapter();
            empidLabel = new System.Windows.Forms.Label();
            firstnameLabel = new System.Windows.Forms.Label();
            lastnameLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            profileLabel = new System.Windows.Forms.Label();
            departmentLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            zipLabel = new System.Windows.Forms.Label();
            homephoneLabel = new System.Windows.Forms.Label();
            cellphoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            driverslicenseLabel = new System.Windows.Forms.Label();
            dobLabel = new System.Windows.Forms.Label();
            ssnLabel = new System.Windows.Forms.Label();
            datehiredLabel = new System.Windows.Forms.Label();
            datefiredLabel = new System.Windows.Forms.Label();
            payment_commissionLabel = new System.Windows.Forms.Label();
            payment_flatrateLabel = new System.Windows.Forms.Label();
            profileLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dMDataSetEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingNavigator)).BeginInit();
            this.employeesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).BeginInit();
            this.radGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox4)).BeginInit();
            this.radGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.securityprofilesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMDataSetSecurity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // empidLabel
            // 
            empidLabel.AutoSize = true;
            empidLabel.Location = new System.Drawing.Point(417, 28);
            empidLabel.Name = "empidLabel";
            empidLabel.Size = new System.Drawing.Size(67, 13);
            empidLabel.TabIndex = 1;
            empidLabel.Text = "Employee ID";
            // 
            // firstnameLabel
            // 
            firstnameLabel.AutoSize = true;
            firstnameLabel.Location = new System.Drawing.Point(5, 28);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new System.Drawing.Size(57, 13);
            firstnameLabel.TabIndex = 3;
            firstnameLabel.Text = "First Name";
            // 
            // lastnameLabel
            // 
            lastnameLabel.AutoSize = true;
            lastnameLabel.Location = new System.Drawing.Point(211, 28);
            lastnameLabel.Name = "lastnameLabel";
            lastnameLabel.Size = new System.Drawing.Size(58, 13);
            lastnameLabel.TabIndex = 5;
            lastnameLabel.Text = "Last Name";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(5, 28);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(55, 13);
            usernameLabel.TabIndex = 7;
            usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(176, 28);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(53, 13);
            passwordLabel.TabIndex = 9;
            passwordLabel.Text = "Password";
            // 
            // profileLabel
            // 
            profileLabel.AutoSize = true;
            profileLabel.Location = new System.Drawing.Point(5, 67);
            profileLabel.Name = "profileLabel";
            profileLabel.Size = new System.Drawing.Size(77, 13);
            profileLabel.TabIndex = 11;
            profileLabel.Text = "Security Profile";
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Location = new System.Drawing.Point(177, 67);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new System.Drawing.Size(62, 13);
            departmentLabel.TabIndex = 13;
            departmentLabel.Text = "Department";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(5, 67);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(45, 13);
            addressLabel.TabIndex = 25;
            addressLabel.Text = "Address";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(5, 110);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(24, 13);
            cityLabel.TabIndex = 27;
            cityLabel.Text = "City";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(175, 110);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(32, 13);
            stateLabel.TabIndex = 29;
            stateLabel.Text = "State";
            // 
            // zipLabel
            // 
            zipLabel.AutoSize = true;
            zipLabel.Location = new System.Drawing.Point(292, 110);
            zipLabel.Name = "zipLabel";
            zipLabel.Size = new System.Drawing.Size(50, 13);
            zipLabel.TabIndex = 31;
            zipLabel.Text = "Zip Code";
            // 
            // homephoneLabel
            // 
            homephoneLabel.AutoSize = true;
            homephoneLabel.Location = new System.Drawing.Point(5, 149);
            homephoneLabel.Name = "homephoneLabel";
            homephoneLabel.Size = new System.Drawing.Size(69, 13);
            homephoneLabel.TabIndex = 33;
            homephoneLabel.Text = "Home Phone";
            // 
            // cellphoneLabel
            // 
            cellphoneLabel.AutoSize = true;
            cellphoneLabel.Location = new System.Drawing.Point(213, 149);
            cellphoneLabel.Name = "cellphoneLabel";
            cellphoneLabel.Size = new System.Drawing.Size(58, 13);
            cellphoneLabel.TabIndex = 35;
            cellphoneLabel.Text = "Cell Phone";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(5, 188);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(32, 13);
            emailLabel.TabIndex = 37;
            emailLabel.Text = "Email";
            // 
            // driverslicenseLabel
            // 
            driverslicenseLabel.AutoSize = true;
            driverslicenseLabel.Location = new System.Drawing.Point(417, 67);
            driverslicenseLabel.Name = "driverslicenseLabel";
            driverslicenseLabel.Size = new System.Drawing.Size(100, 13);
            driverslicenseLabel.TabIndex = 39;
            driverslicenseLabel.Text = "Drivers License No.";
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Location = new System.Drawing.Point(417, 110);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new System.Drawing.Size(66, 13);
            dobLabel.TabIndex = 41;
            dobLabel.Text = "Date of Birth";
            // 
            // ssnLabel
            // 
            ssnLabel.AutoSize = true;
            ssnLabel.Location = new System.Drawing.Point(420, 149);
            ssnLabel.Name = "ssnLabel";
            ssnLabel.Size = new System.Drawing.Size(77, 13);
            ssnLabel.TabIndex = 43;
            ssnLabel.Text = "Social Security";
            // 
            // datehiredLabel
            // 
            datehiredLabel.AutoSize = true;
            datehiredLabel.Location = new System.Drawing.Point(5, 28);
            datehiredLabel.Name = "datehiredLabel";
            datehiredLabel.Size = new System.Drawing.Size(56, 13);
            datehiredLabel.TabIndex = 45;
            datehiredLabel.Text = "Date hired";
            // 
            // datefiredLabel
            // 
            datefiredLabel.AutoSize = true;
            datefiredLabel.Location = new System.Drawing.Point(5, 58);
            datefiredLabel.Name = "datefiredLabel";
            datefiredLabel.Size = new System.Drawing.Size(53, 13);
            datefiredLabel.TabIndex = 47;
            datefiredLabel.Text = "Date fired";
            // 
            // payment_commissionLabel
            // 
            payment_commissionLabel.AutoSize = true;
            payment_commissionLabel.Location = new System.Drawing.Point(5, 31);
            payment_commissionLabel.Name = "payment_commissionLabel";
            payment_commissionLabel.Size = new System.Drawing.Size(62, 13);
            payment_commissionLabel.TabIndex = 49;
            payment_commissionLabel.Text = "Commission";
            // 
            // payment_flatrateLabel
            // 
            payment_flatrateLabel.AutoSize = true;
            payment_flatrateLabel.Location = new System.Drawing.Point(5, 59);
            payment_flatrateLabel.Name = "payment_flatrateLabel";
            payment_flatrateLabel.Size = new System.Drawing.Size(45, 13);
            payment_flatrateLabel.TabIndex = 51;
            payment_flatrateLabel.Text = "Flat rate";
            // 
            // profileLabel1
            // 
            profileLabel1.AutoSize = true;
            profileLabel1.Location = new System.Drawing.Point(560, 333);
            profileLabel1.Name = "profileLabel1";
            profileLabel1.Size = new System.Drawing.Size(0, 13);
            profileLabel1.TabIndex = 56;
            // 
            // dMDataSetEmployees
            // 
            this.dMDataSetEmployees.DataSetName = "DMDataSetEmployees";
            this.dMDataSetEmployees.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "employees";
            this.employeesBindingSource.DataSource = this.dMDataSetEmployees;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.employeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.UpdateOrder = DealerManager.Data.DMDataSetEmployeesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeesBindingNavigator
            // 
            this.employeesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.employeesBindingNavigator.BindingSource = this.employeesBindingSource;
            this.employeesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.employeesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.employeesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.employeesBindingNavigatorSaveItem});
            this.employeesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.employeesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.employeesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.employeesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.employeesBindingNavigator.MovePreviousItem = this.bindingNavigatorPositionItem;
            this.employeesBindingNavigator.Name = "employeesBindingNavigator";
            this.employeesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.employeesBindingNavigator.Size = new System.Drawing.Size(850, 25);
            this.employeesBindingNavigator.TabIndex = 0;
            this.employeesBindingNavigator.Text = "bindingNavigator1";
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
            // employeesBindingNavigatorSaveItem
            // 
            this.employeesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.employeesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("employeesBindingNavigatorSaveItem.Image")));
            this.employeesBindingNavigatorSaveItem.Name = "employeesBindingNavigatorSaveItem";
            this.employeesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.employeesBindingNavigatorSaveItem.Text = "Save Data";
            this.employeesBindingNavigatorSaveItem.Click += new System.EventHandler(this.employeesBindingNavigatorSaveItem_Click);
            // 
            // empidTextBox
            // 
            this.empidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "empid", true));
            this.empidTextBox.Location = new System.Drawing.Point(420, 44);
            this.empidTextBox.Name = "empidTextBox";
            this.empidTextBox.ReadOnly = true;
            this.empidTextBox.Size = new System.Drawing.Size(113, 20);
            this.empidTextBox.TabIndex = 2;
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "firstname", true));
            this.firstnameTextBox.Location = new System.Drawing.Point(8, 44);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(200, 20);
            this.firstnameTextBox.TabIndex = 1;
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "lastname", true));
            this.lastnameTextBox.Location = new System.Drawing.Point(214, 44);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(200, 20);
            this.lastnameTextBox.TabIndex = 2;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(8, 44);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(165, 20);
            this.usernameTextBox.TabIndex = 17;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(179, 44);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(163, 20);
            this.passwordTextBox.TabIndex = 19;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(8, 87);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(406, 20);
            this.addressTextBox.TabIndex = 3;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "city", true));
            this.cityTextBox.Location = new System.Drawing.Point(8, 126);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(161, 20);
            this.cityTextBox.TabIndex = 4;
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "state", true));
            this.stateTextBox.Location = new System.Drawing.Point(178, 126);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(111, 20);
            this.stateTextBox.TabIndex = 5;
            // 
            // zipTextBox
            // 
            this.zipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "zip", true));
            this.zipTextBox.Location = new System.Drawing.Point(295, 126);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(119, 20);
            this.zipTextBox.TabIndex = 6;
            // 
            // homephoneTextBox
            // 
            this.homephoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "homephone", true));
            this.homephoneTextBox.Location = new System.Drawing.Point(8, 165);
            this.homephoneTextBox.Name = "homephoneTextBox";
            this.homephoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.homephoneTextBox.TabIndex = 7;
            // 
            // cellphoneTextBox
            // 
            this.cellphoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "cellphone", true));
            this.cellphoneTextBox.Location = new System.Drawing.Point(214, 165);
            this.cellphoneTextBox.Name = "cellphoneTextBox";
            this.cellphoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.cellphoneTextBox.TabIndex = 8;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(8, 204);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(525, 20);
            this.emailTextBox.TabIndex = 9;
            // 
            // driverslicenseTextBox
            // 
            this.driverslicenseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "driverslicense", true));
            this.driverslicenseTextBox.Location = new System.Drawing.Point(420, 87);
            this.driverslicenseTextBox.Name = "driverslicenseTextBox";
            this.driverslicenseTextBox.Size = new System.Drawing.Size(113, 20);
            this.driverslicenseTextBox.TabIndex = 10;
            // 
            // dobDateTimePicker
            // 
            this.dobDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeesBindingSource, "dob", true));
            this.dobDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobDateTimePicker.Location = new System.Drawing.Point(420, 126);
            this.dobDateTimePicker.Name = "dobDateTimePicker";
            this.dobDateTimePicker.Size = new System.Drawing.Size(113, 20);
            this.dobDateTimePicker.TabIndex = 11;
            // 
            // ssnTextBox
            // 
            this.ssnTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "ssn", true));
            this.ssnTextBox.Location = new System.Drawing.Point(420, 165);
            this.ssnTextBox.Name = "ssnTextBox";
            this.ssnTextBox.Size = new System.Drawing.Size(113, 20);
            this.ssnTextBox.TabIndex = 12;
            // 
            // datehiredDateTimePicker
            // 
            this.datehiredDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeesBindingSource, "datehired", true));
            this.datehiredDateTimePicker.Location = new System.Drawing.Point(70, 25);
            this.datehiredDateTimePicker.Name = "datehiredDateTimePicker";
            this.datehiredDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datehiredDateTimePicker.TabIndex = 13;
            // 
            // datefiredDateTimePicker
            // 
            this.datefiredDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeesBindingSource, "datefired", true));
            this.datefiredDateTimePicker.Location = new System.Drawing.Point(70, 52);
            this.datefiredDateTimePicker.Name = "datefiredDateTimePicker";
            this.datefiredDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datefiredDateTimePicker.TabIndex = 14;
            // 
            // payment_commissionTextBox
            // 
            this.payment_commissionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "payment_commission", true));
            this.payment_commissionTextBox.Location = new System.Drawing.Point(66, 28);
            this.payment_commissionTextBox.Name = "payment_commissionTextBox";
            this.payment_commissionTextBox.Size = new System.Drawing.Size(200, 20);
            this.payment_commissionTextBox.TabIndex = 15;
            // 
            // payment_flatrateTextBox
            // 
            this.payment_flatrateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "payment_flatrate", true));
            this.payment_flatrateTextBox.Location = new System.Drawing.Point(66, 56);
            this.payment_flatrateTextBox.Name = "payment_flatrateTextBox";
            this.payment_flatrateTextBox.Size = new System.Drawing.Size(200, 20);
            this.payment_flatrateTextBox.TabIndex = 16;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(payment_commissionLabel);
            this.radGroupBox1.Controls.Add(this.payment_flatrateTextBox);
            this.radGroupBox1.Controls.Add(payment_flatrateLabel);
            this.radGroupBox1.Controls.Add(this.payment_commissionTextBox);
            this.radGroupBox1.HeaderText = "Payment Information";
            this.radGroupBox1.Location = new System.Drawing.Point(556, 122);
            this.radGroupBox1.Name = "radGroupBox1";
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox1.Size = new System.Drawing.Size(288, 91);
            this.radGroupBox1.TabIndex = 53;
            this.radGroupBox1.Text = "Payment Information";
            this.radGroupBox1.ThemeName = "TelerikMetroBlue";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(datehiredLabel);
            this.radGroupBox2.Controls.Add(datefiredLabel);
            this.radGroupBox2.Controls.Add(this.datehiredDateTimePicker);
            this.radGroupBox2.Controls.Add(this.datefiredDateTimePicker);
            this.radGroupBox2.HeaderText = "Employment Information";
            this.radGroupBox2.Location = new System.Drawing.Point(556, 28);
            this.radGroupBox2.Name = "radGroupBox2";
            // 
            // 
            // 
            this.radGroupBox2.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox2.Size = new System.Drawing.Size(288, 88);
            this.radGroupBox2.TabIndex = 54;
            this.radGroupBox2.Text = "Employment Information";
            this.radGroupBox2.ThemeName = "TelerikMetroBlue";
            // 
            // radGroupBox3
            // 
            this.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox3.Controls.Add(firstnameLabel);
            this.radGroupBox3.Controls.Add(this.firstnameTextBox);
            this.radGroupBox3.Controls.Add(this.lastnameTextBox);
            this.radGroupBox3.Controls.Add(empidLabel);
            this.radGroupBox3.Controls.Add(lastnameLabel);
            this.radGroupBox3.Controls.Add(this.empidTextBox);
            this.radGroupBox3.Controls.Add(addressLabel);
            this.radGroupBox3.Controls.Add(this.addressTextBox);
            this.radGroupBox3.Controls.Add(cityLabel);
            this.radGroupBox3.Controls.Add(this.cityTextBox);
            this.radGroupBox3.Controls.Add(stateLabel);
            this.radGroupBox3.Controls.Add(this.stateTextBox);
            this.radGroupBox3.Controls.Add(this.zipTextBox);
            this.radGroupBox3.Controls.Add(zipLabel);
            this.radGroupBox3.Controls.Add(homephoneLabel);
            this.radGroupBox3.Controls.Add(this.homephoneTextBox);
            this.radGroupBox3.Controls.Add(this.cellphoneTextBox);
            this.radGroupBox3.Controls.Add(cellphoneLabel);
            this.radGroupBox3.Controls.Add(emailLabel);
            this.radGroupBox3.Controls.Add(this.emailTextBox);
            this.radGroupBox3.Controls.Add(driverslicenseLabel);
            this.radGroupBox3.Controls.Add(this.ssnTextBox);
            this.radGroupBox3.Controls.Add(ssnLabel);
            this.radGroupBox3.Controls.Add(this.dobDateTimePicker);
            this.radGroupBox3.Controls.Add(dobLabel);
            this.radGroupBox3.Controls.Add(this.driverslicenseTextBox);
            this.radGroupBox3.HeaderText = "Basic Information";
            this.radGroupBox3.Location = new System.Drawing.Point(12, 28);
            this.radGroupBox3.Name = "radGroupBox3";
            // 
            // 
            // 
            this.radGroupBox3.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox3.Size = new System.Drawing.Size(538, 244);
            this.radGroupBox3.TabIndex = 55;
            this.radGroupBox3.Text = "Basic Information";
            this.radGroupBox3.ThemeName = "TelerikMetroBlue";
            // 
            // radGroupBox4
            // 
            this.radGroupBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox4.Controls.Add(usernameLabel);
            this.radGroupBox4.Controls.Add(this.profileComboBox);
            this.radGroupBox4.Controls.Add(this.departmentComboBox);
            this.radGroupBox4.Controls.Add(this.usernameTextBox);
            this.radGroupBox4.Controls.Add(this.passwordTextBox);
            this.radGroupBox4.Controls.Add(passwordLabel);
            this.radGroupBox4.Controls.Add(departmentLabel);
            this.radGroupBox4.Controls.Add(profileLabel);
            this.radGroupBox4.HeaderText = "Security";
            this.radGroupBox4.Location = new System.Drawing.Point(12, 278);
            this.radGroupBox4.Name = "radGroupBox4";
            // 
            // 
            // 
            this.radGroupBox4.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox4.Size = new System.Drawing.Size(352, 121);
            this.radGroupBox4.TabIndex = 56;
            this.radGroupBox4.Text = "Security";
            this.radGroupBox4.ThemeName = "TelerikMetroBlue";
            // 
            // profileComboBox
            // 
            this.profileComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "profile", true));
            this.profileComboBox.DataSource = this.securityprofilesBindingSource;
            this.profileComboBox.DisplayMember = "title";
            this.profileComboBox.FormattingEnabled = true;
            this.profileComboBox.Location = new System.Drawing.Point(8, 83);
            this.profileComboBox.Name = "profileComboBox";
            this.profileComboBox.Size = new System.Drawing.Size(165, 21);
            this.profileComboBox.TabIndex = 20;
            this.profileComboBox.ValueMember = "title";
            // 
            // securityprofilesBindingSource
            // 
            this.securityprofilesBindingSource.DataMember = "securityprofiles";
            this.securityprofilesBindingSource.DataSource = this.dMDataSetSecurity;
            // 
            // dMDataSetSecurity
            // 
            this.dMDataSetSecurity.DataSetName = "DMDataSetSecurity";
            this.dMDataSetSecurity.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "department", true));
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Items.AddRange(new object[] {
            "Administrative",
            "Office",
            "Sales",
            "Mechanical",
            "Other"});
            this.departmentComboBox.Location = new System.Drawing.Point(178, 83);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(164, 21);
            this.departmentComboBox.TabIndex = 21;
            // 
            // securityprofilesTableAdapter
            // 
            this.securityprofilesTableAdapter.ClearBeforeFill = true;
            // 
            // EMP0002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 409);
            this.Controls.Add(profileLabel1);
            this.Controls.Add(this.radGroupBox4);
            this.Controls.Add(this.radGroupBox3);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.employeesBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EMP0002";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "EMP0002 - Employee Information";
            this.ThemeName = "TelerikMetroBlue";
            this.Load += new System.EventHandler(this.EMP0002_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dMDataSetEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingNavigator)).EndInit();
            this.employeesBindingNavigator.ResumeLayout(false);
            this.employeesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
            this.radGroupBox3.ResumeLayout(false);
            this.radGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox4)).EndInit();
            this.radGroupBox4.ResumeLayout(false);
            this.radGroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.securityprofilesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMDataSetSecurity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DMDataSetEmployees dMDataSetEmployees;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private Data.DMDataSetEmployeesTableAdapters.employeesTableAdapter employeesTableAdapter;
        private Data.DMDataSetEmployeesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator employeesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton employeesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox empidTextBox;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.TextBox homephoneTextBox;
        private System.Windows.Forms.TextBox cellphoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox driverslicenseTextBox;
        private System.Windows.Forms.DateTimePicker dobDateTimePicker;
        private System.Windows.Forms.TextBox ssnTextBox;
        private System.Windows.Forms.DateTimePicker datehiredDateTimePicker;
        private System.Windows.Forms.DateTimePicker datefiredDateTimePicker;
        private System.Windows.Forms.TextBox payment_commissionTextBox;
        private System.Windows.Forms.TextBox payment_flatrateTextBox;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox3;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox4;
        private System.Windows.Forms.ComboBox profileComboBox;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private DMDataSetSecurity dMDataSetSecurity;
        private System.Windows.Forms.BindingSource securityprofilesBindingSource;
        private Data.DMDataSetSecurityTableAdapters.securityprofilesTableAdapter securityprofilesTableAdapter;
    }
}

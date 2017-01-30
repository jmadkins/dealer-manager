namespace DealerManager.Forms.Inventory
{
    partial class INV0002
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
            System.Windows.Forms.Label stockIDLabel;
            System.Windows.Forms.Label vINLabel;
            System.Windows.Forms.Label yearLabel;
            System.Windows.Forms.Label makeLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label seriesLabel;
            System.Windows.Forms.Label bodyStyleLabel;
            System.Windows.Forms.Label engineSizeLabel;
            System.Windows.Forms.Label colorIntLabel;
            System.Windows.Forms.Label colorExtLabel;
            System.Windows.Forms.Label transmissionLabel;
            System.Windows.Forms.Label vehilceTypeLabel;
            System.Windows.Forms.Label fuelTypeLabel;
            System.Windows.Forms.Label cylindersLabel;
            System.Windows.Forms.Label driveTransmissionLabel;
            System.Windows.Forms.Label dateInLabel;
            System.Windows.Forms.Label askingPriceLabel;
            System.Windows.Forms.Label internetPriceLabel;
            System.Windows.Forms.Label wholeSaleBookLabel;
            System.Windows.Forms.Label retailBookLabel;
            System.Windows.Forms.Label tradeBookLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label keyNoLabel;
            System.Windows.Forms.Label licensePlateLabel;
            System.Windows.Forms.Label mileageLabel;
            System.Windows.Forms.Label kilometersLabel;
            System.Windows.Forms.Label odometerStatusLabel;
            System.Windows.Forms.Label lastRegLabel;
            System.Windows.Forms.Label stateRegLabel;
            System.Windows.Forms.Label mCEngineLabel;
            System.Windows.Forms.Label axlesLabel;
            System.Windows.Forms.Label grossWeightLabel;
            System.Windows.Forms.Label doorsLabel;
            System.Windows.Forms.Label passengersLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INV0002));
            this.dMDataSetInventory = new DealerManager.Data.DMDataSetInventory();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTableAdapter = new DealerManager.Data.DMDataSetInventoryTableAdapters.inventoryTableAdapter();
            this.tableAdapterManager = new DealerManager.Data.DMDataSetInventoryTableAdapters.TableAdapterManager();
            this.inventoryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.inventoryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.stockIDTextBox = new System.Windows.Forms.TextBox();
            this.vINTextBox = new System.Windows.Forms.TextBox();
            this.dateInDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.askingPriceTextBox = new System.Windows.Forms.TextBox();
            this.internetPriceTextBox = new System.Windows.Forms.TextBox();
            this.wholeSaleBookTextBox = new System.Windows.Forms.TextBox();
            this.retailBookTextBox = new System.Windows.Forms.TextBox();
            this.tradeBookTextBox = new System.Windows.Forms.TextBox();
            this.keyNoTextBox = new System.Windows.Forms.TextBox();
            this.licensePlateTextBox = new System.Windows.Forms.TextBox();
            this.mileageTextBox = new System.Windows.Forms.TextBox();
            this.kilometersTextBox = new System.Windows.Forms.TextBox();
            this.lastRegTextBox = new System.Windows.Forms.TextBox();
            this.stateRegTextBox = new System.Windows.Forms.TextBox();
            this.mCEngineTextBox = new System.Windows.Forms.TextBox();
            this.axlesTextBox = new System.Windows.Forms.TextBox();
            this.grossWeightTextBox = new System.Windows.Forms.TextBox();
            this.doorsTextBox = new System.Windows.Forms.TextBox();
            this.passengersTextBox = new System.Windows.Forms.TextBox();
            this.availableCheckBox = new System.Windows.Forms.CheckBox();
            this.odometerStatusComboBox = new System.Windows.Forms.ComboBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.makeComboBox = new System.Windows.Forms.ComboBox();
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.seriesComboBox = new System.Windows.Forms.ComboBox();
            this.bodyStyleComboBox = new System.Windows.Forms.ComboBox();
            this.engineSizeComboBox = new System.Windows.Forms.ComboBox();
            this.colorIntComboBox = new System.Windows.Forms.ComboBox();
            this.colorExtComboBox = new System.Windows.Forms.ComboBox();
            this.transmissionComboBox = new System.Windows.Forms.ComboBox();
            this.fuelTypeComboBox = new System.Windows.Forms.ComboBox();
            this.vehilceTypeComboBox = new System.Windows.Forms.ComboBox();
            this.cylindersComboBox = new System.Windows.Forms.ComboBox();
            this.driveTransmissionComboBox = new System.Windows.Forms.ComboBox();
            this.dMDataSetSystemCodes = new DealerManager.Data.DMDataSetSystemCodes();
            this.dMDataSetSystemCodesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sysinventoryColorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sys_inventoryColorsTableAdapter = new DealerManager.Data.DMDataSetSystemCodesTableAdapters.sys_inventoryColorsTableAdapter();
            this.sysinventoryTransmissionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sys_inventoryTransmissionTableAdapter = new DealerManager.Data.DMDataSetSystemCodesTableAdapters.sys_inventoryTransmissionTableAdapter();
            this.sysinventoryFuelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sys_inventoryFuelTableAdapter = new DealerManager.Data.DMDataSetSystemCodesTableAdapters.sys_inventoryFuelTableAdapter();
            this.sysinventoryTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sys_inventoryTypeTableAdapter = new DealerManager.Data.DMDataSetSystemCodesTableAdapters.sys_inventoryTypeTableAdapter();
            stockIDLabel = new System.Windows.Forms.Label();
            vINLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            makeLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            seriesLabel = new System.Windows.Forms.Label();
            bodyStyleLabel = new System.Windows.Forms.Label();
            engineSizeLabel = new System.Windows.Forms.Label();
            colorIntLabel = new System.Windows.Forms.Label();
            colorExtLabel = new System.Windows.Forms.Label();
            transmissionLabel = new System.Windows.Forms.Label();
            vehilceTypeLabel = new System.Windows.Forms.Label();
            fuelTypeLabel = new System.Windows.Forms.Label();
            cylindersLabel = new System.Windows.Forms.Label();
            driveTransmissionLabel = new System.Windows.Forms.Label();
            dateInLabel = new System.Windows.Forms.Label();
            askingPriceLabel = new System.Windows.Forms.Label();
            internetPriceLabel = new System.Windows.Forms.Label();
            wholeSaleBookLabel = new System.Windows.Forms.Label();
            retailBookLabel = new System.Windows.Forms.Label();
            tradeBookLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            keyNoLabel = new System.Windows.Forms.Label();
            licensePlateLabel = new System.Windows.Forms.Label();
            mileageLabel = new System.Windows.Forms.Label();
            kilometersLabel = new System.Windows.Forms.Label();
            odometerStatusLabel = new System.Windows.Forms.Label();
            lastRegLabel = new System.Windows.Forms.Label();
            stateRegLabel = new System.Windows.Forms.Label();
            mCEngineLabel = new System.Windows.Forms.Label();
            axlesLabel = new System.Windows.Forms.Label();
            grossWeightLabel = new System.Windows.Forms.Label();
            doorsLabel = new System.Windows.Forms.Label();
            passengersLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dMDataSetInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingNavigator)).BeginInit();
            this.inventoryBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dMDataSetSystemCodes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMDataSetSystemCodesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysinventoryColorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysinventoryTransmissionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysinventoryFuelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysinventoryTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // stockIDLabel
            // 
            stockIDLabel.AutoSize = true;
            stockIDLabel.Location = new System.Drawing.Point(54, 45);
            stockIDLabel.Name = "stockIDLabel";
            stockIDLabel.Size = new System.Drawing.Size(52, 13);
            stockIDLabel.TabIndex = 1;
            stockIDLabel.Text = "Stock ID:";
            // 
            // vINLabel
            // 
            vINLabel.AutoSize = true;
            vINLabel.Location = new System.Drawing.Point(78, 71);
            vINLabel.Name = "vINLabel";
            vINLabel.Size = new System.Drawing.Size(28, 13);
            vINLabel.TabIndex = 3;
            vINLabel.Text = "VIN:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new System.Drawing.Point(74, 96);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(32, 13);
            yearLabel.TabIndex = 5;
            yearLabel.Text = "Year:";
            // 
            // makeLabel
            // 
            makeLabel.AutoSize = true;
            makeLabel.Location = new System.Drawing.Point(69, 121);
            makeLabel.Name = "makeLabel";
            makeLabel.Size = new System.Drawing.Size(37, 13);
            makeLabel.TabIndex = 7;
            makeLabel.Text = "Make:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(67, 147);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(39, 13);
            modelLabel.TabIndex = 9;
            modelLabel.Text = "Model:";
            // 
            // seriesLabel
            // 
            seriesLabel.AutoSize = true;
            seriesLabel.Location = new System.Drawing.Point(67, 171);
            seriesLabel.Name = "seriesLabel";
            seriesLabel.Size = new System.Drawing.Size(39, 13);
            seriesLabel.TabIndex = 11;
            seriesLabel.Text = "Series:";
            // 
            // bodyStyleLabel
            // 
            bodyStyleLabel.AutoSize = true;
            bodyStyleLabel.Location = new System.Drawing.Point(46, 194);
            bodyStyleLabel.Name = "bodyStyleLabel";
            bodyStyleLabel.Size = new System.Drawing.Size(60, 13);
            bodyStyleLabel.TabIndex = 13;
            bodyStyleLabel.Text = "Body Style:";
            // 
            // engineSizeLabel
            // 
            engineSizeLabel.AutoSize = true;
            engineSizeLabel.Location = new System.Drawing.Point(40, 219);
            engineSizeLabel.Name = "engineSizeLabel";
            engineSizeLabel.Size = new System.Drawing.Size(66, 13);
            engineSizeLabel.TabIndex = 15;
            engineSizeLabel.Text = "Engine Size:";
            // 
            // colorIntLabel
            // 
            colorIntLabel.AutoSize = true;
            colorIntLabel.Location = new System.Drawing.Point(57, 245);
            colorIntLabel.Name = "colorIntLabel";
            colorIntLabel.Size = new System.Drawing.Size(49, 13);
            colorIntLabel.TabIndex = 17;
            colorIntLabel.Text = "Color Int:";
            // 
            // colorExtLabel
            // 
            colorExtLabel.AutoSize = true;
            colorExtLabel.Location = new System.Drawing.Point(54, 271);
            colorExtLabel.Name = "colorExtLabel";
            colorExtLabel.Size = new System.Drawing.Size(52, 13);
            colorExtLabel.TabIndex = 19;
            colorExtLabel.Text = "Color Ext:";
            // 
            // transmissionLabel
            // 
            transmissionLabel.AutoSize = true;
            transmissionLabel.Location = new System.Drawing.Point(35, 297);
            transmissionLabel.Name = "transmissionLabel";
            transmissionLabel.Size = new System.Drawing.Size(71, 13);
            transmissionLabel.TabIndex = 21;
            transmissionLabel.Text = "Transmission:";
            // 
            // vehilceTypeLabel
            // 
            vehilceTypeLabel.AutoSize = true;
            vehilceTypeLabel.Location = new System.Drawing.Point(34, 325);
            vehilceTypeLabel.Name = "vehilceTypeLabel";
            vehilceTypeLabel.Size = new System.Drawing.Size(72, 13);
            vehilceTypeLabel.TabIndex = 23;
            vehilceTypeLabel.Text = "Vehilce Type:";
            // 
            // fuelTypeLabel
            // 
            fuelTypeLabel.AutoSize = true;
            fuelTypeLabel.Location = new System.Drawing.Point(49, 347);
            fuelTypeLabel.Name = "fuelTypeLabel";
            fuelTypeLabel.Size = new System.Drawing.Size(57, 13);
            fuelTypeLabel.TabIndex = 25;
            fuelTypeLabel.Text = "Fuel Type:";
            // 
            // cylindersLabel
            // 
            cylindersLabel.AutoSize = true;
            cylindersLabel.Location = new System.Drawing.Point(54, 374);
            cylindersLabel.Name = "cylindersLabel";
            cylindersLabel.Size = new System.Drawing.Size(52, 13);
            cylindersLabel.TabIndex = 27;
            cylindersLabel.Text = "Cylinders:";
            // 
            // driveTransmissionLabel
            // 
            driveTransmissionLabel.AutoSize = true;
            driveTransmissionLabel.Location = new System.Drawing.Point(7, 401);
            driveTransmissionLabel.Name = "driveTransmissionLabel";
            driveTransmissionLabel.Size = new System.Drawing.Size(99, 13);
            driveTransmissionLabel.TabIndex = 29;
            driveTransmissionLabel.Text = "Drive Transmission:";
            // 
            // dateInLabel
            // 
            dateInLabel.AutoSize = true;
            dateInLabel.Location = new System.Drawing.Point(308, 38);
            dateInLabel.Name = "dateInLabel";
            dateInLabel.Size = new System.Drawing.Size(45, 13);
            dateInLabel.TabIndex = 31;
            dateInLabel.Text = "Date In:";
            // 
            // askingPriceLabel
            // 
            askingPriceLabel.AutoSize = true;
            askingPriceLabel.Location = new System.Drawing.Point(284, 67);
            askingPriceLabel.Name = "askingPriceLabel";
            askingPriceLabel.Size = new System.Drawing.Size(69, 13);
            askingPriceLabel.TabIndex = 33;
            askingPriceLabel.Text = "Asking Price:";
            // 
            // internetPriceLabel
            // 
            internetPriceLabel.AutoSize = true;
            internetPriceLabel.Location = new System.Drawing.Point(280, 91);
            internetPriceLabel.Name = "internetPriceLabel";
            internetPriceLabel.Size = new System.Drawing.Size(73, 13);
            internetPriceLabel.TabIndex = 35;
            internetPriceLabel.Text = "Internet Price:";
            // 
            // wholeSaleBookLabel
            // 
            wholeSaleBookLabel.AutoSize = true;
            wholeSaleBookLabel.Location = new System.Drawing.Point(260, 119);
            wholeSaleBookLabel.Name = "wholeSaleBookLabel";
            wholeSaleBookLabel.Size = new System.Drawing.Size(93, 13);
            wholeSaleBookLabel.TabIndex = 37;
            wholeSaleBookLabel.Text = "Whole Sale Book:";
            // 
            // retailBookLabel
            // 
            retailBookLabel.AutoSize = true;
            retailBookLabel.Location = new System.Drawing.Point(288, 143);
            retailBookLabel.Name = "retailBookLabel";
            retailBookLabel.Size = new System.Drawing.Size(65, 13);
            retailBookLabel.TabIndex = 39;
            retailBookLabel.Text = "Retail Book:";
            // 
            // tradeBookLabel
            // 
            tradeBookLabel.AutoSize = true;
            tradeBookLabel.Location = new System.Drawing.Point(287, 172);
            tradeBookLabel.Name = "tradeBookLabel";
            tradeBookLabel.Size = new System.Drawing.Size(66, 13);
            tradeBookLabel.TabIndex = 41;
            tradeBookLabel.Text = "Trade Book:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(313, 196);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 43;
            statusLabel.Text = "Status:";
            // 
            // keyNoLabel
            // 
            keyNoLabel.AutoSize = true;
            keyNoLabel.Location = new System.Drawing.Point(308, 221);
            keyNoLabel.Name = "keyNoLabel";
            keyNoLabel.Size = new System.Drawing.Size(45, 13);
            keyNoLabel.TabIndex = 45;
            keyNoLabel.Text = "Key No:";
            // 
            // licensePlateLabel
            // 
            licensePlateLabel.AutoSize = true;
            licensePlateLabel.Location = new System.Drawing.Point(279, 247);
            licensePlateLabel.Name = "licensePlateLabel";
            licensePlateLabel.Size = new System.Drawing.Size(74, 13);
            licensePlateLabel.TabIndex = 47;
            licensePlateLabel.Text = "License Plate:";
            // 
            // mileageLabel
            // 
            mileageLabel.AutoSize = true;
            mileageLabel.Location = new System.Drawing.Point(306, 273);
            mileageLabel.Name = "mileageLabel";
            mileageLabel.Size = new System.Drawing.Size(47, 13);
            mileageLabel.TabIndex = 49;
            mileageLabel.Text = "Mileage:";
            // 
            // kilometersLabel
            // 
            kilometersLabel.AutoSize = true;
            kilometersLabel.Location = new System.Drawing.Point(295, 299);
            kilometersLabel.Name = "kilometersLabel";
            kilometersLabel.Size = new System.Drawing.Size(58, 13);
            kilometersLabel.TabIndex = 51;
            kilometersLabel.Text = "Kilometers:";
            // 
            // odometerStatusLabel
            // 
            odometerStatusLabel.AutoSize = true;
            odometerStatusLabel.Location = new System.Drawing.Point(264, 325);
            odometerStatusLabel.Name = "odometerStatusLabel";
            odometerStatusLabel.Size = new System.Drawing.Size(89, 13);
            odometerStatusLabel.TabIndex = 53;
            odometerStatusLabel.Text = "Odometer Status:";
            // 
            // lastRegLabel
            // 
            lastRegLabel.AutoSize = true;
            lastRegLabel.Location = new System.Drawing.Point(300, 351);
            lastRegLabel.Name = "lastRegLabel";
            lastRegLabel.Size = new System.Drawing.Size(53, 13);
            lastRegLabel.TabIndex = 55;
            lastRegLabel.Text = "Last Reg:";
            // 
            // stateRegLabel
            // 
            stateRegLabel.AutoSize = true;
            stateRegLabel.Location = new System.Drawing.Point(295, 377);
            stateRegLabel.Name = "stateRegLabel";
            stateRegLabel.Size = new System.Drawing.Size(58, 13);
            stateRegLabel.TabIndex = 57;
            stateRegLabel.Text = "State Reg:";
            // 
            // mCEngineLabel
            // 
            mCEngineLabel.AutoSize = true;
            mCEngineLabel.Location = new System.Drawing.Point(294, 403);
            mCEngineLabel.Name = "mCEngineLabel";
            mCEngineLabel.Size = new System.Drawing.Size(59, 13);
            mCEngineLabel.TabIndex = 59;
            mCEngineLabel.Text = "MCEngine:";
            // 
            // axlesLabel
            // 
            axlesLabel.AutoSize = true;
            axlesLabel.Location = new System.Drawing.Point(524, 38);
            axlesLabel.Name = "axlesLabel";
            axlesLabel.Size = new System.Drawing.Size(35, 13);
            axlesLabel.TabIndex = 61;
            axlesLabel.Text = "Axles:";
            // 
            // grossWeightLabel
            // 
            grossWeightLabel.AutoSize = true;
            grossWeightLabel.Location = new System.Drawing.Point(488, 64);
            grossWeightLabel.Name = "grossWeightLabel";
            grossWeightLabel.Size = new System.Drawing.Size(74, 13);
            grossWeightLabel.TabIndex = 63;
            grossWeightLabel.Text = "Gross Weight:";
            // 
            // doorsLabel
            // 
            doorsLabel.AutoSize = true;
            doorsLabel.Location = new System.Drawing.Point(524, 90);
            doorsLabel.Name = "doorsLabel";
            doorsLabel.Size = new System.Drawing.Size(38, 13);
            doorsLabel.TabIndex = 65;
            doorsLabel.Text = "Doors:";
            // 
            // passengersLabel
            // 
            passengersLabel.AutoSize = true;
            passengersLabel.Location = new System.Drawing.Point(497, 113);
            passengersLabel.Name = "passengersLabel";
            passengersLabel.Size = new System.Drawing.Size(65, 13);
            passengersLabel.TabIndex = 67;
            passengersLabel.Text = "Passengers:";
            // 
            // dMDataSetInventory
            // 
            this.dMDataSetInventory.DataSetName = "DMDataSetInventory";
            this.dMDataSetInventory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "inventory";
            this.inventoryBindingSource.DataSource = this.dMDataSetInventory;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.inventoryTableAdapter = this.inventoryTableAdapter;
            this.tableAdapterManager.UpdateOrder = DealerManager.Data.DMDataSetInventoryTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // inventoryBindingNavigator
            // 
            this.inventoryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.inventoryBindingNavigator.BindingSource = this.inventoryBindingSource;
            this.inventoryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.inventoryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.inventoryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.inventoryBindingNavigatorSaveItem});
            this.inventoryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.inventoryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.inventoryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.inventoryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.inventoryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.inventoryBindingNavigator.Name = "inventoryBindingNavigator";
            this.inventoryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.inventoryBindingNavigator.Size = new System.Drawing.Size(780, 25);
            this.inventoryBindingNavigator.TabIndex = 0;
            this.inventoryBindingNavigator.Text = "bindingNavigator1";
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
            // inventoryBindingNavigatorSaveItem
            // 
            this.inventoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.inventoryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("inventoryBindingNavigatorSaveItem.Image")));
            this.inventoryBindingNavigatorSaveItem.Name = "inventoryBindingNavigatorSaveItem";
            this.inventoryBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.inventoryBindingNavigatorSaveItem.Text = "Save Data";
            this.inventoryBindingNavigatorSaveItem.Click += new System.EventHandler(this.inventoryBindingNavigatorSaveItem_Click);
            // 
            // stockIDTextBox
            // 
            this.stockIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "StockID", true));
            this.stockIDTextBox.Location = new System.Drawing.Point(112, 38);
            this.stockIDTextBox.Name = "stockIDTextBox";
            this.stockIDTextBox.Size = new System.Drawing.Size(144, 20);
            this.stockIDTextBox.TabIndex = 2;
            // 
            // vINTextBox
            // 
            this.vINTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "VIN", true));
            this.vINTextBox.Location = new System.Drawing.Point(112, 64);
            this.vINTextBox.Name = "vINTextBox";
            this.vINTextBox.Size = new System.Drawing.Size(144, 20);
            this.vINTextBox.TabIndex = 4;
            // 
            // dateInDateTimePicker
            // 
            this.dateInDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.inventoryBindingSource, "DateIn", true));
            this.dateInDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateInDateTimePicker.Location = new System.Drawing.Point(359, 32);
            this.dateInDateTimePicker.Name = "dateInDateTimePicker";
            this.dateInDateTimePicker.Size = new System.Drawing.Size(123, 20);
            this.dateInDateTimePicker.TabIndex = 32;
            // 
            // askingPriceTextBox
            // 
            this.askingPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "AskingPrice", true));
            this.askingPriceTextBox.Location = new System.Drawing.Point(359, 58);
            this.askingPriceTextBox.Name = "askingPriceTextBox";
            this.askingPriceTextBox.Size = new System.Drawing.Size(123, 20);
            this.askingPriceTextBox.TabIndex = 34;
            // 
            // internetPriceTextBox
            // 
            this.internetPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "InternetPrice", true));
            this.internetPriceTextBox.Location = new System.Drawing.Point(359, 84);
            this.internetPriceTextBox.Name = "internetPriceTextBox";
            this.internetPriceTextBox.Size = new System.Drawing.Size(123, 20);
            this.internetPriceTextBox.TabIndex = 36;
            // 
            // wholeSaleBookTextBox
            // 
            this.wholeSaleBookTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "WholeSaleBook", true));
            this.wholeSaleBookTextBox.Location = new System.Drawing.Point(359, 110);
            this.wholeSaleBookTextBox.Name = "wholeSaleBookTextBox";
            this.wholeSaleBookTextBox.Size = new System.Drawing.Size(123, 20);
            this.wholeSaleBookTextBox.TabIndex = 38;
            // 
            // retailBookTextBox
            // 
            this.retailBookTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "RetailBook", true));
            this.retailBookTextBox.Location = new System.Drawing.Point(359, 136);
            this.retailBookTextBox.Name = "retailBookTextBox";
            this.retailBookTextBox.Size = new System.Drawing.Size(123, 20);
            this.retailBookTextBox.TabIndex = 40;
            // 
            // tradeBookTextBox
            // 
            this.tradeBookTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "TradeBook", true));
            this.tradeBookTextBox.Location = new System.Drawing.Point(359, 162);
            this.tradeBookTextBox.Name = "tradeBookTextBox";
            this.tradeBookTextBox.Size = new System.Drawing.Size(123, 20);
            this.tradeBookTextBox.TabIndex = 42;
            // 
            // keyNoTextBox
            // 
            this.keyNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "KeyNo", true));
            this.keyNoTextBox.Location = new System.Drawing.Point(359, 214);
            this.keyNoTextBox.Name = "keyNoTextBox";
            this.keyNoTextBox.Size = new System.Drawing.Size(123, 20);
            this.keyNoTextBox.TabIndex = 46;
            // 
            // licensePlateTextBox
            // 
            this.licensePlateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "LicensePlate", true));
            this.licensePlateTextBox.Location = new System.Drawing.Point(359, 240);
            this.licensePlateTextBox.Name = "licensePlateTextBox";
            this.licensePlateTextBox.Size = new System.Drawing.Size(123, 20);
            this.licensePlateTextBox.TabIndex = 48;
            // 
            // mileageTextBox
            // 
            this.mileageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "Mileage", true));
            this.mileageTextBox.Location = new System.Drawing.Point(359, 266);
            this.mileageTextBox.Name = "mileageTextBox";
            this.mileageTextBox.Size = new System.Drawing.Size(123, 20);
            this.mileageTextBox.TabIndex = 50;
            // 
            // kilometersTextBox
            // 
            this.kilometersTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "Kilometers", true));
            this.kilometersTextBox.Location = new System.Drawing.Point(359, 292);
            this.kilometersTextBox.Name = "kilometersTextBox";
            this.kilometersTextBox.Size = new System.Drawing.Size(123, 20);
            this.kilometersTextBox.TabIndex = 52;
            // 
            // lastRegTextBox
            // 
            this.lastRegTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "LastReg", true));
            this.lastRegTextBox.Location = new System.Drawing.Point(359, 344);
            this.lastRegTextBox.Name = "lastRegTextBox";
            this.lastRegTextBox.Size = new System.Drawing.Size(123, 20);
            this.lastRegTextBox.TabIndex = 56;
            // 
            // stateRegTextBox
            // 
            this.stateRegTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "StateReg", true));
            this.stateRegTextBox.Location = new System.Drawing.Point(359, 370);
            this.stateRegTextBox.Name = "stateRegTextBox";
            this.stateRegTextBox.Size = new System.Drawing.Size(123, 20);
            this.stateRegTextBox.TabIndex = 58;
            // 
            // mCEngineTextBox
            // 
            this.mCEngineTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "MCEngine", true));
            this.mCEngineTextBox.Location = new System.Drawing.Point(359, 396);
            this.mCEngineTextBox.Name = "mCEngineTextBox";
            this.mCEngineTextBox.Size = new System.Drawing.Size(123, 20);
            this.mCEngineTextBox.TabIndex = 60;
            // 
            // axlesTextBox
            // 
            this.axlesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "Axles", true));
            this.axlesTextBox.Location = new System.Drawing.Point(565, 35);
            this.axlesTextBox.Name = "axlesTextBox";
            this.axlesTextBox.Size = new System.Drawing.Size(200, 20);
            this.axlesTextBox.TabIndex = 62;
            // 
            // grossWeightTextBox
            // 
            this.grossWeightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "GrossWeight", true));
            this.grossWeightTextBox.Location = new System.Drawing.Point(565, 60);
            this.grossWeightTextBox.Name = "grossWeightTextBox";
            this.grossWeightTextBox.Size = new System.Drawing.Size(200, 20);
            this.grossWeightTextBox.TabIndex = 64;
            // 
            // doorsTextBox
            // 
            this.doorsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "Doors", true));
            this.doorsTextBox.Location = new System.Drawing.Point(565, 84);
            this.doorsTextBox.Name = "doorsTextBox";
            this.doorsTextBox.Size = new System.Drawing.Size(200, 20);
            this.doorsTextBox.TabIndex = 66;
            // 
            // passengersTextBox
            // 
            this.passengersTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "Passengers", true));
            this.passengersTextBox.Location = new System.Drawing.Point(565, 110);
            this.passengersTextBox.Name = "passengersTextBox";
            this.passengersTextBox.Size = new System.Drawing.Size(200, 20);
            this.passengersTextBox.TabIndex = 68;
            // 
            // availableCheckBox
            // 
            this.availableCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.inventoryBindingSource, "Available", true));
            this.availableCheckBox.Location = new System.Drawing.Point(527, 136);
            this.availableCheckBox.Name = "availableCheckBox";
            this.availableCheckBox.Size = new System.Drawing.Size(238, 46);
            this.availableCheckBox.TabIndex = 70;
            this.availableCheckBox.Text = "Available for Purchase";
            this.availableCheckBox.UseVisualStyleBackColor = true;
            // 
            // odometerStatusComboBox
            // 
            this.odometerStatusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "OdometerStatus", true));
            this.odometerStatusComboBox.FormattingEnabled = true;
            this.odometerStatusComboBox.Items.AddRange(new object[] {
            "ACTUAL",
            "TMU",
            "OVER",
            "TMU/OVER",
            "EXEMPT",
            "MNR"});
            this.odometerStatusComboBox.Location = new System.Drawing.Point(359, 317);
            this.odometerStatusComboBox.Name = "odometerStatusComboBox";
            this.odometerStatusComboBox.Size = new System.Drawing.Size(123, 21);
            this.odometerStatusComboBox.TabIndex = 74;
            // 
            // statusComboBox
            // 
            this.statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "Status", true));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "New",
            "Used"});
            this.statusComboBox.Location = new System.Drawing.Point(359, 188);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(123, 21);
            this.statusComboBox.TabIndex = 76;
            // 
            // yearComboBox
            // 
            this.yearComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "Year", true));
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(112, 87);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(144, 21);
            this.yearComboBox.TabIndex = 77;
            // 
            // makeComboBox
            // 
            this.makeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "Make", true));
            this.makeComboBox.FormattingEnabled = true;
            this.makeComboBox.Location = new System.Drawing.Point(112, 113);
            this.makeComboBox.Name = "makeComboBox";
            this.makeComboBox.Size = new System.Drawing.Size(144, 21);
            this.makeComboBox.TabIndex = 78;
            // 
            // modelComboBox
            // 
            this.modelComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "Model", true));
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Location = new System.Drawing.Point(112, 139);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(144, 21);
            this.modelComboBox.TabIndex = 79;
            // 
            // seriesComboBox
            // 
            this.seriesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "Series", true));
            this.seriesComboBox.FormattingEnabled = true;
            this.seriesComboBox.Location = new System.Drawing.Point(112, 163);
            this.seriesComboBox.Name = "seriesComboBox";
            this.seriesComboBox.Size = new System.Drawing.Size(144, 21);
            this.seriesComboBox.TabIndex = 80;
            // 
            // bodyStyleComboBox
            // 
            this.bodyStyleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "BodyStyle", true));
            this.bodyStyleComboBox.FormattingEnabled = true;
            this.bodyStyleComboBox.Location = new System.Drawing.Point(112, 185);
            this.bodyStyleComboBox.Name = "bodyStyleComboBox";
            this.bodyStyleComboBox.Size = new System.Drawing.Size(144, 21);
            this.bodyStyleComboBox.TabIndex = 81;
            // 
            // engineSizeComboBox
            // 
            this.engineSizeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "EngineSize", true));
            this.engineSizeComboBox.FormattingEnabled = true;
            this.engineSizeComboBox.Items.AddRange(new object[] {
            "1.5",
            "1.6",
            "2.2",
            "2.8",
            "3.2",
            "5.0",
            "5.2",
            "7.0",
            "V6 4.0",
            "V8 5.7"});
            this.engineSizeComboBox.Location = new System.Drawing.Point(112, 211);
            this.engineSizeComboBox.Name = "engineSizeComboBox";
            this.engineSizeComboBox.Size = new System.Drawing.Size(144, 21);
            this.engineSizeComboBox.TabIndex = 82;
            // 
            // colorIntComboBox
            // 
            this.colorIntComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "ColorInt", true));
            this.colorIntComboBox.DataSource = this.sysinventoryColorsBindingSource;
            this.colorIntComboBox.DisplayMember = "ColorName";
            this.colorIntComboBox.FormattingEnabled = true;
            this.colorIntComboBox.Location = new System.Drawing.Point(112, 237);
            this.colorIntComboBox.Name = "colorIntComboBox";
            this.colorIntComboBox.Size = new System.Drawing.Size(144, 21);
            this.colorIntComboBox.TabIndex = 83;
            this.colorIntComboBox.ValueMember = "ColorName";
            // 
            // colorExtComboBox
            // 
            this.colorExtComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "ColorExt", true));
            this.colorExtComboBox.DataSource = this.sysinventoryColorsBindingSource;
            this.colorExtComboBox.DisplayMember = "ColorName";
            this.colorExtComboBox.FormattingEnabled = true;
            this.colorExtComboBox.Location = new System.Drawing.Point(112, 263);
            this.colorExtComboBox.Name = "colorExtComboBox";
            this.colorExtComboBox.Size = new System.Drawing.Size(144, 21);
            this.colorExtComboBox.TabIndex = 84;
            this.colorExtComboBox.ValueMember = "ColorName";
            // 
            // transmissionComboBox
            // 
            this.transmissionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "Transmission", true));
            this.transmissionComboBox.DataSource = this.sysinventoryTransmissionBindingSource;
            this.transmissionComboBox.DisplayMember = "Name";
            this.transmissionComboBox.FormattingEnabled = true;
            this.transmissionComboBox.Location = new System.Drawing.Point(112, 289);
            this.transmissionComboBox.Name = "transmissionComboBox";
            this.transmissionComboBox.Size = new System.Drawing.Size(144, 21);
            this.transmissionComboBox.TabIndex = 85;
            this.transmissionComboBox.ValueMember = "Name";
            // 
            // fuelTypeComboBox
            // 
            this.fuelTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "FuelType", true));
            this.fuelTypeComboBox.DataSource = this.sysinventoryFuelBindingSource;
            this.fuelTypeComboBox.DisplayMember = "Name";
            this.fuelTypeComboBox.FormattingEnabled = true;
            this.fuelTypeComboBox.Location = new System.Drawing.Point(112, 339);
            this.fuelTypeComboBox.Name = "fuelTypeComboBox";
            this.fuelTypeComboBox.Size = new System.Drawing.Size(144, 21);
            this.fuelTypeComboBox.TabIndex = 86;
            this.fuelTypeComboBox.ValueMember = "Name";
            // 
            // vehilceTypeComboBox
            // 
            this.vehilceTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "VehilceType", true));
            this.vehilceTypeComboBox.DataSource = this.sysinventoryTypeBindingSource;
            this.vehilceTypeComboBox.DisplayMember = "VehicleType";
            this.vehilceTypeComboBox.FormattingEnabled = true;
            this.vehilceTypeComboBox.Location = new System.Drawing.Point(112, 315);
            this.vehilceTypeComboBox.Name = "vehilceTypeComboBox";
            this.vehilceTypeComboBox.Size = new System.Drawing.Size(144, 21);
            this.vehilceTypeComboBox.TabIndex = 87;
            this.vehilceTypeComboBox.ValueMember = "VehicleType";
            // 
            // cylindersComboBox
            // 
            this.cylindersComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "Cylinders", true));
            this.cylindersComboBox.FormattingEnabled = true;
            this.cylindersComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cylindersComboBox.Location = new System.Drawing.Point(112, 366);
            this.cylindersComboBox.Name = "cylindersComboBox";
            this.cylindersComboBox.Size = new System.Drawing.Size(144, 21);
            this.cylindersComboBox.TabIndex = 88;
            // 
            // driveTransmissionComboBox
            // 
            this.driveTransmissionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "DriveTransmission", true));
            this.driveTransmissionComboBox.FormattingEnabled = true;
            this.driveTransmissionComboBox.Items.AddRange(new object[] {
            "2WD",
            "4WD",
            "AWD",
            "FWD",
            "RWD"});
            this.driveTransmissionComboBox.Location = new System.Drawing.Point(112, 393);
            this.driveTransmissionComboBox.Name = "driveTransmissionComboBox";
            this.driveTransmissionComboBox.Size = new System.Drawing.Size(144, 21);
            this.driveTransmissionComboBox.TabIndex = 89;
            // 
            // dMDataSetSystemCodes
            // 
            this.dMDataSetSystemCodes.DataSetName = "DMDataSetSystemCodes";
            this.dMDataSetSystemCodes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dMDataSetSystemCodesBindingSource
            // 
            this.dMDataSetSystemCodesBindingSource.DataSource = this.dMDataSetSystemCodes;
            this.dMDataSetSystemCodesBindingSource.Position = 0;
            // 
            // sysinventoryColorsBindingSource
            // 
            this.sysinventoryColorsBindingSource.DataMember = "sys_inventoryColors";
            this.sysinventoryColorsBindingSource.DataSource = this.dMDataSetSystemCodesBindingSource;
            // 
            // sys_inventoryColorsTableAdapter
            // 
            this.sys_inventoryColorsTableAdapter.ClearBeforeFill = true;
            // 
            // sysinventoryTransmissionBindingSource
            // 
            this.sysinventoryTransmissionBindingSource.DataMember = "sys_inventoryTransmission";
            this.sysinventoryTransmissionBindingSource.DataSource = this.dMDataSetSystemCodesBindingSource;
            // 
            // sys_inventoryTransmissionTableAdapter
            // 
            this.sys_inventoryTransmissionTableAdapter.ClearBeforeFill = true;
            // 
            // sysinventoryFuelBindingSource
            // 
            this.sysinventoryFuelBindingSource.DataMember = "sys_inventoryFuel";
            this.sysinventoryFuelBindingSource.DataSource = this.dMDataSetSystemCodesBindingSource;
            // 
            // sys_inventoryFuelTableAdapter
            // 
            this.sys_inventoryFuelTableAdapter.ClearBeforeFill = true;
            // 
            // sysinventoryTypeBindingSource
            // 
            this.sysinventoryTypeBindingSource.DataMember = "sys_inventoryType";
            this.sysinventoryTypeBindingSource.DataSource = this.dMDataSetSystemCodesBindingSource;
            // 
            // sys_inventoryTypeTableAdapter
            // 
            this.sys_inventoryTypeTableAdapter.ClearBeforeFill = true;
            // 
            // INV0002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 442);
            this.Controls.Add(this.driveTransmissionComboBox);
            this.Controls.Add(this.cylindersComboBox);
            this.Controls.Add(this.vehilceTypeComboBox);
            this.Controls.Add(this.fuelTypeComboBox);
            this.Controls.Add(this.transmissionComboBox);
            this.Controls.Add(this.colorExtComboBox);
            this.Controls.Add(this.colorIntComboBox);
            this.Controls.Add(this.engineSizeComboBox);
            this.Controls.Add(this.bodyStyleComboBox);
            this.Controls.Add(this.seriesComboBox);
            this.Controls.Add(this.modelComboBox);
            this.Controls.Add(this.makeComboBox);
            this.Controls.Add(this.yearComboBox);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.odometerStatusComboBox);
            this.Controls.Add(stockIDLabel);
            this.Controls.Add(this.stockIDTextBox);
            this.Controls.Add(vINLabel);
            this.Controls.Add(this.vINTextBox);
            this.Controls.Add(yearLabel);
            this.Controls.Add(makeLabel);
            this.Controls.Add(modelLabel);
            this.Controls.Add(seriesLabel);
            this.Controls.Add(bodyStyleLabel);
            this.Controls.Add(engineSizeLabel);
            this.Controls.Add(colorIntLabel);
            this.Controls.Add(colorExtLabel);
            this.Controls.Add(transmissionLabel);
            this.Controls.Add(vehilceTypeLabel);
            this.Controls.Add(fuelTypeLabel);
            this.Controls.Add(cylindersLabel);
            this.Controls.Add(driveTransmissionLabel);
            this.Controls.Add(dateInLabel);
            this.Controls.Add(this.dateInDateTimePicker);
            this.Controls.Add(askingPriceLabel);
            this.Controls.Add(this.askingPriceTextBox);
            this.Controls.Add(internetPriceLabel);
            this.Controls.Add(this.internetPriceTextBox);
            this.Controls.Add(wholeSaleBookLabel);
            this.Controls.Add(this.wholeSaleBookTextBox);
            this.Controls.Add(retailBookLabel);
            this.Controls.Add(this.retailBookTextBox);
            this.Controls.Add(tradeBookLabel);
            this.Controls.Add(this.tradeBookTextBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(keyNoLabel);
            this.Controls.Add(this.keyNoTextBox);
            this.Controls.Add(licensePlateLabel);
            this.Controls.Add(this.licensePlateTextBox);
            this.Controls.Add(mileageLabel);
            this.Controls.Add(this.mileageTextBox);
            this.Controls.Add(kilometersLabel);
            this.Controls.Add(this.kilometersTextBox);
            this.Controls.Add(odometerStatusLabel);
            this.Controls.Add(lastRegLabel);
            this.Controls.Add(this.lastRegTextBox);
            this.Controls.Add(stateRegLabel);
            this.Controls.Add(this.stateRegTextBox);
            this.Controls.Add(mCEngineLabel);
            this.Controls.Add(this.mCEngineTextBox);
            this.Controls.Add(axlesLabel);
            this.Controls.Add(this.axlesTextBox);
            this.Controls.Add(grossWeightLabel);
            this.Controls.Add(this.grossWeightTextBox);
            this.Controls.Add(doorsLabel);
            this.Controls.Add(this.doorsTextBox);
            this.Controls.Add(passengersLabel);
            this.Controls.Add(this.passengersTextBox);
            this.Controls.Add(this.availableCheckBox);
            this.Controls.Add(this.inventoryBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "INV0002";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "INV0002 - Vehicle Details";
            this.ThemeName = "TelerikMetroBlue";
            this.Load += new System.EventHandler(this.INV0002_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dMDataSetInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingNavigator)).EndInit();
            this.inventoryBindingNavigator.ResumeLayout(false);
            this.inventoryBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dMDataSetSystemCodes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMDataSetSystemCodesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysinventoryColorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysinventoryTransmissionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysinventoryFuelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysinventoryTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Data.DMDataSetInventory dMDataSetInventory;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private Data.DMDataSetInventoryTableAdapters.inventoryTableAdapter inventoryTableAdapter;
        private Data.DMDataSetInventoryTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator inventoryBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton inventoryBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox stockIDTextBox;
        private System.Windows.Forms.TextBox vINTextBox;
        private System.Windows.Forms.DateTimePicker dateInDateTimePicker;
        private System.Windows.Forms.TextBox askingPriceTextBox;
        private System.Windows.Forms.TextBox internetPriceTextBox;
        private System.Windows.Forms.TextBox wholeSaleBookTextBox;
        private System.Windows.Forms.TextBox retailBookTextBox;
        private System.Windows.Forms.TextBox tradeBookTextBox;
        private System.Windows.Forms.TextBox keyNoTextBox;
        private System.Windows.Forms.TextBox licensePlateTextBox;
        private System.Windows.Forms.TextBox mileageTextBox;
        private System.Windows.Forms.TextBox kilometersTextBox;
        private System.Windows.Forms.TextBox lastRegTextBox;
        private System.Windows.Forms.TextBox stateRegTextBox;
        private System.Windows.Forms.TextBox mCEngineTextBox;
        private System.Windows.Forms.TextBox axlesTextBox;
        private System.Windows.Forms.TextBox grossWeightTextBox;
        private System.Windows.Forms.TextBox doorsTextBox;
        private System.Windows.Forms.TextBox passengersTextBox;
        private System.Windows.Forms.CheckBox availableCheckBox;
        private System.Windows.Forms.ComboBox odometerStatusComboBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.ComboBox makeComboBox;
        private System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.ComboBox seriesComboBox;
        private System.Windows.Forms.ComboBox bodyStyleComboBox;
        private System.Windows.Forms.ComboBox engineSizeComboBox;
        private System.Windows.Forms.ComboBox colorIntComboBox;
        private System.Windows.Forms.ComboBox colorExtComboBox;
        private System.Windows.Forms.ComboBox transmissionComboBox;
        private System.Windows.Forms.ComboBox fuelTypeComboBox;
        private System.Windows.Forms.ComboBox vehilceTypeComboBox;
        private System.Windows.Forms.ComboBox cylindersComboBox;
        private System.Windows.Forms.ComboBox driveTransmissionComboBox;
        private Data.DMDataSetSystemCodes dMDataSetSystemCodes;
        private System.Windows.Forms.BindingSource dMDataSetSystemCodesBindingSource;
        private System.Windows.Forms.BindingSource sysinventoryColorsBindingSource;
        private Data.DMDataSetSystemCodesTableAdapters.sys_inventoryColorsTableAdapter sys_inventoryColorsTableAdapter;
        private System.Windows.Forms.BindingSource sysinventoryTransmissionBindingSource;
        private Data.DMDataSetSystemCodesTableAdapters.sys_inventoryTransmissionTableAdapter sys_inventoryTransmissionTableAdapter;
        private System.Windows.Forms.BindingSource sysinventoryFuelBindingSource;
        private Data.DMDataSetSystemCodesTableAdapters.sys_inventoryFuelTableAdapter sys_inventoryFuelTableAdapter;
        private System.Windows.Forms.BindingSource sysinventoryTypeBindingSource;
        private Data.DMDataSetSystemCodesTableAdapters.sys_inventoryTypeTableAdapter sys_inventoryTypeTableAdapter;
    }
}

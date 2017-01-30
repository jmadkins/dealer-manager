namespace DealerManager.Modules.Employees
{
    partial class EMP0004
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EMP0004));
            this.employeeNotesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.employeeNotesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.employeeNotesDataGridView = new System.Windows.Forms.DataGridView();
            this.FollowUp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Completed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.radButton5 = new Telerik.WinControls.UI.RadButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNotesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dMDataSetEmployeeNotes = new DealerManager.Data.DMDataSetEmployeeNotes();
            this.employeeNotesTableAdapter = new DealerManager.Data.DMDataSetEmployeeNotesTableAdapters.employeeNotesTableAdapter();
            this.tableAdapterManager = new DealerManager.Data.DMDataSetEmployeeNotesTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.employeeNotesBindingNavigator)).BeginInit();
            this.employeeNotesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeNotesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeNotesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMDataSetEmployeeNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeNotesBindingNavigator
            // 
            this.employeeNotesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.employeeNotesBindingNavigator.BindingSource = this.employeeNotesBindingSource;
            this.employeeNotesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.employeeNotesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.employeeNotesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.employeeNotesBindingNavigatorSaveItem});
            this.employeeNotesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.employeeNotesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.employeeNotesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.employeeNotesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.employeeNotesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.employeeNotesBindingNavigator.Name = "employeeNotesBindingNavigator";
            this.employeeNotesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.employeeNotesBindingNavigator.Size = new System.Drawing.Size(700, 25);
            this.employeeNotesBindingNavigator.TabIndex = 0;
            this.employeeNotesBindingNavigator.Text = "bindingNavigator1";
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
            // employeeNotesBindingNavigatorSaveItem
            // 
            this.employeeNotesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.employeeNotesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("employeeNotesBindingNavigatorSaveItem.Image")));
            this.employeeNotesBindingNavigatorSaveItem.Name = "employeeNotesBindingNavigatorSaveItem";
            this.employeeNotesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.employeeNotesBindingNavigatorSaveItem.Text = "Save Data";
            this.employeeNotesBindingNavigatorSaveItem.Click += new System.EventHandler(this.employeeNotesBindingNavigatorSaveItem_Click);
            // 
            // employeeNotesDataGridView
            // 
            this.employeeNotesDataGridView.AutoGenerateColumns = false;
            this.employeeNotesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeNotesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.FollowUp,
            this.Completed});
            this.employeeNotesDataGridView.DataSource = this.employeeNotesBindingSource;
            this.employeeNotesDataGridView.Location = new System.Drawing.Point(0, 28);
            this.employeeNotesDataGridView.Name = "employeeNotesDataGridView";
            this.employeeNotesDataGridView.Size = new System.Drawing.Size(696, 376);
            this.employeeNotesDataGridView.TabIndex = 1;
            // 
            // FollowUp
            // 
            this.FollowUp.DataPropertyName = "FollowUp";
            this.FollowUp.HeaderText = "Follow Up Date";
            this.FollowUp.Name = "FollowUp";
            // 
            // Completed
            // 
            this.Completed.DataPropertyName = "Completed";
            this.Completed.HeaderText = "Completed";
            this.Completed.Name = "Completed";
            // 
            // radButton5
            // 
            this.radButton5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radButton5.Image = global::DealerManager.Properties.Resources.exit;
            this.radButton5.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButton5.Location = new System.Drawing.Point(640, 409);
            this.radButton5.Name = "radButton5";
            this.radButton5.Size = new System.Drawing.Size(56, 51);
            this.radButton5.TabIndex = 15;
            this.radButton5.ThemeName = "TelerikMetroBlue";
            this.radButton5.Click += new System.EventHandler(this.radButton5_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 410);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 17);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Show Completed";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn3.HeaderText = "Title";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Text";
            this.dataGridViewTextBoxColumn4.HeaderText = "Text";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // employeeNotesBindingSource
            // 
            this.employeeNotesBindingSource.DataMember = "employeeNotes";
            this.employeeNotesBindingSource.DataSource = this.dMDataSetEmployeeNotes;
            // 
            // dMDataSetEmployeeNotes
            // 
            this.dMDataSetEmployeeNotes.DataSetName = "DMDataSetEmployeeNotes";
            this.dMDataSetEmployeeNotes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeNotesTableAdapter
            // 
            this.employeeNotesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.employeeNotesTableAdapter = this.employeeNotesTableAdapter;
            this.tableAdapterManager.UpdateOrder = DealerManager.Data.DMDataSetEmployeeNotesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // EMP0004
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 463);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.radButton5);
            this.Controls.Add(this.employeeNotesDataGridView);
            this.Controls.Add(this.employeeNotesBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EMP0004";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "EMP0004 - Employee Notes";
            this.ThemeName = "TelerikMetroBlue";
            this.Load += new System.EventHandler(this.EMP0004_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeNotesBindingNavigator)).EndInit();
            this.employeeNotesBindingNavigator.ResumeLayout(false);
            this.employeeNotesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeNotesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeNotesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMDataSetEmployeeNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Data.DMDataSetEmployeeNotes dMDataSetEmployeeNotes;
        private System.Windows.Forms.BindingSource employeeNotesBindingSource;
        private Data.DMDataSetEmployeeNotesTableAdapters.employeeNotesTableAdapter employeeNotesTableAdapter;
        private Data.DMDataSetEmployeeNotesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator employeeNotesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton employeeNotesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView employeeNotesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn FollowUp;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Completed;
        private Telerik.WinControls.UI.RadButton radButton5;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

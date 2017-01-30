using DealerManager.Data;
namespace DealerManager
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.appVersion = new System.Windows.Forms.Label();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.passwordBox = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameBox = new Telerik.WinControls.UI.RadTextBox();
            this.dMDataSet = new DealerManager.Data.DMDataSet();
            this.dMDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dMDataSetEmployees = new DealerManager.Data.DMDataSetEmployees();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new DealerManager.Data.DMDataSetEmployeesTableAdapters.employeesTableAdapter();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMDataSetEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Image = global::DealerManager.Properties.Resources.asd_dealermanager;
            this.pictureBox3.Location = new System.Drawing.Point(88, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(385, 84);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 48;
            this.pictureBox3.TabStop = false;
            // 
            // appVersion
            // 
            this.appVersion.AutoSize = true;
            this.appVersion.Font = new System.Drawing.Font("Segoe WP", 10F);
            this.appVersion.Location = new System.Drawing.Point(84, 110);
            this.appVersion.Name = "appVersion";
            this.appVersion.Size = new System.Drawing.Size(112, 19);
            this.appVersion.TabIndex = 46;
            this.appVersion.Text = "Version: 0.2.13.15";
            // 
            // radButton1
            // 
            this.radButton1.EnableKeyMap = true;
            this.radButton1.Location = new System.Drawing.Point(88, 197);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(187, 32);
            this.radButton1.TabIndex = 3;
            this.radButton1.Text = "CONNECT";
            this.radButton1.ThemeName = "TelerikMetroBlue";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            this.radButton1.Enter += new System.EventHandler(this.radButton1_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(201, 165);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(227, 22);
            this.passwordBox.TabIndex = 2;
            this.passwordBox.TabStop = false;
            this.passwordBox.ThemeName = "TelerikMetroBlue";
            this.passwordBox.Enter += new System.EventHandler(this.passwordBox_Enter);
            this.passwordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordBox_KeyDown);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radLabel1.Location = new System.Drawing.Point(110, 131);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(85, 25);
            this.radLabel1.TabIndex = 53;
            this.radLabel1.Text = "Username:";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radLabel2.Location = new System.Drawing.Point(110, 162);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(80, 25);
            this.radLabel2.TabIndex = 55;
            this.radLabel2.Text = "Password:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.Red;
            this.passwordLabel.Location = new System.Drawing.Point(12, 263);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(170, 17);
            this.passwordLabel.TabIndex = 57;
            this.passwordLabel.Text = "[password status or error]";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(201, 134);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(227, 22);
            this.usernameBox.TabIndex = 1;
            this.usernameBox.TabStop = false;
            this.usernameBox.ThemeName = "TelerikMetroBlue";
            // 
            // dMDataSet
            // 
            this.dMDataSet.DataSetName = "DMDataSet";
            this.dMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dMDataSetBindingSource
            // 
            this.dMDataSetBindingSource.DataSource = this.dMDataSet;
            this.dMDataSetBindingSource.Position = 0;
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
            // radButton2
            // 
            this.radButton2.EnableKeyMap = true;
            this.radButton2.Location = new System.Drawing.Point(286, 197);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(187, 32);
            this.radButton2.TabIndex = 58;
            this.radButton2.Text = "EXIT";
            this.radButton2.ThemeName = "TelerikMetroBlue";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 289);
            this.ControlBox = false;
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.appVersion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ThemeName = "TelerikMetroBlue";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMDataSetEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label appVersion;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadTextBox passwordBox;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.BindingSource dMDataSetBindingSource;
        private DMDataSet dMDataSet;
        private DMDataSetEmployees dMDataSetEmployees;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private Data.DMDataSetEmployeesTableAdapters.employeesTableAdapter employeesTableAdapter;
        private Telerik.WinControls.UI.RadTextBox usernameBox;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
        private Telerik.WinControls.UI.RadButton radButton2;
    }
}

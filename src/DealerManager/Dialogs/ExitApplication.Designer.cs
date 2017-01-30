namespace DealerManager.Dialogs
{
    partial class ExitApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExitApplication));
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.appVersion = new System.Windows.Forms.Label();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(43, 54);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(229, 24);
            this.radButton1.TabIndex = 49;
            this.radButton1.Text = "Yes";
            this.radButton1.ThemeName = "TelerikMetroBlue";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Image = global::DealerManager.Properties.Resources.stop;
            this.pictureBox3.Location = new System.Drawing.Point(12, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 51;
            this.pictureBox3.TabStop = false;
            // 
            // appVersion
            // 
            this.appVersion.AutoSize = true;
            this.appVersion.Font = new System.Drawing.Font("Segoe WP SemiLight", 12F);
            this.appVersion.Location = new System.Drawing.Point(54, 12);
            this.appVersion.Name = "appVersion";
            this.appVersion.Size = new System.Drawing.Size(473, 21);
            this.appVersion.TabIndex = 50;
            this.appVersion.Text = "You are about to exit the Dealer Management System! Are you sure?";
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(278, 54);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(229, 24);
            this.radButton2.TabIndex = 52;
            this.radButton2.Text = "No";
            this.radButton2.ThemeName = "TelerikMetroBlue";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // ExitApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 88);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.appVersion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExitApplication";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Exit Application";
            this.ThemeName = "TelerikMetroBlue";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton radButton1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label appVersion;
        private Telerik.WinControls.UI.RadButton radButton2;
    }
}

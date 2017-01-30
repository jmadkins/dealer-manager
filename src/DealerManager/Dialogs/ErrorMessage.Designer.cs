namespace DealerManager.Dialogs
{
    partial class ErrorMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorMessage));
            this.positiveButton = new Telerik.WinControls.UI.RadButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.message = new System.Windows.Forms.Label();
            this.negativeButton = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.positiveButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.negativeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // positiveButton
            // 
            this.positiveButton.Location = new System.Drawing.Point(58, 89);
            this.positiveButton.Name = "positiveButton";
            this.positiveButton.Size = new System.Drawing.Size(229, 24);
            this.positiveButton.TabIndex = 49;
            this.positiveButton.Text = "Yes";
            this.positiveButton.ThemeName = "TelerikMetroBlue";
            this.positiveButton.Click += new System.EventHandler(this.positiveButton_Click);
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
            // message
            // 
            this.message.AutoEllipsis = true;
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Segoe WP SemiLight", 12F);
            this.message.Location = new System.Drawing.Point(54, 12);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(128, 21);
            this.message.TabIndex = 50;
            this.message.Text = "<error message>";
            // 
            // negativeButton
            // 
            this.negativeButton.Location = new System.Drawing.Point(293, 89);
            this.negativeButton.Name = "negativeButton";
            this.negativeButton.Size = new System.Drawing.Size(229, 24);
            this.negativeButton.TabIndex = 52;
            this.negativeButton.Text = "No";
            this.negativeButton.ThemeName = "TelerikMetroBlue";
            this.negativeButton.Click += new System.EventHandler(this.negativeButton_Click);
            // 
            // ErrorMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 125);
            this.Controls.Add(this.negativeButton);
            this.Controls.Add(this.positiveButton);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.message);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ErrorMessage";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Exit Application";
            this.ThemeName = "TelerikMetroBlue";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ErrorMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.positiveButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.negativeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton positiveButton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label message;
        private Telerik.WinControls.UI.RadButton negativeButton;
    }
}

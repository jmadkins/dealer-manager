using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace DealerManager.Dialogs
{
    public partial class ErrorMessage : Telerik.WinControls.UI.RadForm
    {
        public ErrorMessage(string title, string message, int buttons)
        {            
            /* Buttons
             * 1 = Yes and No
             * 2 = Yes
             * 3 = Ok
             * 4 = Ok and Cancel
             * 5 = ?
             */             
            
            InitializeComponent();

            this.message.Text = message;
            this.Text = title;

            if (buttons == 1)
            {
                this.positiveButton.Text = "Yes";
                this.negativeButton.Text = "No";
            }

            if (buttons == 2)
            {
                this.positiveButton.Text = "Yes";
                this.negativeButton.Visible = false;
            }

            if (buttons == 3)
            {
                this.positiveButton.Text = "Ok";
                this.negativeButton.Visible = false;
            }

            if (buttons == 4)
            {
                this.positiveButton.Text = "Ok";
                this.negativeButton.Text = "Cancel";
            }

            if (buttons == 5)
            {
                this.positiveButton.Text = "???";
                this.negativeButton.Text = "???";
            }
        }

        private void ErrorMessage_Load(object sender, EventArgs e)
        {
            
        }

        private void positiveButton_Click(object sender, EventArgs e)
        {
            if (positiveButton.Text == "Ok")
            {
                this.Close();
            }
        }

        private void negativeButton_Click(object sender, EventArgs e)
        {

        }
    }
}

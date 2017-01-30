using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;

namespace DealerManager
{
    partial class APP0001 : Telerik.WinControls.UI.RadForm
    {
        public APP0001()
        {
            InitializeComponent();

            Properties.Settings.Default.app_buildString = "v " + Properties.Settings.Default.app_version + "." + Properties.Settings.Default.app_buildDate + "." + Properties.Settings.Default.app_milestone;
            Properties.Settings.Default.app_versionFriendly = "v " + Properties.Settings.Default.app_version;

            this.appName.Text = Properties.Settings.Default.app_name;
            this.appVersion.Text = Properties.Settings.Default.app_versionFriendly;
            this.prereleaseVersion.Text = "Evaluation copy. Build " + Properties.Settings.Default.app_buildString;

            //Pre-Release Warning Information
            if (Properties.Settings.Default.app_prerelease == true)
            {
                this.prereleaseVersion.Visible = true;
                this.prereleaseWarning.Visible = true;
            }
            else
            {
                this.prereleaseVersion.Visible = false;
                this.prereleaseWarning.Visible = false;
            }

            //this.connectedUser.Text = Properties.Settings.Default.app_connectedUser;
            //this.connectedUserProfile.Text = Properties.Settings.Default.app_connectedUserProfile + " - " + Properties.Settings.Default.app_licensedComany;
        }
    }
}

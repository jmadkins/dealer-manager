using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using DealerManager.Code;
using DealerManager.Forms.Employees;
using DealerManager.Data;
using System.Net;
using System.IO;

namespace DealerManager.Forms.System_Codes
{
	public partial class SYSCODES : Telerik.WinControls.UI.RadForm
	{
		public SYSCODES()
		{
			InitializeComponent();

            #region System Settings
			
			#region Core Application


			//Config & Reg - Reg. User - RO
			radTextBox3.Text = Properties.Settings.Default.app_licensedUser;
			//Config & Reg - Reg. Company - RO
			radTextBox4.Text = Properties.Settings.Default.app_licensedComany;
			//Config & Reg - AppName - RO
			radTextBox5.Text = Properties.Settings.Default.app_name;
			//Config & Reg - Version - RO
			radTextBox6.Text = Properties.Settings.Default.app_version;
			//Config & Reg - Build Date - RO
			radTextBox8.Text = Properties.Settings.Default.app_buildDate;
			//Config & Reg - Milestone - RO
			radTextBox9.Text = Properties.Settings.Default.app_milestone;
			//Config & Reg - PreRelease - RO
			radCheckBox1.Checked = Properties.Settings.Default.app_prerelease;
            //
            radCheckBox2.Checked = Properties.Settings.Default.app_backgroundUpdates;

			//Com & Loc -

			//Sec & Users - Maximum allowed of failed password attempts - 
			//radTextBox1.Text = Properties.Settings.Default.app_maxPasswordAttempts;               
						
			//Emp -

			//Data -
			
			#endregion

			#region Modules

			//Customers
            cus_autoData.Checked = Properties.Settings.Default.app_autodata;

			//Inventory

			//Billing


			#endregion

			#endregion

		}

		private void radButton1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void SYSCODES_Load(object sender, EventArgs e)
		{
            this.employeesTableAdapter1.Fill(this.dMDataSetCompanyLocations.employees);
            this.locationsTableAdapter.Fill(this.dMDataSetCompanyLocations.locations);
            this.companyTableAdapter.Fill(this.dMDataSetCompanyLocations.company);
            this.sys_ReferenceRelationshipTableAdapter.Fill(this.dMDataSetSystemCodes.sys_ReferenceRelationship);
            
            //Set Active view to first page
            //TODO: Limit pages based on security permissions
            this.radPageView1.SelectedPage = this.radPageViewPage7;

            this.sys_customerSourceTableAdapter.Fill(this.dMDataSetSystemCodes.sys_customerSource);
			this.securityprofilesTableAdapter.Fill(this.dMDataSetSecurity.securityprofiles);
			this.employeesTableAdapter.Fill(this.dMDataSetEmployees.employees);
		}

		private void radButton3_Click(object sender, EventArgs e)
		{
			this.employeesBindingSource.EndEdit();
			this.employeesTableAdapter.Update(this.dMDataSetEmployees.employees);

			//should we create user permissions here?
		}

		private void radButton2_Click_1(object sender, EventArgs e)
		{
			this.securityprofilesBindingSource.EndEdit();
			this.securityprofilesTableAdapter.Update(this.dMDataSetSecurity);
		}

		public void radButton6_Click(object sender, EventArgs e)
		{
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;
                ad.CheckForUpdateCompleted += new CheckForUpdateCompletedEventHandler(ad_CheckForUpdateCompleted);
                ad.CheckForUpdateProgressChanged += new DeploymentProgressChangedEventHandler(ad_CheckForUpdateProgressChanged);

                ad.CheckForUpdateAsync();
            }
        }

    #region Update
        void ad_CheckForUpdateProgressChanged(object sender, DeploymentProgressChangedEventArgs e)
        {
             updateLabel.Text = String.Format("Downloading: {0}. {1:D}K of {2:D}K downloaded.", GetProgressString(e.State), e.BytesCompleted / 1024, e.BytesTotal / 1024);
        }

        string GetProgressString(DeploymentProgressState state)
        {
            if (state == DeploymentProgressState.DownloadingApplicationFiles)
            {
                return "application files";
            }
            else if (state == DeploymentProgressState.DownloadingApplicationInformation)
            {
                return "application manifest";
            }
            else
            {
                return "deployment manifest";
            }
        }

        void ad_CheckForUpdateCompleted(object sender, CheckForUpdateCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("ERROR: Could not retrieve new version of Dealer Manager. Reason: \n" + e.Error.Message + "\nPlease contact Adkins Software Development customer support.");
                return;
            }
            else if (e.Cancelled == true)
            {
                MessageBox.Show("The update was cancelled.");
            }

            // Ask the user if they would like to update the application now. 
            if (e.UpdateAvailable == true)
            {
                long sizeOfUpdate = e.UpdateSizeBytes;
                
                if (!e.IsUpdateRequired)
                {
                    DialogResult dr = MessageBox.Show("Updates can make Dealer Manager work better and add new features. They can also make Dealer Manager more secure.\nWould you like to install it now?\n\nVersion: " + e.AvailableVersion + " - Update Download Size: " + sizeOfUpdate + "\nTo learn more about this update visit Adkins Software Development.", "An update is available", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (DialogResult.Yes == dr)
                    {
                        BeginUpdate();
                    }
                }
                else
                {
                    MessageBox.Show("A mandatory update is available for Dealer Manager. We will install the update now, and afterwards restart Dealer Manager.", "Update found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    BeginUpdate();
                }
            }
            else
            {
                MessageBox.Show("You are running the latest version of Dealer Manager.", "No Updates found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void BeginUpdate()
        {
            ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;
            ad.UpdateCompleted += new AsyncCompletedEventHandler(ad_UpdateCompleted);

            // Indicate progress in the application's status bar.
            ad.UpdateProgressChanged += new DeploymentProgressChangedEventHandler(ad_UpdateProgressChanged);
            ad.UpdateAsync();
        }

        void ad_UpdateProgressChanged(object sender, DeploymentProgressChangedEventArgs e)
        {
            String progressText = String.Format("{0:D}K out of {1:D}K downloaded - {2:D}% complete", e.BytesCompleted / 1024, e.BytesTotal / 1024, e.ProgressPercentage);
            updateLabel.Text = progressText;
        }

        void ad_UpdateCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("The update was cancelled.");
                return;
            }
            else if (e.Error != null)
            {
                MessageBox.Show("ERROR: Could not install the latest version of Dealer Manager. Reason: \n" + e.Error.Message + "\nPlease report this error to the system administrator.");
                return;
            }

            DialogResult dr = MessageBox.Show("Dealer Manager has been updated. Restart? (If you do not restart now, the new version will not take effect until after you quit and launch the application again.)", "Restart Application", MessageBoxButtons.OKCancel);
            if (DialogResult.OK == dr)
            {
                Application.Restart();
            }
        }
#endregion

        private void radButton13_Click(object sender, EventArgs e)
		{
			APP0100 frm = new APP0100();
			frm.ShowDialog();
		}

		private void radButton14_Click(object sender, EventArgs e)
		{
			ReleaseNotes frm = new ReleaseNotes();
			frm.ShowDialog();
		}

        private void radGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (radGridView1.SelectedRows.Count > 0)
            {
                DataRowView _rowItemView = (DataRowView)this.radGridView1.SelectedRows[0].DataBoundItem;
                DMDataSetEmployees.employeesRow _employeesRow = (DMDataSetEmployees.employeesRow)_rowItemView.Row;
                int _position = this.dMDataSetEmployees.employees.Rows.IndexOf(_employeesRow);

                new EMP0002(this.dMDataSetEmployees, _position, false).Show();
            }
        }

        private void radButton15_Click(object sender, EventArgs e)
        {   
            this.Validate();
            this.sys_customerSourceBindingSource.EndEdit();
            this.sys_customerSourceTableAdapter.Update(this.dMDataSetSystemCodes.sys_customerSource);
        }

        private void radButton7_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Data.SqlServerCe;

namespace DealerManager
{
    public partial class Login : Telerik.WinControls.UI.RadForm
    {
        int maxPasswordAttempts = Properties.Settings.Default.app_maxPasswordAttempts;
        int passwordAttempts;
        
        public Login()
        {
            InitializeComponent();

            //UI Business
            Properties.Settings.Default.app_versionFriendly = "Version: " + Properties.Settings.Default.app_version;
            this.appVersion.Text = Properties.Settings.Default.app_versionFriendly;
            ThemeResolutionService.ApplicationThemeName = "TelerikMetroBlue";             
        }

        //Compares user password to value in database
        private bool CompareStrings(string string1, string string2)
        {
            return String.Compare(string1, string2, false, System.Globalization.CultureInfo.InvariantCulture) == 0 ? true : false;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            passwordAttempts += 1;
            passwordLabel.Text = "";
            string username = usernameBox.Text;
            string password = passwordBox.Text;
            int empID;

            if (usernameBox.Text == "" || passwordBox.Text == "")
            {
                passwordLabel.Text = "Please enter your username or password!";
            }
            
            try
            {
                SqlCeConnection DMDatabase = new SqlCeConnection();
                DMDatabase.ConnectionString = Properties.Settings.Default.DMConnectionString;
                DMDatabase.Open();

                SqlCeCommand cmd = new SqlCeCommand("SELECT * FROM employees WHERE username='" + usernameBox.Text + "'", DMDatabase);

                SqlCeDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //TODO: if statement to see if username is in database, if not, +1 to passwordattempts                    
                    //passwordLabel.Text = "User not found! This is attempt " + passwordAttempts + " of " + maxPasswordAttempts + ".";                    

                    if (this.CompareStrings(dr["username"].ToString(), username) &&
                        this.CompareStrings(dr["password"].ToString(), password))
                    {
                        //AUTENTICATION IS SUCESSFUL
                        
                        string fullname = dr["firstname"] + " " + dr["lastname"];
                        
                        object o = dr["empID"];
                        empID = (int)o;

                        /* This captures the users information that is required for features of the application
                         * All required info is captured here rather than someone else
                         * When a user logs out of the application, the DMParent is closed and Login Form is shown
                         * This ensures that all of the data is captured since all of the code is in one place
                         */ 

                        Properties.Settings.Default.app_connectedUser = fullname;
                        Properties.Settings.Default.app_connectedUsername = username;
                        Properties.Settings.Default.app_connectedUserID = empID;
                        
                        /* Must hide login form instead of closing it
                         * If it is closed, the application will exit.
                         * Handle the exiting of the application via the closing of DMParent
                         */

                        this.Hide();


                        //Open DMParent

                        DMParent frm = new DMParent();
                        frm.Show();
                    }
                    else
                    {
                        //AUTENTICATION FAILED
                        
                        passwordLabel.Text = "Password Incorrect! This is attempt " + passwordAttempts + " of " + maxPasswordAttempts + ".";

                        if (passwordAttempts == maxPasswordAttempts)
                        {
                            Application.Exit();
                        }
                        else
                        {
                            /* Password was simply incorrect
                            * No need to increase password attempt
                            * That is done when the button is first clicked
                            */
                        }
                    }
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void passwordBox_Enter(object sender, EventArgs e)
        {
            this.passwordBox.Text = "";
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            passwordLabel.Text = "";

            this.Text = "Login - Instance: " + Properties.Settings.Default.app_productionStatus;
        }

        private void passwordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                radButton1.PerformClick();
            }
        }
    }
}

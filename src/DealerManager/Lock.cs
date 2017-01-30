using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealerManager
{
    public partial class Lock : Form
    {
        bool passwordCorrect = false;
        int passwordAttempts = 0;
        int maxPasswordAttempts = 2;

        public Lock()
        {
            InitializeComponent();
        }

        private bool CompareStrings(string string1, string string2)
        {
            return String.Compare(string1, string2, false, System.Globalization.CultureInfo.InvariantCulture) == 0 ? true : false;
        }

        private void Lock_Load(object sender, EventArgs e)
        {
            passwordLabel.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            passwordAttempts += 1;
            string username = Properties.Settings.Default.app_connectedUsername;
            string password = textBox1.Text;
            
            if (textBox1.Text == "")
            {
                passwordLabel.Text = "Please enter your password!";
            }

            try
            {
                SqlCeConnection DMDatabase = new SqlCeConnection();
                DMDatabase.ConnectionString = Properties.Settings.Default.DMConnectionString;
                DMDatabase.Open();

                SqlCeCommand cmd = new SqlCeCommand("SELECT * FROM employees WHERE username='" + username + "'", DMDatabase);

                SqlCeDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (this.CompareStrings(dr["username"].ToString(), username) &&
                    this.CompareStrings(dr["password"].ToString(), password))
                    {
                        passwordCorrect = true;
                        this.Close();
                    }
                    else
                    {
                        DMParent frm = new DMParent();
                        frm.applicationStatusChange("Password Incorrect! This is attempt " + passwordAttempts + " of " + maxPasswordAttempts + ".");
                        
                        passwordLabel.Text = "Password Incorrect! This is attempt " + passwordAttempts + " of " + maxPasswordAttempts + ".";

                        if (passwordAttempts == maxPasswordAttempts)
                        {
                            passwordCorrect = false;

                            this.Close();
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

        private void Lock_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (passwordCorrect == true)
            {
                ExitLockMode(this,"Application Ready");
           }
            else
            {
                Application.Exit();
            }
        }

        public static void ExitLockMode(Form myFrm, string pMsg)
        {
            try
            {
                DMParent parent = (DMParent)myFrm.MdiParent;
                parent.returnFromLock("Application Ready", true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured!" + ex);
            }
        }

    }
}

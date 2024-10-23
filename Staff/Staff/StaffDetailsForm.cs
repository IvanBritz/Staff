using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Staff
{
    public partial class StaffDetailsForm : Form
    {
        public StaffDetailsForm()
        {
            InitializeComponent();
        }

        private void StaffDetailsForm_Load(object sender, EventArgs e)
        {

        }

        public StaffDetailsForm(int staffID, string staffName, string roleName, string username, string password)
        {
            InitializeComponent();


            lblStaffID.Text = "Staff ID: " + staffID.ToString();
            lblStaffName.Text = "Staff Name: " + staffName;
            lblRoleName.Text = "Role Name: " + roleName;


            if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
            {
                lbAccount.Text = string.Empty;
                lblUsername.Text = "No additional information available";
                lblPassword.Text = string.Empty;
            }
            else
            {

                lblUsername.Text = "Username: " + username;
                lblPassword.Text = "PassWord: " +password;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

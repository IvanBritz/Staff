using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Staff
{
    public partial class AddForm : Form
    {
        Role r = Role.GetInstance();
        Staff s = Staff.GetInstance();
        private Form1 mainForm;
        public AddForm(Form1 mainForm)
        {
            InitializeComponent();
            r.LoadRole(cbRole);
            r.load(lbUsername, lbPassworld, tbUsername, tbPassword);
            this.mainForm = mainForm;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            r.OpenLogin(cbRole, lbUsername, lbPassworld, tbUsername, tbPassword);
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string StaffName = tbStaffName.Text;
            string role = cbRole.SelectedItem.ToString();
            decimal BaseSalary = Convert.ToDecimal(tbBaseSalary.Text);
            string username = tbUsername.Text;
            string Password = tbPassword.Text;

            int roleID = r.GetRoleID(role);

            s.AddStaffToDatabase(StaffName, roleID, BaseSalary,username,Password);

            mainForm.LoadStaffData();
            MessageBox.Show("Added Successfully");
            this.Close();
        }
    }
}

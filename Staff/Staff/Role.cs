using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staff
{
    public class Role
    {
        private static Role _instance = null;
        private Role() { }
        public static Role GetInstance()
        {
                if (_instance == null)
                {
                    _instance = new Role();
                }
                return _instance;
            
        }
        
        public void LoadRole(ComboBox comboBox1)
        {
            String query = "SELECT RoleName FROM Role";
            DatabaseConn b = DatabaseConn.getInstance();
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, b.GetConnection()))
                {
                    if (b.GetConnection().State == System.Data.ConnectionState.Closed)
                    {
                        b.GetConnection().Open();
                    }

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        comboBox1.Items.Clear();

                        while (reader.Read())
                        {
                            comboBox1.Items.Add(reader["RoleName"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading roles: " + ex.Message);
            }
            finally
            {
                b.CloseConnection();
            }
        }

        public void load(Label l1, Label l2, TextBox tb1, TextBox tb2)
        {
            l1.Visible = false;
            l2.Visible = false;
            tb1.Visible = false;
            tb2.Visible = false;
        }

        public void OpenLogin(ComboBox comboBox1, Label l1, Label l2, TextBox tb1, TextBox tb2) {

            string selectedRole = comboBox1.SelectedItem.ToString();
            String[] login = new string[] { "Cashier","Admin","Front Desk"};
            if (login.Contains(selectedRole))
            {
                l1.Visible = true;
                l2.Visible = true;
                tb1 .Visible = true;
                tb2 .Visible = true;
            }
            else
            {
                l1.Visible = false;
                l2.Visible = false;
                tb1 .Visible = false;   
                tb2 .Visible = false;
            }
            
        
        }

        public int GetRoleID(string roleName)
        {
            string query = "SELECT RoleID FROM Role WHERE RoleName = @RoleName";
            DatabaseConn b = DatabaseConn.getInstance();

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, b.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@RoleName", roleName);

                    if (b.GetConnection().State == System.Data.ConnectionState.Closed)
                    {
                        b.GetConnection().Open();
                    }

                    return (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching RoleID: " + ex.Message);
                return -1;
            }
            finally
            {
                b.CloseConnection();
            }
        }

    }
}

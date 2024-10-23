using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Staff
{
    public class Staff
    {
        private static Staff _instance = null;

        private Staff() { }

        public static Staff GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Staff();
            }
            return _instance;
        }

        public bool AddStaffToDatabase(string staffName, int roleID, decimal baseSalary, string Username, string Password)
        {
            string query = "INSERT INTO Staff (StaffName, RoleID, BaseSalary, Username, Password) VALUES (@StaffName, @RoleID, @BaseSalary, @Username, @Password)";
            DatabaseConn b = DatabaseConn.getInstance();

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, b.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@StaffName", staffName);
                    cmd.Parameters.AddWithValue("@RoleID", roleID);
                    cmd.Parameters.AddWithValue("@BaseSalary", baseSalary);
                    cmd.Parameters.AddWithValue("@Username", Username);
                    cmd.Parameters.AddWithValue ("@Password", Password);

                    if (b.GetConnection().State == System.Data.ConnectionState.Closed)
                    {
                        b.GetConnection().Open();
                    }

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding staff: " + ex.Message);
                return false;
            }
            finally
            {
                b.CloseConnection();
            }
        }

    }
}

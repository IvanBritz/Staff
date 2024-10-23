using System.Data;
using System.Data.SqlClient;
namespace Staff
{
    public partial class Form1 : Form
    {
        private StaffRepository _staffRepo = new StaffRepository();
        public Form1()
        {
            InitializeComponent();
            
            _staffRepo.DataChanged += (s, e) => LoadStaffData();
            LoadStaffData();
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbSearch.TextChanged += tbSearch_TextChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStaffData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form addForm = FormFactory.CreateAddForm(this);
            addForm.ShowDialog();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                int staffID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["StaffID"].Value);
                _staffRepo.DeleteStaff(staffID);
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int staffID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["StaffID"].Value);
                ShowStaffDetailsPopup(staffID);
            }


        }

        private void ShowStaffDetailsPopup(int staffID)
        {
            string query = @"
        SELECT s.StaffID, s.StaffName, r.RoleName, s.Username, s.Password
        FROM Staff s
        INNER JOIN Role r ON s.RoleID = r.RoleID
        WHERE s.StaffID = @StaffID";
            DatabaseConn b = DatabaseConn.getInstance();

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, b.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@StaffID", staffID);

                    if (b.GetConnection().State == System.Data.ConnectionState.Closed)
                    {
                        b.GetConnection().Open();
                    }

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            int id = Convert.ToInt32(reader["StaffID"]);
                            string name = reader["StaffName"].ToString();
                            string role = reader["RoleName"].ToString();
                            string username = reader["Username"]?.ToString();
                            string password = reader["Password"]?.ToString();


                            StaffDetailsForm detailsForm = new StaffDetailsForm(id, name, role, username, password);
                            detailsForm.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving staff details: " + ex.Message);
            }
            finally
            {
                b.CloseConnection();
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = tbSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchValue))
            {
                LoadStaffData();
            }
            else
            {
                FilterStaffData(searchValue);
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int staffID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["StaffID"].Value);
            string staffName = dataGridView1.Rows[e.RowIndex].Cells["StaffName"].Value.ToString();
            decimal baseSalary = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["BaseSalary"].Value);

            _staffRepo.UpdateStaff(staffID, staffName, baseSalary);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FilterStaffData(string searchValue)
        {
            string query = "SELECT StaffID, StaffName, BaseSalary FROM Staff WHERE StaffName LIKE @SearchValue";
            DatabaseConn b = DatabaseConn.getInstance();

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, b.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@SearchValue", "%" + searchValue + "%");

                    if (b.GetConnection().State == System.Data.ConnectionState.Closed)
                    {
                        b.GetConnection().Open();
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering staff data: " + ex.Message);
            }
            finally
            {
                b.CloseConnection();
            }
        }

        public void LoadStaffData()
        {
            dataGridView1.DataSource = _staffRepo.GetAllStaff();
            FormatDataGridView();
        }

        private void FormatDataGridView()
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;

            if (!dataGridView1.Columns.Contains("Delete"))
            {
                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    HeaderText = "Delete",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true,
                    FlatStyle = FlatStyle.Popup
                };
                deleteButton.DefaultCellStyle.BackColor = Color.SlateBlue;
                deleteButton.DefaultCellStyle.ForeColor = Color.White;
                dataGridView1.Columns.Add(deleteButton);
            }
        }
    }
}

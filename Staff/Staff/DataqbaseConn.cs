using System;
using System.Windows.Forms;
using System.Data.SqlClient;

public class DatabaseConn
{
    private static DatabaseConn database = null;
    private SqlConnection connection;

    // Private constructor to prevent instantiation
    private DatabaseConn()
    {
        InitializeConnection();
    }

    // Method to initialize the connection
    private void InitializeConnection()
    {
        try
        {
            string connectionString = "Data Source=DESKTOP-4QDSNFR\\SQLEXPRESS01;Initial Catalog=PetWorld4;Integrated Security=True;TrustServerCertificate=True";
            connection = new SqlConnection(connectionString);
            connection.Open(); // Open connection here
        }
        catch (Exception e)
        {
            MessageBox.Show("Error initializing database connection: " + e.Message);
        }
    }

    // Singleton pattern with getInstance method
    public static DatabaseConn getInstance()
    {
        if (database == null)
        {
            database = new DatabaseConn();
        }
        return database;
    }

    // Method to get the connection
    public SqlConnection GetConnection()
    {
        if (connection == null || connection.State != System.Data.ConnectionState.Open)
        {
            InitializeConnection(); // Re-initialize if the connection is closed
        }
        return connection;
    }

    public SqlConnection CloseConnection()
    {
        connection.Close();
        return connection;
    }
}
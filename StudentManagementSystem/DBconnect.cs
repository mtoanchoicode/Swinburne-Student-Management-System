using MySql.Data.MySqlClient;

namespace StudentManagementSystem
{
    internal class DBconnect
    {
        // Singleton instance
        private static DBconnect _instance;

        // Lock synchronization object
        private static readonly object _lock = new object();

        // Connect DB
        private readonly MySqlConnection _conn;

        // Private constructor to prevent instantiation from outside
        private DBconnect()
        {
            _conn = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=studentdb");
        }

        // Public static method to get the singleton instance
        public static DBconnect Instance
        {
            get
            {
                // Ensure thread safety
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new DBconnect();
                    }
                }
                return _instance;
            }
        }

        // Get Connection
        public MySqlConnection GetConnection
        {
            get
            {
                return _conn;
            }
        }

        // Function to open connection
        public void OpenConnect()
        {
            if (_conn.State == System.Data.ConnectionState.Closed)
            {
                _conn.Open();
            }
        }

        // Create function to close connection
        public void CloseConnect()
        {
            if (_conn.State == System.Data.ConnectionState.Open)
            {
                _conn.Close();
            }
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    internal abstract class SchoolClass : IManageActivities
    {
        protected readonly DBconnect _conn;
        protected SchoolClass()
        {
            _conn = DBconnect.Instance;
        }
        // function for any command relate to db
        public DataTable GetList(MySqlCommand command)
        {
            command.Connection = _conn.GetConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        //Function to delete the database element
        public abstract bool DeleteThing(int id);
    }
}


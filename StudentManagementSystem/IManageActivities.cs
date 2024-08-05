using MySql.Data.MySqlClient;
using System.Data;

namespace StudentManagementSystem
{
    public interface IManageActivities
    {
        public DataTable GetList(MySqlCommand command);
        public bool DeleteThing(int id);
    }
}

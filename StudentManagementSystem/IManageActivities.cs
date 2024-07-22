using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

using MySql.Data.MySqlClient;

namespace StudentManagementSystem
{
    internal class CourseClass : SchoolClass, IManageActivities
    {
        // Singleton instance
        private static CourseClass _instance;

        // Lock synchronization object
        private static readonly object _lock = new object();

        private CourseClass() { }
        // Public static method to get the singleton instance
        public static CourseClass Instance
        {
            get
            {
                // Ensure thread safety
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new CourseClass();
                    }
                }
                return _instance;
            }
        }
        //Function to insert Course
        public bool InsertCourse(string cName, int hr, string desc)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `course`(`CourseName`, `CourseHour`, `Description`) VALUES (@cn, @ch, @desc)", _conn.GetConnection);
            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = cName;
            command.Parameters.Add("@ch", MySqlDbType.Int32).Value = hr;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = desc;
            _conn.OpenConnect();
            if(command.ExecuteNonQuery() == 1)
            {
                _conn.CloseConnect();
                return true;
            }
            else
            {
                _conn.CloseConnect();
                return false;
            }
        }
        //Update function for course
        public bool UpdateCourse(int id, string cName, int hr, string desc)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `course` SET `CourseName`= @cn,`CourseHour`=@ch,`Description`= @desc WHERE `CourseId`=@id", _conn.GetConnection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = cName;
            command.Parameters.Add("@ch", MySqlDbType.Int32).Value = hr;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = desc;
            _conn.OpenConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                _conn.CloseConnect();
                return true;
            }
            else
            {
                _conn.CloseConnect();
                return false;
            }
        }
        //Create a function to delete a course
        public override bool DeleteThing(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `course` WHERE `CourseId` = @id", _conn.GetConnection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            _conn.OpenConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                _conn.CloseConnect();
                return true;
            }
            else
            {
                _conn.CloseConnect();
                return false;
            }
        }
    }
}

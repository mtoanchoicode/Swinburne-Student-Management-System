using MySql.Data.MySqlClient;

namespace StudentManagementSystem
{
    internal class StudentClass : SchoolClass, IManageActivities
    {
        // Singleton instance
        private static StudentClass _instance;

        // Lock synchronization object
        private static readonly object _lock = new object();

        private StudentClass() { }
        // Public static method to get the singleton instance
        public static StudentClass Instance
        {
            get
            {
                // Ensure thread safety
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new StudentClass();
                    }
                }
                return _instance;
            }
        }
        //Create a function to add a new students to the database

        public bool InsertStudent(string fname, string lname, DateTime bdate, string gender, string phone, string address, byte[] img)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `student`(`StdFirstName`, `StdLastName`, `Birthdate`, `Gender`, `Phone`, `Address`, `Photo`) VALUES (@fn, @ln, @bd, @gd, @ph, @adr, @img)", _conn.GetConnection);
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bd", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@gd", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

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
        //Count Student

        public string ExeCount(string query)
        {
            MySqlCommand command = new MySqlCommand(query, _conn.GetConnection);
            _conn.OpenConnect();
            string count = command.ExecuteScalar().ToString();
            _conn.CloseConnect();
            return count;
        }
        //Calc Total Student
        public string TotalStudent()
        {
            return ExeCount("SELECT COUNT(*) FROM student");
        }
        //Calc Male Student
        public string MaleStudent()
        {
            return ExeCount("SELECT COUNT(*) FROM student WHERE `Gender` = 'Male'");
        }
        //Calc FeMale Student
        public string FemaleStudent()
        {
            return ExeCount("SELECT COUNT(*) FROM student WHERE `Gender` = 'Female'");
        }

        //Function to Update Student
        public bool UpdateStudent(int id, string fname, string lname, DateTime bdate, string gender, string phone, string address, byte[] img)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `student` SET `StdFirstName`= @fn, `StdLastName`=@ln,`Birthdate`= @bd,`Gender`=@gd,`Phone`=@ph,`Address`=@adr,`Photo`=@img WHERE `StdId`= @id", _conn.GetConnection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bd", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@gd", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

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
        //Function to delete student
        public override bool DeleteThing(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `student` WHERE `StdId` = @id", _conn.GetConnection);
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

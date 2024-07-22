using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public class SchoolFacade
    {
        private readonly StudentClass _studentClass;
        private readonly CourseClass _courseClass;
        private readonly ScoreClass _scoreClass;
        // Singleton instance
        private static SchoolFacade _instance;

        // Lock synchronization object
        private static readonly object _lock = new object();

        private SchoolFacade()
        {
            _studentClass = StudentClass.Instance;
            _courseClass = CourseClass.Instance;
            _scoreClass = ScoreClass.Instance;
        }
        // Public static method to get the singleton instance
        public static SchoolFacade Instance
        {
            get
            {
                // Ensure thread safety
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SchoolFacade();
                    }
                }
                return _instance;
            }
        }

        // Facade methods for student management
        public DataTable GetStudentList(MySqlCommand command)
        {
            return _studentClass.GetList(command);
        }
        public bool InsertStudents(string fname, string lname, DateTime bdate, string gender, string phone, string address, byte[] img)
        {
            return _studentClass.InsertStudent(fname, lname, bdate, gender, phone, address, img);
        }

        public bool UpdateStudents(int id, string fname, string lname, DateTime bdate, string gender, string phone, string address, byte[] img)
        {
            return _studentClass.UpdateStudent(id, fname, lname, bdate, gender, phone, address, img);
        }

        public bool DeleteStudents(int id)
        {
            return _studentClass.DeleteThing(id);
        }

        public string TotalStudents()
        {
            return _studentClass.TotalStudent();
        }

        public string MaleStudents()
        {
            return _studentClass.MaleStudent();
        }

        public string FemaleStudents()
        {
            return _studentClass.FemaleStudent();
        }

        // Facade methods for course management
        public DataTable GetCourseList(MySqlCommand command)
        {
            return _courseClass.GetList(command);
        }
        public bool InsertCourses(string cName, int hr, string desc)
        {
            return _courseClass.InsertCourse(cName, hr, desc);
        }

        public bool UpdateCourses(int id, string cName, int hr, string desc)
        {
            return _courseClass.UpdateCourse(id, cName, hr, desc);
        }

        public bool DeleteCourses(int id)
        {
            return _courseClass.DeleteThing(id);
        }

        // Facade methods for score management
        public DataTable GetScoreList(MySqlCommand command)
        {
            return _scoreClass.GetList(command);
        }
        public bool InsertScores(int stdid, string courseName, double score, string desc)
        {
            return _scoreClass.InsertScore(stdid, courseName, score, desc);
        }

        public bool UpdateScores(int stdid, string scn, double score, string desc)
        {
            return _scoreClass.UpdateScore(stdid, scn, score, desc);
        }
        public bool CheckScores(int stdID, string cName)
        {
            return _scoreClass.CheckScore(stdID, cName);
        }
        public bool DeleteScores(int id)
        {
            return _scoreClass.DeleteThing(id);
        }
    }
}

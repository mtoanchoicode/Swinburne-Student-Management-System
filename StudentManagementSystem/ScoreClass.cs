using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    internal class ScoreClass : SchoolClass, IManageActivities
    {
        // Singleton instance
        private static ScoreClass _instance;

        // Lock synchronization object
        private static readonly object _lock = new object();

        private ScoreClass() { }
        // Public static method to get the singleton instance
        public static ScoreClass Instance
        {
            get
            {
                // Ensure thread safety
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ScoreClass();
                    }
                }
                return _instance;
            }
        }
        //Function to insert Score
        public bool InsertScore(int stdid, string courseName, double score, string desc)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `score`(`StudentId`, `CourseName`, `Score`, `Description`) VALUES (@stid, @cn, @sco, @desc)", _conn.GetConnection);
            command.Parameters.Add("@stid", MySqlDbType.Int32).Value = stdid;
            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@sco", MySqlDbType.Double).Value = score;
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
        // function to check already course score
        public bool CheckScore(int stdID, string cName)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `score` WHERE `StudentId` = @stdid AND `CourseName` = @cname", _conn.GetConnection);
            command.Parameters.Add("@stdid", MySqlDbType.Int32).Value = stdID;
            command.Parameters.Add("@cname", MySqlDbType.VarChar).Value = cName;
            DataTable table = GetList(command);
            if (table.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        // update score
        public bool UpdateScore(int stdid, string scn, double score, string desc)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `score` SET `Score`=@sco,`Description`=@desc WHERE `StudentId`=@stid AND `CourseName` = @scn", _conn.GetConnection);
            command.Parameters.Add("@stid", MySqlDbType.Int32).Value = stdid;
            command.Parameters.Add("@sco", MySqlDbType.Double).Value = score;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = desc;
            command.Parameters.Add("@scn", MySqlDbType.VarChar).Value = scn;
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
        //Function to Delete score
        public override bool DeleteThing(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `score` WHERE `StudentId` = @id", _conn.GetConnection);
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

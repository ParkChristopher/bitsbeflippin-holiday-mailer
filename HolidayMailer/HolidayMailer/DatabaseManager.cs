using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;


namespace HolidayMailer
{
    class DatabaseManager
    {
        private String dbfilename = "HolidayMailer.db";
        private String connectionString = "Data Source=HolidayMailer.db;Version=3;Compress=true";
        private SQLiteConnection connection;
        private SQLiteCommand command;
        private bool isNew;

        public DatabaseManager()
        {
            createDatabase();
            connectDatabase();
            
            if( isNew ) 
                createTable();
        }

        private void createDatabase()
        {
            if( !File.Exists(dbfilename) )
            {
                SQLiteConnection.CreateFile(dbfilename);
                isNew = true;
            }
            else
                isNew = false;
        }

        private void connectDatabase()
        {
            connection = new SQLiteConnection(connectionString);
            connection.Open();
        }

        private void createTable()
        {
            string sql = "CREATE TABLE default_user ("
                         + "LastName VARCHAR(30),"
                         + "FirstName VARCHAR(30),"
                         + "Email VARCHAR(100),"
                         + "LastYear BOOLEAN)";

            command = new SQLiteCommand(sql, connection);
            command.ExecuteNonQuery();
        }
    }
}

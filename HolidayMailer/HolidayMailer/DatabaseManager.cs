using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.IO;


namespace HolidayMailer
{
    class DatabaseManager
    {
        private String dbfilename = "HolidayMailer.db";
        private String connectionString = "Data Source=HolidayMailer.db;Version=3;Compress=true";
        private SQLiteConnection connection;
        private SQLiteCommand command;

        public DatabaseManager()
        {
            if( createDatabase() ) 
                createTable();
        }

        public void add(string lname, string fname, string email, bool lastYear)
        {
            string sql = "INSERT INTO default_user (LastName, FirstName, Email, LastYear)"
                        + "VALUES (\'" + lname + "\', \'" + fname + "\', \'" + email + "\', \'"
                        + lastYear + "\');";

            executeQuery(sql);
        }

        public void delete(string email)
        {
            string sql = "DELETE FROM default_user WHERE Email = \'" + email + "\';";

            executeQuery(sql);
        }

        public void clearDB()
        {
            string sql = "DELETE * FROM default_user;";

            executeQuery(sql);
        }
        public void retrieveContacts()
        {
            command = new SQLiteCommand("SELECT * FROM default_user;");
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = command;
            da.Fill(dt);

        }

        private bool createDatabase()
        {
            if( !File.Exists(dbfilename) )
            {
                SQLiteConnection.CreateFile(dbfilename);
                return true;
            }
            return false;
        }

        private void setConnection()
        {
            connection = new SQLiteConnection(connectionString);
        }
        
        private void executeQuery(string queryTxt)
        {
            setConnection();
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = queryTxt;
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void createTable()
        {
            string sql = "CREATE TABLE default_user ("
                         + "LastName VARCHAR(30) NOT NULL,"
                         + "FirstName VARCHAR(30) NOT NULL,"
                         + "Email VARCHAR(100) PRIMARY KEY NOT NULL,"
                         + "LastYear BOOLEAN);";

            executeQuery(sql);
        }

        

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.IO;
using System.Collections;


namespace HolidayMailer
{
    public class DatabaseManager
    {

        private String dbfilename = "HolidayMailer.db";
        private String connectionString = "Data Source=HolidayMailer.db;Version=3;Compress=true";
        private SQLiteConnection connection;
        private SQLiteCommand command;

        public DatabaseManager()
        {
            if (createDatabase())
                createTable();
        }

        public void add(string lname, string fname, string email, bool lastYear)
        {
            string sql = "INSERT INTO default_user (LastName, FirstName, Email, LastYear)"
                        + "VALUES (\'" + lname + "\', \'" + fname + "\', \'" + email + "\', \'"
                        + lastYear + "\');";

            executeQuery(sql);
        }

        private void formatInput(string input)
        {

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
        public List<Contact> retrieveContacts()
        {
            DataTable dt = new DataTable();
            List<Contact> contactList = new List<Contact>();
            Object[] contactData;

            int i;

            setConnection();
            connection.Open();
            command = new SQLiteCommand("SELECT * FROM default_user;",
                connection);
            SQLiteDataAdapter da = new SQLiteDataAdapter();

            da.SelectCommand = command;
            da.Fill(dt);

            
            foreach (DataRow row in dt.Rows)
            {
                contactData = new Object[4];
                i = 0;
                foreach (DataColumn column in dt.Columns)
                {
                    contactData[i] = row[column];
                    i++;
                }

                contactList.Add(new Contact((string)contactData[0],
                    (string)contactData[1],
                    (string)contactData[2],
                    (bool)contactData[3]));
            }
            connection.Close();

            return contactList;
        }

        private bool createDatabase()
        {
            if (!File.Exists(dbfilename))
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
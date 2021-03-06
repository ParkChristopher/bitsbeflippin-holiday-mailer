﻿using System;
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
        private Object[] contactData;

        public DatabaseManager()
        {
            if (createDatabase())
                createTable();
        }

        public void add(string lname, string fname, string email, bool lastYear)
        {
            string sql = "INSERT INTO default_user (LastName, FirstName, Email, LastYear)"
                        + "VALUES (@lname, @fname, @email, @lastYear);";

            setConnection();
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = sql;
            
            command.Parameters.AddWithValue("@lname", lname);
            command.Parameters.AddWithValue("@fname", fname);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@lastYear", lastYear);

            command.ExecuteNonQuery();
            connection.Close();
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
        
        public List<Contact> retrieveByLastName(string text)
        {
            DataTable dt = new DataTable();
            List<Contact> contactList = new List<Contact>();
          
            setConnection();
            connection.Open();

            command = new SQLiteCommand("SELECT * FROM default_user WHERE LastName LIKE"
                +" @textInput;", connection);
            command.Parameters.AddWithValue("@textInput", text + "%");

            SQLiteDataAdapter da = new SQLiteDataAdapter();
            da.SelectCommand = command;
            da.Fill(dt);

            contactList = populateContactList(dt);
            
            connection.Close();

            return contactList;
        }

        public List<Contact> retrieveContacts()
        {
            DataTable dt = new DataTable();
            List<Contact> contactList = new List<Contact>();

            setConnection();
            connection.Open();

            command = new SQLiteCommand("SELECT * FROM default_user;",
                connection);
            SQLiteDataAdapter da = new SQLiteDataAdapter();

            da.SelectCommand = command;
            da.Fill(dt);

            contactList = populateContactList(dt);
        
            connection.Close();

            return contactList;
        }

        private List<Contact> populateContactList(DataTable dt)
        {
            int i;
            List<Contact> tempList = new List<Contact>();

            foreach (DataRow row in dt.Rows)
            {
                contactData = new Object[4];
                i = 0;
                foreach (DataColumn column in dt.Columns)
                {
                    contactData[i] = row[column];
                    i++;
                }

                tempList.Add(new Contact((string)contactData[0],
                    (string)contactData[1],
                    (string)contactData[2],
                    (bool)contactData[3]));
            }

            return tempList;
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
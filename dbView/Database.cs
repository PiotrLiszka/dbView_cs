using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;

namespace dbView
{

    class Database
    {
        private static string dbPath = System.IO.Path.GetTempPath();
        private static string dbName = "vehicledb.db";
        private string connectionString = "Data Source =" + dbPath + dbName+ ";version=3";
        public static SQLiteConnection SqliteConnection;

        public static void sqliteCommand(DataTable dataTable, string qry)
        {
            if (SqliteConnection.State == System.Data.ConnectionState.Open)
            {
                dataTable.Clear();
                SQLiteCommand command = new SQLiteCommand(qry, Database.SqliteConnection);
                command.CommandType = CommandType.Text;
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                adapter.Fill(dataTable);
            }
            else
            {
                MessageBox.Show("Error. Database not connected");
            }
        }

        public Database()
        {
            DbConnection();
        }

        private bool DbExists(string path)
        {
            return System.IO.File.Exists(path);
        }

        private void DbConnection()
        {
            SqliteConnection = new SQLiteConnection(connectionString);
            if (DbExists(dbPath + dbName))
            {
                SqliteConnection.Open();
                if (SqliteConnection.State == System.Data.ConnectionState.Open)
                {
                    MessageBox.Show($"Connected to {dbName}.");
                }
            }
            else
            {
                MessageBox.Show($"Database {dbName} does not exist. Closing application... \nCheck path = {dbPath} ","Error");
                System.Environment.Exit(1);
            }

        }

        public void DbViewVechiles(DbViewWindow dbView)         
        {
            if (SqliteConnection.State == System.Data.ConnectionState.Open)
            {
                DataTable selectTable = new DataTable();
                string qry = QueryCreator.SelectQuery(dbView);
                sqliteCommand(selectTable, qry);
                dbView.ViewOnWindow(selectTable);       
            }
            else
            {
                MessageBox.Show("Error. Database not connected");       
            }
            
        }
        
    }
}

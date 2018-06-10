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
        private SQLiteConnection sqliteConnection;

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
            sqliteConnection = new SQLiteConnection(connectionString);
            if (DbExists(dbPath + dbName))
            {
                sqliteConnection.Open();
                if (sqliteConnection.State == System.Data.ConnectionState.Open)
                {
                    MessageBox.Show($"Connected to {dbName}.");
                }
            }
            else
            {
                MessageBox.Show($"Database {dbName} does not exist.");
            }

        }

        private void sqliteCommand(DataTable filtersTable, string qry)
        {
            filtersTable.Clear();
            SQLiteCommand command = new SQLiteCommand(qry, sqliteConnection);
            command.CommandType = CommandType.Text;
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            adapter.Fill(filtersTable);
        }

        public void GetFilters(DbViewWindow dbView)
        {
            List<string> brandFilter = new List<string>();

            List<string> yearFilter = new List<string>();
            int tabId = dbView.GetTabId;
            DataTable filtersTable = new DataTable();
            string groupDetails = "";
            string table = "";

            table = GetTableName(tabId);

            groupDetails = "v.brand";
            string qry = $"SELECT {groupDetails} FROM {table} details LEFT JOIN vehicle v ON v.vid = details.vid GROUP BY {groupDetails}";
            sqliteCommand(filtersTable, qry);
            foreach (DataRow row in filtersTable.Rows)
                brandFilter.Add(row[0].ToString());

            groupDetails = "v.Prodyear";
            qry = $"SELECT MIN({groupDetails}) FROM {table} details LEFT JOIN vehicle v ON v.vid = details.vid";
            sqliteCommand(filtersTable, qry);
            foreach (DataRow row in filtersTable.Rows)
                yearFilter.Add(row[1].ToString());

            qry = $"SELECT MAX({groupDetails}) FROM {table} details LEFT JOIN vehicle v ON v.vid = details.vid";
            sqliteCommand(filtersTable, qry);
            foreach (DataRow row in filtersTable.Rows)
                yearFilter.Add(row[2].ToString());

            dbView.AddFilters(brandFilter, yearFilter);
        }

        private static string GetTableName(int tabId)
        {
            string table;
            if (tabId == 0)
                table = "car";
            else if (tabId == 1)
                table = "truck";
            else if (tabId == 2)
                table = "bike";
            else
                table = "scooter";
            return table;
        }

        public void GetModelFilter(DbViewWindow dbView)
        {
            string brand = "";
            string groupDetails = "";
            string table = "";
            int tabId = dbView.GetTabId;

            table = GetTableName(tabId);

            DataTable filtersTable = new DataTable();
            List<string> modelFilter = new List<string>();

            brand = dbView.BrandFilter;
            groupDetails = "v.model";
            string qry = $"SELECT {groupDetails} FROM {table} details LEFT JOIN vehicle v ON v.vid = details.vid WHERE v.brand = '{brand}' GROUP BY {groupDetails} ";
            sqliteCommand(filtersTable, qry);
            foreach (DataRow row in filtersTable.Rows)
                modelFilter.Add(row[0].ToString());

            dbView.AddModelFilter(modelFilter);

        }


        private string getWhereQuery(DbViewWindow dbView)
        {
            List<string> filtersList = new List<string>();
            string whereQuery = "";
            string modelFilterString = "";
            string brandFilterString = "";
            string yearToFilterString = "";
            string yearFromFilterString = "";


            int nrOfFiltersAcrive = 0;
            if (dbView.BrandFilter.ToString() != "")
            {
                brandFilterString = $"v.brand = '{ dbView.BrandFilter.ToString() }'";
                nrOfFiltersAcrive++;
            }
            if (dbView.ModelFilter.ToString() != "")
            {
                if (nrOfFiltersAcrive > 0)
                    modelFilterString += " AND ";
                modelFilterString += $"  v.model = '{ dbView.ModelFilter.ToString() }'";
                nrOfFiltersAcrive++;
            }

            if (dbView.YearFromFilter.ToString() != "")
            {
                if (nrOfFiltersAcrive > 0)
                    yearFromFilterString += " AND ";
                yearFromFilterString +=$" v.prodYear <= '{ dbView.YearFromFilter.ToString() }'";
                nrOfFiltersAcrive++;
            }
            if (dbView.YearToFilter.ToString() != "")
            {
                if (nrOfFiltersAcrive > 0)
                    yearToFilterString += " AND ";
                yearToFilterString +=$" v.prodYear >= '{ dbView.YearToFilter.ToString() } '";
                nrOfFiltersAcrive++;
            }

            if (nrOfFiltersAcrive > 0)
                whereQuery = $"WHERE {brandFilterString}{modelFilterString}{yearFromFilterString}{yearToFilterString}";

            return whereQuery;
        }


        private string ViewQuery(DbViewWindow dbView)
        {
            int tabId = dbView.GetTabId;
            string detailsTable = "";
            string whereQuery = getWhereQuery(dbView);
            if (tabId == 0)
                detailsTable = "details.engine,details.doors FROM car";
            else if (tabId == 1)
                detailsTable = "details.engine,details.capacity FROM truck";
            else if (tabId == 2)
                detailsTable = "details.type FROM bike";
            else
                detailsTable = "details.range FROM scooter";

            return $"SELECT v.brand, v.model, v.prodYear,  v.color, {detailsTable} details LEFT JOIN vehicle v ON v.vid = details.vid {whereQuery}";

        }

        public void DbViewVechiles(DbViewWindow dbView)         
        {
            if (sqliteConnection.State == System.Data.ConnectionState.Open)
            {
                DataTable selectTable = new DataTable();
                string qry = ViewQuery(dbView);
                sqliteCommand(selectTable, qry);
                dbView.ViewOnList(selectTable);       
            }
            else
            {
                MessageBox.Show("Error. Database not connected");       
            }
            
        }
        
    }
}

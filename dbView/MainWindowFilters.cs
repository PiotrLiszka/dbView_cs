using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace dbView
{
    class MainWindowFilters
    {
        private string sqlTable;
        private string sqlGroupDetails;
        private int activeTabId;
        private string qry;
 
        public MainWindowFilters()
        {
        }

        private string GetTableName(int tabId)
        {
            string activeTable;
            if (tabId == 0)
                activeTable = "car";
            else if (tabId == 1)
                activeTable = "truck";
            else if (tabId == 2)
                activeTable = "bike";
            else
                activeTable = "scooter";
            return activeTable;
        }

        public void SetBrandFilter(DbViewWindow dbView)
        {
            List<string> brandFilter = new List<string>();
            activeTabId = dbView.GetActiveTabId;
            DataTable BrandFiltersTable = new DataTable();
            sqlGroupDetails = "";
            sqlTable = "";

            sqlTable = GetTableName(activeTabId);

            sqlGroupDetails = "v.brand";
            qry = $"SELECT {sqlGroupDetails} FROM {sqlTable} details LEFT JOIN vehicle v ON v.vid = details.vid GROUP BY {sqlGroupDetails}";
            Database.sqliteCommand(BrandFiltersTable, qry);
            foreach (DataRow row in BrandFiltersTable.Rows)
                brandFilter.Add(row[0].ToString());

            dbView.AddBrandFilter(brandFilter);

        }

        public void SetModelFilter(DbViewWindow dbView)
        {
            string brand = "";
            sqlGroupDetails = "";
            sqlTable = "";
            activeTabId = dbView.GetActiveTabId;

            sqlTable = GetTableName(activeTabId);

            DataTable ModelFiltersTable = new DataTable();
            List<string> modelFilter = new List<string>();

            brand = dbView.BrandFilterValue;
            sqlGroupDetails = "v.model";
            qry = $"SELECT {sqlGroupDetails} FROM {sqlTable} details LEFT JOIN vehicle v ON v.vid = details.vid WHERE v.brand = '{brand}' GROUP BY {sqlGroupDetails} ";
            Database.sqliteCommand(ModelFiltersTable, qry);
            foreach (DataRow row in ModelFiltersTable.Rows)
                modelFilter.Add(row[0].ToString());

            dbView.AddModelFilter(modelFilter);

        }
        public void SetYearFilter(DbViewWindow dbView)
        {
            List<string> yearFilter = new List<string>();
            DataTable ModelFiltersTable = new DataTable();
            sqlTable = "";
            string whereQuery = "";
            activeTabId = dbView.GetActiveTabId;
            sqlTable = GetTableName(activeTabId);
            if (dbView.BrandFilterValue != "")
                whereQuery += $"WHERE v.brand = '{dbView.BrandFilterValue.ToString()}'";
            if (dbView.ModelFilterValue != "")
                whereQuery += $"AND v.model = '{dbView.ModelFilterValue.ToString()}'";

            qry = $"SELECT MIN(v.prodYear) FROM {sqlTable} details LEFT JOIN vehicle v ON v.vid = details.vid {whereQuery}";
            Database.sqliteCommand(ModelFiltersTable, qry);
            foreach (DataRow row in ModelFiltersTable.Rows)
                yearFilter.Add(row[0].ToString());

            qry = $"SELECT MAX(v.prodYear) FROM {sqlTable} details LEFT JOIN vehicle v ON v.vid = details.vid {whereQuery}";
            Database.sqliteCommand(ModelFiltersTable, qry);
            foreach (DataRow row in ModelFiltersTable.Rows)
                yearFilter.Add(row[1].ToString());

            dbView.AddYearFilter(yearFilter);
        }
    }
}

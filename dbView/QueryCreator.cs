using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbView
{
    class QueryCreator
    {

        public static string getWhereQuery(DbViewWindow dbView)
        {
            List<string> filtersList = new List<string>();
            string whereQuery = "";
            string modelFilterWhereQuery = "";
            string brandFilterWhereQuery = "";
            string yearToFilterWhereQuery = "";
            string yearFromFilterWhereQuery = "";
            int nrOfFiltersActive = 0;

            if (dbView.BrandFilterValue.ToString() != "")
            {
                brandFilterWhereQuery = $"v.brand = '{ dbView.BrandFilterValue.ToString() }'";
                nrOfFiltersActive++;
            }
            if (dbView.ModelFilterValue.ToString() != "")
            {
                if (nrOfFiltersActive > 0)
                    modelFilterWhereQuery += " AND ";
                modelFilterWhereQuery += $"  v.model = '{ dbView.ModelFilterValue.ToString() }'";
                nrOfFiltersActive++;
            }

            if (dbView.YearFromFilterValue.ToString() != "")
            {
                if (nrOfFiltersActive > 0)
                    yearFromFilterWhereQuery += " AND ";
                yearFromFilterWhereQuery += $" v.prodYear >= '{ dbView.YearFromFilterValue.ToString() }'";
                nrOfFiltersActive++;
            }
            if (dbView.YearToFilterValue.ToString() != "")
            {
                if (nrOfFiltersActive > 0)
                    yearToFilterWhereQuery += " AND ";
                yearToFilterWhereQuery += $" v.prodYear <= '{ dbView.YearToFilterValue.ToString() } '";
                nrOfFiltersActive++;
            }

            if (nrOfFiltersActive > 0)
                whereQuery = $"WHERE {brandFilterWhereQuery}{modelFilterWhereQuery}{yearFromFilterWhereQuery}{yearToFilterWhereQuery}";

            return whereQuery;
        }

        public static string SelectQuery(DbViewWindow dbView)
        {
            int tabId = dbView.GetActiveTabId;
            string detailsTableQuery = "";
            string whereQuery = getWhereQuery(dbView);
            if (tabId == 0)
                detailsTableQuery = "details.engine AS Engine,details.doors AS No_of_doors FROM car";
            else if (tabId == 1)
                detailsTableQuery = $"details.engine AS Engine,details.capacity As Max_capacity_kg FROM truck";
            else if (tabId == 2)
                detailsTableQuery = "details.type AS Type FROM bike";
            else
                detailsTableQuery = "details.range As Range_in_km FROM scooter";

            return $"SELECT v.brand AS Brand, v.model AS Model, v.prodYear AS Production_Year," +
                $"  v.color AS Color, {detailsTableQuery} details LEFT JOIN vehicle v ON v.vid = details.vid {whereQuery}";

        }

    }
}

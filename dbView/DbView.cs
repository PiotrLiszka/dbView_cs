using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace dbView
{
    public partial class DbViewWindow : Form
    {
        Database sqlite;
        MainWindowFilters filters;

        private string brandFilterValue = "";
        private string modelFilterValue = "";
        private string yearFromFilterValue = "";
        private string yearToFilterValue = "";
        private int getActiveTabId = 0;

        public string BrandFilterValue { get => brandFilterValue; set => brandFilterValue = value; }
        public string ModelFilterValue { get => modelFilterValue; set => modelFilterValue = value; }
        public string YearFromFilterValue { get => yearFromFilterValue; set => yearFromFilterValue = value; }
        public string YearToFilterValue { get => yearToFilterValue; set => yearToFilterValue = value; }
        public int GetActiveTabId { get => getActiveTabId; set => getActiveTabId = value; }

        public DbViewWindow()
        {
            InitializeComponent();
            sqlite = new Database();
            filters = new MainWindowFilters();
            sqlite.DbViewVechiles(this);                                    //Viewing initial table
            filters.SetBrandFilter(this);                                   //Setting initial filters
            filters.SetYearFilter(this);
        }

        public void ViewOnWindow(DataTable dt)
        {
            if (GetActiveTabId == 0)
                this.carGrid.DataSource = dt;
            else if (GetActiveTabId == 1)
                this.truckGrid.DataSource = dt;
            else if (GetActiveTabId == 2)
                this.bikeGrid.DataSource = dt;
            else if (GetActiveTabId == 3)
                this.scooterGrid.DataSource = dt;
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            GetActiveTabId = this.tabControl1.SelectedIndex;
            brandFilterValue = "";
            modelFilterValue = "";
            yearFromFilterValue = "";
            yearToFilterValue = "";
            sqlite.DbViewVechiles(this);
            filters.SetModelFilter(this);
            filters.SetBrandFilter(this);
            filters.SetYearFilter(this);
        }

        public void AddBrandFilter(List<string> brand)
        {
            this.brandCombo.Items.Clear();
            this.brandCombo.Items.Add("");

            foreach (string s in brand)
                this.brandCombo.Items.Add(s);
        }

        public void AddModelFilter(List<string> model)
        {
            this.modelCombo.Items.Clear();
            this.modelCombo.Items.Add("");

            foreach (string s in model)
                this.modelCombo.Items.Add(s);
        }

        public void AddYearFilter(List<string> year)
        {
            this.yearFromCombo.Items.Clear();
            this.yearToCombo.Items.Clear();
            this.yearFromCombo.Items.Add("");
            this.yearToCombo.Items.Add("");
            if (Int32.TryParse(year[0], out int res) && Int32.TryParse(year[1], out res))
            {
                for (int i = Int32.Parse(year[0]); i <= Int32.Parse(year[1]); ++i)
                {
                    this.yearFromCombo.Items.Add(i);
                    this.yearToCombo.Items.Add(i);
                }
            }
        }

        private bool YearValidation()
        {
            if (YearToFilterValue != "" && YearFromFilterValue != "")
            {
                if (Int32.Parse(yearFromFilterValue) <= Int32.Parse(yearToFilterValue))
                    return true;
                else
                {
                    MessageBox.Show("Year From cannot be lower than Year To.");
                    return false;
                }
            }
            return true;

        }


        private void brandCombo_TextChanged(object sender, EventArgs e)
        {
            BrandFilterValue = this.brandCombo.Text;
            if (brandCombo.Text.ToString() == "")
            {
                modelCombo.Enabled = false;
                this.modelCombo.Text = "";
            }
            else
            {
                modelCombo.Enabled = true;
                this.modelCombo.Text = "";
            }
            this.yearFromCombo.Text = "";
            this.yearToCombo.Text = "";

            filters.SetModelFilter(this);
            filters.SetYearFilter(this);
            sqlite.DbViewVechiles(this);
        }

        private void modelCombo_TextChanged(object sender, EventArgs e)
        {
            ModelFilterValue = this.modelCombo.Text;
            this.yearFromCombo.Text = "";
            this.yearToCombo.Text = "";
            filters.SetYearFilter(this);
            sqlite.DbViewVechiles(this);
        }

        private void yearFromCombo_TextChanged(object sender, EventArgs e)
        {
            YearFromFilterValue = this.yearFromCombo.Text;
            if (YearValidation())
                sqlite.DbViewVechiles(this);
        }

        private void yearToCombo_TextChanged(object sender, EventArgs e)
        {
            YearToFilterValue = this.yearToCombo.Text;
            if (YearValidation())
                sqlite.DbViewVechiles(this);
        }


        private void resetButton_Click(object sender, EventArgs e)
        {
            brandCombo.Text = "";
            modelCombo.Text = "";
            yearFromCombo.Text = "";
            yearToCombo.Text = "";
            brandFilterValue = "";
            modelFilterValue = "";
            yearFromFilterValue = "";
            yearToFilterValue = "";

            sqlite.DbViewVechiles(this);
        }


    }


}

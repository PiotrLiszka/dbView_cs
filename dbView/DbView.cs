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
        private string brandFilter = "";
        private string modelFilter = "";
        private string yearFromFilter = "";
        private string yearToFilter = "";
        private int getTabId = 0;
        private bool modelComboEnabled = false;

        public string BrandFilter { get => brandFilter; set => brandFilter = value; }
        public string ModelFilter { get => modelFilter; set => modelFilter = value; }
        public string YearFromFilter { get => yearFromFilter; set => yearFromFilter = value; }
        public string YearToFilter { get => yearToFilter; set => yearToFilter = value; }
        public int GetTabId { get => getTabId; set => getTabId = value; }
        public bool ModelComboEnabled { get => modelComboEnabled; set => modelComboEnabled = value; }

        public DbViewWindow()
        {
            InitializeComponent();
            sqlite = new Database();
            sqlite.DbViewVechiles(this);        //Viewing initial table
            sqlite.GetFilters(this);            //Setting initial filters
        }

        public void ViewOnList(DataTable dt)
        {
            if (GetTabId == 0)
                this.carGrid.DataSource = dt;
            else if (GetTabId == 1)
                this.truckGrid.DataSource = dt;
            else if (GetTabId == 2)
                this.bikeGrid.DataSource = dt;
            else if (GetTabId == 3)
                this.scooterGrid.DataSource = dt;
        }



        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            GetTabId = this.tabControl1.SelectedIndex;
            this.brandCombo.Text = "";
            brandFilter = "";
            modelFilter = "";
            yearFromFilter = "";
            yearToFilter = "";
            sqlite.DbViewVechiles(this);
            sqlite.GetFilters(this);
        }

        public void AddFilters(List<string> brand,  List<string> year)
        {
            this.brandCombo.Items.Clear();
            this.yearFromCombo.Items.Clear();
            this.yearToCombo.Items.Clear();

            this.brandCombo.Items.Add("");
            this.yearFromCombo.Items.Add("");
            this.yearToCombo.Items.Add("");

            foreach (string s in brand)
                this.brandCombo.Items.Add(s);
            
            for(int i = Int32.Parse(year[0]); i<= Int32.Parse(year[1]); ++i)
            {
                this.yearFromCombo.Items.Add(i);
                this.yearToCombo.Items.Add(i);
            }

        }

        public void AddModelFilter(List<string> model)
        {
            this.modelCombo.Items.Clear();
            this.modelCombo.Items.Add("");

            foreach (string s in model)
                this.modelCombo.Items.Add(s);
        }


        private void filterButton_Click(object sender, EventArgs e)
        {
            brandFilter = this.brandCombo.Text.ToString();
            modelFilter = this.modelCombo.Text.ToString();
            yearToFilter = this.yearFromCombo.Text.ToString();
            yearFromFilter = this.yearToCombo.Text.ToString();
            if (YearToFilter != "" && YearFromFilter != "")
            {
                if (Int32.Parse(yearFromFilter) >= Int32.Parse(yearToFilter))
                    sqlite.DbViewVechiles(this);
                else
                {
                    MessageBox.Show("Year From cannot be lower than Year To.");
                    return;
                }
            }

            sqlite.DbViewVechiles(this);
        }


        private void brandCombo_TextChanged(object sender, EventArgs e)
        {
            BrandFilter = this.brandCombo.Text;
            if (brandCombo.Text.ToString() == "")
            {
                modelCombo.Enabled = false;
                this.modelCombo.Text = "";
            }
            else
                modelCombo.Enabled = true;


            sqlite.GetModelFilter(this);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            brandCombo.Text = "";
            modelCombo.Text = "";
            yearFromCombo.Text = "";
            yearToCombo.Text = "";
            brandFilter = "";
            modelFilter = "";
            yearFromFilter = "";
            yearToFilter = "";

            sqlite.DbViewVechiles(this);
        }
    }


}

namespace dbView
{
    partial class DbViewWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.carsPage = new System.Windows.Forms.TabPage();
            this.carGrid = new System.Windows.Forms.DataGridView();
            this.trucksPage = new System.Windows.Forms.TabPage();
            this.truckGrid = new System.Windows.Forms.DataGridView();
            this.bikesPage = new System.Windows.Forms.TabPage();
            this.bikeGrid = new System.Windows.Forms.DataGridView();
            this.scootersPage = new System.Windows.Forms.TabPage();
            this.scooterGrid = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.filterLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.yearFromLabel = new System.Windows.Forms.Label();
            this.brandCombo = new System.Windows.Forms.ComboBox();
            this.modelCombo = new System.Windows.Forms.ComboBox();
            this.yearFromCombo = new System.Windows.Forms.ComboBox();
            this.yearToLabel = new System.Windows.Forms.Label();
            this.yearToCombo = new System.Windows.Forms.ComboBox();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.carsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carGrid)).BeginInit();
            this.trucksPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.truckGrid)).BeginInit();
            this.bikesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bikeGrid)).BeginInit();
            this.scootersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scooterGrid)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.carsPage);
            this.tabControl1.Controls.Add(this.trucksPage);
            this.tabControl1.Controls.Add(this.bikesPage);
            this.tabControl1.Controls.Add(this.scootersPage);
            this.tabControl1.Location = new System.Drawing.Point(228, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(678, 433);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // carsPage
            // 
            this.carsPage.Controls.Add(this.carGrid);
            this.carsPage.Location = new System.Drawing.Point(4, 22);
            this.carsPage.Name = "carsPage";
            this.carsPage.Padding = new System.Windows.Forms.Padding(3);
            this.carsPage.Size = new System.Drawing.Size(670, 407);
            this.carsPage.TabIndex = 0;
            this.carsPage.Text = "Cars";
            this.carsPage.UseVisualStyleBackColor = true;
            // 
            // carGrid
            // 
            this.carGrid.AllowUserToAddRows = false;
            this.carGrid.AllowUserToDeleteRows = false;
            this.carGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carGrid.Location = new System.Drawing.Point(6, 6);
            this.carGrid.Name = "carGrid";
            this.carGrid.ReadOnly = true;
            this.carGrid.Size = new System.Drawing.Size(658, 395);
            this.carGrid.TabIndex = 0;
            // 
            // trucksPage
            // 
            this.trucksPage.Controls.Add(this.truckGrid);
            this.trucksPage.Location = new System.Drawing.Point(4, 22);
            this.trucksPage.Name = "trucksPage";
            this.trucksPage.Padding = new System.Windows.Forms.Padding(3);
            this.trucksPage.Size = new System.Drawing.Size(634, 407);
            this.trucksPage.TabIndex = 1;
            this.trucksPage.Text = "Trucks";
            this.trucksPage.UseVisualStyleBackColor = true;
            // 
            // truckGrid
            // 
            this.truckGrid.AllowUserToAddRows = false;
            this.truckGrid.AllowUserToDeleteRows = false;
            this.truckGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.truckGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.truckGrid.Location = new System.Drawing.Point(6, 6);
            this.truckGrid.Name = "truckGrid";
            this.truckGrid.ReadOnly = true;
            this.truckGrid.Size = new System.Drawing.Size(622, 395);
            this.truckGrid.TabIndex = 0;
            // 
            // bikesPage
            // 
            this.bikesPage.Controls.Add(this.bikeGrid);
            this.bikesPage.Location = new System.Drawing.Point(4, 22);
            this.bikesPage.Name = "bikesPage";
            this.bikesPage.Padding = new System.Windows.Forms.Padding(3);
            this.bikesPage.Size = new System.Drawing.Size(634, 407);
            this.bikesPage.TabIndex = 2;
            this.bikesPage.Text = "Bikes";
            this.bikesPage.UseVisualStyleBackColor = true;
            // 
            // bikeGrid
            // 
            this.bikeGrid.AllowUserToAddRows = false;
            this.bikeGrid.AllowUserToDeleteRows = false;
            this.bikeGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bikeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bikeGrid.Location = new System.Drawing.Point(6, 6);
            this.bikeGrid.Name = "bikeGrid";
            this.bikeGrid.ReadOnly = true;
            this.bikeGrid.Size = new System.Drawing.Size(622, 395);
            this.bikeGrid.TabIndex = 0;
            // 
            // scootersPage
            // 
            this.scootersPage.Controls.Add(this.scooterGrid);
            this.scootersPage.Location = new System.Drawing.Point(4, 22);
            this.scootersPage.Name = "scootersPage";
            this.scootersPage.Padding = new System.Windows.Forms.Padding(3);
            this.scootersPage.Size = new System.Drawing.Size(634, 407);
            this.scootersPage.TabIndex = 3;
            this.scootersPage.Text = "Scooters";
            this.scootersPage.UseVisualStyleBackColor = true;
            // 
            // scooterGrid
            // 
            this.scooterGrid.AllowUserToAddRows = false;
            this.scooterGrid.AllowUserToDeleteRows = false;
            this.scooterGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scooterGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scooterGrid.Location = new System.Drawing.Point(6, 6);
            this.scooterGrid.Name = "scooterGrid";
            this.scooterGrid.ReadOnly = true;
            this.scooterGrid.Size = new System.Drawing.Size(622, 395);
            this.scooterGrid.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tabControl1, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(909, 439);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.filterLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.brandLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.modelLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.yearFromLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.brandCombo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.modelCombo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.yearFromCombo, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.yearToLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.yearToCombo, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.resetButton, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(219, 227);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // filterLabel
            // 
            this.filterLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filterLabel.AutoSize = true;
            this.filterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filterLabel.Location = new System.Drawing.Point(14, 9);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(51, 16);
            this.filterLabel.TabIndex = 0;
            this.filterLabel.Text = "Filters";
            // 
            // brandLabel
            // 
            this.brandLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.brandLabel.AutoSize = true;
            this.brandLabel.Location = new System.Drawing.Point(22, 46);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(35, 13);
            this.brandLabel.TabIndex = 1;
            this.brandLabel.Text = "Brand";
            // 
            // modelLabel
            // 
            this.modelLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(22, 81);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(36, 13);
            this.modelLabel.TabIndex = 2;
            this.modelLabel.Text = "Model";
            // 
            // yearFromLabel
            // 
            this.yearFromLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yearFromLabel.AutoSize = true;
            this.yearFromLabel.Location = new System.Drawing.Point(11, 116);
            this.yearFromLabel.Name = "yearFromLabel";
            this.yearFromLabel.Size = new System.Drawing.Size(58, 13);
            this.yearFromLabel.TabIndex = 3;
            this.yearFromLabel.Text = "Year From:";
            // 
            // brandCombo
            // 
            this.brandCombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.brandCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brandCombo.FormattingEnabled = true;
            this.brandCombo.Location = new System.Drawing.Point(89, 42);
            this.brandCombo.Name = "brandCombo";
            this.brandCombo.Size = new System.Drawing.Size(121, 21);
            this.brandCombo.TabIndex = 5;
            this.brandCombo.TextChanged += new System.EventHandler(this.brandCombo_TextChanged);
            // 
            // modelCombo
            // 
            this.modelCombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modelCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelCombo.Enabled = false;
            this.modelCombo.FormattingEnabled = true;
            this.modelCombo.Location = new System.Drawing.Point(89, 77);
            this.modelCombo.Name = "modelCombo";
            this.modelCombo.Size = new System.Drawing.Size(121, 21);
            this.modelCombo.TabIndex = 6;
            this.modelCombo.TextChanged += new System.EventHandler(this.modelCombo_TextChanged);
            // 
            // yearFromCombo
            // 
            this.yearFromCombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yearFromCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearFromCombo.FormattingEnabled = true;
            this.yearFromCombo.Location = new System.Drawing.Point(89, 112);
            this.yearFromCombo.Name = "yearFromCombo";
            this.yearFromCombo.Size = new System.Drawing.Size(121, 21);
            this.yearFromCombo.TabIndex = 7;
            this.yearFromCombo.TextChanged += new System.EventHandler(this.yearFromCombo_TextChanged);
            // 
            // yearToLabel
            // 
            this.yearToLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yearToLabel.AutoSize = true;
            this.yearToLabel.Location = new System.Drawing.Point(16, 151);
            this.yearToLabel.Name = "yearToLabel";
            this.yearToLabel.Size = new System.Drawing.Size(48, 13);
            this.yearToLabel.TabIndex = 8;
            this.yearToLabel.Text = "Year To:";
            // 
            // yearToCombo
            // 
            this.yearToCombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yearToCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearToCombo.FormattingEnabled = true;
            this.yearToCombo.Location = new System.Drawing.Point(89, 147);
            this.yearToCombo.Name = "yearToCombo";
            this.yearToCombo.Size = new System.Drawing.Size(121, 21);
            this.yearToCombo.TabIndex = 9;
            this.yearToCombo.TextChanged += new System.EventHandler(this.yearToCombo_TextChanged);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetButton.Location = new System.Drawing.Point(101, 189);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(97, 23);
            this.resetButton.TabIndex = 10;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // DbViewWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 464);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Name = "DbViewWindow";
            this.Text = "dbView";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.carsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carGrid)).EndInit();
            this.trucksPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.truckGrid)).EndInit();
            this.bikesPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bikeGrid)).EndInit();
            this.scootersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scooterGrid)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage carsPage;
        private System.Windows.Forms.TabPage trucksPage;
        private System.Windows.Forms.TabPage bikesPage;
        private System.Windows.Forms.TabPage scootersPage;
        private System.Windows.Forms.DataGridView carGrid;
        private System.Windows.Forms.DataGridView truckGrid;
        private System.Windows.Forms.DataGridView bikeGrid;
        private System.Windows.Forms.DataGridView scooterGrid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label yearFromLabel;
        private System.Windows.Forms.ComboBox brandCombo;
        private System.Windows.Forms.ComboBox modelCombo;
        private System.Windows.Forms.ComboBox yearFromCombo;
        private System.Windows.Forms.Label yearToLabel;
        private System.Windows.Forms.ComboBox yearToCombo;
        private System.Windows.Forms.Button resetButton;
    }
}


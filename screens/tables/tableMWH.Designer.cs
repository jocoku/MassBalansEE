namespace MassBalans
{
    partial class tableMWH
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gasyieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputCountryMWHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSourceDataSet = new MassBalans.dbSourceDataSet();
            this.inputBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inputTableAdapter = new MassBalans.dbSourceDataSetTableAdapters.inputTableAdapter();
            this.inputCountryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inputCountryTableAdapter = new MassBalans.dbSourceDataSetTableAdapters.InputCountryTableAdapter();
            this.inputCountryMWHTableAdapter = new MassBalans.dbSourceDataSetTableAdapters.InputCountryMWHTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCountryMWHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSourceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCountryBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.countryDataGridViewTextBoxColumn,
            this.supplierDataGridViewTextBoxColumn,
            this.resourceDataGridViewTextBoxColumn,
            this.gasyieldDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inputCountryMWHBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(1699, 931);
            this.dataGridView1.TabIndex = 0;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            this.supplierDataGridViewTextBoxColumn.DataPropertyName = "Supplier";
            this.supplierDataGridViewTextBoxColumn.HeaderText = "Supplier";
            this.supplierDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            this.supplierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resourceDataGridViewTextBoxColumn
            // 
            this.resourceDataGridViewTextBoxColumn.DataPropertyName = "Resource";
            this.resourceDataGridViewTextBoxColumn.HeaderText = "Resource";
            this.resourceDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.resourceDataGridViewTextBoxColumn.Name = "resourceDataGridViewTextBoxColumn";
            this.resourceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gasyieldDataGridViewTextBoxColumn
            // 
            this.gasyieldDataGridViewTextBoxColumn.DataPropertyName = "Gasyield";
            this.gasyieldDataGridViewTextBoxColumn.HeaderText = "Gasyield";
            this.gasyieldDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.gasyieldDataGridViewTextBoxColumn.Name = "gasyieldDataGridViewTextBoxColumn";
            this.gasyieldDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inputCountryMWHBindingSource
            // 
            this.inputCountryMWHBindingSource.DataMember = "InputCountryMWH";
            this.inputCountryMWHBindingSource.DataSource = this.dbSourceDataSet;
            // 
            // dbSourceDataSet
            // 
            this.dbSourceDataSet.DataSetName = "dbSourceDataSet";
            this.dbSourceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inputBindingSource
            // 
            this.inputBindingSource.DataMember = "input";
            this.inputBindingSource.DataSource = this.dbSourceDataSet;
            // 
            // inputTableAdapter
            // 
            this.inputTableAdapter.ClearBeforeFill = true;
            // 
            // inputCountryBindingSource
            // 
            this.inputCountryBindingSource.DataMember = "InputCountry";
            this.inputCountryBindingSource.DataSource = this.dbSourceDataSet;
            // 
            // inputCountryTableAdapter
            // 
            this.inputCountryTableAdapter.ClearBeforeFill = true;
            // 
            // inputCountryMWHTableAdapter
            // 
            this.inputCountryMWHTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 891);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1699, 40);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(64, 34);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // tableMWH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "tableMWH";
            this.Size = new System.Drawing.Size(1699, 931);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCountryMWHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSourceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCountryBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource inputBindingSource;
        private dbSourceDataSet dbSourceDataSet;
        private dbSourceDataSetTableAdapters.inputTableAdapter inputTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gasyieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource inputCountryMWHBindingSource;
        private System.Windows.Forms.BindingSource inputCountryBindingSource;
        private dbSourceDataSetTableAdapters.InputCountryTableAdapter inputCountryTableAdapter;
        private dbSourceDataSetTableAdapters.InputCountryMWHTableAdapter inputCountryMWHTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}

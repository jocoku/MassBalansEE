namespace MassBalans
{
    partial class MassProdPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.dbSourceDataSet = new MassBalans.dbSourceDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblSelectItem = new System.Windows.Forms.Label();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierTableAdapter = new MassBalans.dbSourceDataSetTableAdapters.supplierTableAdapter();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDGVtbc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.truckSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dbSourceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(611, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "This is the producers screen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dbSourceDataSet
            // 
            this.dbSourceDataSet.DataSetName = "dbSourceDataSet";
            this.dbSourceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.country,
            this.city,
            this.codeDGVtbc,
            this.truckSizeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.supplierBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(42, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(1787, 921);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnEdit.Location = new System.Drawing.Point(1471, 1027);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(171, 61);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnNew.Location = new System.Drawing.Point(1658, 1027);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(171, 61);
            this.btnNew.TabIndex = 9;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblSelectItem
            // 
            this.lblSelectItem.AutoSize = true;
            this.lblSelectItem.Location = new System.Drawing.Point(26, 1048);
            this.lblSelectItem.Name = "lblSelectItem";
            this.lblSelectItem.Size = new System.Drawing.Size(159, 25);
            this.lblSelectItem.TabIndex = 11;
            this.lblSelectItem.Text = "PLACEHOLDER";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "supplier";
            this.supplierBindingSource.DataSource = this.dbSourceDataSet;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 9;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // country
            // 
            this.country.DataPropertyName = "country";
            this.country.HeaderText = "Country";
            this.country.MinimumWidth = 9;
            this.country.Name = "country";
            this.country.ReadOnly = true;
            // 
            // city
            // 
            this.city.DataPropertyName = "city";
            this.city.HeaderText = "City";
            this.city.MinimumWidth = 9;
            this.city.Name = "city";
            this.city.ReadOnly = true;
            // 
            // codeDGVtbc
            // 
            this.codeDGVtbc.DataPropertyName = "code";
            this.codeDGVtbc.HeaderText = "code";
            this.codeDGVtbc.MinimumWidth = 9;
            this.codeDGVtbc.Name = "codeDGVtbc";
            this.codeDGVtbc.ReadOnly = true;
            this.codeDGVtbc.Visible = false;
            // 
            // truckSizeDataGridViewTextBoxColumn
            // 
            this.truckSizeDataGridViewTextBoxColumn.DataPropertyName = "truckSize";
            this.truckSizeDataGridViewTextBoxColumn.HeaderText = "Truck size";
            this.truckSizeDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.truckSizeDataGridViewTextBoxColumn.Name = "truckSizeDataGridViewTextBoxColumn";
            this.truckSizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MassProdPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSelectItem);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "MassProdPanel";
            this.Size = new System.Drawing.Size(1899, 1131);
            this.Load += new System.EventHandler(this.MassProdPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbSourceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private dbSourceDataSet dbSourceDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblSelectItem;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private dbSourceDataSetTableAdapters.supplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn country;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDGVtbc;
        private System.Windows.Forms.DataGridViewTextBoxColumn truckSizeDataGridViewTextBoxColumn;
    }
}

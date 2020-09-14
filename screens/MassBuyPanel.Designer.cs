namespace MassBalans
{
    partial class MassBuyPanel
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
            this.btnNew = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbSourceDataSet = new MassBalans.dbSourceDataSet();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new MassBalans.dbSourceDataSetTableAdapters.clientTableAdapter();
            this.lblSelectItem = new System.Windows.Forms.Label();
            this.codeDGVtbc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.certVertoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSourceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = "This is the buyers screen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnNew.Location = new System.Drawing.Point(1657, 1038);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(171, 61);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDGVtbc,
            this.nameDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.zipCodeDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.contractDataGridViewCheckBoxColumn,
            this.certVertoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientBindingSource1;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(30, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(1840, 939);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // clientBindingSource1
            // 
            this.clientBindingSource1.DataMember = "client";
            this.clientBindingSource1.DataSource = this.dbSourceDataSet;
            // 
            // dbSourceDataSet
            // 
            this.dbSourceDataSet.DataSetName = "dbSourceDataSet";
            this.dbSourceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.dbSourceDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // lblSelectItem
            // 
            this.lblSelectItem.AutoSize = true;
            this.lblSelectItem.Location = new System.Drawing.Point(96, 1079);
            this.lblSelectItem.Name = "lblSelectItem";
            this.lblSelectItem.Size = new System.Drawing.Size(159, 25);
            this.lblSelectItem.TabIndex = 7;
            this.lblSelectItem.Text = "PLACEHOLDER";
            // 
            // codeDGVtbc
            // 
            this.codeDGVtbc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codeDGVtbc.DataPropertyName = "code";
            this.codeDGVtbc.HeaderText = "code";
            this.codeDGVtbc.MinimumWidth = 9;
            this.codeDGVtbc.Name = "codeDGVtbc";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "country";
            this.countryDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "city";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // zipCodeDataGridViewTextBoxColumn
            // 
            this.zipCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.zipCodeDataGridViewTextBoxColumn.DataPropertyName = "zipCode";
            this.zipCodeDataGridViewTextBoxColumn.HeaderText = "zipCode";
            this.zipCodeDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.zipCodeDataGridViewTextBoxColumn.Name = "zipCodeDataGridViewTextBoxColumn";
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "street";
            this.streetDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            // 
            // contractDataGridViewCheckBoxColumn
            // 
            this.contractDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.contractDataGridViewCheckBoxColumn.DataPropertyName = "contract";
            this.contractDataGridViewCheckBoxColumn.HeaderText = "contract";
            this.contractDataGridViewCheckBoxColumn.MinimumWidth = 9;
            this.contractDataGridViewCheckBoxColumn.Name = "contractDataGridViewCheckBoxColumn";
            this.contractDataGridViewCheckBoxColumn.Width = 87;
            // 
            // certVertoDataGridViewTextBoxColumn
            // 
            this.certVertoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.certVertoDataGridViewTextBoxColumn.DataPropertyName = "certVerto";
            this.certVertoDataGridViewTextBoxColumn.HeaderText = "certVerto";
            this.certVertoDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.certVertoDataGridViewTextBoxColumn.Name = "certVertoDataGridViewTextBoxColumn";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnEdit.Location = new System.Drawing.Point(1467, 1038);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(171, 61);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // MassBuyPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblSelectItem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label1);
            this.Name = "MassBuyPanel";
            this.Size = new System.Drawing.Size(1899, 1131);
            this.Load += new System.EventHandler(this.MassBuyPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSourceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private dbSourceDataSet dbSourceDataSet;
        private dbSourceDataSetTableAdapters.clientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource clientBindingSource1;
        private System.Windows.Forms.Label lblSelectItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDGVtbc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn contractDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn certVertoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnEdit;
    }
}

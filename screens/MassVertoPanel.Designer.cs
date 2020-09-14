namespace MassBalans
{
    partial class MassVertoPanel
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
            this.button1 = new System.Windows.Forms.Button();
            this.dbSourceDataSet = new MassBalans.dbSourceDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.serialCertDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ntaCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vertoValuesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vertoValuesTableAdapter = new MassBalans.dbSourceDataSetTableAdapters.vertoValuesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbSourceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertoValuesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "This is the vertogas screen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1557, 1024);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(304, 86);
            this.button1.TabIndex = 3;
            this.button1.Text = "Import a CSV";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialCertDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.ntaCodeDataGridViewTextBoxColumn,
            this.transactionDateDataGridViewTextBoxColumn,
            this.accountToDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vertoValuesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(1838, 927);
            this.dataGridView1.TabIndex = 4;
            // 
            // serialCertDataGridViewTextBoxColumn
            // 
            this.serialCertDataGridViewTextBoxColumn.DataPropertyName = "serialCert";
            this.serialCertDataGridViewTextBoxColumn.HeaderText = "serialCert";
            this.serialCertDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.serialCertDataGridViewTextBoxColumn.Name = "serialCertDataGridViewTextBoxColumn";
            this.serialCertDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ntaCodeDataGridViewTextBoxColumn
            // 
            this.ntaCodeDataGridViewTextBoxColumn.DataPropertyName = "ntaCode";
            this.ntaCodeDataGridViewTextBoxColumn.HeaderText = "ntaCode";
            this.ntaCodeDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.ntaCodeDataGridViewTextBoxColumn.Name = "ntaCodeDataGridViewTextBoxColumn";
            this.ntaCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transactionDateDataGridViewTextBoxColumn
            // 
            this.transactionDateDataGridViewTextBoxColumn.DataPropertyName = "transactionDate";
            this.transactionDateDataGridViewTextBoxColumn.HeaderText = "transactionDate";
            this.transactionDateDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.transactionDateDataGridViewTextBoxColumn.Name = "transactionDateDataGridViewTextBoxColumn";
            this.transactionDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountToDataGridViewTextBoxColumn
            // 
            this.accountToDataGridViewTextBoxColumn.DataPropertyName = "accountTo";
            this.accountToDataGridViewTextBoxColumn.HeaderText = "accountTo";
            this.accountToDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.accountToDataGridViewTextBoxColumn.Name = "accountToDataGridViewTextBoxColumn";
            this.accountToDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vertoValuesBindingSource
            // 
            this.vertoValuesBindingSource.DataMember = "vertoValues";
            this.vertoValuesBindingSource.DataSource = this.dbSourceDataSet;
            // 
            // vertoValuesTableAdapter
            // 
            this.vertoValuesTableAdapter.ClearBeforeFill = true;
            // 
            // MassVertoPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "MassVertoPanel";
            this.Size = new System.Drawing.Size(1899, 1131);
            ((System.ComponentModel.ISupportInitialize)(this.dbSourceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertoValuesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private dbSourceDataSet dbSourceDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialCertDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ntaCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountToDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vertoValuesBindingSource;
        private dbSourceDataSetTableAdapters.vertoValuesTableAdapter vertoValuesTableAdapter;
    }
}

namespace MassBalans.screens.vertogasScreens
{
    partial class vertogasImportPage
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSelectedFile = new System.Windows.Forms.Label();
            this.lblSelectfile = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.serialCertDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ntaCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vertoValuesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSourceDataSet = new MassBalans.dbSourceDataSet();
            this.lblPreview = new System.Windows.Forms.Label();
            this.vertoValuesTableAdapter = new MassBalans.dbSourceDataSetTableAdapters.vertoValuesTableAdapter();
            this.tableAdapterManager = new MassBalans.dbSourceDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertoValuesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSourceDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.Location = new System.Drawing.Point(1315, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSelectedFile
            // 
            this.lblSelectedFile.AutoSize = true;
            this.lblSelectedFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedFile.Location = new System.Drawing.Point(649, 46);
            this.lblSelectedFile.Name = "lblSelectedFile";
            this.lblSelectedFile.Size = new System.Drawing.Size(201, 30);
            this.lblSelectedFile.TabIndex = 1;
            this.lblSelectedFile.Text = "No File Selected";
            // 
            // lblSelectfile
            // 
            this.lblSelectfile.AutoSize = true;
            this.lblSelectfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblSelectfile.Location = new System.Drawing.Point(451, 46);
            this.lblSelectfile.Name = "lblSelectfile";
            this.lblSelectfile.Size = new System.Drawing.Size(155, 30);
            this.lblSelectfile.TabIndex = 2;
            this.lblSelectfile.Text = "Vertogas file";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1724, 1024);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 49);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnCancel.Location = new System.Drawing.Point(66, 1024);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 48);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
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
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(66, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(1770, 889);
            this.dataGridView1.TabIndex = 5;
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
            // dbSourceDataSet
            // 
            this.dbSourceDataSet.DataSetName = "dbSourceDataSet";
            this.dbSourceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblPreview.Location = new System.Drawing.Point(66, 966);
            this.lblPreview.MinimumSize = new System.Drawing.Size(1770, 0);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(1770, 30);
            this.lblPreview.TabIndex = 6;
            this.lblPreview.Text = "PREVIEW";
            this.lblPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vertoValuesTableAdapter
            // 
            this.vertoValuesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.inputTableAdapter = null;
            this.tableAdapterManager.mbSourcesTableAdapter = null;
            this.tableAdapterManager.OutputTableAdapter = null;
            this.tableAdapterManager.resourceTableAdapter = null;
            this.tableAdapterManager.supplierCertTableAdapter = null;
            this.tableAdapterManager.supplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MassBalans.dbSourceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vertoValuesTableAdapter = this.vertoValuesTableAdapter;
            // 
            // vertogasImportPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPreview);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblSelectfile);
            this.Controls.Add(this.lblSelectedFile);
            this.Controls.Add(this.button1);
            this.Name = "vertogasImportPage";
            this.Size = new System.Drawing.Size(1899, 1131);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertoValuesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSourceDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSelectedFile;
        private System.Windows.Forms.Label lblSelectfile;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialCertDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ntaCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountToDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vertoValuesBindingSource;
        private dbSourceDataSet dbSourceDataSet;
        private dbSourceDataSetTableAdapters.vertoValuesTableAdapter vertoValuesTableAdapter;
        private dbSourceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

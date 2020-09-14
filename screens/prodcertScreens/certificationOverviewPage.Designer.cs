namespace MassBalans.screens.prodcertScreens
{
    partial class certificationOverviewPage
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
            this.lblGenText = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.buttNew = new System.Windows.Forms.Button();
            this.buttBack = new System.Windows.Forms.Button();
            this.dbSourceDataSet = new MassBalans.dbSourceDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.supplierCertBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEdit = new System.Windows.Forms.Button();
            this.supplierCertTableAdapter = new MassBalans.dbSourceDataSetTableAdapters.supplierCertTableAdapter();
            this.serialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selfdecDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.startdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dbSourceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierCertBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGenText
            // 
            this.lblGenText.AutoSize = true;
            this.lblGenText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblGenText.Location = new System.Drawing.Point(694, 54);
            this.lblGenText.Name = "lblGenText";
            this.lblGenText.Size = new System.Drawing.Size(243, 39);
            this.lblGenText.TabIndex = 0;
            this.lblGenText.Text = "Certificates for";
            this.lblGenText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCompany.Location = new System.Drawing.Point(936, 54);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(103, 39);
            this.lblCompany.TabIndex = 1;
            this.lblCompany.Text = "Aviko";
            // 
            // buttNew
            // 
            this.buttNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttNew.Location = new System.Drawing.Point(1712, 1042);
            this.buttNew.Name = "buttNew";
            this.buttNew.Size = new System.Drawing.Size(130, 47);
            this.buttNew.TabIndex = 28;
            this.buttNew.Text = "New";
            this.buttNew.UseVisualStyleBackColor = true;
            this.buttNew.Click += new System.EventHandler(this.buttNew_Click);
            // 
            // buttBack
            // 
            this.buttBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttBack.Location = new System.Drawing.Point(44, 1042);
            this.buttBack.Name = "buttBack";
            this.buttBack.Size = new System.Drawing.Size(130, 47);
            this.buttBack.TabIndex = 26;
            this.buttBack.Text = "Back";
            this.buttBack.UseVisualStyleBackColor = true;
            this.buttBack.Click += new System.EventHandler(this.buttBack_Click);
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
            this.serialDataGridViewTextBoxColumn,
            this.selfdecDataGridViewCheckBoxColumn,
            this.startdateDataGridViewTextBoxColumn,
            this.enddateDataGridViewTextBoxColumn,
            this.supplierCodeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.supplierCertBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(44, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(1798, 889);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // supplierCertBindingSource
            // 
            this.supplierCertBindingSource.DataMember = "supplierCert";
            this.supplierCertBindingSource.DataSource = this.dbSourceDataSet;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(1576, 1042);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(130, 47);
            this.btnEdit.TabIndex = 31;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // supplierCertTableAdapter
            // 
            this.supplierCertTableAdapter.ClearBeforeFill = true;
            // 
            // serialDataGridViewTextBoxColumn
            // 
            this.serialDataGridViewTextBoxColumn.DataPropertyName = "serial";
            this.serialDataGridViewTextBoxColumn.HeaderText = "Number";
            this.serialDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.serialDataGridViewTextBoxColumn.Name = "serialDataGridViewTextBoxColumn";
            this.serialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // selfdecDataGridViewCheckBoxColumn
            // 
            this.selfdecDataGridViewCheckBoxColumn.DataPropertyName = "selfdec";
            this.selfdecDataGridViewCheckBoxColumn.HeaderText = "Selfdeclaration";
            this.selfdecDataGridViewCheckBoxColumn.MinimumWidth = 9;
            this.selfdecDataGridViewCheckBoxColumn.Name = "selfdecDataGridViewCheckBoxColumn";
            this.selfdecDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // startdateDataGridViewTextBoxColumn
            // 
            this.startdateDataGridViewTextBoxColumn.DataPropertyName = "startdate";
            this.startdateDataGridViewTextBoxColumn.HeaderText = "Start date";
            this.startdateDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.startdateDataGridViewTextBoxColumn.Name = "startdateDataGridViewTextBoxColumn";
            this.startdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enddateDataGridViewTextBoxColumn
            // 
            this.enddateDataGridViewTextBoxColumn.DataPropertyName = "enddate";
            this.enddateDataGridViewTextBoxColumn.HeaderText = "End date";
            this.enddateDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.enddateDataGridViewTextBoxColumn.Name = "enddateDataGridViewTextBoxColumn";
            this.enddateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplierCodeDataGridViewTextBoxColumn
            // 
            this.supplierCodeDataGridViewTextBoxColumn.DataPropertyName = "supplierCode";
            this.supplierCodeDataGridViewTextBoxColumn.HeaderText = "supplierCode";
            this.supplierCodeDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.supplierCodeDataGridViewTextBoxColumn.Name = "supplierCodeDataGridViewTextBoxColumn";
            this.supplierCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplierCodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // certificationOverviewPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttNew);
            this.Controls.Add(this.buttBack);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.lblGenText);
            this.Name = "certificationOverviewPage";
            this.Size = new System.Drawing.Size(1899, 1131);
            ((System.ComponentModel.ISupportInitialize)(this.dbSourceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierCertBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGenText;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Button buttNew;
        private System.Windows.Forms.Button buttBack;
        private dbSourceDataSet dbSourceDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.BindingSource supplierCertBindingSource;
        private dbSourceDataSetTableAdapters.supplierCertTableAdapter supplierCertTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selfdecDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierCodeDataGridViewTextBoxColumn;
    }
}

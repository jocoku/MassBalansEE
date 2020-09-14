namespace MassBalans
{
    partial class MassInputPanel
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
            this.lblLastIn = new System.Windows.Forms.Label();
            this.btnNxtMonth = new System.Windows.Forms.Button();
            this.btnPrvMonth = new System.Windows.Forms.Button();
            this.lblCurrMonth = new System.Windows.Forms.Label();
            this.btnNewDel = new System.Windows.Forms.Button();
            this.dbSourceDataSet = new MassBalans.dbSourceDataSet();
            this.btnNewPro = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sUPPLIERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aMOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRUCKSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fULLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inputGroupTableAdapter = new MassBalans.dbSourceDataSetTableAdapters.InputGroupTableAdapter();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.btnM3 = new System.Windows.Forms.Button();
            this.btnMWH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbSourceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputGroupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLastIn
            // 
            this.lblLastIn.AutoSize = true;
            this.lblLastIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastIn.Location = new System.Drawing.Point(16, 24);
            this.lblLastIn.Name = "lblLastIn";
            this.lblLastIn.Size = new System.Drawing.Size(494, 39);
            this.lblLastIn.TabIndex = 3;
            this.lblLastIn.Text = "Input per supplier and resource";
            // 
            // btnNxtMonth
            // 
            this.btnNxtMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNxtMonth.Location = new System.Drawing.Point(1724, 1043);
            this.btnNxtMonth.Name = "btnNxtMonth";
            this.btnNxtMonth.Size = new System.Drawing.Size(145, 49);
            this.btnNxtMonth.TabIndex = 5;
            this.btnNxtMonth.Text = "Next";
            this.btnNxtMonth.UseVisualStyleBackColor = true;
            this.btnNxtMonth.Click += new System.EventHandler(this.btnNxtMonth_Click);
            // 
            // btnPrvMonth
            // 
            this.btnPrvMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrvMonth.Location = new System.Drawing.Point(24, 1043);
            this.btnPrvMonth.Name = "btnPrvMonth";
            this.btnPrvMonth.Size = new System.Drawing.Size(145, 49);
            this.btnPrvMonth.TabIndex = 6;
            this.btnPrvMonth.Text = "Previous";
            this.btnPrvMonth.UseVisualStyleBackColor = true;
            this.btnPrvMonth.Click += new System.EventHandler(this.btnPrvMonth_Click);
            // 
            // lblCurrMonth
            // 
            this.lblCurrMonth.AutoSize = true;
            this.lblCurrMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrMonth.Location = new System.Drawing.Point(826, 1052);
            this.lblCurrMonth.Name = "lblCurrMonth";
            this.lblCurrMonth.Size = new System.Drawing.Size(191, 30);
            this.lblCurrMonth.TabIndex = 7;
            this.lblCurrMonth.Text = "[Current Month]";
            // 
            // btnNewDel
            // 
            this.btnNewDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewDel.Location = new System.Drawing.Point(1251, 14);
            this.btnNewDel.Name = "btnNewDel";
            this.btnNewDel.Size = new System.Drawing.Size(290, 49);
            this.btnNewDel.TabIndex = 8;
            this.btnNewDel.Text = "New delivery";
            this.btnNewDel.UseVisualStyleBackColor = true;
            this.btnNewDel.Click += new System.EventHandler(this.btnNewInput_Click);
            // 
            // dbSourceDataSet
            // 
            this.dbSourceDataSet.DataSetName = "dbSourceDataSet";
            this.dbSourceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnNewPro
            // 
            this.btnNewPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPro.Location = new System.Drawing.Point(1571, 14);
            this.btnNewPro.Name = "btnNewPro";
            this.btnNewPro.Size = new System.Drawing.Size(290, 49);
            this.btnNewPro.TabIndex = 10;
            this.btnNewPro.Text = "New processing";
            this.btnNewPro.UseVisualStyleBackColor = true;
            this.btnNewPro.Click += new System.EventHandler(this.btnNewPro_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sUPPLIERDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.aMOUNTDataGridViewTextBoxColumn,
            this.tRUCKSDataGridViewTextBoxColumn,
            this.fULLDataGridViewTextBoxColumn,
            this.eMPTYDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inputGroupBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(33, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(1828, 965);
            this.dataGridView1.TabIndex = 9;
            // 
            // sUPPLIERDataGridViewTextBoxColumn
            // 
            this.sUPPLIERDataGridViewTextBoxColumn.DataPropertyName = "SUPPLIER";
            this.sUPPLIERDataGridViewTextBoxColumn.HeaderText = "Supplier";
            this.sUPPLIERDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.sUPPLIERDataGridViewTextBoxColumn.Name = "sUPPLIERDataGridViewTextBoxColumn";
            this.sUPPLIERDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RESOURCE";
            this.dataGridViewTextBoxColumn1.HeaderText = "Delivered resource";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // aMOUNTDataGridViewTextBoxColumn
            // 
            this.aMOUNTDataGridViewTextBoxColumn.DataPropertyName = "AMOUNT";
            this.aMOUNTDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.aMOUNTDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.aMOUNTDataGridViewTextBoxColumn.Name = "aMOUNTDataGridViewTextBoxColumn";
            this.aMOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tRUCKSDataGridViewTextBoxColumn
            // 
            this.tRUCKSDataGridViewTextBoxColumn.DataPropertyName = "TRUCKS";
            this.tRUCKSDataGridViewTextBoxColumn.HeaderText = "Trucks";
            this.tRUCKSDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.tRUCKSDataGridViewTextBoxColumn.Name = "tRUCKSDataGridViewTextBoxColumn";
            this.tRUCKSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fULLDataGridViewTextBoxColumn
            // 
            this.fULLDataGridViewTextBoxColumn.DataPropertyName = "FULL";
            this.fULLDataGridViewTextBoxColumn.HeaderText = "Full KM";
            this.fULLDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.fULLDataGridViewTextBoxColumn.Name = "fULLDataGridViewTextBoxColumn";
            this.fULLDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eMPTYDataGridViewTextBoxColumn
            // 
            this.eMPTYDataGridViewTextBoxColumn.DataPropertyName = "EMPTY";
            this.eMPTYDataGridViewTextBoxColumn.HeaderText = "Empty KM";
            this.eMPTYDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.eMPTYDataGridViewTextBoxColumn.Name = "eMPTYDataGridViewTextBoxColumn";
            this.eMPTYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inputGroupBindingSource
            // 
            this.inputGroupBindingSource.DataMember = "InputGroup";
            this.inputGroupBindingSource.DataSource = this.dbSourceDataSet;
            // 
            // inputGroupTableAdapter
            // 
            this.inputGroupTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(23, 23);
            // 
            // btnM3
            // 
            this.btnM3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnM3.Location = new System.Drawing.Point(516, 14);
            this.btnM3.Name = "btnM3";
            this.btnM3.Size = new System.Drawing.Size(138, 48);
            this.btnM3.TabIndex = 11;
            this.btnM3.Text = "M3";
            this.btnM3.UseVisualStyleBackColor = true;
            this.btnM3.Click += new System.EventHandler(this.btnM3_Click);
            // 
            // btnMWH
            // 
            this.btnMWH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMWH.Location = new System.Drawing.Point(710, 14);
            this.btnMWH.Name = "btnMWH";
            this.btnMWH.Size = new System.Drawing.Size(130, 48);
            this.btnMWH.TabIndex = 12;
            this.btnMWH.Text = "MWH";
            this.btnMWH.UseVisualStyleBackColor = true;
            this.btnMWH.Click += new System.EventHandler(this.btnMWH_Click);
            // 
            // MassInputPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnMWH);
            this.Controls.Add(this.btnM3);
            this.Controls.Add(this.btnNewPro);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnNewDel);
            this.Controls.Add(this.lblCurrMonth);
            this.Controls.Add(this.btnPrvMonth);
            this.Controls.Add(this.btnNxtMonth);
            this.Controls.Add(this.lblLastIn);
            this.Name = "MassInputPanel";
            this.Size = new System.Drawing.Size(1899, 1131);
            ((System.ComponentModel.ISupportInitialize)(this.dbSourceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputGroupBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLastIn;
        private System.Windows.Forms.Button btnNxtMonth;
        private System.Windows.Forms.Button btnPrvMonth;
        private System.Windows.Forms.Label lblCurrMonth;
        private System.Windows.Forms.Button btnNewDel;
        private dbSourceDataSet dbSourceDataSet;
        private System.Windows.Forms.Button btnNewPro;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUPPLIERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRUCKSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fULLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPTYDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource inputGroupBindingSource;
        private dbSourceDataSetTableAdapters.InputGroupTableAdapter inputGroupTableAdapter;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.Button btnM3;
        private System.Windows.Forms.Button btnMWH;
    }
}

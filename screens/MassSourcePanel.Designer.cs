namespace MassBalans
{
    partial class MassSourcePanel
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
            this.lstbResources = new System.Windows.Forms.ListBox();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.numNTA = new System.Windows.Forms.NumericUpDown();
            this.lclNTAcode = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cmbbCrtGrp = new System.Windows.Forms.ComboBox();
            this.lblISCC = new System.Windows.Forms.Label();
            this.lblCrtGrp = new System.Windows.Forms.Label();
            this.txtbISCC = new System.Windows.Forms.TextBox();
            this.dbSourceDataSet = new MassBalans.dbSourceDataSet();
            this.lblResourceOverview = new System.Windows.Forms.Label();
            this.dGV_Resources = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gasyieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ntaCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resourceTableAdapter = new MassBalans.dbSourceDataSetTableAdapters.resourceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.numNTA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSourceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Resources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lstbResources
            // 
            this.lstbResources.FormattingEnabled = true;
            this.lstbResources.ItemHeight = 24;
            this.lstbResources.Location = new System.Drawing.Point(57, 21);
            this.lstbResources.Name = "lstbResources";
            this.lstbResources.Size = new System.Drawing.Size(574, 988);
            this.lstbResources.TabIndex = 4;
            this.lstbResources.SelectedIndexChanged += new System.EventHandler(this.lstbResources_SelectedIndexChanged);
            // 
            // txtbName
            // 
            this.txtbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbName.Location = new System.Drawing.Point(971, 252);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(831, 37);
            this.txtbName.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblName.Location = new System.Drawing.Point(751, 252);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 30);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name";
            // 
            // numNTA
            // 
            this.numNTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNTA.Location = new System.Drawing.Point(971, 175);
            this.numNTA.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numNTA.Name = "numNTA";
            this.numNTA.Size = new System.Drawing.Size(120, 37);
            this.numNTA.TabIndex = 13;
            // 
            // lclNTAcode
            // 
            this.lclNTAcode.AutoSize = true;
            this.lclNTAcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lclNTAcode.Location = new System.Drawing.Point(751, 177);
            this.lclNTAcode.Name = "lclNTAcode";
            this.lclNTAcode.Size = new System.Drawing.Size(133, 30);
            this.lclNTAcode.TabIndex = 12;
            this.lclNTAcode.Text = "NTA Code";
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(517, 1027);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(114, 55);
            this.btnNew.TabIndex = 14;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSave.Location = new System.Drawing.Point(1659, 1022);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 65);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnCancel.Location = new System.Drawing.Point(1473, 1022);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(143, 65);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(57, 1032);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(114, 55);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cmbbCrtGrp
            // 
            this.cmbbCrtGrp.Enabled = false;
            this.cmbbCrtGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbCrtGrp.FormattingEnabled = true;
            this.cmbbCrtGrp.Location = new System.Drawing.Point(1659, 174);
            this.cmbbCrtGrp.Name = "cmbbCrtGrp";
            this.cmbbCrtGrp.Size = new System.Drawing.Size(143, 38);
            this.cmbbCrtGrp.Sorted = true;
            this.cmbbCrtGrp.TabIndex = 21;
            // 
            // lblISCC
            // 
            this.lblISCC.AutoSize = true;
            this.lblISCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISCC.Location = new System.Drawing.Point(751, 330);
            this.lblISCC.Name = "lblISCC";
            this.lblISCC.Size = new System.Drawing.Size(142, 30);
            this.lblISCC.TabIndex = 22;
            this.lblISCC.Text = "ISCC Code";
            // 
            // lblCrtGrp
            // 
            this.lblCrtGrp.AutoSize = true;
            this.lblCrtGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrtGrp.Location = new System.Drawing.Point(1382, 177);
            this.lblCrtGrp.Name = "lblCrtGrp";
            this.lblCrtGrp.Size = new System.Drawing.Size(221, 30);
            this.lblCrtGrp.TabIndex = 23;
            this.lblCrtGrp.Text = "Certification group";
            // 
            // txtbISCC
            // 
            this.txtbISCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtbISCC.Location = new System.Drawing.Point(971, 327);
            this.txtbISCC.Name = "txtbISCC";
            this.txtbISCC.Size = new System.Drawing.Size(831, 37);
            this.txtbISCC.TabIndex = 24;
            // 
            // dbSourceDataSet
            // 
            this.dbSourceDataSet.DataSetName = "dbSourceDataSet";
            this.dbSourceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblResourceOverview
            // 
            this.lblResourceOverview.AutoSize = true;
            this.lblResourceOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblResourceOverview.Location = new System.Drawing.Point(756, 413);
            this.lblResourceOverview.Name = "lblResourceOverview";
            this.lblResourceOverview.Size = new System.Drawing.Size(315, 30);
            this.lblResourceOverview.TabIndex = 26;
            this.lblResourceOverview.Text = "Resources in this category";
            // 
            // dGV_Resources
            // 
            this.dGV_Resources.AllowUserToDeleteRows = false;
            this.dGV_Resources.AutoGenerateColumns = false;
            this.dGV_Resources.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_Resources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Resources.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.gasyieldDataGridViewTextBoxColumn,
            this.ntaCodeDataGridViewTextBoxColumn});
            this.dGV_Resources.DataSource = this.resourceBindingSource;
            this.dGV_Resources.Location = new System.Drawing.Point(756, 458);
            this.dGV_Resources.Name = "dGV_Resources";
            this.dGV_Resources.RowHeadersWidth = 72;
            this.dGV_Resources.RowTemplate.Height = 31;
            this.dGV_Resources.Size = new System.Drawing.Size(1046, 449);
            this.dGV_Resources.TabIndex = 25;
            this.dGV_Resources.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dGV_Resources_DefaultValuesNeeded);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // gasyieldDataGridViewTextBoxColumn
            // 
            this.gasyieldDataGridViewTextBoxColumn.DataPropertyName = "gasyield";
            this.gasyieldDataGridViewTextBoxColumn.HeaderText = "gasyield";
            this.gasyieldDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.gasyieldDataGridViewTextBoxColumn.Name = "gasyieldDataGridViewTextBoxColumn";
            // 
            // ntaCodeDataGridViewTextBoxColumn
            // 
            this.ntaCodeDataGridViewTextBoxColumn.DataPropertyName = "ntaCode";
            this.ntaCodeDataGridViewTextBoxColumn.HeaderText = "ntaCode";
            this.ntaCodeDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.ntaCodeDataGridViewTextBoxColumn.Name = "ntaCodeDataGridViewTextBoxColumn";
            // 
            // resourceBindingSource
            // 
            this.resourceBindingSource.DataMember = "resource";
            this.resourceBindingSource.DataSource = this.dbSourceDataSet;
            // 
            // resourceTableAdapter
            // 
            this.resourceTableAdapter.ClearBeforeFill = true;
            // 
            // MassSourcePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblResourceOverview);
            this.Controls.Add(this.dGV_Resources);
            this.Controls.Add(this.txtbISCC);
            this.Controls.Add(this.lblCrtGrp);
            this.Controls.Add(this.lblISCC);
            this.Controls.Add(this.cmbbCrtGrp);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.numNTA);
            this.Controls.Add(this.lclNTAcode);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtbName);
            this.Controls.Add(this.lstbResources);
            this.Name = "MassSourcePanel";
            this.Size = new System.Drawing.Size(1899, 1131);
            ((System.ComponentModel.ISupportInitialize)(this.numNTA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSourceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Resources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstbResources;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;

        private System.Windows.Forms.Label lclNTAcode;
        private System.Windows.Forms.NumericUpDown numNTA;
        private System.Windows.Forms.Label lblISCC;
        private System.Windows.Forms.Label lblCrtGrp;
        private System.Windows.Forms.ComboBox cmbbCrtGrp;

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtbName;

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtbISCC;
        private dbSourceDataSet dbSourceDataSet;
        private System.Windows.Forms.Label lblResourceOverview;
        private System.Windows.Forms.DataGridView dGV_Resources;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gasyieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ntaCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource resourceBindingSource;
        private dbSourceDataSetTableAdapters.resourceTableAdapter resourceTableAdapter;
    }
}

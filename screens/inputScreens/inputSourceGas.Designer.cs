namespace MassBalans.screens.inputScreens
{
    partial class inputSourceGas
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
            this.lblProducer = new System.Windows.Forms.Label();
            this.lblResource = new System.Windows.Forms.Label();
            this.cmbbProd = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSourceDataSet = new MassBalans.dbSourceDataSet();
            this.cmbbResc = new System.Windows.Forms.ComboBox();
            this.resourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblRemainLstMonth = new System.Windows.Forms.Label();
            this.availResc = new System.Windows.Forms.Label();
            this.lblRemainNxtMonth = new System.Windows.Forms.Label();
            this.remResource = new System.Windows.Forms.Label();
            this.buttCancel = new System.Windows.Forms.Button();
            this.buttSave = new System.Windows.Forms.Button();
            this.lblAmounts = new System.Windows.Forms.Label();
            this.lblGenInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numGasUse = new System.Windows.Forms.NumericUpDown();
            this.resourceTableAdapter = new MassBalans.dbSourceDataSetTableAdapters.resourceTableAdapter();
            this.supplierTableAdapter = new MassBalans.dbSourceDataSetTableAdapters.supplierTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSourceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGasUse)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProducer
            // 
            this.lblProducer.AutoSize = true;
            this.lblProducer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducer.Location = new System.Drawing.Point(305, 183);
            this.lblProducer.Name = "lblProducer";
            this.lblProducer.Size = new System.Drawing.Size(117, 30);
            this.lblProducer.TabIndex = 0;
            this.lblProducer.Text = "Producer";
            // 
            // lblResource
            // 
            this.lblResource.AutoSize = true;
            this.lblResource.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResource.Location = new System.Drawing.Point(305, 241);
            this.lblResource.Name = "lblResource";
            this.lblResource.Size = new System.Drawing.Size(123, 30);
            this.lblResource.TabIndex = 1;
            this.lblResource.Text = "Resource";
            // 
            // cmbbProd
            // 
            this.cmbbProd.DataSource = this.supplierBindingSource;
            this.cmbbProd.DisplayMember = "name";
            this.cmbbProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbProd.FormattingEnabled = true;
            this.cmbbProd.Location = new System.Drawing.Point(430, 174);
            this.cmbbProd.Name = "cmbbProd";
            this.cmbbProd.Size = new System.Drawing.Size(320, 38);
            this.cmbbProd.TabIndex = 5;
            this.cmbbProd.ValueMember = "code";
            this.cmbbProd.SelectedIndexChanged += new System.EventHandler(this.cmbbProd_SelectedIndexChanged);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "supplier";
            this.supplierBindingSource.DataSource = this.dbSourceDataSet;
            // 
            // dbSourceDataSet
            // 
            this.dbSourceDataSet.DataSetName = "dbSourceDataSet";
            this.dbSourceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbbResc
            // 
            this.cmbbResc.DataSource = this.resourceBindingSource;
            this.cmbbResc.DisplayMember = "name";
            this.cmbbResc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbResc.FormattingEnabled = true;
            this.cmbbResc.Location = new System.Drawing.Point(430, 241);
            this.cmbbResc.Name = "cmbbResc";
            this.cmbbResc.Size = new System.Drawing.Size(320, 38);
            this.cmbbResc.TabIndex = 6;
            this.cmbbResc.ValueMember = "Id";
            this.cmbbResc.SelectedIndexChanged += new System.EventHandler(this.cmbbResc_SelectedIndexChanged);
            // 
            // resourceBindingSource
            // 
            this.resourceBindingSource.DataMember = "resource";
            this.resourceBindingSource.DataSource = this.dbSourceDataSet;
            // 
            // lblRemainLstMonth
            // 
            this.lblRemainLstMonth.AutoSize = true;
            this.lblRemainLstMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainLstMonth.Location = new System.Drawing.Point(757, 447);
            this.lblRemainLstMonth.Name = "lblRemainLstMonth";
            this.lblRemainLstMonth.Size = new System.Drawing.Size(316, 30);
            this.lblRemainLstMonth.TabIndex = 9;
            this.lblRemainLstMonth.Text = "Remainder last month (kg)";
            // 
            // availResc
            // 
            this.availResc.AutoSize = true;
            this.availResc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availResc.Location = new System.Drawing.Point(1083, 447);
            this.availResc.Name = "availResc";
            this.availResc.Size = new System.Drawing.Size(27, 30);
            this.availResc.TabIndex = 10;
            this.availResc.Text = "1";
            this.availResc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRemainNxtMonth
            // 
            this.lblRemainNxtMonth.AutoSize = true;
            this.lblRemainNxtMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainNxtMonth.Location = new System.Drawing.Point(757, 504);
            this.lblRemainNxtMonth.Name = "lblRemainNxtMonth";
            this.lblRemainNxtMonth.Size = new System.Drawing.Size(316, 30);
            this.lblRemainNxtMonth.TabIndex = 11;
            this.lblRemainNxtMonth.Text = "Remainder this month (kg)";
            // 
            // remResource
            // 
            this.remResource.AutoSize = true;
            this.remResource.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remResource.Location = new System.Drawing.Point(1083, 504);
            this.remResource.Name = "remResource";
            this.remResource.Size = new System.Drawing.Size(27, 30);
            this.remResource.TabIndex = 12;
            this.remResource.Text = "1";
            this.remResource.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttCancel
            // 
            this.buttCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttCancel.Location = new System.Drawing.Point(44, 1042);
            this.buttCancel.Name = "buttCancel";
            this.buttCancel.Size = new System.Drawing.Size(130, 47);
            this.buttCancel.TabIndex = 20;
            this.buttCancel.Text = "Cancel";
            this.buttCancel.UseVisualStyleBackColor = true;
            this.buttCancel.Click += new System.EventHandler(this.buttCancel_Click);
            // 
            // buttSave
            // 
            this.buttSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttSave.Location = new System.Drawing.Point(1712, 1042);
            this.buttSave.Name = "buttSave";
            this.buttSave.Size = new System.Drawing.Size(130, 47);
            this.buttSave.TabIndex = 22;
            this.buttSave.Text = "Save";
            this.buttSave.UseVisualStyleBackColor = true;
            this.buttSave.Click += new System.EventHandler(this.buttSave_Click);
            // 
            // lblAmounts
            // 
            this.lblAmounts.AutoSize = true;
            this.lblAmounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmounts.Location = new System.Drawing.Point(207, 395);
            this.lblAmounts.Name = "lblAmounts";
            this.lblAmounts.Size = new System.Drawing.Size(185, 35);
            this.lblAmounts.TabIndex = 25;
            this.lblAmounts.Text = "Input/Output";
            // 
            // lblGenInfo
            // 
            this.lblGenInfo.AutoSize = true;
            this.lblGenInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenInfo.Location = new System.Drawing.Point(207, 131);
            this.lblGenInfo.Name = "lblGenInfo";
            this.lblGenInfo.Size = new System.Drawing.Size(284, 35);
            this.lblGenInfo.TabIndex = 26;
            this.lblGenInfo.Text = "General information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 30);
            this.label1.TabIndex = 52;
            this.label1.Text = "Used amount (kg)";
            // 
            // numGasUse
            // 
            this.numGasUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numGasUse.Location = new System.Drawing.Point(495, 502);
            this.numGasUse.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numGasUse.Name = "numGasUse";
            this.numGasUse.Size = new System.Drawing.Size(134, 37);
            this.numGasUse.TabIndex = 51;
            this.numGasUse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numGasUse.ValueChanged += new System.EventHandler(this.numGasUse_ValueChanged);
            // 
            // resourceTableAdapter
            // 
            this.resourceTableAdapter.ClearBeforeFill = true;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // inputSourceGas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numGasUse);
            this.Controls.Add(this.lblGenInfo);
            this.Controls.Add(this.lblAmounts);
            this.Controls.Add(this.buttSave);
            this.Controls.Add(this.buttCancel);
            this.Controls.Add(this.remResource);
            this.Controls.Add(this.lblRemainNxtMonth);
            this.Controls.Add(this.availResc);
            this.Controls.Add(this.lblRemainLstMonth);
            this.Controls.Add(this.cmbbResc);
            this.Controls.Add(this.cmbbProd);
            this.Controls.Add(this.lblResource);
            this.Controls.Add(this.lblProducer);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "inputSourceGas";
            this.Size = new System.Drawing.Size(1899, 1131);
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSourceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGasUse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProducer;
        private System.Windows.Forms.Label lblResource;
        private System.Windows.Forms.ComboBox cmbbProd;
        private System.Windows.Forms.ComboBox cmbbResc;
        private System.Windows.Forms.Label lblRemainLstMonth;
        private System.Windows.Forms.Label availResc;
        private System.Windows.Forms.Label lblRemainNxtMonth;
        private System.Windows.Forms.Label remResource;
        private System.Windows.Forms.Button buttCancel;
        private System.Windows.Forms.Button buttSave;
        private System.Windows.Forms.Label lblAmounts;
        private System.Windows.Forms.Label lblGenInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numGasUse;
        private System.Windows.Forms.BindingSource resourceBindingSource;
        private dbSourceDataSet dbSourceDataSet;
        private dbSourceDataSetTableAdapters.resourceTableAdapter resourceTableAdapter;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private dbSourceDataSetTableAdapters.supplierTableAdapter supplierTableAdapter;
    }
}

namespace MassBalans.screens.inputScreens
{
    partial class inputNewSource
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
            this.lblGenInfo = new System.Windows.Forms.Label();
            this.buttSave = new System.Windows.Forms.Button();
            this.buttCancel = new System.Windows.Forms.Button();
            this.numTruckNeed = new System.Windows.Forms.NumericUpDown();
            this.lblNmbrTrucks = new System.Windows.Forms.Label();
            this.numTruckEmpty = new System.Windows.Forms.NumericUpDown();
            this.numTruckFull = new System.Windows.Forms.NumericUpDown();
            this.cmbbCountry = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chkbContract = new System.Windows.Forms.CheckBox();
            this.remResource = new System.Windows.Forms.Label();
            this.lblRemainResource = new System.Windows.Forms.Label();
            this.availResc = new System.Windows.Forms.Label();
            this.lblAvailReso = new System.Windows.Forms.Label();
            this.cmbbResource = new System.Windows.Forms.ComboBox();
            this.resourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSourceDataSet = new MassBalans.dbSourceDataSet();
            this.cmbbProd = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblEmptyTrucks = new System.Windows.Forms.Label();
            this.lblFullTrucks = new System.Windows.Forms.Label();
            this.lblResource = new System.Windows.Forms.Label();
            this.lblProducer = new System.Windows.Forms.Label();
            this.supplierTableAdapter = new MassBalans.dbSourceDataSetTableAdapters.supplierTableAdapter();
            this.resourceTableAdapter = new MassBalans.dbSourceDataSetTableAdapters.resourceTableAdapter();
            this.numDelivery = new System.Windows.Forms.NumericUpDown();
            this.lblAmount = new System.Windows.Forms.Label();
            this.grDeliverAmount = new System.Windows.Forms.GroupBox();
            this.grpTrucks = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numTruckNeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTruckEmpty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTruckFull)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSourceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelivery)).BeginInit();
            this.grDeliverAmount.SuspendLayout();
            this.grpTrucks.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGenInfo
            // 
            this.lblGenInfo.AutoSize = true;
            this.lblGenInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenInfo.Location = new System.Drawing.Point(213, 86);
            this.lblGenInfo.Name = "lblGenInfo";
            this.lblGenInfo.Size = new System.Drawing.Size(284, 35);
            this.lblGenInfo.TabIndex = 53;
            this.lblGenInfo.Text = "General information";
            // 
            // buttSave
            // 
            this.buttSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttSave.Location = new System.Drawing.Point(1718, 997);
            this.buttSave.Name = "buttSave";
            this.buttSave.Size = new System.Drawing.Size(130, 47);
            this.buttSave.TabIndex = 49;
            this.buttSave.Text = "Save";
            this.buttSave.UseVisualStyleBackColor = true;
            this.buttSave.Click += new System.EventHandler(this.buttSave_Click);
            // 
            // buttCancel
            // 
            this.buttCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttCancel.Location = new System.Drawing.Point(50, 997);
            this.buttCancel.Name = "buttCancel";
            this.buttCancel.Size = new System.Drawing.Size(130, 47);
            this.buttCancel.TabIndex = 47;
            this.buttCancel.Text = "Cancel";
            this.buttCancel.UseVisualStyleBackColor = true;
            this.buttCancel.Click += new System.EventHandler(this.buttCancel_Click);
            // 
            // numTruckNeed
            // 
            this.numTruckNeed.Enabled = false;
            this.numTruckNeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTruckNeed.Location = new System.Drawing.Point(877, 76);
            this.numTruckNeed.Name = "numTruckNeed";
            this.numTruckNeed.Size = new System.Drawing.Size(120, 37);
            this.numTruckNeed.TabIndex = 46;
            // 
            // lblNmbrTrucks
            // 
            this.lblNmbrTrucks.AutoSize = true;
            this.lblNmbrTrucks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNmbrTrucks.Location = new System.Drawing.Point(669, 76);
            this.lblNmbrTrucks.Name = "lblNmbrTrucks";
            this.lblNmbrTrucks.Size = new System.Drawing.Size(178, 30);
            this.lblNmbrTrucks.TabIndex = 45;
            this.lblNmbrTrucks.Text = "Needed trucks";
            // 
            // numTruckEmpty
            // 
            this.numTruckEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTruckEmpty.Location = new System.Drawing.Point(252, 134);
            this.numTruckEmpty.Name = "numTruckEmpty";
            this.numTruckEmpty.Size = new System.Drawing.Size(120, 37);
            this.numTruckEmpty.TabIndex = 44;
            // 
            // numTruckFull
            // 
            this.numTruckFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTruckFull.Location = new System.Drawing.Point(252, 78);
            this.numTruckFull.Name = "numTruckFull";
            this.numTruckFull.Size = new System.Drawing.Size(120, 37);
            this.numTruckFull.TabIndex = 43;
            this.numTruckFull.ValueChanged += new System.EventHandler(this.numTruckFull_ValueChanged);
            // 
            // cmbbCountry
            // 
            this.cmbbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbCountry.FormattingEnabled = true;
            this.cmbbCountry.Items.AddRange(new object[] {
            "Albania",
            "Andorra",
            "Armenia",
            "Austria",
            "Azerbaijan",
            "Belarus",
            "Belgium",
            "Bosnia and Herzegovina",
            "Bulgaria",
            "Croatia",
            "Cyprus",
            "Czechia",
            "Denmark",
            "Estonia",
            "Finland",
            "France",
            "Georgia",
            "Germany",
            "Greece",
            "Hungary",
            "Iceland",
            "Ireland",
            "Italy",
            "Kazakhstan",
            "Kosovo",
            "Latvia",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Malta",
            "Moldova",
            "Monaco",
            "Montenegro",
            "Netherlands",
            "North Macedonia",
            "Norway",
            "Poland",
            "Portugal",
            "Romania",
            "Russia",
            "San Marino",
            "Serbia",
            "Slovakia",
            "Slovenia",
            "Spain",
            "Sweden",
            "Switzerland",
            "Turkey",
            "Ukraine",
            "United Kingdom",
            "Vatican City"});
            this.cmbbCountry.Location = new System.Drawing.Point(1046, 193);
            this.cmbbCountry.Name = "cmbbCountry";
            this.cmbbCountry.Size = new System.Drawing.Size(352, 38);
            this.cmbbCountry.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(842, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(201, 30);
            this.label10.TabIndex = 41;
            this.label10.Text = "Country of origin";
            // 
            // chkbContract
            // 
            this.chkbContract.AutoSize = true;
            this.chkbContract.Enabled = false;
            this.chkbContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbContract.Location = new System.Drawing.Point(1046, 131);
            this.chkbContract.Name = "chkbContract";
            this.chkbContract.Size = new System.Drawing.Size(135, 34);
            this.chkbContract.TabIndex = 40;
            this.chkbContract.Text = "Certified";
            this.chkbContract.UseVisualStyleBackColor = true;
            // 
            // remResource
            // 
            this.remResource.AutoSize = true;
            this.remResource.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remResource.Location = new System.Drawing.Point(887, 126);
            this.remResource.Name = "remResource";
            this.remResource.Size = new System.Drawing.Size(27, 30);
            this.remResource.TabIndex = 39;
            this.remResource.Text = "1";
            this.remResource.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRemainResource
            // 
            this.lblRemainResource.AutoSize = true;
            this.lblRemainResource.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainResource.Location = new System.Drawing.Point(587, 126);
            this.lblRemainResource.Name = "lblRemainResource";
            this.lblRemainResource.Size = new System.Drawing.Size(295, 30);
            this.lblRemainResource.TabIndex = 38;
            this.lblRemainResource.Text = "Remaining resource (kg)";
            // 
            // availResc
            // 
            this.availResc.AutoSize = true;
            this.availResc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availResc.Location = new System.Drawing.Point(887, 69);
            this.availResc.Name = "availResc";
            this.availResc.Size = new System.Drawing.Size(27, 30);
            this.availResc.TabIndex = 37;
            this.availResc.Text = "1";
            this.availResc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAvailReso
            // 
            this.lblAvailReso.AutoSize = true;
            this.lblAvailReso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailReso.Location = new System.Drawing.Point(587, 69);
            this.lblAvailReso.Name = "lblAvailReso";
            this.lblAvailReso.Size = new System.Drawing.Size(276, 30);
            this.lblAvailReso.TabIndex = 36;
            this.lblAvailReso.Text = "Available resource (kg)";
            // 
            // cmbbResource
            // 
            this.cmbbResource.DataSource = this.resourceBindingSource;
            this.cmbbResource.DisplayMember = "name";
            this.cmbbResource.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbResource.FormattingEnabled = true;
            this.cmbbResource.Location = new System.Drawing.Point(436, 196);
            this.cmbbResource.Name = "cmbbResource";
            this.cmbbResource.Size = new System.Drawing.Size(320, 38);
            this.cmbbResource.TabIndex = 33;
            this.cmbbResource.ValueMember = "Id";
            this.cmbbResource.SelectedIndexChanged += new System.EventHandler(this.cmbbResource_SelectedIndexChanged);
            // 
            // resourceBindingSource
            // 
            this.resourceBindingSource.DataMember = "resource";
            this.resourceBindingSource.DataSource = this.dbSourceDataSet;
            // 
            // dbSourceDataSet
            // 
            this.dbSourceDataSet.DataSetName = "dbSourceDataSet";
            this.dbSourceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbbProd
            // 
            this.cmbbProd.DataSource = this.supplierBindingSource;
            this.cmbbProd.DisplayMember = "name";
            this.cmbbProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbProd.FormattingEnabled = true;
            this.cmbbProd.Location = new System.Drawing.Point(436, 129);
            this.cmbbProd.Name = "cmbbProd";
            this.cmbbProd.Size = new System.Drawing.Size(320, 38);
            this.cmbbProd.TabIndex = 32;
            this.cmbbProd.ValueMember = "code";
            this.cmbbProd.SelectedIndexChanged += new System.EventHandler(this.cmbbProd_SelectedIndexChanged);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "supplier";
            this.supplierBindingSource.DataSource = this.dbSourceDataSet;
            // 
            // lblEmptyTrucks
            // 
            this.lblEmptyTrucks.AutoSize = true;
            this.lblEmptyTrucks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmptyTrucks.Location = new System.Drawing.Point(94, 136);
            this.lblEmptyTrucks.Name = "lblEmptyTrucks";
            this.lblEmptyTrucks.Size = new System.Drawing.Size(150, 30);
            this.lblEmptyTrucks.TabIndex = 31;
            this.lblEmptyTrucks.Text = "Empty KM\'s";
            // 
            // lblFullTrucks
            // 
            this.lblFullTrucks.AutoSize = true;
            this.lblFullTrucks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullTrucks.Location = new System.Drawing.Point(125, 80);
            this.lblFullTrucks.Name = "lblFullTrucks";
            this.lblFullTrucks.Size = new System.Drawing.Size(119, 30);
            this.lblFullTrucks.TabIndex = 30;
            this.lblFullTrucks.Text = "Full KM\'s";
            // 
            // lblResource
            // 
            this.lblResource.AutoSize = true;
            this.lblResource.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResource.Location = new System.Drawing.Point(311, 196);
            this.lblResource.Name = "lblResource";
            this.lblResource.Size = new System.Drawing.Size(123, 30);
            this.lblResource.TabIndex = 28;
            this.lblResource.Text = "Resource";
            // 
            // lblProducer
            // 
            this.lblProducer.AutoSize = true;
            this.lblProducer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducer.Location = new System.Drawing.Point(311, 138);
            this.lblProducer.Name = "lblProducer";
            this.lblProducer.Size = new System.Drawing.Size(117, 30);
            this.lblProducer.TabIndex = 27;
            this.lblProducer.Text = "Producer";
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // resourceTableAdapter
            // 
            this.resourceTableAdapter.ClearBeforeFill = true;
            // 
            // numDelivery
            // 
            this.numDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDelivery.Location = new System.Drawing.Point(374, 69);
            this.numDelivery.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numDelivery.Name = "numDelivery";
            this.numDelivery.Size = new System.Drawing.Size(134, 37);
            this.numDelivery.TabIndex = 57;
            this.numDelivery.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDelivery.ValueChanged += new System.EventHandler(this.numDelivery_ValueChanged);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(38, 69);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(266, 30);
            this.lblAmount.TabIndex = 56;
            this.lblAmount.Text = "Delivered amount (kg)";
            // 
            // grDeliverAmount
            // 
            this.grDeliverAmount.Controls.Add(this.lblAmount);
            this.grDeliverAmount.Controls.Add(this.lblAvailReso);
            this.grDeliverAmount.Controls.Add(this.numDelivery);
            this.grDeliverAmount.Controls.Add(this.availResc);
            this.grDeliverAmount.Controls.Add(this.lblRemainResource);
            this.grDeliverAmount.Controls.Add(this.remResource);
            this.grDeliverAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.grDeliverAmount.Location = new System.Drawing.Point(219, 317);
            this.grDeliverAmount.Name = "grDeliverAmount";
            this.grDeliverAmount.Size = new System.Drawing.Size(1276, 242);
            this.grDeliverAmount.TabIndex = 58;
            this.grDeliverAmount.TabStop = false;
            this.grDeliverAmount.Text = "Delivered Amount";
            // 
            // grpTrucks
            // 
            this.grpTrucks.Controls.Add(this.lblFullTrucks);
            this.grpTrucks.Controls.Add(this.lblEmptyTrucks);
            this.grpTrucks.Controls.Add(this.numTruckFull);
            this.grpTrucks.Controls.Add(this.numTruckEmpty);
            this.grpTrucks.Controls.Add(this.lblNmbrTrucks);
            this.grpTrucks.Controls.Add(this.numTruckNeed);
            this.grpTrucks.Enabled = false;
            this.grpTrucks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.grpTrucks.Location = new System.Drawing.Point(219, 616);
            this.grpTrucks.Name = "grpTrucks";
            this.grpTrucks.Size = new System.Drawing.Size(1276, 247);
            this.grpTrucks.TabIndex = 59;
            this.grpTrucks.TabStop = false;
            this.grpTrucks.Text = "Used trucks";
            // 
            // inputNewSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpTrucks);
            this.Controls.Add(this.grDeliverAmount);
            this.Controls.Add(this.lblGenInfo);
            this.Controls.Add(this.buttSave);
            this.Controls.Add(this.buttCancel);
            this.Controls.Add(this.cmbbCountry);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.chkbContract);
            this.Controls.Add(this.cmbbResource);
            this.Controls.Add(this.cmbbProd);
            this.Controls.Add(this.lblResource);
            this.Controls.Add(this.lblProducer);
            this.Name = "inputNewSource";
            this.Size = new System.Drawing.Size(1899, 1131);
            ((System.ComponentModel.ISupportInitialize)(this.numTruckNeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTruckEmpty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTruckFull)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSourceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelivery)).EndInit();
            this.grDeliverAmount.ResumeLayout(false);
            this.grDeliverAmount.PerformLayout();
            this.grpTrucks.ResumeLayout(false);
            this.grpTrucks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGenInfo;
        private System.Windows.Forms.Button buttSave;
        private System.Windows.Forms.Button buttCancel;
        private System.Windows.Forms.NumericUpDown numTruckNeed;
        private System.Windows.Forms.Label lblNmbrTrucks;
        private System.Windows.Forms.NumericUpDown numTruckEmpty;
        private System.Windows.Forms.NumericUpDown numTruckFull;
        private System.Windows.Forms.ComboBox cmbbCountry;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkbContract;
        private System.Windows.Forms.Label remResource;
        private System.Windows.Forms.Label lblRemainResource;
        private System.Windows.Forms.Label availResc;
        private System.Windows.Forms.Label lblAvailReso;
        private System.Windows.Forms.ComboBox cmbbResource;
        private System.Windows.Forms.ComboBox cmbbProd;
        private System.Windows.Forms.Label lblEmptyTrucks;
        private System.Windows.Forms.Label lblFullTrucks;
        private System.Windows.Forms.Label lblResource;
        private System.Windows.Forms.Label lblProducer;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private dbSourceDataSet dbSourceDataSet;
        private dbSourceDataSetTableAdapters.supplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.BindingSource resourceBindingSource;
        private dbSourceDataSetTableAdapters.resourceTableAdapter resourceTableAdapter;
        private System.Windows.Forms.NumericUpDown numDelivery;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.GroupBox grDeliverAmount;
        private System.Windows.Forms.GroupBox grpTrucks;
    }
}

namespace MassBalans.screens.prodcertScreens
{
    partial class producerDetailPage
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
            this.lblProdName = new System.Windows.Forms.Label();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblCertificate = new System.Windows.Forms.Label();
            this.lblCert = new System.Windows.Forms.Label();
            this.btnCertViewAll = new System.Windows.Forms.Button();
            this.buttSave = new System.Windows.Forms.Button();
            this.buttCancel = new System.Windows.Forms.Button();
            this.lblClientCode = new System.Windows.Forms.Label();
            this.txtbCity = new System.Windows.Forms.TextBox();
            this.lblExpired = new System.Windows.Forms.Label();
            this.lblTruckCap = new System.Windows.Forms.Label();
            this.numTruckCap = new System.Windows.Forms.NumericUpDown();
            this.cmbbCountry = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numTruckCap)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdName.Location = new System.Drawing.Point(582, 276);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(82, 30);
            this.lblProdName.TabIndex = 0;
            this.lblProdName.Text = "Name";
            // 
            // txtbName
            // 
            this.txtbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbName.Location = new System.Drawing.Point(716, 273);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(245, 37);
            this.txtbName.TabIndex = 1;
            this.txtbName.TextChanged += new System.EventHandler(this.txtbName_TextChanged);
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(561, 369);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(103, 30);
            this.lblCountry.TabIndex = 2;
            this.lblCountry.Text = "Country";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(1037, 369);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(58, 30);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City";
            // 
            // lblCertificate
            // 
            this.lblCertificate.AutoSize = true;
            this.lblCertificate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCertificate.Location = new System.Drawing.Point(535, 466);
            this.lblCertificate.Name = "lblCertificate";
            this.lblCertificate.Size = new System.Drawing.Size(129, 30);
            this.lblCertificate.TabIndex = 6;
            this.lblCertificate.Text = "Certificate";
            // 
            // lblCert
            // 
            this.lblCert.AutoSize = true;
            this.lblCert.BackColor = System.Drawing.SystemColors.Control;
            this.lblCert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCert.Location = new System.Drawing.Point(711, 466);
            this.lblCert.Name = "lblCert";
            this.lblCert.Size = new System.Drawing.Size(338, 30);
            this.lblCert.TabIndex = 7;
            this.lblCert.Text = "ISCC-Cert-XX999-99900999";
            // 
            // btnCertViewAll
            // 
            this.btnCertViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCertViewAll.Location = new System.Drawing.Point(1127, 459);
            this.btnCertViewAll.Name = "btnCertViewAll";
            this.btnCertViewAll.Size = new System.Drawing.Size(123, 44);
            this.btnCertViewAll.TabIndex = 8;
            this.btnCertViewAll.Text = "View all";
            this.btnCertViewAll.UseVisualStyleBackColor = true;
            this.btnCertViewAll.Click += new System.EventHandler(this.btnCertViewAll_Click);
            // 
            // buttSave
            // 
            this.buttSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttSave.Location = new System.Drawing.Point(1712, 1042);
            this.buttSave.Name = "buttSave";
            this.buttSave.Size = new System.Drawing.Size(130, 47);
            this.buttSave.TabIndex = 25;
            this.buttSave.Text = "Save";
            this.buttSave.UseVisualStyleBackColor = true;
            this.buttSave.Click += new System.EventHandler(this.buttSave_Click);
            // 
            // buttCancel
            // 
            this.buttCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttCancel.Location = new System.Drawing.Point(44, 1042);
            this.buttCancel.Name = "buttCancel";
            this.buttCancel.Size = new System.Drawing.Size(130, 47);
            this.buttCancel.TabIndex = 23;
            this.buttCancel.Text = "Cancel";
            this.buttCancel.UseVisualStyleBackColor = true;
            this.buttCancel.Click += new System.EventHandler(this.buttCancel_Click);
            // 
            // lblClientCode
            // 
            this.lblClientCode.AutoSize = true;
            this.lblClientCode.Location = new System.Drawing.Point(1122, 281);
            this.lblClientCode.Name = "lblClientCode";
            this.lblClientCode.Size = new System.Drawing.Size(100, 25);
            this.lblClientCode.TabIndex = 30;
            this.lblClientCode.Text = "clientcode";
            this.lblClientCode.Visible = false;
            // 
            // txtbCity
            // 
            this.txtbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbCity.Location = new System.Drawing.Point(1127, 366);
            this.txtbCity.Name = "txtbCity";
            this.txtbCity.Size = new System.Drawing.Size(245, 37);
            this.txtbCity.TabIndex = 32;
            // 
            // lblExpired
            // 
            this.lblExpired.AutoSize = true;
            this.lblExpired.BackColor = System.Drawing.Color.Red;
            this.lblExpired.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblExpired.Location = new System.Drawing.Point(710, 496);
            this.lblExpired.Name = "lblExpired";
            this.lblExpired.Size = new System.Drawing.Size(138, 32);
            this.lblExpired.TabIndex = 33;
            this.lblExpired.Text = "EXPIRED";
            this.lblExpired.Visible = false;
            // 
            // lblTruckCap
            // 
            this.lblTruckCap.AutoSize = true;
            this.lblTruckCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTruckCap.Location = new System.Drawing.Point(478, 562);
            this.lblTruckCap.Name = "lblTruckCap";
            this.lblTruckCap.Size = new System.Drawing.Size(186, 30);
            this.lblTruckCap.TabIndex = 34;
            this.lblTruckCap.Text = "Truck capacity ";
            // 
            // numTruckCap
            // 
            this.numTruckCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.numTruckCap.Location = new System.Drawing.Point(716, 562);
            this.numTruckCap.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numTruckCap.Name = "numTruckCap";
            this.numTruckCap.Size = new System.Drawing.Size(245, 37);
            this.numTruckCap.TabIndex = 36;
            // 
            // cmbbCountry
            // 
            this.cmbbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
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
            this.cmbbCountry.Location = new System.Drawing.Point(716, 366);
            this.cmbbCountry.Name = "cmbbCountry";
            this.cmbbCountry.Size = new System.Drawing.Size(245, 38);
            this.cmbbCountry.TabIndex = 37;
            // 
            // producerDetailPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbbCountry);
            this.Controls.Add(this.numTruckCap);
            this.Controls.Add(this.lblTruckCap);
            this.Controls.Add(this.lblExpired);
            this.Controls.Add(this.txtbCity);
            this.Controls.Add(this.lblClientCode);
            this.Controls.Add(this.buttSave);
            this.Controls.Add(this.buttCancel);
            this.Controls.Add(this.btnCertViewAll);
            this.Controls.Add(this.lblCert);
            this.Controls.Add(this.lblCertificate);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtbName);
            this.Controls.Add(this.lblProdName);
            this.Name = "producerDetailPage";
            this.Size = new System.Drawing.Size(1899, 1131);
            ((System.ComponentModel.ISupportInitialize)(this.numTruckCap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCertificate;
        private System.Windows.Forms.Label lblCert;
        private System.Windows.Forms.Button btnCertViewAll;
        private System.Windows.Forms.Button buttSave;
        private System.Windows.Forms.Button buttCancel;
        private System.Windows.Forms.Label lblClientCode;
        private System.Windows.Forms.TextBox txtbCity;
        private System.Windows.Forms.Label lblExpired;
        private System.Windows.Forms.Label lblTruckCap;
        private System.Windows.Forms.NumericUpDown numTruckCap;
        private System.Windows.Forms.ComboBox cmbbCountry;
    }
}

namespace MassBalans.screens.companyScreens
{
    partial class mainCompDetailPage
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
            this.buttCancel = new System.Windows.Forms.Button();
            this.buttSave = new System.Windows.Forms.Button();
            this.lblCompName = new System.Windows.Forms.Label();
            this.lblCntry = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblCertInfo = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblZIP = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.txtbCompName = new System.Windows.Forms.TextBox();
            this.txtbAddress = new System.Windows.Forms.TextBox();
            this.txtbZip = new System.Windows.Forms.TextBox();
            this.txtbCert = new System.Windows.Forms.TextBox();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtbCountry = new System.Windows.Forms.TextBox();
            this.txtbCity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttCancel
            // 
            this.buttCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttCancel.Location = new System.Drawing.Point(60, 1023);
            this.buttCancel.Name = "buttCancel";
            this.buttCancel.Size = new System.Drawing.Size(168, 53);
            this.buttCancel.TabIndex = 0;
            this.buttCancel.Text = "Cancel";
            this.buttCancel.UseVisualStyleBackColor = true;
            this.buttCancel.Click += new System.EventHandler(this.buttCancel_Click);
            // 
            // buttSave
            // 
            this.buttSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttSave.Location = new System.Drawing.Point(1674, 1023);
            this.buttSave.Name = "buttSave";
            this.buttSave.Size = new System.Drawing.Size(168, 53);
            this.buttSave.TabIndex = 1;
            this.buttSave.Text = "Save";
            this.buttSave.UseVisualStyleBackColor = true;
            this.buttSave.Click += new System.EventHandler(this.buttSave_Click);
            // 
            // lblCompName
            // 
            this.lblCompName.AutoSize = true;
            this.lblCompName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCompName.Location = new System.Drawing.Point(358, 231);
            this.lblCompName.Name = "lblCompName";
            this.lblCompName.Size = new System.Drawing.Size(194, 30);
            this.lblCompName.TabIndex = 2;
            this.lblCompName.Text = "Company name";
            // 
            // lblCntry
            // 
            this.lblCntry.AutoSize = true;
            this.lblCntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCntry.Location = new System.Drawing.Point(449, 309);
            this.lblCntry.Name = "lblCntry";
            this.lblCntry.Size = new System.Drawing.Size(103, 30);
            this.lblCntry.TabIndex = 3;
            this.lblCntry.Text = "Country";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblStreet.Location = new System.Drawing.Point(445, 386);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(107, 30);
            this.lblStreet.TabIndex = 4;
            this.lblStreet.Text = "Address";
            // 
            // lblCertInfo
            // 
            this.lblCertInfo.AutoSize = true;
            this.lblCertInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCertInfo.Location = new System.Drawing.Point(329, 462);
            this.lblCertInfo.Name = "lblCertInfo";
            this.lblCertInfo.Size = new System.Drawing.Size(223, 30);
            this.lblCertInfo.TabIndex = 5;
            this.lblCertInfo.Text = "Certificate number";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCity.Location = new System.Drawing.Point(1063, 309);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(58, 30);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "City";
            // 
            // lblZIP
            // 
            this.lblZIP.AutoSize = true;
            this.lblZIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblZIP.Location = new System.Drawing.Point(1011, 386);
            this.lblZIP.Name = "lblZIP";
            this.lblZIP.Size = new System.Drawing.Size(110, 30);
            this.lblZIP.TabIndex = 7;
            this.lblZIP.Text = "ZipCode";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblEndDate.Location = new System.Drawing.Point(438, 536);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(114, 30);
            this.lblEndDate.TabIndex = 8;
            this.lblEndDate.Text = "End date";
            // 
            // txtbCompName
            // 
            this.txtbCompName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtbCompName.Location = new System.Drawing.Point(589, 228);
            this.txtbCompName.Name = "txtbCompName";
            this.txtbCompName.Size = new System.Drawing.Size(311, 37);
            this.txtbCompName.TabIndex = 9;
            this.txtbCompName.Text = global::MassBalans.Properties.Settings.Default.CompName;
            // 
            // txtbAddress
            // 
            this.txtbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtbAddress.Location = new System.Drawing.Point(589, 383);
            this.txtbAddress.Name = "txtbAddress";
            this.txtbAddress.Size = new System.Drawing.Size(311, 37);
            this.txtbAddress.TabIndex = 12;
            this.txtbAddress.Text = global::MassBalans.Properties.Settings.Default.CompAddress;
            // 
            // txtbZip
            // 
            this.txtbZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtbZip.Location = new System.Drawing.Point(1163, 383);
            this.txtbZip.Name = "txtbZip";
            this.txtbZip.Size = new System.Drawing.Size(253, 37);
            this.txtbZip.TabIndex = 13;
            this.txtbZip.Text = global::MassBalans.Properties.Settings.Default.CompZipCode;
            // 
            // txtbCert
            // 
            this.txtbCert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtbCert.Location = new System.Drawing.Point(589, 459);
            this.txtbCert.Name = "txtbCert";
            this.txtbCert.Size = new System.Drawing.Size(311, 37);
            this.txtbCert.TabIndex = 14;
            this.txtbCert.Text = global::MassBalans.Properties.Settings.Default.CompCertificate;
            // 
            // dtEndDate
            // 
            this.dtEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtEndDate.Location = new System.Drawing.Point(589, 531);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(311, 37);
            this.dtEndDate.TabIndex = 15;
            this.dtEndDate.Value = global::MassBalans.Properties.Settings.Default.CompCertDate;
            // 
            // txtbCountry
            // 
            this.txtbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtbCountry.Location = new System.Drawing.Point(589, 309);
            this.txtbCountry.Name = "txtbCountry";
            this.txtbCountry.Size = new System.Drawing.Size(311, 37);
            this.txtbCountry.TabIndex = 16;
            this.txtbCountry.Text = global::MassBalans.Properties.Settings.Default.CompCountry;
            // 
            // txtbCity
            // 
            this.txtbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtbCity.Location = new System.Drawing.Point(1163, 309);
            this.txtbCity.Name = "txtbCity";
            this.txtbCity.Size = new System.Drawing.Size(311, 37);
            this.txtbCity.TabIndex = 17;
            this.txtbCity.Text = global::MassBalans.Properties.Settings.Default.CompCity;
            // 
            // mainCompDetailPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.txtbCompName);
            this.Controls.Add(this.txtbCountry);
            this.Controls.Add(this.txtbCity);
            this.Controls.Add(this.txtbAddress);
            this.Controls.Add(this.txtbZip);
            this.Controls.Add(this.txtbCert);
            this.Controls.Add(this.dtEndDate);
            this.Controls.Add(this.lblZIP);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblCertInfo);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblCntry);
            this.Controls.Add(this.lblCompName);
            this.Controls.Add(this.buttSave);
            this.Controls.Add(this.buttCancel);
            this.Name = "mainCompDetailPage";
            this.Size = new System.Drawing.Size(1899, 1131);
            this.Load += new System.EventHandler(this.mainCompDetailPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttCancel;
        private System.Windows.Forms.Button buttSave;
        private System.Windows.Forms.Label lblCompName;
        private System.Windows.Forms.Label lblCntry;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblCertInfo;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblZIP;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.TextBox txtbCompName;
        private System.Windows.Forms.TextBox txtbAddress;
        private System.Windows.Forms.TextBox txtbZip;
        private System.Windows.Forms.TextBox txtbCert;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.TextBox txtbCountry;
        private System.Windows.Forms.TextBox txtbCity;
    }
}

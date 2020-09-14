namespace MassBalans.screens.outputScreens
{
    partial class outputDetailPage
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
            this.buttSave = new System.Windows.Forms.Button();
            this.buttDelete = new System.Windows.Forms.Button();
            this.buttCancel = new System.Windows.Forms.Button();
            this.lblBuyer = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblContractnumber = new System.Windows.Forms.Label();
            this.lblPOS = new System.Windows.Forms.Label();
            this.cmbbBuyer = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSourceDataSet = new MassBalans.dbSourceDataSet();
            this.txtbContract = new System.Windows.Forms.TextBox();
            this.txtbPOS = new System.Windows.Forms.TextBox();
            this.nmbQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblSellDate = new System.Windows.Forms.Label();
            this.dtSellDate = new System.Windows.Forms.DateTimePicker();
            this.clientTableAdapter = new MassBalans.dbSourceDataSetTableAdapters.clientTableAdapter();
            this.lblAvail = new System.Windows.Forms.Label();
            this.availnum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSourceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // buttSave
            // 
            this.buttSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttSave.Location = new System.Drawing.Point(1683, 1043);
            this.buttSave.Name = "buttSave";
            this.buttSave.Size = new System.Drawing.Size(130, 47);
            this.buttSave.TabIndex = 25;
            this.buttSave.Text = "Save";
            this.buttSave.UseVisualStyleBackColor = true;
            this.buttSave.Click += new System.EventHandler(this.buttSave_Click);
            // 
            // buttDelete
            // 
            this.buttDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttDelete.Location = new System.Drawing.Point(1518, 1043);
            this.buttDelete.Name = "buttDelete";
            this.buttDelete.Size = new System.Drawing.Size(130, 47);
            this.buttDelete.TabIndex = 24;
            this.buttDelete.Text = "Delete";
            this.buttDelete.UseVisualStyleBackColor = true;
            this.buttDelete.Click += new System.EventHandler(this.buttDelete_Click);
            // 
            // buttCancel
            // 
            this.buttCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttCancel.Location = new System.Drawing.Point(44, 1043);
            this.buttCancel.Name = "buttCancel";
            this.buttCancel.Size = new System.Drawing.Size(130, 47);
            this.buttCancel.TabIndex = 23;
            this.buttCancel.Text = "Cancel";
            this.buttCancel.UseVisualStyleBackColor = true;
            this.buttCancel.Click += new System.EventHandler(this.buttCancel_Click);
            // 
            // lblBuyer
            // 
            this.lblBuyer.AutoSize = true;
            this.lblBuyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyer.Location = new System.Drawing.Point(767, 344);
            this.lblBuyer.Name = "lblBuyer";
            this.lblBuyer.Size = new System.Drawing.Size(80, 30);
            this.lblBuyer.TabIndex = 26;
            this.lblBuyer.Text = "Buyer";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(692, 411);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(155, 30);
            this.lblAmount.TabIndex = 27;
            this.lblAmount.Text = "Amount sold";
            // 
            // lblContractnumber
            // 
            this.lblContractnumber.AutoSize = true;
            this.lblContractnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContractnumber.Location = new System.Drawing.Point(650, 478);
            this.lblContractnumber.Name = "lblContractnumber";
            this.lblContractnumber.Size = new System.Drawing.Size(197, 30);
            this.lblContractnumber.TabIndex = 28;
            this.lblContractnumber.Text = "Contractnumber";
            // 
            // lblPOS
            // 
            this.lblPOS.AutoSize = true;
            this.lblPOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPOS.Location = new System.Drawing.Point(686, 602);
            this.lblPOS.Name = "lblPOS";
            this.lblPOS.Size = new System.Drawing.Size(161, 30);
            this.lblPOS.TabIndex = 29;
            this.lblPOS.Text = "POS number";
            this.lblPOS.Visible = false;
            // 
            // cmbbBuyer
            // 
            this.cmbbBuyer.DataSource = this.clientBindingSource;
            this.cmbbBuyer.DisplayMember = "name";
            this.cmbbBuyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbBuyer.FormattingEnabled = true;
            this.cmbbBuyer.Location = new System.Drawing.Point(875, 340);
            this.cmbbBuyer.Name = "cmbbBuyer";
            this.cmbbBuyer.Size = new System.Drawing.Size(314, 38);
            this.cmbbBuyer.TabIndex = 30;
            this.cmbbBuyer.ValueMember = "code";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.dbSourceDataSet;
            // 
            // dbSourceDataSet
            // 
            this.dbSourceDataSet.DataSetName = "dbSourceDataSet";
            this.dbSourceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtbContract
            // 
            this.txtbContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbContract.Location = new System.Drawing.Point(875, 475);
            this.txtbContract.Name = "txtbContract";
            this.txtbContract.Size = new System.Drawing.Size(142, 37);
            this.txtbContract.TabIndex = 32;
            // 
            // txtbPOS
            // 
            this.txtbPOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPOS.Location = new System.Drawing.Point(875, 599);
            this.txtbPOS.Name = "txtbPOS";
            this.txtbPOS.Size = new System.Drawing.Size(142, 37);
            this.txtbPOS.TabIndex = 33;
            this.txtbPOS.Visible = false;
            // 
            // nmbQuantity
            // 
            this.nmbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nmbQuantity.Location = new System.Drawing.Point(876, 409);
            this.nmbQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmbQuantity.Name = "nmbQuantity";
            this.nmbQuantity.Size = new System.Drawing.Size(141, 37);
            this.nmbQuantity.TabIndex = 34;
            this.nmbQuantity.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblSellDate
            // 
            this.lblSellDate.AutoSize = true;
            this.lblSellDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellDate.Location = new System.Drawing.Point(735, 543);
            this.lblSellDate.Name = "lblSellDate";
            this.lblSellDate.Size = new System.Drawing.Size(112, 30);
            this.lblSellDate.TabIndex = 35;
            this.lblSellDate.Text = "Sell date";
            // 
            // dtSellDate
            // 
            this.dtSellDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtSellDate.Location = new System.Drawing.Point(876, 543);
            this.dtSellDate.Name = "dtSellDate";
            this.dtSellDate.Size = new System.Drawing.Size(313, 37);
            this.dtSellDate.TabIndex = 36;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // lblAvail
            // 
            this.lblAvail.AutoSize = true;
            this.lblAvail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblAvail.Location = new System.Drawing.Point(676, 282);
            this.lblAvail.Name = "lblAvail";
            this.lblAvail.Size = new System.Drawing.Size(171, 30);
            this.lblAvail.TabIndex = 37;
            this.lblAvail.Text = "Available Gas";
            // 
            // availnum
            // 
            this.availnum.AutoSize = true;
            this.availnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.availnum.Location = new System.Drawing.Point(871, 282);
            this.availnum.Name = "availnum";
            this.availnum.Size = new System.Drawing.Size(27, 30);
            this.availnum.TabIndex = 38;
            this.availnum.Text = "0";
            // 
            // outputDetailPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.availnum);
            this.Controls.Add(this.lblAvail);
            this.Controls.Add(this.dtSellDate);
            this.Controls.Add(this.lblSellDate);
            this.Controls.Add(this.nmbQuantity);
            this.Controls.Add(this.txtbPOS);
            this.Controls.Add(this.txtbContract);
            this.Controls.Add(this.cmbbBuyer);
            this.Controls.Add(this.lblPOS);
            this.Controls.Add(this.lblContractnumber);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblBuyer);
            this.Controls.Add(this.buttSave);
            this.Controls.Add(this.buttDelete);
            this.Controls.Add(this.buttCancel);
            this.Name = "outputDetailPage";
            this.Size = new System.Drawing.Size(1862, 1128);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSourceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttSave;
        private System.Windows.Forms.Button buttDelete;
        private System.Windows.Forms.Button buttCancel;
        private System.Windows.Forms.Label lblBuyer;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblContractnumber;
        private System.Windows.Forms.Label lblPOS;
        private System.Windows.Forms.ComboBox cmbbBuyer;
        private System.Windows.Forms.TextBox txtbContract;
        private System.Windows.Forms.TextBox txtbPOS;
        private dbSourceDataSet dbSourceDataSet;
        private System.Windows.Forms.NumericUpDown nmbQuantity;
        private System.Windows.Forms.Label lblSellDate;
        private System.Windows.Forms.DateTimePicker dtSellDate;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private dbSourceDataSetTableAdapters.clientTableAdapter clientTableAdapter;
        private System.Windows.Forms.Label lblAvail;
        private System.Windows.Forms.Label availnum;
    }
}

namespace MassBalans.screens.prodcertScreens
{
    partial class certificationDetailPage
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
            this.lblProducer = new System.Windows.Forms.Label();
            this.chkSelfDec = new System.Windows.Forms.CheckBox();
            this.rdbFreight = new System.Windows.Forms.RadioButton();
            this.grpSelf = new System.Windows.Forms.GroupBox();
            this.rdbDuration = new System.Windows.Forms.RadioButton();
            this.rdbBatch = new System.Windows.Forms.RadioButton();
            this.lblStrtDt = new System.Windows.Forms.Label();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.lblEndDt = new System.Windows.Forms.Label();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.lblCertCode = new System.Windows.Forms.Label();
            this.txtbCertNum = new System.Windows.Forms.TextBox();
            this.buttSave = new System.Windows.Forms.Button();
            this.buttDelete = new System.Windows.Forms.Button();
            this.buttCancel = new System.Windows.Forms.Button();
            this.txtbProducer = new System.Windows.Forms.TextBox();
            this.grpSelf.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProducer
            // 
            this.lblProducer.AutoSize = true;
            this.lblProducer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducer.Location = new System.Drawing.Point(542, 288);
            this.lblProducer.Name = "lblProducer";
            this.lblProducer.Size = new System.Drawing.Size(117, 30);
            this.lblProducer.TabIndex = 0;
            this.lblProducer.Text = "Producer";
            // 
            // chkSelfDec
            // 
            this.chkSelfDec.AutoSize = true;
            this.chkSelfDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSelfDec.Location = new System.Drawing.Point(578, 348);
            this.chkSelfDec.Name = "chkSelfDec";
            this.chkSelfDec.Size = new System.Drawing.Size(208, 34);
            this.chkSelfDec.TabIndex = 2;
            this.chkSelfDec.Text = "Selfdeclaration";
            this.chkSelfDec.UseVisualStyleBackColor = true;
            this.chkSelfDec.CheckedChanged += new System.EventHandler(this.chkSelfDec_CheckedChanged);
            // 
            // rdbFreight
            // 
            this.rdbFreight.AutoSize = true;
            this.rdbFreight.Location = new System.Drawing.Point(22, 38);
            this.rdbFreight.Name = "rdbFreight";
            this.rdbFreight.Size = new System.Drawing.Size(156, 34);
            this.rdbFreight.TabIndex = 3;
            this.rdbFreight.TabStop = true;
            this.rdbFreight.Tag = "FRT";
            this.rdbFreight.Text = "Per freight";
            this.rdbFreight.UseVisualStyleBackColor = true;
            // 
            // grpSelf
            // 
            this.grpSelf.Controls.Add(this.rdbDuration);
            this.grpSelf.Controls.Add(this.rdbBatch);
            this.grpSelf.Controls.Add(this.rdbFreight);
            this.grpSelf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSelf.Location = new System.Drawing.Point(808, 328);
            this.grpSelf.Name = "grpSelf";
            this.grpSelf.Size = new System.Drawing.Size(380, 151);
            this.grpSelf.TabIndex = 4;
            this.grpSelf.TabStop = false;
            this.grpSelf.Text = "Type of selfdeclaration";
            this.grpSelf.Visible = false;
            this.grpSelf.Enter += new System.EventHandler(this.grpSelf_Enter);
            // 
            // rdbDuration
            // 
            this.rdbDuration.AutoSize = true;
            this.rdbDuration.Location = new System.Drawing.Point(22, 110);
            this.rdbDuration.Name = "rdbDuration";
            this.rdbDuration.Size = new System.Drawing.Size(177, 34);
            this.rdbDuration.TabIndex = 5;
            this.rdbDuration.TabStop = true;
            this.rdbDuration.Tag = "DUR";
            this.rdbDuration.Text = "Per duration";
            this.rdbDuration.UseVisualStyleBackColor = true;
            // 
            // rdbBatch
            // 
            this.rdbBatch.AutoSize = true;
            this.rdbBatch.Location = new System.Drawing.Point(22, 74);
            this.rdbBatch.Name = "rdbBatch";
            this.rdbBatch.Size = new System.Drawing.Size(147, 34);
            this.rdbBatch.TabIndex = 4;
            this.rdbBatch.TabStop = true;
            this.rdbBatch.Tag = "BTC";
            this.rdbBatch.Text = "Per batch";
            this.rdbBatch.UseVisualStyleBackColor = true;
            // 
            // lblStrtDt
            // 
            this.lblStrtDt.AutoSize = true;
            this.lblStrtDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrtDt.Location = new System.Drawing.Point(536, 498);
            this.lblStrtDt.Name = "lblStrtDt";
            this.lblStrtDt.Size = new System.Drawing.Size(123, 30);
            this.lblStrtDt.TabIndex = 5;
            this.lblStrtDt.Text = "Start date";
            // 
            // dtStart
            // 
            this.dtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStart.Location = new System.Drawing.Point(685, 494);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(200, 37);
            this.dtStart.TabIndex = 6;
            this.dtStart.ValueChanged += new System.EventHandler(this.dtStart_ValueChanged);
            // 
            // lblEndDt
            // 
            this.lblEndDt.AutoSize = true;
            this.lblEndDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDt.Location = new System.Drawing.Point(925, 498);
            this.lblEndDt.Name = "lblEndDt";
            this.lblEndDt.Size = new System.Drawing.Size(114, 30);
            this.lblEndDt.TabIndex = 7;
            this.lblEndDt.Text = "End date";
            // 
            // dtEnd
            // 
            this.dtEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEnd.Location = new System.Drawing.Point(1058, 493);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(200, 37);
            this.dtEnd.TabIndex = 8;
            this.dtEnd.ValueChanged += new System.EventHandler(this.dtEnd_ValueChanged);
            // 
            // lblCertCode
            // 
            this.lblCertCode.AutoSize = true;
            this.lblCertCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCertCode.Location = new System.Drawing.Point(468, 423);
            this.lblCertCode.Name = "lblCertCode";
            this.lblCertCode.Size = new System.Drawing.Size(191, 30);
            this.lblCertCode.TabIndex = 9;
            this.lblCertCode.Text = "Certificate code";
            // 
            // txtbCertNum
            // 
            this.txtbCertNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbCertNum.Location = new System.Drawing.Point(685, 420);
            this.txtbCertNum.Name = "txtbCertNum";
            this.txtbCertNum.Size = new System.Drawing.Size(374, 37);
            this.txtbCertNum.TabIndex = 10;
            this.txtbCertNum.Text = "ISCC-Cert-XX999-99900999";
            // 
            // buttSave
            // 
            this.buttSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttSave.Location = new System.Drawing.Point(1712, 1042);
            this.buttSave.Name = "buttSave";
            this.buttSave.Size = new System.Drawing.Size(130, 47);
            this.buttSave.TabIndex = 28;
            this.buttSave.Text = "Save";
            this.buttSave.UseVisualStyleBackColor = true;
            this.buttSave.Click += new System.EventHandler(this.buttSave_Click);
            // 
            // buttDelete
            // 
            this.buttDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttDelete.Location = new System.Drawing.Point(1521, 1042);
            this.buttDelete.Name = "buttDelete";
            this.buttDelete.Size = new System.Drawing.Size(130, 47);
            this.buttDelete.TabIndex = 27;
            this.buttDelete.Text = "Delete";
            this.buttDelete.UseVisualStyleBackColor = true;
            this.buttDelete.Click += new System.EventHandler(this.buttDelete_Click);
            // 
            // buttCancel
            // 
            this.buttCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttCancel.Location = new System.Drawing.Point(44, 1042);
            this.buttCancel.Name = "buttCancel";
            this.buttCancel.Size = new System.Drawing.Size(130, 47);
            this.buttCancel.TabIndex = 26;
            this.buttCancel.Text = "Cancel";
            this.buttCancel.UseVisualStyleBackColor = true;
            this.buttCancel.Click += new System.EventHandler(this.buttCancel_Click);
            // 
            // txtbProducer
            // 
            this.txtbProducer.Enabled = false;
            this.txtbProducer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbProducer.Location = new System.Drawing.Point(685, 285);
            this.txtbProducer.Name = "txtbProducer";
            this.txtbProducer.Size = new System.Drawing.Size(338, 37);
            this.txtbProducer.TabIndex = 29;
            this.txtbProducer.Text = "FreeFarms";
            // 
            // certificationDetailPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtbProducer);
            this.Controls.Add(this.buttSave);
            this.Controls.Add(this.buttDelete);
            this.Controls.Add(this.buttCancel);
            this.Controls.Add(this.txtbCertNum);
            this.Controls.Add(this.lblCertCode);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.lblEndDt);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.lblStrtDt);
            this.Controls.Add(this.grpSelf);
            this.Controls.Add(this.chkSelfDec);
            this.Controls.Add(this.lblProducer);
            this.Name = "certificationDetailPage";
            this.Size = new System.Drawing.Size(1899, 1131);
            this.grpSelf.ResumeLayout(false);
            this.grpSelf.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProducer;
        private System.Windows.Forms.TextBox txtbProducer;
        private System.Windows.Forms.CheckBox chkSelfDec;
        private System.Windows.Forms.GroupBox grpSelf;
        private System.Windows.Forms.RadioButton rdbFreight;
        private System.Windows.Forms.RadioButton rdbBatch;
        private System.Windows.Forms.RadioButton rdbDuration;
        private System.Windows.Forms.TextBox txtbCertNum;
        private System.Windows.Forms.Label lblStrtDt;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.Label lblEndDt;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Label lblCertCode;
        private System.Windows.Forms.Button buttSave;
        private System.Windows.Forms.Button buttDelete;
        private System.Windows.Forms.Button buttCancel;
    }
}

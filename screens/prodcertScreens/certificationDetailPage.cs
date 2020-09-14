using MassBalans.dto;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MassBalans.screens.prodcertScreens
{
    public partial class certificationDetailPage : UserControl
    {
        private static certificationDetailPage _instance;

        public static certificationDetailPage Instance
        {
            get
            {
                if (_instance == null) _instance = new certificationDetailPage();
                return _instance;
            }
        }

        public certificationDetailPage()
        {
            InitializeComponent();
        }

        private bool EditMode;
        public bool editMode
        {
            get { return EditMode; }
            set
            {
                EditMode = value;
            }
        }

        private string CertCode;
        public string certCode
        {
            get
            {
                return CertCode;
            }
            set
            {
                CertCode = value;
                Load_values();
            }
        }

        public int CompCode { get; set; }

        private string compName;
        public string CompName
        {
            get
            {
                return compName;
            }
            set
            {
                compName = value;
                txtbProducer.Text = value;
            }
        }

        private void buttSave_Click(object sender, EventArgs e)
        {


            if (DbConn.save_cert(new supplierCertDto()
                                    {
                                        serial = (!chkSelfDec.Checked) ? txtbCertNum.Text :
                                                                    "SELF-" + CompCode + grpSelf.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Tag +
                                                                    "-" + dtStart.Value.ToString("ddMM") + "-" + dtEnd.Value.ToString("ddMM"),
                                        selfdec = chkSelfDec.Checked,
                                        startdate = dtStart.Value,
                                        enddate = dtEnd.Value,
                                        supplierCode = CompCode,
                                        selfdecmeth = (chkSelfDec.Checked) ? grpSelf.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).TabIndex - 2 : 0
            }))
            {
                if (!Parent.Controls.Contains(certificationOverviewPage.Instance))
                {
                    Parent.Controls.Add(certificationOverviewPage.Instance);

                    certificationOverviewPage.Instance.Dock = DockStyle.Fill;
                    certificationOverviewPage.Instance.Load_values();
                    certificationOverviewPage.Instance.BringToFront();
                }
                else certificationOverviewPage.Instance.BringToFront();
            } else
            {
                MessageBox.Show("There was an error saving the information, check all fields and try again.");
            }           
        }

        private void buttDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This input won't be available for future use, existing records will be kept. \nContinue?", "Confirm deletion", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if (!Parent.Controls.Contains(certificationOverviewPage.Instance))
                {
                    Parent.Controls.Add(certificationOverviewPage.Instance);

                    certificationOverviewPage.Instance.Dock = DockStyle.Fill;
                    certificationOverviewPage.Instance.BringToFront();
                }
                else certificationOverviewPage.Instance.BringToFront();
            }
        }

        private void buttCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("All unsaved changes will be lost. Continue?", "Continue cancellation?", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if (!Parent.Controls.Contains(certificationOverviewPage.Instance))
                {
                    Parent.Controls.Add(certificationOverviewPage.Instance);

                    certificationOverviewPage.Instance.Dock = DockStyle.Fill;
                    certificationOverviewPage.Instance.BringToFront();
                }
                else certificationOverviewPage.Instance.BringToFront();
            }
        }

        private void change_edit(supplierCertDto certDto)
        {
            txtbCertNum.Enabled = editMode;
            chkSelfDec.Enabled = editMode;
            dtStart.Enabled = editMode;
            dtEnd.Enabled = editMode;

            if (certDto.name == null || certDto.name == "")
            {
                txtbProducer.Text = compName;
            } else { txtbProducer.Text = certDto.name; }

            if (certDto.serial != null)
            {
                chkSelfDec.Checked = certDto.selfdec;
                lblCertCode.Visible = !certDto.selfdec;
                txtbCertNum.Visible = !certDto.selfdec;
                grpSelf.Visible = certDto.selfdec;
                switch (certDto.selfdecmeth)
                {
                    case 1:
                        rdbFreight.Checked = true;
                        rdbBatch.Checked = false;
                        rdbDuration.Checked = false;
                        break;
                    case 2:
                        rdbFreight.Checked = false;
                        rdbBatch.Checked = true;
                        rdbDuration.Checked = false;
                        break;
                    case 3:
                        rdbFreight.Checked = false;
                        rdbBatch.Checked = false;
                        rdbDuration.Checked = true;
                        break;
                    default:
                        rdbFreight.Checked = false;
                        rdbBatch.Checked = false;
                        rdbDuration.Checked = false;
                        break;
                };

                txtbCertNum.Text = certDto.serial;
                dtStart.Value = certDto.startdate;
                dtEnd.Value = certDto.enddate;
            }
            else
            {
                chkSelfDec.Checked = certDto.selfdec;
                lblCertCode.Visible = !certDto.selfdec;
                txtbCertNum.Visible = !certDto.selfdec;
                grpSelf.Visible = certDto.selfdec;

                txtbCertNum.Text = certDto.serial;
                dtStart.Value = DateTime.Today;
                dtEnd.Value = DateTime.Today.AddDays(1);
            }
        }

        internal DB_Connection DbConn { get; set; } = new DB_Connection();

        private void Load_values()
        {
            if (certCode == "" || certCode == null)
            {
                change_edit(new supplierCertDto() { supplierCode = CompCode });
            }
            else
            {
                change_edit(DbConn.certs_get_one(certCode));
            }

        }

        private void chkSelfDec_CheckedChanged(object sender, EventArgs e)
        {
            lblCertCode.Visible = !chkSelfDec.Checked;
            txtbCertNum.Visible = !chkSelfDec.Checked;
            grpSelf.Visible = chkSelfDec.Checked;
        }

        private void grpSelf_Enter(object sender, EventArgs e)
        {

        }

        private void dtEnd_ValueChanged(object sender, EventArgs e)
        {
            if (dtEnd.Value < dtStart.Value) { dtEnd.Value = dtStart.Value; }
        }

        private void dtStart_ValueChanged(object sender, EventArgs e)
        {
            if (dtStart.Value > dtEnd.Value) { dtStart.Value = dtEnd.Value; }
        }
    }
}

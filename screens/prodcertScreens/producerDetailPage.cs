using MassBalans.dto;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MassBalans.screens.prodcertScreens
{
    public partial class producerDetailPage : UserControl
    {
        private static producerDetailPage _instance;

        public static producerDetailPage Instance
        {
            get
            {
                if (_instance == null) _instance = new producerDetailPage();
                return _instance;
            }
        }

        public producerDetailPage()
        {
            InitializeComponent();
        }

        private string iName;

        private int compCode;
        public int CompCode
        {
            get { return compCode; }
            set
            {
                compCode = value;
                Load_values();
            }
        }

        internal DB_Connection DbConn { get; set; } = new DB_Connection();

        private void Load_values()
        {
            if (compCode != 0)
            {
                set_current_info(DbConn.supplier_get_one(compCode));
            }
            else
            {
                set_current_info(new supplierDto());
            }
        }

        private void buttSave_Click(object sender, EventArgs e)
        {
            DbConn.supplier_save(new supplierDto
            {
                code = int.Parse(lblClientCode.Text),
                name = txtbName.Text,
                country = cmbbCountry.SelectedItem.ToString(),
                city = txtbCity.Text,
                truckCap = (int) numTruckCap.Value
            });

            if (!Parent.Controls.Contains(MassProdPanel.Instance))
            {
                Parent.Controls.Add(MassProdPanel.Instance);

                MassProdPanel.Instance.Dock = DockStyle.Fill;
                MassProdPanel.Instance.reload();
                MassProdPanel.Instance.BringToFront();
            }
            else
            {
                MassProdPanel.Instance.reload();
                MassProdPanel.Instance.BringToFront();
            }
        }

        private void buttCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("All unsaved changes will be lost. Continue?", "Continue cancellation?", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if (!Parent.Controls.Contains(MassProdPanel.Instance))
                {
                    Parent.Controls.Add(MassProdPanel.Instance);

                    MassProdPanel.Instance.Dock = DockStyle.Fill;
                    MassProdPanel.Instance.reload();
                    MassProdPanel.Instance.BringToFront();
                }
                else
                {
                    MassProdPanel.Instance.BringToFront();
                    MassProdPanel.Instance.reload();
                }
            }
        }

        private void btnCertViewAll_Click(object sender, EventArgs e)
        {
            if (!Parent.Controls.Contains(certificationOverviewPage.Instance))
            {
                Parent.Controls.Add(certificationOverviewPage.Instance);

                certificationOverviewPage.Instance.Dock = DockStyle.Fill;
                certificationOverviewPage.Instance.itemCode = compCode;
                certificationOverviewPage.Instance.compName = iName;
                certificationOverviewPage.Instance.BringToFront();
            }
            else
            {
                certificationOverviewPage.Instance.itemCode = compCode;
                certificationOverviewPage.Instance.compName = iName;
                certificationOverviewPage.Instance.BringToFront();
            }
        }

        private void set_current_info(supplierDto supplier)
        {
            lblClientCode.Text = supplier.code.ToString();
            txtbName.Text = supplier.name;
            iName = supplier.name;

            cmbbCountry.SelectedItem = supplier.country;
            txtbCity.Text = supplier.city;
            numTruckCap.Value = supplier.truckCap;

            lblCert.Text = supplier.certCode;

            if (supplier.enddate > DateTime.Today && supplier.certCode != null)
            {
                lblCert.BackColor = Color.GreenYellow;
                lblExpired.Visible = false;
            }
            else if (supplier.enddate == DateTime.Today && supplier.certCode != null)
            {
                lblCert.BackColor = Color.Orange;
                lblExpired.Visible = false;
            }
            else if (supplier.enddate < DateTime.Today && supplier.certCode != null)
            {
                lblCert.BackColor = Color.Red;
                lblExpired.Visible = true;
            }
            else
            {
                lblCert.BackColor = Color.Red;
                lblCert.Text = "NO CERTIFICATION SAVED";
            }
        }

        private void txtbName_TextChanged(object sender, EventArgs e)
        {
            if (txtbName.TextLength > 0)
            {
                btnCertViewAll.Enabled = true;
                iName = txtbName.Text;
            }
            else
            {
                btnCertViewAll.Enabled = false;
            }
        }
    }
}

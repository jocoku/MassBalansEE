using System;
using System.Data;
using System.Windows.Forms;

namespace MassBalans.screens.prodcertScreens
{
    public partial class certificationOverviewPage : UserControl
    {
        private static certificationOverviewPage _instance;

        public static certificationOverviewPage Instance
        {
            get
            {
                if (_instance == null) _instance = new certificationOverviewPage();
                return _instance;
            }
        }

        private bool firstrow;

        internal DB_Connection DbConn { get; set; } = new DB_Connection();

        public void Load_values()
        {
            try
            {
                this.supplierCertTableAdapter.FillBy(this.dbSourceDataSet.supplierCert, ItemCode);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            if (dataGridView1.Rows.Count == 0)
            {
                btnEdit.Visible = false;
            }
            else { btnEdit.Visible = true; }

            lblCompany.Text = CompName;

            //try
            //{
            //    this.supplierCertTableAdapter.FillBy(this.dbSourceDataSet.supplierCert, ItemCode);
            //}
            //catch (System.Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private int ItemCode;
        public int itemCode
        {
            get { return ItemCode; }
            set
            {
                ItemCode = value;
            }
        }

        private string CompName;
        public string compName
        {
            get { return CompName; }
            set
            {
                CompName = value;
                Load_values();
            }
        }

        public certificationOverviewPage()
        {
            InitializeComponent();
        }

        

        private void buttBack_Click(object sender, EventArgs e)
        {
            if (!Parent.Controls.Contains(producerDetailPage.Instance))
            {
                Parent.Controls.Add(producerDetailPage.Instance);

                producerDetailPage.Instance.Dock = DockStyle.Fill;
                producerDetailPage.Instance.BringToFront();
            }
            else producerDetailPage.Instance.BringToFront();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentCell != null)
                {
                    int selectedrowindex = dataGridView1.CurrentCell.RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                    if (selectedrowindex == 0 && (DateTime) dataGridView1.Rows[selectedrowindex].Cells[3].Value >= DateTime.Today)
                    {
                        // show edit button
                        firstrow = true;
                        btnEdit.Text = "Edit";
                    }
                    else
                    {
                        // show view button
                        firstrow = false;
                        btnEdit.Text = "View";
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttNew_Click(object sender, EventArgs e)
        {
            if (!Parent.Controls.Contains(certificationDetailPage.Instance))
            {
                Parent.Controls.Add(certificationDetailPage.Instance);

                certificationDetailPage.Instance.Dock = DockStyle.Fill;
                certificationDetailPage.Instance.editMode = true;
                certificationDetailPage.Instance.CompName = compName;
                certificationDetailPage.Instance.CompCode = itemCode;
                certificationDetailPage.Instance.certCode = "";
                certificationDetailPage.Instance.BringToFront();
            }
            else
            {
                certificationDetailPage.Instance.editMode = true;
                certificationDetailPage.Instance.certCode = "";
                certificationDetailPage.Instance.BringToFront();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (firstrow)
            {
                //direct to details with edit enabled
                if (!Parent.Controls.Contains(certificationDetailPage.Instance))
                {
                    Parent.Controls.Add(certificationDetailPage.Instance);

                    certificationDetailPage.Instance.Dock = DockStyle.Fill;
                    certificationDetailPage.Instance.editMode = true;
                    certificationDetailPage.Instance.certCode = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["serialDataGridViewTextBoxColumn"].Value.ToString();
                    certificationDetailPage.Instance.BringToFront();
                }
                else
                {
                    certificationDetailPage.Instance.editMode = true;
                    certificationDetailPage.Instance.certCode = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["serialDataGridViewTextBoxColumn"].Value.ToString();
                    certificationDetailPage.Instance.BringToFront();
                }
            }
            else
            {
                //direct to details without edit enabled || VIEW MODE
                if (!Parent.Controls.Contains(certificationDetailPage.Instance))
                {
                    Parent.Controls.Add(certificationDetailPage.Instance);

                    certificationDetailPage.Instance.Dock = DockStyle.Fill;
                    certificationDetailPage.Instance.editMode = false;
                    certificationDetailPage.Instance.certCode = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["serialDataGridViewTextBoxColumn"].Value.ToString();
                    certificationDetailPage.Instance.BringToFront();
                }
                else
                {
                    certificationDetailPage.Instance.editMode = false;
                    certificationDetailPage.Instance.certCode = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["serialDataGridViewTextBoxColumn"].Value.ToString();
                    certificationDetailPage.Instance.BringToFront();
                }
            }
        }
    }
}

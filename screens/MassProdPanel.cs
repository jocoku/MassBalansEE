using MassBalans.screens.prodcertScreens;
using System;
using System.Windows.Forms;

namespace MassBalans
{
    public partial class MassProdPanel : UserControl
    {
        private static MassProdPanel _instance;

        public static MassProdPanel Instance
        {
            get
            {
                if (_instance == null) _instance = new MassProdPanel();
                return _instance;
            }
        }

        public MassProdPanel()
        {
            InitializeComponent();
        }

        public void reload()
        {
            try
            {
                this.supplierTableAdapter.FillBy(this.dbSourceDataSet.supplier);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void MassProdPanel_Load(object sender, EventArgs e)
        {
            try
            {
                this.supplierTableAdapter.FillBy(this.dbSourceDataSet.supplier);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentCell != null)
                {
                    lblSelectItem.Text = dataGridView1.CurrentCell.Value.ToString();
                    int selectedrowindex = dataGridView1.CurrentCell.RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            if (!Parent.Controls.Contains(producerDetailPage.Instance))
            {
                Parent.Controls.Add(producerDetailPage.Instance);

                producerDetailPage.Instance.Dock = DockStyle.Fill;
                producerDetailPage.Instance.CompCode = 0;
                producerDetailPage.Instance.BringToFront();
            }
            else
            {
                producerDetailPage.Instance.CompCode = 0;
                producerDetailPage.Instance.BringToFront();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!Parent.Controls.Contains(producerDetailPage.Instance))
            {
                Parent.Controls.Add(producerDetailPage.Instance);

                producerDetailPage.Instance.Dock = DockStyle.Fill;
                producerDetailPage.Instance.CompCode = int.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["codeDGVtbc"].Value.ToString());
                producerDetailPage.Instance.BringToFront();
            }
            else
            {
                producerDetailPage.Instance.CompCode = int.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["codeDGVtbc"].Value.ToString());
                producerDetailPage.Instance.BringToFront();
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.supplierTableAdapter.FillBy(this.dbSourceDataSet.supplier);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}

using MassBalans.screens.buyerScreens;
using System;
using System.Windows.Forms;

namespace MassBalans
{
    public partial class MassBuyPanel : UserControl
    {
        private static MassBuyPanel _instance;

        public static MassBuyPanel Instance
        {
            get
            {
                if (_instance == null) _instance = new MassBuyPanel();
                return _instance;
            }
        }

        public MassBuyPanel()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (!Parent.Controls.Contains(buyerDetailPage.Instance))
            {
                Parent.Controls.Add(buyerDetailPage.Instance);

                buyerDetailPage.Instance.item = "";
                buyerDetailPage.Instance.Dock = DockStyle.Fill;
                buyerDetailPage.Instance.BringToFront();
            }
            else
            {
                buyerDetailPage.Instance.item = "";
                buyerDetailPage.Instance.BringToFront();
            }
        }

        private void MassBuyPanel_Load(object sender, EventArgs e)
        {
            try
            {
                this.clientTableAdapter.FillBy(this.dbSourceDataSet.client);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void refill()
        {
            try
            {
                this.clientTableAdapter.FillBy(this.dbSourceDataSet.client);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!Parent.Controls.Contains(buyerDetailPage.Instance))
            {
                Parent.Controls.Add(buyerDetailPage.Instance);
                buyerDetailPage.Instance.item = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["codeDGVtbc"].Value.ToString();
                buyerDetailPage.Instance.Dock = DockStyle.Fill;
                buyerDetailPage.Instance.BringToFront();

            }
            else
            {
                buyerDetailPage.Instance.BringToFront();
                buyerDetailPage.Instance.item = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["codeDGVtbc"].Value.ToString();
            }
        }
    }
}

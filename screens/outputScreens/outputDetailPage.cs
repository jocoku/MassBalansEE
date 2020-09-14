using MassBalans.dto;
using System;
using System.Data.Common;
using System.Windows.Forms;

namespace MassBalans.screens.outputScreens
{
    public partial class outputDetailPage : UserControl
    {
        private static outputDetailPage _instance;

        public static outputDetailPage Instance
        {
            get
            {
                if (_instance == null) _instance = new outputDetailPage();
                return _instance;
            }
        }

        internal DB_Connection DbConn { get; set; } = new DB_Connection();

        public outputDetailPage()
        {
            InitializeComponent();
            try
            {
                this.clientTableAdapter.FillBy(this.dbSourceDataSet.client);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        public void count_gas()
        {
            availnum.Text = DbConn.available_gas().ToString() + " nm3";
            nmbQuantity.Value = 0;
            txtbContract.Text = null;
            dtSellDate.Value = DateTime.Today;
        }

        private void buttSave_Click(object sender, EventArgs e)
        {
            bool res = DbConn.save_output(new outputDto()
            {
                id = (txtbPOS.Text.Length > 0) ? int.Parse(txtbPOS.Text) : 0,
                buyer = (int)cmbbBuyer.SelectedValue,
                quantity = (int)nmbQuantity.Value,
                date = (DateTime)dtSellDate.Value
            });
            if (res)
            {
                if (!Parent.Controls.Contains(MassOuputPanel.Instance))
                {
                    Parent.Controls.Add(MassOuputPanel.Instance);
                    MassOuputPanel.Instance.load_List();
                    MassOuputPanel.Instance.Dock = DockStyle.Fill;
                    MassOuputPanel.Instance.BringToFront();
                }
                else
                {
                    MassOuputPanel.Instance.load_List();
                    MassOuputPanel.Instance.BringToFront();
                }
            } else
            {
                MessageBox.Show("An error occured. Check all values and try again.");
            }
        }

        private void buttDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This input won't be available for future use, existing records will be kept. \nContinue?", "Confirm deletion", MessageBoxButtons.OKCancel);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                if (!Parent.Controls.Contains(MassOuputPanel.Instance))
                {
                    Parent.Controls.Add(MassOuputPanel.Instance);

                    MassOuputPanel.Instance.Dock = DockStyle.Fill;
                    MassOuputPanel.Instance.BringToFront();
                }
                else MassOuputPanel.Instance.BringToFront();
            }
        }

        private void buttCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("All unsaved changes will be lost. Continue?", "Continue cancellation?", MessageBoxButtons.OKCancel);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                if (!Parent.Controls.Contains(MassOuputPanel.Instance))
                {
                    Parent.Controls.Add(MassOuputPanel.Instance);

                    MassOuputPanel.Instance.Dock = DockStyle.Fill;
                    MassOuputPanel.Instance.BringToFront();
                }
                else MassOuputPanel.Instance.BringToFront();
            }
        }
    }
}

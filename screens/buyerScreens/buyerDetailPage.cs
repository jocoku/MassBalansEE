using MassBalans.dto;
using System;
using System.Windows.Forms;

namespace MassBalans.screens.buyerScreens
{
    public partial class buyerDetailPage : UserControl
    {
        private static buyerDetailPage _instance;
        private string Item;

        public string item
        {
            get { return Item; }
            set
            {
                Item = value;
                Load_values();
            }
        }

        internal DB_Connection DbConn { get; set; } = new DB_Connection();

        private void Load_values()
        {
            set_current_info(DbConn.buyer_get_one(Item));
        }

        public static buyerDetailPage Instance
        {
            get
            {
                if (_instance == null) _instance = new buyerDetailPage();
                return _instance;
            }
        }

        public buyerDetailPage()
        {
            InitializeComponent();
        }

        private void buttSave_Click(object sender, EventArgs e)
        {
            if (!Parent.Controls.Contains(MassBuyPanel.Instance))
            {
                Parent.Controls.Add(MassBuyPanel.Instance);

                MassBuyPanel.Instance.refill();
                MassBuyPanel.Instance.Dock = DockStyle.Fill;
                MassBuyPanel.Instance.BringToFront();
            }
            else
            {
                MassBuyPanel.Instance.refill();
                MassBuyPanel.Instance.BringToFront();
            }
        }

        private void buttDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This buyer won't be available for future use, existing records will be kept. \nContinue?", "Confirm deletion", MessageBoxButtons.OKCancel);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                if (!Parent.Controls.Contains(MassBuyPanel.Instance))
                {
                    Parent.Controls.Add(MassBuyPanel.Instance);

                    MassBuyPanel.Instance.Dock = DockStyle.Fill;
                    MassBuyPanel.Instance.BringToFront();
                }
                else MassBuyPanel.Instance.BringToFront();
            }
        }

        private void buttCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("All unsaved changes will be lost. Continue?", "Continue cancellation?", MessageBoxButtons.OKCancel);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                if (!Parent.Controls.Contains(MassBuyPanel.Instance))
                {
                    Parent.Controls.Add(MassBuyPanel.Instance);

                    MassBuyPanel.Instance.Dock = DockStyle.Fill;
                    MassBuyPanel.Instance.BringToFront();
                }
                else MassBuyPanel.Instance.BringToFront();
            }
        }

        private clientDto get_current_info()
        {
            clientDto clientDto = new clientDto();
            string whatitis = "";

            clientDto.code = int.Parse(lblClientCode.Text);
            clientDto.name = txtbName.Text;
            whatitis += lblClientCode.Text + " " + txtbName.Text + "\n";

            clientDto.country = txtbCountry.Text;
            clientDto.city = txtbCity.Text;
            whatitis += txtbCountry.Text + " " + txtbCity.Text + "\n";

            clientDto.zipCode = txtbZIP.Text;
            clientDto.street = txtbStreet.Text;
            clientDto.contract = chkbContract.Checked;
            clientDto.certVerto = txtbCont.Text;
            whatitis += txtbZIP.Text + " " + txtbStreet.Text + " " + chkbContract.Checked + " " + txtbCont.Text + "\n";


            MessageBox.Show(whatitis);

            return clientDto;
        }

        private void set_current_info(clientDto client)
        {
            lblClientCode.Text = client.code.ToString();
            txtbName.Text = client.name;

            txtbCountry.Text = client.country;
            txtbCity.Text = client.city;

            txtbZIP.Text = client.zipCode;
            txtbStreet.Text = client.street;

            if (client.contract)
            {
                chkbContract.Checked = client.contract;
                lblContractCode.Visible = client.contract;
                txtbCont.Visible = client.contract;

                txtbCont.Text = client.certVerto.ToString();
            }
            else
            {
                chkbContract.Checked = client.contract;
                lblContractCode.Visible = client.contract;
                txtbCont.Visible = client.contract;

                txtbCont.Text = "";
            }
        }

        private void chkbContract_CheckedChanged(object sender, EventArgs e)
        {
            lblContractCode.Visible = chkbContract.Checked;
            txtbCont.Visible = chkbContract.Checked;
        }
    }
}

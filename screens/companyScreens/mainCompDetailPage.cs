using System;
using System.Windows.Forms;

namespace MassBalans.screens.companyScreens
{
    public partial class mainCompDetailPage : UserControl
    {
        private static mainCompDetailPage _instance;

        public static mainCompDetailPage Instance
        {
            get
            {
                if (_instance == null) _instance = new mainCompDetailPage();
                return _instance;
            }
        }

        public mainCompDetailPage()
        {
            InitializeComponent();
        }

        private void mainCompDetailPage_Load(object sender, EventArgs e)
        {

        }

        private void buttCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("All unsaved changes will be lost. Continue?", "Continue cancellation?", MessageBoxButtons.OKCancel);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                if (!Parent.Controls.Contains(MassHomePanel.Instance))
                {
                    Parent.Controls.Add(MassHomePanel.Instance);

                    MassHomePanel.Instance.Dock = DockStyle.Fill;
                    MassHomePanel.Instance.BringToFront();
                }
                else MassHomePanel.Instance.BringToFront();
            }
        }

        private void buttSave_Click(object sender, EventArgs e)
        {
            //TODO SAVE STUFF
            Properties.Settings.Default.CompName = txtbCompName.Text;
            Properties.Settings.Default.CompCountry = txtbCountry.Text;
            Properties.Settings.Default.CompCity = txtbCity.Text;
            Properties.Settings.Default.CompAddress = txtbAddress.Text;
            Properties.Settings.Default.CompZipCode = txtbZip.Text;
            Properties.Settings.Default.CompCertificate = txtbCert.Text;
            Properties.Settings.Default.CompCertDate = dtEndDate.Value;

            Properties.Settings.Default.Save();

            if (!Parent.Controls.Contains(MassHomePanel.Instance))
            {
                Parent.Controls.Add(MassHomePanel.Instance);

                MassHomePanel.Instance.Dock = DockStyle.Fill;
                MassHomePanel.Instance.BringToFront();
            }
            else MassHomePanel.Instance.BringToFront();
        }
    }
}

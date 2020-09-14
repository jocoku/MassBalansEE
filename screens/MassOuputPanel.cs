using MassBalans.screens.outputScreens;
using System;
using System.Windows.Forms;

namespace MassBalans
{
    public partial class MassOuputPanel : UserControl
    {
        private static MassOuputPanel _instance;

        public static MassOuputPanel Instance
        {
            get
            {
                if (_instance == null) _instance = new MassOuputPanel();
                return _instance;
            }

        }
        public MassOuputPanel()
        {
            InitializeComponent();
        }

        public void load_List()
        {
            try
            {
                this.outputBuyerTableAdapter.FillBy(this.dbSourceDataSet.OutputBuyer);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (!Parent.Controls.Contains(outputDetailPage.Instance))
            {
                Parent.Controls.Add(outputDetailPage.Instance);

                outputDetailPage.Instance.Dock = DockStyle.Fill;
                outputDetailPage.Instance.count_gas();
                outputDetailPage.Instance.BringToFront();
            }
            else
            {
                outputDetailPage.Instance.BringToFront();
                outputDetailPage.Instance.count_gas();
            }
        }
    }
}

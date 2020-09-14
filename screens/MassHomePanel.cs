using MassBalans.screens.companyScreens;
using MassBalans.screens.outputScreens;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace MassBalans
{
    public partial class MassHomePanel : UserControl
    {
        private static MassHomePanel _instance;

        public static MassHomePanel Instance
        {
            get
            {
                if (_instance == null) _instance = new MassHomePanel();
                return _instance;
            }
        }

        private DateTime selectDate;

        internal DB_Connection DbConn { get; set; } = new DB_Connection();

        public MassHomePanel()
        {
            InitializeComponent();

            selectDate = DateTime.Today;

            setPeriod();

            if (selectDate.Year == DateTime.Today.Year && selectDate.Month == DateTime.Today.Month)
            {
                btnNxtMonth.Enabled = false;
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (!Parent.Controls.Contains(mainCompDetailPage.Instance))
            {
                Parent.Controls.Add(mainCompDetailPage.Instance);

                mainCompDetailPage.Instance.Dock = DockStyle.Fill;
                mainCompDetailPage.Instance.BringToFront();
            }
            else mainCompDetailPage.Instance.BringToFront();
        }

        private void btnNxtMonth_Click(object sender, EventArgs e)
        {
            if (selectDate.AddMonths(3).Year == DateTime.Today.Year && selectDate.AddMonths(3).Month > DateTime.Today.Month)
            {
                btnNxtMonth.Enabled = false;
            }
            else if (selectDate.AddMonths(3).Year == DateTime.Today.Year && selectDate.AddMonths(3).Month == DateTime.Today.Month)
            {
                selectDate = selectDate.AddMonths(3);
                btnNxtMonth.Enabled = false;
            }
            else
            {
                selectDate = selectDate.AddMonths(3);
                btnNxtMonth.Enabled = true;
            }

            // Adjust to show the massbalance information of the month
            //dataGridView1.DataSource = DbConn.load_deliveries_dat(selectDate);
            MessageBox.Show("Click?");
            setPeriod();
        }

        private void btnPrvMonth_Click(object sender, EventArgs e)
        {
            if (selectDate.AddMonths(-3).Year == DateTime.Today.Year && selectDate.AddMonths(-3).Month > DateTime.Today.Month)
            {
                btnNxtMonth.Enabled = false;
            }
            else if (selectDate.AddMonths(-3).Year == DateTime.Today.Year && selectDate.AddMonths(-3).Month == DateTime.Today.Month)
            {
                selectDate = selectDate.AddMonths(-3);
                btnNxtMonth.Enabled = false;
            }
            else
            {
                selectDate = selectDate.AddMonths(-3);
                btnNxtMonth.Enabled = true;
            }

            // Adjust to show the massbalance information of the month
            //dataGridView1.DataSource = DbConn.load_deliveries_dat(selectDate);

            setPeriod();
        }

        private void setPeriod()
        {
            int activePeriod = 1;

            if (selectDate.Month >= 01 && selectDate.Month <= 03)
            {
                lblCurrMonth.Text = "Period 1 - " + selectDate.ToString("yyyy");
                activePeriod = 1;
            }
            else if (selectDate.Month >= 04 && selectDate.Month <= 06)
            {
                lblCurrMonth.Text = "Period 2 - " + selectDate.ToString("yyyy");
                activePeriod = 2;
            }
            else if (selectDate.Month >= 07 && selectDate.Month <= 09)
            {
                lblCurrMonth.Text = "Period 3 - " + selectDate.ToString("yyyy");
                activePeriod = 3;
            }
            else if (selectDate.Month >= 10 && selectDate.Month <= 12)
            {
                lblCurrMonth.Text = "Period 4 - " + selectDate.ToString("yyyy");
                activePeriod = 4;
            }

            Dictionary<string,object> dicttt = DbConn.getPeriodInfo(selectDate);
            
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            excelOutput excelOutput = new excelOutput();
            excelOutput.Export_to_POS();
        }
    }
}

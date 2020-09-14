using MassBalans.screens.inputScreens;
using MassBalans.screens.tables;
using System;
using System.Windows.Forms;

namespace MassBalans
{
    public partial class MassInputPanel : UserControl
    {
        private static MassInputPanel _instance;

        public static MassInputPanel Instance
        {
            get
            {
                if (_instance == null) _instance = new MassInputPanel();
                return _instance;
            }
        }

        internal DB_Connection DbConn { get; set; } = new DB_Connection();

        private DateTime selectDate;

        public MassInputPanel()
        {
            InitializeComponent();

            selectDate = DateTime.Today;
            lblCurrMonth.Text = selectDate.ToString("MMMM - yyyy");

            if (selectDate.Year == DateTime.Today.Year && selectDate.Month == DateTime.Today.Month)
            {
                btnNxtMonth.Enabled = false;
            }
        }

        public void load_list()
        {
            try
            { 
                this.inputGroupTableAdapter.FillBy(this.dbSourceDataSet.InputGroup);
                dataGridView1.DataSource = DbConn.load_deliveries_dat(DateTime.Today);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnNewInput_Click(object sender, EventArgs e)
        {
            if (!Parent.Controls.Contains(inputNewSource.Instance))
            {
                Parent.Controls.Add(inputNewSource.Instance);

                inputNewSource.Instance.Dock = DockStyle.Fill;
                inputNewSource.Instance.load_information();
                inputNewSource.Instance.BringToFront();
            }
            else
            {
                inputNewSource.Instance.load_information();
                inputNewSource.Instance.BringToFront();
            }
        }

        private void btnNewPro_Click(object sender, EventArgs e)
        {
            if (!Parent.Controls.Contains(inputSourceGas.Instance))
            {
                Parent.Controls.Add(inputSourceGas.Instance);

                inputSourceGas.Instance.load_values();
                inputSourceGas.Instance.Dock = DockStyle.Fill;
                inputSourceGas.Instance.BringToFront();
            }
            else
            {
                inputSourceGas.Instance.load_values();
                inputSourceGas.Instance.BringToFront();
            }
        }

        private void btnNxtMonth_Click(object sender, EventArgs e)
        {
            if (selectDate.AddMonths(1).Year == DateTime.Today.Year && selectDate.AddMonths(1).Month > DateTime.Today.Month)
            {
                btnNxtMonth.Enabled = false;
            }
            else if (selectDate.AddMonths(1).Year == DateTime.Today.Year && selectDate.AddMonths(1).Month == DateTime.Today.Month)
            {
                selectDate = selectDate.AddMonths(1);
                btnNxtMonth.Enabled = false;
            }
            else
            {
                selectDate = selectDate.AddMonths(1);
                btnNxtMonth.Enabled = true;
            }

            dataGridView1.DataSource = DbConn.load_deliveries_dat(selectDate);

            lblCurrMonth.Text = selectDate.ToString("MMMM - yyyy");
        }

        private void btnPrvMonth_Click(object sender, EventArgs e)
        {
            if (selectDate.AddMonths(-1).Year == DateTime.Today.Year && selectDate.AddMonths(-1).Month > DateTime.Today.Month)
            {
                btnNxtMonth.Enabled = false;
            }
            else if (selectDate.AddMonths(-1).Year == DateTime.Today.Year && selectDate.AddMonths(-1).Month == DateTime.Today.Month)
            {
                selectDate = selectDate.AddMonths(-1);
                btnNxtMonth.Enabled = false;
            }
            else
            {
                selectDate = selectDate.AddMonths(-1);
                btnNxtMonth.Enabled = true;
            }

            dataGridView1.DataSource = DbConn.load_deliveries_dat(selectDate);

            lblCurrMonth.Text = selectDate.ToString("MMMM - yyyy");
        }

        private void btnM3_Click(object sender, EventArgs e)
        {
            showTables sh = new showTables(true, this.ParentForm);
            sh.Show();
        }

        private void btnMWH_Click(object sender, EventArgs e)
        {
            showTables sh = new showTables(false, this.ParentForm);
            sh.Show();
        }
    }
}

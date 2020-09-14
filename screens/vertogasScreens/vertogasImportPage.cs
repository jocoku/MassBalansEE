using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MassBalans.screens.vertogasScreens
{
    public partial class vertogasImportPage : UserControl
    {
        private static vertogasImportPage _instance;

        public static vertogasImportPage Instance
        {
            get
            {
                if (_instance == null) _instance = new vertogasImportPage();
                return _instance;
            }
        }

        internal DB_Connection DbConn { get; set; } = new DB_Connection();

        public vertogasImportPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Comma-Separated Value File (*.csv)|*.csv|Excel Files (*.xls, *.xlsx)|*.xls;*.xlsx|Text Files (*.txt)|*.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileparts = openFileDialog1.FileName.Split('\\').Last();

                lblSelectedFile.Text = fileparts;

                try
                {
                    string[] Lines = File.ReadAllLines(openFileDialog1.FileName);
                    string[] Fields;
                    Fields = Lines[0].Split(new char[] { ',' });
                    int Cols = Fields.GetLength(0);
                    DataTable dt = new DataTable();
                    //1st row must be column names; force lower case to ensure matching later on.
                    for (int i = 0; i < Cols; i++)
                        dt.Columns.Add(Fields[i].ToLower(), typeof(string));
                    DataRow Row;
                    for (int i = 1; i < Lines.GetLength(0); i++)
                    {

                        Fields = Lines[i].Split(new char[] { ',' });
                        Row = dt.NewRow();
                        if ((string)Fields[4] == "Mar-20") MessageBox.Show(((string)Fields[4] == "Mar-20") + " " + Fields[4]);
                        for (int f = 0; f < Cols; f++) Row[f] = Fields[f];
                        dt.Rows.Add(Row);
                    }
                    dataGridView1.DataSource = dt;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("All unsaved changes will be lost. Continue?", "Continue cancellation?", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if (!Parent.Controls.Contains(MassVertoPanel.Instance))
                {
                    Parent.Controls.Add(MassVertoPanel.Instance);

                    MassVertoPanel.Instance.Dock = DockStyle.Fill;
                    MassVertoPanel.Instance.load_list();
                    MassVertoPanel.Instance.BringToFront();
                }
                else
                {
                    MassVertoPanel.Instance.BringToFront();
                    MassVertoPanel.Instance.load_list();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable info = (DataTable)dataGridView1.DataSource;
            info.Columns.Remove("Duurzame Energiebron");
            info.Columns.Remove("Kenmerk");

            info.Columns["Serienummer"].ColumnName = "serialCert";
            info.Columns["Hoeveelheid"].ColumnName = "quantity";
            info.Columns["NTA-Classificatie"].ColumnName = "ntaCode";
            info.Columns["Creatie datum"].ColumnName = "transactionDate";

            DataTable toSafe = new DataTable();
            toSafe.Columns.Add("serialCert").DataType = typeof(string);
            toSafe.Columns.Add("quantity").DataType = typeof(int);
            toSafe.Columns.Add("ntaCode").DataType = typeof(int);
            toSafe.Columns.Add("transactionDate").DataType = typeof(DateTime);
            toSafe.Columns.Add("accountTo").DataType = typeof(int);

            dataGridView1.DataSource = info;

            if (!info.Columns.Contains("accountTo"))
            {
                info.Columns.Add("accountTo");
            }

            DbConn.save_verto_info((DataTable)dataGridView1.DataSource);

            if (!Parent.Controls.Contains(MassVertoPanel.Instance))
            {
                Parent.Controls.Add(MassVertoPanel.Instance);

                MassVertoPanel.Instance.Dock = DockStyle.Fill;
                MassVertoPanel.Instance.BringToFront();
            }
            else
            {
                MassVertoPanel.Instance.BringToFront();
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.vertoValuesTableAdapter.FillBy(this.dbSourceDataSet.vertoValues);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}

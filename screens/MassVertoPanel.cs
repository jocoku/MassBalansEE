using MassBalans.screens.vertogasScreens;
using System;
using System.Windows.Forms;

namespace MassBalans
{
    public partial class MassVertoPanel : UserControl
    {
        private static MassVertoPanel _instance;

        public static MassVertoPanel Instance
        {
            get
            {
                if (_instance == null) _instance = new MassVertoPanel();
                return _instance;
            }
        }

        public MassVertoPanel()
        {
            InitializeComponent();
            load_list();
        }

        public void load_list()
        {
            try
            {
                this.vertoValuesTableAdapter.FillBy1(this.dbSourceDataSet.vertoValues);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Parent.Controls.Contains(vertogasImportPage.Instance))
            {
                Parent.Controls.Add(vertogasImportPage.Instance);

                vertogasImportPage.Instance.Dock = DockStyle.Fill;
                vertogasImportPage.Instance.BringToFront();
            }
            else vertogasImportPage.Instance.BringToFront();
        }
    }
}

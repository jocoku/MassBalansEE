using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassBalans
{
    public partial class tableMWH : UserControl
    {
        public tableMWH()
        {
            InitializeComponent();
        }

        public void load_list()
        {
            try
            {
                this.inputCountryMWHTableAdapter.FillBy(this.dbSourceDataSet.InputCountryMWH);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.inputCountryMWHTableAdapter.FillBy(this.dbSourceDataSet.InputCountryMWH);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}

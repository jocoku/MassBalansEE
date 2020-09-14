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
    public partial class tableM3 : UserControl
    {
        public tableM3()
        {
            InitializeComponent();
        }
        public void load_list()
        {
            try
            {
                this.inputCountryTableAdapter.FillBy(this.dbSourceDataSet.InputCountry);
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
                this.inputCountryTableAdapter.FillBy(this.dbSourceDataSet.InputCountry);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassBalans.screens.tables
{
    public partial class showTables : Form
    {
        private Form orgForm;

        public showTables(Boolean panelm3, Form back)
        {
            InitializeComponent();

            if (panelm3) { 
                tableM31.BringToFront();
                tableM31.load_list();
                this.Text = "Available gas M3";
            } else { 
                tableMWH1.BringToFront();
                tableMWH1.load_list();
                this.Text = "Available gas MWH";
            }

            orgForm = back;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();

            orgForm.BringToFront();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (panel1.Controls[0].Name == tableM31.Name)
            {
                tableM31.load_list();
            }
            else if (panel1.Controls[0].Name == tableM31.Name)
            {
                tableMWH1.load_list();
            }
        }
    }
}

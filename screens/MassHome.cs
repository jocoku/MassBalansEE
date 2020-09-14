using System;
using System.Windows.Forms;

namespace MassBalans
{
    public partial class MassHome : Form
    {
        private static MassHome _instance;

        public static MassHome Instance
        {
            get
            {
                if (_instance == null) _instance = new MassHome();
                return _instance;
            }
        }

        public MassHome()
        {
            InitializeComponent();
        }

        private void MassHome_Load(object sender, EventArgs e)
        {

        }

        private void tabsMain_SelectedIndexchanged(object sender, EventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                case 0: //tab home
                    massHomePanel2.BringToFront();
                    break;
                case 1: //tab input
                    massInputPanel1.BringToFront();
                    massInputPanel1.load_list();
                    break;
                case 2: //tab Output
                    massOuputPanel1.load_List();
                    massOuputPanel1.BringToFront();
                    break;
                case 3: //tab Vertogas
                    massVertoPanel1.BringToFront();
                    massVertoPanel1.load_list();
                    break;
                case 4: //tab producers
                    massProdPanel1.BringToFront();
                    massProdPanel1.reload();
                    break;
                case 5: //tab resource
                    massSourcePanel2.reload_list();
                    massSourcePanel2.BringToFront();
                    break;
                case 6: //tab buyer
                    massBuyPanel1.BringToFront();
                    massBuyPanel1.refill();
                    break;
            }
        }

        private void outputDetailPage1_Load(object sender, EventArgs e)
        {

        }
    }
}

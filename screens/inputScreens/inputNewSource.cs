using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MassBalans.dto;

namespace MassBalans.screens.inputScreens
{
    public partial class inputNewSource : UserControl
    {
        private static inputNewSource _instance;

        public static inputNewSource Instance
        {
            get
            {
                if (_instance == null) _instance = new inputNewSource();
                return _instance;
            }
        }

        public inputNewSource()
        {
            InitializeComponent();
        }

        internal DB_Connection DbConn { get; set; } = new DB_Connection();

        public void load_information()
        {
            //Fill known suppliers && resources
            try
            {
                this.supplierTableAdapter.FillBy1(this.dbSourceDataSet.supplier);
                cmbbProd.SelectedIndex = -1;
                this.resourceTableAdapter.FillBy2(this.dbSourceDataSet.resource);
                cmbbResource.SelectedIndex = -1;
                cmbbCountry.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Disable groups, to be filled when selections are made
            grDeliverAmount.Enabled = false;
            grpTrucks.Enabled = false;

        }

        private void buttSave_Click(object sender, EventArgs e)
        {

            DbConn.delivery_save(new inputDto()
            {
                resource = (int)cmbbResource.SelectedValue,
                quantity = (int)numDelivery.Value,
                supplier = (int)cmbbProd.SelectedValue,
                conversion = false,
                trucksneed = (int)numTruckNeed.Value,
                truckFull = (int)numTruckFull.Value,
                truckEmpty = (int)numTruckEmpty.Value,
                orgCountry = cmbbCountry.SelectedValue.ToString()
            });


            if (!Parent.Controls.Contains(MassInputPanel.Instance))
            {
                Parent.Controls.Add(MassInputPanel.Instance);

                MassInputPanel.Instance.Dock = DockStyle.Fill;
                MassInputPanel.Instance.load_list();
                MassInputPanel.Instance.BringToFront();
            }
            else
            {
                MassInputPanel.Instance.BringToFront();
                MassInputPanel.Instance.load_list();
            }
        }

        private void buttCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("All unsaved changes will be lost. Continue?", "Continue cancellation?", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if (!Parent.Controls.Contains(MassInputPanel.Instance))
                {
                    Parent.Controls.Add(MassInputPanel.Instance);

                    MassInputPanel.Instance.Dock = DockStyle.Fill;
                    MassInputPanel.Instance.BringToFront();
                    MassInputPanel.Instance.load_list();
                }
                else
                {
                    MassInputPanel.Instance.BringToFront();
                    MassInputPanel.Instance.load_list();

                }
            }
        }

        private void cmbbProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbProd.SelectedIndex != -1)
            {
                chkbContract.Checked = (DbConn.check_certs((int)cmbbProd.SelectedValue)) ? true : false;

                if (cmbbResource.SelectedItem != null || cmbbResource.SelectedIndex != -1)
                {
                    grDeliverAmount.Enabled = true;

                    load_amounts();
                }
            }
        }

        private void cmbbResource_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbResource.SelectedIndex != -1)
            {
                if (cmbbProd.SelectedItem != null || cmbbProd.SelectedIndex != -1)
                {
                    grDeliverAmount.Enabled = true;
                    load_amounts();
                }
            }
        }
            
        private void load_amounts()
        {
            if (cmbbProd.SelectedIndex != -1 && cmbbResource.SelectedIndex != -1)
            {
                // connect to db and do lookup
                availResc.Text = remResource.Text = DbConn.get_resc_amount((int) cmbbResource.SelectedValue, (int) cmbbProd.SelectedValue).ToString();
            }
        }

        private void numDelivery_ValueChanged(object sender, EventArgs e)
        {
            int total = int.Parse(availResc.Text) + (int)numDelivery.Value;
            remResource.Text = total.ToString();

            numTruckNeed.Value = Math.Ceiling(numDelivery.Value / DbConn.get_truck_cap((int) cmbbProd.SelectedValue));
            grpTrucks.Enabled = true;
        }

        private void numTruckFull_ValueChanged(object sender, EventArgs e)
        {
            if (numTruckFull.Value > numTruckEmpty.Value)
            {
                numTruckEmpty.Value = numTruckFull.Value;
            }
        }
    }
}

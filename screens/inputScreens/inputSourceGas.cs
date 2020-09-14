using System;
using System.Drawing;
using System.Windows.Forms;
using MassBalans.dto;

namespace MassBalans.screens.inputScreens
{
    public partial class inputSourceGas : UserControl
    {
        private static inputSourceGas _instance;

        public static inputSourceGas Instance
        {
            get
            {
                if (_instance == null) _instance = new inputSourceGas();
                return _instance;
            }
        }

        public inputSourceGas()
        {
            InitializeComponent();
        }

        internal DB_Connection DbConn { get; set; } = new DB_Connection();

        public void load_values()
        {
            try
            {
                this.supplierTableAdapter.FillBy(this.dbSourceDataSet.supplier);
                cmbbProd.SelectedIndex = -1;
                this.resourceTableAdapter.FillBy2(this.dbSourceDataSet.resource);
                cmbbResc.SelectedIndex = -1;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void buttSave_Click(object sender, EventArgs e)
        {
            DbConn.delivery_save(new inputDto()
            {
                resource = (int)cmbbResc.SelectedValue,
                quantity = -(int)numGasUse.Value,
                supplier = (int)cmbbProd.SelectedValue,
                conversion = true
            });

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

        private void buttCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("All unsaved changes will be lost. Continue?", "Continue cancellation?", MessageBoxButtons.OKCancel);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                if (!Parent.Controls.Contains(MassInputPanel.Instance))
                {
                    Parent.Controls.Add(MassInputPanel.Instance);

                    MassInputPanel.Instance.Dock = DockStyle.Fill;
                    MassInputPanel.Instance.BringToFront();
                }
                else MassInputPanel.Instance.BringToFront();
            }
        }

        private void numGasUse_ValueChanged(object sender, EventArgs e)
        {
            if (numGasUse.Value > int.Parse(availResc.Text) && numGasUse.Value >= 0)
            {
                remResource.Text = (int.Parse(availResc.Text) - (int)numGasUse.Value) + "";
                remResource.ForeColor = Color.Red;
            }
            else if (numGasUse.Value <= int.Parse(availResc.Text) && numGasUse.Value >= 0)
            {
                remResource.Text = (int.Parse(availResc.Text) - (int)numGasUse.Value) + "";
                remResource.ForeColor = Color.Black;
            } else
            {
                MessageBox.Show("The value " + numGasUse.Value + " is not permitted.", "Alert!");
            }
        }

        private void cmbbProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbProd.SelectedIndex != -1)
            {
                if (cmbbResc.SelectedIndex != -1)
                {
                    load_amounts();
                } else
                {
                    cmbbResc.DataSource = DbConn.load_deliveries_pro((int)cmbbProd.SelectedValue);
                    cmbbResc.DisplayMember = "name";
                    cmbbResc.ValueMember = "id";
                }
            }
        }

        private void cmbbResc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbResc.SelectedIndex != -1)
            {
                if (cmbbProd.SelectedIndex != -1)
                {
                    load_amounts();
                }
                else
                {
                    cmbbProd.DataSource = DbConn.load_deliveries_res((int)cmbbProd.SelectedValue);
                    cmbbProd.DisplayMember = "name";
                    cmbbProd.ValueMember = "id";
                }
            }

        }

        private void load_amounts()
        {
            // if bth cmbb selected
            availResc.Text = remResource.Text = DbConn.get_resc_amount((int) cmbbResc.SelectedValue, (int) cmbbProd.SelectedValue).ToString();
            numGasUse.Value = 0;
        }
    }
}

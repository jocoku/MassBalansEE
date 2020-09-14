using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace MassBalans
{
    public partial class MassSourcePanel : UserControl
    {
        private static MassSourcePanel _instance;

        public static MassSourcePanel Instance
        {
            get
            {
                if (_instance == null) _instance = new MassSourcePanel();
                return _instance;
            }
        }

        private bool isNew;

        internal DB_Connection DbConn { get; set; } = new DB_Connection();

        public MassSourcePanel()
        {
            InitializeComponent();
            btnSave.Hide();
            btnCancel.Hide();

            numNTA.Enabled = false;
            txtbName.Enabled = false;
            txtbISCC.Enabled = false;

            dGV_Resources.Enabled = false;

            cmbbCrtGrp.DataSource = new BindingSource(new SortedDictionary<string, int>
            {
                {"", 0},
                {"I", 1},
                {"II", 2},
                {"III", 3},
                {"IV", 4},
                {"V", 5},
                {"VI", 6},
                {"VII", 7},
                {"VIII", 8},
                {"IX", 9},
                {"X", 10},
                {"XI", 11},
                {"XII", 12},
                {"XIII", 13},
                {"XIV", 14},
                {"XV", 15},
                {"XVI", 16}
            }, null);
            cmbbCrtGrp.DisplayMember = "Key";
            cmbbCrtGrp.ValueMember = "Value";
            cmbbCrtGrp.SelectedItem = null;
        }

        public void reload_list()
        {
            DataTable src = DbConn.resource_load_list("mbSources");

            //< show >
            lstbResources.DisplayMember = "name";
            lstbResources.ValueMember = "codeSource";
            lstbResources.DataSource = src;
            //</ show >
        }

        private void lstbResources_SelectedIndexChanged(object sender, EventArgs e)
        {
            dto.resourceDto src = DbConn.resource_get_item((int)lstbResources.SelectedValue);
            numNTA.Value = src.codeSource;
            txtbName.Text = src.name;
            txtbISCC.Text = src.valueISCC;
            cmbbCrtGrp.SelectedValue = src.classificationGroup;

            try
            {
                this.resourceTableAdapter.FillBy1(this.dbSourceDataSet.resource, ((int)numNTA.Value));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region buttons
        private void btnSave_Click(object sender, EventArgs e)
        {
            dto.resourceDto resource = new dto.resourceDto
            {
                codeSource = (int)numNTA.Value,
                name = txtbName.Text,
                valueISCC = txtbISCC.Text,
                classificationGroup = (int)cmbbCrtGrp.SelectedValue
            };

            if (isNew)
            {
                DbConn.resource_new_entry(resource);
            }
            else
            {
                DbConn.resource_update_entry(resource);
            }

            editMode(false);
            reload_list();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("All unsaved changes will be lost. Continue?", "Continue cancellation?", MessageBoxButtons.OKCancel);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                editMode(false);
                reload_list();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isNew = false;
            editMode(true);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            isNew = true;
            editMode(true);

            numNTA.Value = 0;
            txtbISCC.Text = null;
            cmbbCrtGrp.Text = "";

            txtbName.Text = "";
        }

        #endregion buttons

        private void editMode(bool mode)
        {
            if (mode)
            {
                btnSave.Show();
                btnCancel.Show();
                btnNew.Hide();
                btnEdit.Hide();
            }
            else
            {
                btnSave.Hide();
                btnCancel.Hide();
                btnNew.Show();
                btnEdit.Show();
            }

            lstbResources.Enabled = !mode;

            numNTA.Enabled = mode;
            txtbName.Enabled = mode;
            txtbISCC.Enabled = mode;
            cmbbCrtGrp.Enabled = mode;
            dGV_Resources.Enabled = mode;
        }

        private void dGV_Resources_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["ntaCodeDGV"].Value = numNTA.Value;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.resourceTableAdapter.FillBy(this.dbSourceDataSet.resource);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}

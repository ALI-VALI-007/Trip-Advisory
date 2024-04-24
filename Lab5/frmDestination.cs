using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class frmDestination : Form
    {
        public frmDestination()
        {
            InitializeComponent();
        }

        private void frmDestination_Load(object sender, EventArgs e)
        {
            pnlCreateDestination.Visible = false;
            pnlModify.Visible = false;
            pnlSearch.Visible = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            destinationController controller = new destinationController();
            string destinationName = txtCreationName.Text;
            string location = txtCreationLocation.Text;
            string cost = txtCreationCost.Text;
            string URL = txtCreationURL.Text;
            string attractons = txtCreateAttractions.Text;
            bool valid = controller.validDestinationSave(destinationName,location,cost,URL, attractons);
            if (valid)
            {
                MessageBox.Show("Created");
            }
            else
            {
                MessageBox.Show("Not Created");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            destinationController controller = new destinationController();
            string destinationName = cbxModifyDestination.Text;
            string location = txtModifyLocation.Text;
            string cost = txtModifyCost.Text;
            string URL = txtModifyURL.Text;
            string attractions = txtModifyAttractions.Text;
            bool valid = controller.validDestinationUpdate(destinationName, location, cost, URL,attractions);
            if (valid)
            {
                MessageBox.Show("Modified");
            }
            else
            {
                MessageBox.Show("Not Modified");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            destinationController controller = new destinationController();
            string destinationName = cbxModifyDestination.Text;
            bool valid=controller.validDestinationDelete(destinationName);
            if (valid)
            {
                MessageBox.Show("Deleted");
                cbxModifyDestination.Items.Clear();
                List<string> destinationNames = controller.getDestinationList();
                foreach (string curName in destinationNames)
                {
                    //MessageBox.Show(curName);
                    cbxModifyDestination.Items.Add(curName);
                }
            } else
            {
                MessageBox.Show("Not Deleted");
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome homePage = new frmHome();
            this.Hide();
            homePage.Show();
        }

        private void btnSearchPage_Click(object sender, EventArgs e)
        {
            pnlCreateDestination.Visible = false;
            pnlModify.Visible = false;
            pnlSearch.Visible = true;
            destinationController controller = new destinationController();
            cbxSearchDestination.Items.Clear();
            List<string> destinationNames = controller.getDestinationList();
            foreach (string curName in destinationNames)
            {
                //MessageBox.Show(curName);
                cbxSearchDestination.Items.Add(curName);
            }
        }

        private void btnModifyPage_Click(object sender, EventArgs e)
        {
            pnlCreateDestination.Visible = false;
            pnlModify.Visible = true;
            pnlSearch.Visible = false;
            destinationController controller = new destinationController();
            cbxModifyDestination.Items.Clear();
            List<string> destinationNames = controller.getDestinationList();
            foreach (string curName in destinationNames)
            {
                //MessageBox.Show(curName);
                cbxModifyDestination.Items.Add(curName);
            }
        }

        private void btnCreatePage_Click(object sender, EventArgs e)
        {
            pnlCreateDestination.Visible = true;
            pnlModify.Visible = false;
            pnlSearch.Visible = false;

        }

        private void cbxSearchDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            destinationController controller = new destinationController();
            controller.validDestinationLoad(cbxSearchDestination.Text);
            DataTable dataTable = new DataTable();
            dgvSearchDestination.DataSource = dataTable;
            pbxDestinationPicture.SizeMode = PictureBoxSizeMode.Zoom;
            pbxDestinationPicture.Load(controller.getURL());
        }

        private void dgvSearchDestination_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pbxDestinationPicture_Click(object sender, EventArgs e)
        {

        }

        private void cbxModifyDestination_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab5
{
    public partial class frmReviews : Form
    {
        private string curUsername;
        public void setUser(string username)
        {
            curUsername = username;
        }
        public frmReviews()
        {
            InitializeComponent();
        }

        private void pbxDestinationPicture_Click(object sender, EventArgs e)
        {

        }

        private void frmReviews_Load(object sender, EventArgs e)
        {
  

        }

        private void pnlModifyReview_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbxSearchReview_SelectedIndexChanged(object sender, EventArgs e)
        {
            reviewsController controller = new reviewsController();
            string destName = cbxSearchReview.Text;
            DataTable dataTable = controller.getDVG(destName);
            dgvReview.DataSource = dataTable;

            destinationController destinationController = new destinationController();
            destinationController.validDestinationLoad(destName);
            pbxReview.SizeMode = PictureBoxSizeMode.Zoom;
            try
            {
                pbxReview.Load(destinationController.getURL());
            }
            catch
            {

            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            reviewsController controller=new reviewsController();
            string destination = cbxCreateDestination.Text;
            string rating = txtCreateRating.Text;
            string comments = txtCreateComments.Text;
            controller.validReviewSave(curUsername,rating,comments,destination);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            reviewsController controller = new reviewsController();

            string destination = cbxModifyDestination.Text;
            string rating = txtModifyRating.Text;
            string comments = txtModifyComments.Text;
            string id = cbxReviewID.Text;
            bool status=controller.validReviewUpdate(id,curUsername,rating,comments,destination);

            if (status)
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Not deleted");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            reviewsController controller = new reviewsController();
            string id = cbxReviewID.Text;
            bool status =controller.validReviewDelete(id);
            if (status)
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Not deleted");
            }
        }

        private void btnSearchPage_Click(object sender, EventArgs e)
        {
            pnlCreateReview.Visible = false;
            pnlModifyReview.Visible = false;
            pnlSearch.Visible = true;

            destinationController controller = new destinationController();
            cbxSearchReview.Items.Clear();
            List<string> destinationNames = controller.getDestinationList();
            foreach (string curName in destinationNames)
            {
                //MessageBox.Show(curName);
                cbxSearchReview.Items.Add(curName);
            }
        }

        private void btnModifyPage_Click(object sender, EventArgs e)
        {
            pnlCreateReview.Visible = false;
            pnlModifyReview.Visible = true;
            pnlSearch.Visible = false;

            destinationController controller = new destinationController();
            cbxModifyDestination.Items.Clear();
            List<string> destinationNames = controller.getDestinationList();
            foreach (string curName in destinationNames)
            {
                //MessageBox.Show(curName);
                cbxModifyDestination.Items.Add(curName);
            }

            reviewsController controllerR = new reviewsController();
            cbxReviewID.Items.Clear();
            List<string> reviewIDs = controllerR.getReviewsList();
            foreach (string curName in reviewIDs)
            {
                //MessageBox.Show(curName);
                cbxReviewID.Items.Add(curName);
            }
        }

        private void btnCreatePage_Click(object sender, EventArgs e)
        {
            pnlCreateReview.Visible = true;
            pnlModifyReview.Visible = false;
            pnlSearch.Visible = false;

            destinationController controller = new destinationController();
            cbxCreateDestination.Items.Clear();
            List<string> destinationNames = controller.getDestinationList();
            foreach (string curName in destinationNames)
            {
                //MessageBox.Show(curName);
                cbxCreateDestination.Items.Add(curName);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome homePage = new frmHome();
            homePage.setUser(curUsername);
            this.Hide();
            homePage.Show();
        }

        private void dgvReview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

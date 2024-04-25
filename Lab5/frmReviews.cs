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
            // TODO: This line of code loads data into the 'lab5DBDataSet.reviews' table. You can move, or remove it, as needed.
            this.reviewsTableAdapter.Fill(this.lab5DBDataSet.reviews);

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
            pbxReview.Load(destinationController.getURL());
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
            controller.validReviewUpdate(id,curUsername,rating,comments,destination);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            reviewsController controller = new reviewsController();
            string id = cbxReviewID.Text;
            controller.validReviewDelete(id);
        }
    }
}

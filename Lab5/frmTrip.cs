using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class frmTrip : Form
    {
        private string curUsername;
        public void setUser(string username)
        {
            curUsername = username;
        }
        public frmTrip()
        {
            InitializeComponent();
        }

        private void frmTrip_Load(object sender, EventArgs e)
        {
            pageButtons();
        }
        private void pageButtons()
        {
            System.Windows.Forms.Button btnAddPage= new System.Windows.Forms.Button();
            btnAddPage.Location = new Point(10, 10);
            //btnAddPage.Size = new Size(100, 100);
            btnAddPage.Text = "Add Page";
            btnAddPage.Click += new EventHandler(addPage);
            Controls.Add(btnAddPage);

            System.Windows.Forms.Button btnModifyPage = new System.Windows.Forms.Button();
            btnModifyPage.Location = new Point(200, 10);
            btnModifyPage.Text = "Modify Page";
            btnModifyPage.Click += new EventHandler(modifyPage);
            Controls.Add(btnModifyPage);

            System.Windows.Forms.Button btnSearchPage = new System.Windows.Forms.Button();
            btnSearchPage.Location = new Point(500, 10);
            btnSearchPage.Text = "Search Page";
            btnSearchPage.Click += new EventHandler(searchPage);
            Controls.Add(btnSearchPage);
        }
        private void searchPage(object sender, EventArgs e)
        {
            CloseAllPanels();
            System.Windows.Forms.Panel pnlSearch = new System.Windows.Forms.Panel();
            pnlSearch.Location = new Point(10, 40);
            pnlSearch.Size = new System.Drawing.Size(600, 400);
            Controls.Add(pnlSearch);

            System.Windows.Forms.Label lblActivities = new System.Windows.Forms.Label();
            lblActivities.Text = "Destination:";
            lblActivities.Location = new Point(10, 200);
            pnlSearch.Controls.Add(lblActivities);

            System.Windows.Forms.ComboBox cbxDestination = new System.Windows.Forms.ComboBox();
            cbxDestination.Location = new Point(10, 225);
            destinationController dc = new destinationController();
            foreach (string curName in dc.getDestinationList())
            {
                cbxDestination.Items.Add(curName);
            }
            pnlSearch.Controls.Add(cbxDestination);

            cbxDestination.SelectedIndexChanged += new EventHandler(delegate (object senders, EventArgs es)
            {
                searchChange(sender, e, cbxDestination.Text, pnlSearch);
            });
        }
        private void searchChange(object sender, EventArgs e, string destination, Panel pnlSearch)
        {
            System.Windows.Forms.FlowLayoutPanel flpTrips = new System.Windows.Forms.FlowLayoutPanel();

            flpTrips.FlowDirection = FlowDirection.TopDown;
            flpTrips.WrapContents = true;
            flpTrips.AutoSize = true;

            destinationController dt = new destinationController();
            string URL = dt.getURL();

            tripController tc = new tripController();
            List<string> entries = tc.getAll(curUsername);

            foreach (string data in entries)
            {
                //MessageBox.Show(data);
                System.Windows.Forms.Label info = new System.Windows.Forms.Label();
                info.Text = data;
                info.AutoSize = true;

                PictureBox dPicture = new PictureBox();
                dPicture.SizeMode = PictureBoxSizeMode.AutoSize;
                try
                {
                    dPicture.Load(URL);
                }
                catch
                {

                }
                flpTrips.Controls.Add(info);
                flpTrips.Controls.Add(dPicture);
            }
            pnlSearch.Controls.Add(flpTrips);
        }
        private void addPage(object sender, EventArgs e)
        {   //None,txt,none,none,cbx,txt,none,none,txt,txt
            CloseAllPanels();
            System.Windows.Forms.Panel pnlAdd = new System.Windows.Forms.Panel();
            pnlAdd.Location = new Point(10, 40);
            pnlAdd.Size = new System.Drawing.Size(600,400);
            Controls.Add(pnlAdd);

            System.Windows.Forms.Button btnCreate = new System.Windows.Forms.Button();
            btnCreate.Location = new Point(300, 250);
            btnCreate.Text = "Create";
            pnlAdd.Controls.Add(btnCreate);

            /*
            System.Windows.Forms.TextBox txtDateStart = new System.Windows.Forms.TextBox();
            System.Windows.Forms.TextBox txtDateOver = new System.Windows.Forms.TextBox();
            System.Windows.Forms.TextBox txtCost = new System.Windows.Forms.TextBox();
            System.Windows.Forms.TextBox txtCare = new System.Windows.Forms.TextBox();
            System.Windows.Forms.CheckBox cbxActivities = new System.Windows.Forms.CheckBox();
            System.Windows.Forms.TextBox txtPriceFilter = new System.Windows.Forms.TextBox();*/

            System.Windows.Forms.Label lblDateStart = new System.Windows.Forms.Label();
            lblDateStart.Text = "Date Start:";
            lblDateStart.Location = new Point(10, 0);
            pnlAdd.Controls.Add(lblDateStart);

            System.Windows.Forms.TextBox txtDateStart = new System.Windows.Forms.TextBox();
            txtDateStart.Location = new Point(10, 25);
            pnlAdd.Controls.Add(txtDateStart);

            System.Windows.Forms.Label lblDateOver = new System.Windows.Forms.Label();
            lblDateOver.Text = "Date Over:";
            lblDateOver.Location = new Point(10, 50);
            pnlAdd.Controls.Add(lblDateOver);

            System.Windows.Forms.TextBox txtDateOver = new System.Windows.Forms.TextBox();
            txtDateOver.Location = new Point(10, 75);
            pnlAdd.Controls.Add(txtDateOver);

            System.Windows.Forms.Label lblCost = new System.Windows.Forms.Label();
            lblCost.Text = "Additional Cost:";
            lblCost.Location = new Point(10, 100);
            pnlAdd.Controls.Add(lblCost);

            System.Windows.Forms.TextBox txtCost = new System.Windows.Forms.TextBox();
            txtCost.Location = new Point(10, 125);
            pnlAdd.Controls.Add(txtCost);

            System.Windows.Forms.Label lblCare = new System.Windows.Forms.Label();
            lblCare.Text = "Care:";
            lblCare.Location = new Point(10, 150);
            pnlAdd.Controls.Add(lblCare);

            System.Windows.Forms.TextBox txtCare = new System.Windows.Forms.TextBox();
            txtCare.Location = new Point(10, 175);
            pnlAdd.Controls.Add(txtCare);

            System.Windows.Forms.Label lblActivities = new System.Windows.Forms.Label();
            lblActivities.Text = "Destination:";
            lblActivities.Location = new Point(10, 200);
            pnlAdd.Controls.Add(lblActivities);

            System.Windows.Forms.ComboBox cbxDestination = new System.Windows.Forms.ComboBox();
            cbxDestination.Location = new Point(10, 225);
            destinationController dc = new destinationController();
            foreach (string curName in dc.getDestinationList())
            {
                cbxDestination.Items.Add(curName);
            }
            pnlAdd.Controls.Add(cbxDestination);

            btnCreate.Click += new EventHandler(delegate (object senders, EventArgs es)
            {
                btnCreateClick(sender, e, cbxDestination.Text, txtCare.Text,txtCost.Text, txtDateOver.Text,txtDateStart.Text);
            });
        }
        private void modifyPage(object sender, EventArgs e)
        {
            CloseAllPanels();
            System.Windows.Forms.Panel pnlModify = new System.Windows.Forms.Panel();
            pnlModify.Location = new Point(10, 40);
            pnlModify.Size = new System.Drawing.Size(600, 400);
            Controls.Add(pnlModify);

            System.Windows.Forms.Button btnModify = new System.Windows.Forms.Button();
            btnModify.Location = new Point(300, 250);
            btnModify.Text = "Modify";
            pnlModify.Controls.Add(btnModify);
            System.Windows.Forms.Button btnDelete = new System.Windows.Forms.Button();
            btnDelete.Location = new Point(300, 300);
            btnDelete.Text = "Delete";
            pnlModify.Controls.Add(btnDelete);
            /*
            System.Windows.Forms.TextBox txtDateStart = new System.Windows.Forms.TextBox();
            System.Windows.Forms.TextBox txtDateOver = new System.Windows.Forms.TextBox();
            System.Windows.Forms.TextBox txtCost = new System.Windows.Forms.TextBox();
            System.Windows.Forms.TextBox txtCare = new System.Windows.Forms.TextBox();
            System.Windows.Forms.CheckBox cbxActivities = new System.Windows.Forms.CheckBox();
            System.Windows.Forms.TextBox txtPriceFilter = new System.Windows.Forms.TextBox();*/

            System.Windows.Forms.Label lblDateStart = new System.Windows.Forms.Label();
            lblDateStart.Text = "Date Start:";
            lblDateStart.Location = new Point(10, 0);
            pnlModify.Controls.Add(lblDateStart);

            System.Windows.Forms.TextBox txtDateStart = new System.Windows.Forms.TextBox();
            txtDateStart.Location = new Point(10, 25);
            pnlModify.Controls.Add(txtDateStart);

            System.Windows.Forms.Label lblDateOver = new System.Windows.Forms.Label();
            lblDateOver.Text = "Date Over:";
            lblDateOver.Location = new Point(10, 50);
            pnlModify.Controls.Add(lblDateOver);

            System.Windows.Forms.TextBox txtDateOver = new System.Windows.Forms.TextBox();
            txtDateOver.Location = new Point(10, 75);
            pnlModify.Controls.Add(txtDateOver);

            System.Windows.Forms.Label lblCost = new System.Windows.Forms.Label();
            lblCost.Text = "Additional Cost:";
            lblCost.Location = new Point(10, 100);
            pnlModify.Controls.Add(lblCost);

            System.Windows.Forms.TextBox txtCost = new System.Windows.Forms.TextBox();
            txtCost.Location = new Point(10, 125);
            pnlModify.Controls.Add(txtCost);

            System.Windows.Forms.Label lblCare = new System.Windows.Forms.Label();
            lblCare.Text = "Care:";
            lblCare.Location = new Point(10, 150);
            pnlModify.Controls.Add(lblCare);

            System.Windows.Forms.TextBox txtCare = new System.Windows.Forms.TextBox();
            txtCare.Location = new Point(10, 175);
            pnlModify.Controls.Add(txtCare);

            System.Windows.Forms.Label lblActivities = new System.Windows.Forms.Label();
            lblActivities.Text = "Destination:";
            lblActivities.Location = new Point(10, 200);
            pnlModify.Controls.Add(lblActivities);

            System.Windows.Forms.ComboBox cbxDestination = new System.Windows.Forms.ComboBox();
            cbxDestination.Location = new Point(10, 225);
            destinationController dc= new destinationController();
            foreach(string curName in dc.getDestinationList())
            {
                cbxDestination.Items.Add(curName);
            }
            pnlModify.Controls.Add(cbxDestination);

            System.Windows.Forms.Label lblStatus = new System.Windows.Forms.Label();
            lblStatus.Text = "Status:";
            lblStatus.Location = new Point(10, 250);
            pnlModify.Controls.Add(lblStatus);

            System.Windows.Forms.TextBox txtStatuts = new System.Windows.Forms.TextBox();
            txtStatuts.Location = new Point(10, 275);
            pnlModify.Controls.Add(txtStatuts);

            System.Windows.Forms.Label lblId = new System.Windows.Forms.Label();
            lblId.Text = "ID:";
            lblId.Location = new Point(200, 200);
            pnlModify.Controls.Add(lblId);

            System.Windows.Forms.ComboBox cbxId = new System.Windows.Forms.ComboBox();
            cbxId.Location = new Point(200, 225);
            tripController tc = new tripController();
            foreach (string curName in tc.findIdUser(curUsername))
            {
                cbxDestination.Items.Add(curName);
            }
            pnlModify.Controls.Add(cbxId);

            btnModify.Click += new EventHandler(delegate (object senders, EventArgs es)
            {
                btnModifyClick(sender, e, cbxDestination.Text, txtCare.Text, txtCost.Text, txtDateOver.Text, txtDateStart.Text, txtStatuts.Text, cbxId.Text);
            });

            btnDelete.Click += new EventHandler(delegate (object senders, EventArgs es)
            {
                btnDeleteClick(sender, e, cbxId.Text);
            });
        }
        public void btnDeleteClick(object sender, EventArgs e, string id)
        {
            tripController tc = new tripController();
            bool x =tc.validTripDelete(id);
            if (x)
            {
                MessageBox.Show("Trip deleted");
            }
            else
            {
                MessageBox.Show("Trip not deleted");
            }
        }
        public void btnCreateClick(object sender, EventArgs e,string destination, string care, string cost, string dateOver, string dateStart)
        {
            
            travelerController controlerTr = new travelerController();
            bool travelerLoaded = controlerTr.validTravelerLoad(curUsername);
            if(travelerLoaded)
            {
                tripController controllerT = new tripController();
                string accomedations = controlerTr.getAccomedations();
                destinationController controllerD = new destinationController();
                controllerD.validDestinationLoad(destination);
                string activities = controllerD.getActivities();
                bool tripCreated=controllerT.validTripSave(dateStart, activities, destination,accomedations, cost, curUsername, "Planned", care, dateOver);
//(string dateMade, string activities, string accomendations, string destination, string additionalCost, string tName, string status, string careTaker, string dateOver)
                if (tripCreated)
                {
                    controllerT.sendEmail(curUsername);
                    MessageBox.Show("Trip created, check your email!");
                }
            }
            else
            {
                MessageBox.Show("Invalid login");
            }
        }
        public void btnModifyClick(object sender, EventArgs e, string destination, string care, string cost, string dateOver, string dateStart, string status, string id)
        {

            travelerController controlerTr = new travelerController();
            bool travelerLoaded = controlerTr.validTravelerLoad(curUsername);
            if (travelerLoaded)
            {
                tripController controllerT = new tripController();
                string accomedations = controlerTr.getAccomedations();
                destinationController controllerD = new destinationController();
                controllerD.validDestinationLoad(destination);
                string activities = controllerD.getActivities();
                bool tripCreated = controllerT.validTripUpdate(id, dateStart, activities, destination, accomedations, cost, curUsername, status, care, dateOver);
                //(string dateMade, string activities, string accomendations, string destination, string additionalCost, string tName, string status, string careTaker, string dateOver)
                if (tripCreated)
                {
                    controllerT.sendEmail(curUsername);
                    MessageBox.Show("Trip modified, check your email!");
                }
            }
            else
            {
                MessageBox.Show("Invalid login");
            }
        }
        private void CloseAllPanels()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Panel panel)
                {
                    panel.Hide();
                }
            }
        }

    }
}
/*
 System.Windows.Forms.TextBox txtUsername = new System.Windows.Forms.TextBox();
            txtUsername.Location = new Point(10, 10);
            txtUsername.Text = "Usermane";
            pnlLogin.Controls.Add(txtUsername);
            txtUsername.Click += new EventHandler(clearTxtBox);

 
 */
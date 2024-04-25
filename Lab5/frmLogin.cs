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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Lab5
{
    public partial class frmLogin : Form
    {
        private string curUserName;
        public string activeUser()
        {
            return curUserName;
        }

        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            pnlLogin.Visible = true;
            pnlSignup.Visible = false;
            pnlSettings.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            travelerController controller = new travelerController();
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            bool inputValid = controller.validTravelerLoad(username);
            bool passwordCheck = controller.passwordCheck(password);
            //MessageBox.Show(inputValid.ToString());
            if (inputValid && passwordCheck)
            {
                //trigger the home page
                pnlLogin.Visible = false;
                pnlSignup.Visible = false;
                pnlSettings.Visible = true;
                curUserName = username;
                MessageBox.Show("Logged In");
            }
            else
            {
                MessageBox.Show("Username/Password not found. Try again or sign up");
            }
        }
        private void btnSignup_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = false;
            pnlSignup.Visible = true;
            pnlSettings.Visible = false;
        }
        private void lblPreferences_Click(object sender, EventArgs e)
        {

        }
        private void btnCreateAcct_Click(object sender, EventArgs e)
        {
            travelerController controller = new travelerController();
            string username = txtSignupName.Text;
            string password = txtSignupPassword.Text;
            string email = txtEmail.Text;
            string preferences = txtPreferences.Text;
            bool saved=controller.validTravelerSave(username, email, preferences, password);
            if (saved)
            {
                MessageBox.Show("Account Created");
                curUserName = username;
                pnlLogin.Visible = false;
                pnlSignup.Visible = false;
                pnlSettings.Visible = true;
            }
            else
            {
                MessageBox.Show("Account Not Created, password needs atleast 1 letter");
            }
        }
        private void pnlSettings_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            travelerController controller = new travelerController();
            string password = txtSettingsPassword.Text;
            string email = txtSettingsEmail.Text;
            string preferences = txtSettingsPreferences.Text;
            //MessageBox.Show(curUserName);
            bool saved = controller.validTravelerUpdate(curUserName, email, preferences,password);
            if (saved)
            {
                MessageBox.Show("Settings Saved");
            }
            else
            {
                MessageBox.Show("Settings Not saved, password needs 1 character atleast");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            travelerController controller = new travelerController();
            bool deleted = controller.validTravelerDelete(curUserName);
            if (deleted)
            {
                MessageBox.Show("User Deleted");
                pnlLogin.Visible = true;
                pnlSignup.Visible = false;
                pnlSettings.Visible = false;
            }
            else
            {
                MessageBox.Show("User Not Deleted");
            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome homePage = new frmHome();
            homePage.setUser(curUserName);
            this.Hide();
            homePage.Show();
        }
    }
}

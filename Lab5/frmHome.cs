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
    public partial class frmHome : Form
    {
        private string curUsername;
        public void setUser(string username)
        {
            curUsername = username;
        }
        /*public string usernameCheck
        {
            get { return curUsername; }  // Getter method
            set { curUsername = value; }  // Setter method
        }*/
        public frmHome()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(curUsername))
            {
                btnDestinationPage.Enabled = false;
                btnReview.Enabled = false;
                btnTrip.Enabled = false;
            }
            else
            {
                btnDestinationPage.Enabled = true;
                btnReview.Enabled = true;
                btnTrip.Enabled = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin loginPage = new frmLogin();
            this.Hide();
            loginPage.Show();
        }

        private void btnDestinationPage_Click(object sender, EventArgs e)
        {
            frmDestination destinationPage = new frmDestination();
            destinationPage.setUser(curUsername);
            this.Hide();
            destinationPage.Show();
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            frmReviews reviewPage = new frmReviews();
            reviewPage.setUser(curUsername);
            this.Hide();
            reviewPage.Show();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            tripController controller = new tripController();
            controller.sendEmail("works");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmTrip tripPage = new frmTrip();
            tripPage.setUser(curUsername);
            this.Hide();
            tripPage.Show();
        }
    }
}

/*
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loginPanel();
        }
        private void btnSignUpClick(object sender, EventArgs e)
        {
            pnlLogin.Visible = false;
            pnlSignup.Visible = true;
            signupPanel();
        }
        private void signupPanel()
        {
            System.Windows.Forms.TextBox txtUsername = new System.Windows.Forms.TextBox();
            txtUsername.Location = new Point(10, 10);
            txtUsername.Text = "Usermane";
            pnlLogin.Controls.Add(txtUsername);
            txtUsername.Click += new EventHandler(clearTxtBox);

            System.Windows.Forms.TextBox txtPassword = new System.Windows.Forms.TextBox();
            //txtPassword.PasswordChar = '*';       //You didnt teach this in class so I just commented it out
            txtPassword.Location = new Point(10, 40);
            txtPassword.Text = "Password";
            pnlLogin.Controls.Add(txtPassword);
            txtPassword.Click += new EventHandler(clearTxtBox);

            System.Windows.Forms.TextBox txtPassword = new System.Windows.Forms.TextBox();
            //txtPassword.PasswordChar = '*';       //You didnt teach this in class so I just commented it out
            txtPassword.Location = new Point(10, 40);
            txtPassword.Text = "Password";
            pnlLogin.Controls.Add(txtPassword);
            txtPassword.Click += new EventHandler(clearTxtBox);

            System.Windows.Forms.Button btnSignUp = new System.Windows.Forms.Button();
            btnSignUp.Location = new Point(10, 100);
            btnSignUp.Text = "Signup";
            pnlLogin.Controls.Add(btnSignUp);
            btnSignUp.Click += new EventHandler(delegate (object sender, EventArgs e)
            {
                btnSignUpClick(sender, e);
            });
        }
        private void loginPanel()
        {
            System.Windows.Forms.TextBox txtUsername = new System.Windows.Forms.TextBox();
            txtUsername.Location = new Point(10, 10);
            txtUsername.Text = "Usermane";
            pnlLogin.Controls.Add(txtUsername);
            txtUsername.Click += new EventHandler(clearTxtBox);

            System.Windows.Forms.TextBox txtPassword = new System.Windows.Forms.TextBox();
            //txtPassword.PasswordChar = '*';       //You didnt teach this in class so I just commented it out
            txtPassword.Location = new Point(10, 40);
            txtPassword.Text = "Password";
            pnlLogin.Controls.Add(txtPassword);
            txtPassword.Click += new EventHandler(clearTxtBox);

            System.Windows.Forms.Button btnLogin = new System.Windows.Forms.Button();
            btnLogin.Location = new Point(10, 70);
            btnLogin.Text = "Login";
            pnlLogin.Controls.Add(btnLogin);
            btnLogin.Click += new EventHandler(delegate (object sender, EventArgs e)
            {
                btnLoginClick(sender, e, txtUsername.Text, txtPassword.Text); //I honestly have no idea if we learned this in class but I needed it to make it all dynamic
            });

            System.Windows.Forms.Button btnSignUp = new System.Windows.Forms.Button();
            btnSignUp.Location = new Point(10, 100);
            btnSignUp.Text = "Signup";
            pnlLogin.Controls.Add(btnSignUp);
            btnSignUp.Click += new EventHandler(delegate (object sender, EventArgs e)
            {
                btnSignUpClick(sender, e);
            });
        }
        private void btnLoginClick(object sender, EventArgs e, string username, string password)
        {
            travelerController controller = new travelerController();
            bool inputValid = controller.validTravelerLoad(username);
            bool passwordCheck = controller.passwordCheck(password);
            //MessageBox.Show(inputValid.ToString());
            if (inputValid && passwordCheck)
            {
                //trigger the home page
            }
            else
            {
                MessageBox.Show("Username/Password not found. Try again or sign up");
            }
        }
        private void clearTxtBox(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox clickedTxtBox = (System.Windows.Forms.TextBox)sender;
            clickedTxtBox.Clear();
        }
    }
}

 
 
 
 
 */
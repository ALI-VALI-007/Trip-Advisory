namespace Lab5
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lab5DBDataSet1 = new Lab5.lab5DBDataSet();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSignup = new System.Windows.Forms.Button();
            this.pnlSignup = new System.Windows.Forms.Panel();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.btnCreateAcct = new System.Windows.Forms.Button();
            this.lblSignupName = new System.Windows.Forms.Label();
            this.lblSignupPassword = new System.Windows.Forms.Label();
            this.txtSignupName = new System.Windows.Forms.TextBox();
            this.txtSignupPassword = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPreferences = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPreferences = new System.Windows.Forms.TextBox();
            this.lblSettingsEmail = new System.Windows.Forms.Label();
            this.lblSettingsPreferences = new System.Windows.Forms.Label();
            this.txtSettingsEmail = new System.Windows.Forms.TextBox();
            this.txtSettingsPreferences = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSettingsPassword = new System.Windows.Forms.Label();
            this.txtSettingsPassword = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lab5DBDataSet1)).BeginInit();
            this.pnlLogin.SuspendLayout();
            this.pnlSignup.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(49, 61);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 22);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(49, 105);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 1;
            // 
            // lab5DBDataSet1
            // 
            this.lab5DBDataSet1.DataSetName = "lab5DBDataSet";
            this.lab5DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(71, 42);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(47, 16);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Name:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(61, 86);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 16);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.btnSignup);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.lblUsername);
            this.pnlLogin.Controls.Add(this.lblPassword);
            this.pnlLogin.Controls.Add(this.txtUsername);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Location = new System.Drawing.Point(296, 69);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(200, 269);
            this.pnlLogin.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(56, 142);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 34);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSignup
            // 
            this.btnSignup.Location = new System.Drawing.Point(56, 182);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(75, 34);
            this.btnSignup.TabIndex = 6;
            this.btnSignup.Text = "Signup";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // pnlSignup
            // 
            this.pnlSignup.Controls.Add(this.lblEmail);
            this.pnlSignup.Controls.Add(this.lblPreferences);
            this.pnlSignup.Controls.Add(this.txtEmail);
            this.pnlSignup.Controls.Add(this.txtPreferences);
            this.pnlSignup.Controls.Add(this.btnCreateAcct);
            this.pnlSignup.Controls.Add(this.lblSignupName);
            this.pnlSignup.Controls.Add(this.lblSignupPassword);
            this.pnlSignup.Controls.Add(this.txtSignupName);
            this.pnlSignup.Controls.Add(this.txtSignupPassword);
            this.pnlSignup.Location = new System.Drawing.Point(242, 59);
            this.pnlSignup.Name = "pnlSignup";
            this.pnlSignup.Size = new System.Drawing.Size(324, 266);
            this.pnlSignup.TabIndex = 7;
            // 
            // pnlSettings
            // 
            this.pnlSettings.Controls.Add(this.btnHome);
            this.pnlSettings.Controls.Add(this.btnDelete);
            this.pnlSettings.Controls.Add(this.lblSettingsEmail);
            this.pnlSettings.Controls.Add(this.lblSettingsPreferences);
            this.pnlSettings.Controls.Add(this.txtSettingsEmail);
            this.pnlSettings.Controls.Add(this.txtSettingsPreferences);
            this.pnlSettings.Controls.Add(this.btnSave);
            this.pnlSettings.Controls.Add(this.lblSettingsPassword);
            this.pnlSettings.Controls.Add(this.txtSettingsPassword);
            this.pnlSettings.Location = new System.Drawing.Point(49, 69);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(704, 266);
            this.pnlSettings.TabIndex = 8;
            this.pnlSettings.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSettings_Paint);
            // 
            // btnCreateAcct
            // 
            this.btnCreateAcct.Location = new System.Drawing.Point(119, 219);
            this.btnCreateAcct.Name = "btnCreateAcct";
            this.btnCreateAcct.Size = new System.Drawing.Size(75, 34);
            this.btnCreateAcct.TabIndex = 12;
            this.btnCreateAcct.Text = "Create";
            this.btnCreateAcct.UseVisualStyleBackColor = true;
            this.btnCreateAcct.Click += new System.EventHandler(this.btnCreateAcct_Click);
            // 
            // lblSignupName
            // 
            this.lblSignupName.AutoSize = true;
            this.lblSignupName.Location = new System.Drawing.Point(136, 13);
            this.lblSignupName.Name = "lblSignupName";
            this.lblSignupName.Size = new System.Drawing.Size(47, 16);
            this.lblSignupName.TabIndex = 9;
            this.lblSignupName.Text = "Name:";
            // 
            // lblSignupPassword
            // 
            this.lblSignupPassword.AutoSize = true;
            this.lblSignupPassword.Location = new System.Drawing.Point(124, 57);
            this.lblSignupPassword.Name = "lblSignupPassword";
            this.lblSignupPassword.Size = new System.Drawing.Size(70, 16);
            this.lblSignupPassword.TabIndex = 10;
            this.lblSignupPassword.Text = "Password:";
            // 
            // txtSignupName
            // 
            this.txtSignupName.Location = new System.Drawing.Point(112, 32);
            this.txtSignupName.Name = "txtSignupName";
            this.txtSignupName.Size = new System.Drawing.Size(100, 22);
            this.txtSignupName.TabIndex = 7;
            // 
            // txtSignupPassword
            // 
            this.txtSignupPassword.Location = new System.Drawing.Point(112, 76);
            this.txtSignupPassword.Name = "txtSignupPassword";
            this.txtSignupPassword.Size = new System.Drawing.Size(100, 22);
            this.txtSignupPassword.TabIndex = 8;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(136, 102);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Email:";
            // 
            // lblPreferences
            // 
            this.lblPreferences.AutoSize = true;
            this.lblPreferences.Location = new System.Drawing.Point(117, 146);
            this.lblPreferences.Name = "lblPreferences";
            this.lblPreferences.Size = new System.Drawing.Size(83, 16);
            this.lblPreferences.TabIndex = 16;
            this.lblPreferences.Text = "Preferences:";
            this.lblPreferences.Click += new System.EventHandler(this.lblPreferences_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(112, 121);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 13;
            // 
            // txtPreferences
            // 
            this.txtPreferences.Location = new System.Drawing.Point(3, 168);
            this.txtPreferences.Name = "txtPreferences";
            this.txtPreferences.Size = new System.Drawing.Size(318, 22);
            this.txtPreferences.TabIndex = 14;
            // 
            // lblSettingsEmail
            // 
            this.lblSettingsEmail.AutoSize = true;
            this.lblSettingsEmail.Location = new System.Drawing.Point(326, 102);
            this.lblSettingsEmail.Name = "lblSettingsEmail";
            this.lblSettingsEmail.Size = new System.Drawing.Size(44, 16);
            this.lblSettingsEmail.TabIndex = 24;
            this.lblSettingsEmail.Text = "Email:";
            // 
            // lblSettingsPreferences
            // 
            this.lblSettingsPreferences.AutoSize = true;
            this.lblSettingsPreferences.Location = new System.Drawing.Point(307, 146);
            this.lblSettingsPreferences.Name = "lblSettingsPreferences";
            this.lblSettingsPreferences.Size = new System.Drawing.Size(83, 16);
            this.lblSettingsPreferences.TabIndex = 25;
            this.lblSettingsPreferences.Text = "Preferences:";
            // 
            // txtSettingsEmail
            // 
            this.txtSettingsEmail.Location = new System.Drawing.Point(302, 121);
            this.txtSettingsEmail.Name = "txtSettingsEmail";
            this.txtSettingsEmail.Size = new System.Drawing.Size(100, 22);
            this.txtSettingsEmail.TabIndex = 22;
            // 
            // txtSettingsPreferences
            // 
            this.txtSettingsPreferences.Location = new System.Drawing.Point(193, 168);
            this.txtSettingsPreferences.Name = "txtSettingsPreferences";
            this.txtSettingsPreferences.Size = new System.Drawing.Size(318, 22);
            this.txtSettingsPreferences.TabIndex = 23;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(193, 222);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 34);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSettingsPassword
            // 
            this.lblSettingsPassword.AutoSize = true;
            this.lblSettingsPassword.Location = new System.Drawing.Point(314, 57);
            this.lblSettingsPassword.Name = "lblSettingsPassword";
            this.lblSettingsPassword.Size = new System.Drawing.Size(70, 16);
            this.lblSettingsPassword.TabIndex = 20;
            this.lblSettingsPassword.Text = "Password:";
            // 
            // txtSettingsPassword
            // 
            this.txtSettingsPassword.Location = new System.Drawing.Point(302, 76);
            this.txtSettingsPassword.Name = "txtSettingsPassword";
            this.txtSettingsPassword.Size = new System.Drawing.Size(100, 22);
            this.txtSettingsPassword.TabIndex = 18;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(310, 222);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 34);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(433, 222);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 34);
            this.btnHome.TabIndex = 27;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlSignup);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.pnlLogin);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lab5DBDataSet1)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlSignup.ResumeLayout(false);
            this.pnlSignup.PerformLayout();
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private lab5DBDataSet lab5DBDataSet1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Panel pnlSignup;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Button btnCreateAcct;
        private System.Windows.Forms.Label lblSignupName;
        private System.Windows.Forms.Label lblSignupPassword;
        private System.Windows.Forms.TextBox txtSignupName;
        private System.Windows.Forms.TextBox txtSignupPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPreferences;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPreferences;
        private System.Windows.Forms.Label lblSettingsEmail;
        private System.Windows.Forms.Label lblSettingsPreferences;
        private System.Windows.Forms.TextBox txtSettingsEmail;
        private System.Windows.Forms.TextBox txtSettingsPreferences;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSettingsPassword;
        private System.Windows.Forms.TextBox txtSettingsPassword;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnHome;
    }
}
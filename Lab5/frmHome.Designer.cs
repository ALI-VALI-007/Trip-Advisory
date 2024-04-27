namespace Lab5
{
    partial class frmHome
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
            this.btnLoginSettings = new System.Windows.Forms.Button();
            this.btnDestinationPage = new System.Windows.Forms.Button();
            this.btnReview = new System.Windows.Forms.Button();
            this.btnTrip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoginSettings
            // 
            this.btnLoginSettings.Location = new System.Drawing.Point(644, 32);
            this.btnLoginSettings.Name = "btnLoginSettings";
            this.btnLoginSettings.Size = new System.Drawing.Size(127, 49);
            this.btnLoginSettings.TabIndex = 0;
            this.btnLoginSettings.Text = "Login Settings";
            this.btnLoginSettings.UseVisualStyleBackColor = true;
            this.btnLoginSettings.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDestinationPage
            // 
            this.btnDestinationPage.Location = new System.Drawing.Point(449, 32);
            this.btnDestinationPage.Name = "btnDestinationPage";
            this.btnDestinationPage.Size = new System.Drawing.Size(127, 49);
            this.btnDestinationPage.TabIndex = 1;
            this.btnDestinationPage.Text = "Destination Management";
            this.btnDestinationPage.UseVisualStyleBackColor = true;
            this.btnDestinationPage.Click += new System.EventHandler(this.btnDestinationPage_Click);
            // 
            // btnReview
            // 
            this.btnReview.Location = new System.Drawing.Point(243, 32);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(127, 49);
            this.btnReview.TabIndex = 2;
            this.btnReview.Text = "Review Management";
            this.btnReview.UseVisualStyleBackColor = true;
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // btnTrip
            // 
            this.btnTrip.Location = new System.Drawing.Point(58, 32);
            this.btnTrip.Name = "btnTrip";
            this.btnTrip.Size = new System.Drawing.Size(114, 49);
            this.btnTrip.TabIndex = 4;
            this.btnTrip.Text = "Trip";
            this.btnTrip.UseVisualStyleBackColor = true;
            this.btnTrip.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTrip);
            this.Controls.Add(this.btnReview);
            this.Controls.Add(this.btnDestinationPage);
            this.Controls.Add(this.btnLoginSettings);
            this.Name = "frmHome";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoginSettings;
        private System.Windows.Forms.Button btnDestinationPage;
        private System.Windows.Forms.Button btnReview;
        private System.Windows.Forms.Button btnTrip;
    }
}


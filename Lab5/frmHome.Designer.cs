﻿namespace Lab5
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
            this.btnDestinationPage.Location = new System.Drawing.Point(463, 32);
            this.btnDestinationPage.Name = "btnDestinationPage";
            this.btnDestinationPage.Size = new System.Drawing.Size(127, 49);
            this.btnDestinationPage.TabIndex = 1;
            this.btnDestinationPage.Text = "Destination Management";
            this.btnDestinationPage.UseVisualStyleBackColor = true;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}


namespace Lab5
{
    partial class frmDestination
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
            this.pnlCreateDestination = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlCreateDestination
            // 
            this.pnlCreateDestination.Location = new System.Drawing.Point(155, 96);
            this.pnlCreateDestination.Name = "pnlCreateDestination";
            this.pnlCreateDestination.Size = new System.Drawing.Size(464, 266);
            this.pnlCreateDestination.TabIndex = 0;
            // 
            // frmDestination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlCreateDestination);
            this.Name = "frmDestination";
            this.Text = "frmDestination";
            this.Load += new System.EventHandler(this.frmDestination_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCreateDestination;
    }
}
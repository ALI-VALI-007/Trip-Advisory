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
            this.components = new System.ComponentModel.Container();
            this.pnlCreateDestination = new System.Windows.Forms.Panel();
            this.lblCreationName = new System.Windows.Forms.Label();
            this.txtCreationName = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtCreationLocation = new System.Windows.Forms.TextBox();
            this.lblCreationLocation = new System.Windows.Forms.Label();
            this.txtCreationCost = new System.Windows.Forms.TextBox();
            this.lblCreationCost = new System.Windows.Forms.Label();
            this.txtCreationURL = new System.Windows.Forms.TextBox();
            this.lblCreationURL = new System.Windows.Forms.Label();
            this.pnlModify = new System.Windows.Forms.Panel();
            this.txtModifyURL = new System.Windows.Forms.TextBox();
            this.lblModifyURL = new System.Windows.Forms.Label();
            this.txtModifyCost = new System.Windows.Forms.TextBox();
            this.lblModifyCost = new System.Windows.Forms.Label();
            this.txtModifyLocation = new System.Windows.Forms.TextBox();
            this.lblModifyLocation = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.lblModifyDestination = new System.Windows.Forms.Label();
            this.cbxModifyDestination = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreatePage = new System.Windows.Forms.Button();
            this.btnModifyPage = new System.Windows.Forms.Button();
            this.btnSearchPage = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.dgvSearchDestination = new System.Windows.Forms.DataGridView();
            this.lab5DBDataSet = new Lab5.lab5DBDataSet();
            this.destinationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.destinationsTableAdapter = new Lab5.lab5DBDataSetTableAdapters.destinationsTableAdapter();
            this.destinationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxSearchDestination = new System.Windows.Forms.ComboBox();
            this.lblSearchDestination = new System.Windows.Forms.Label();
            this.pbxDestinationPicture = new System.Windows.Forms.PictureBox();
            this.pnlCreateDestination.SuspendLayout();
            this.pnlModify.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchDestination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab5DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDestinationPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCreateDestination
            // 
            this.pnlCreateDestination.Controls.Add(this.txtCreationURL);
            this.pnlCreateDestination.Controls.Add(this.lblCreationURL);
            this.pnlCreateDestination.Controls.Add(this.txtCreationCost);
            this.pnlCreateDestination.Controls.Add(this.lblCreationCost);
            this.pnlCreateDestination.Controls.Add(this.txtCreationLocation);
            this.pnlCreateDestination.Controls.Add(this.lblCreationLocation);
            this.pnlCreateDestination.Controls.Add(this.btnCreate);
            this.pnlCreateDestination.Controls.Add(this.txtCreationName);
            this.pnlCreateDestination.Controls.Add(this.lblCreationName);
            this.pnlCreateDestination.Location = new System.Drawing.Point(162, 99);
            this.pnlCreateDestination.Name = "pnlCreateDestination";
            this.pnlCreateDestination.Size = new System.Drawing.Size(464, 266);
            this.pnlCreateDestination.TabIndex = 0;
            // 
            // lblCreationName
            // 
            this.lblCreationName.AutoSize = true;
            this.lblCreationName.Location = new System.Drawing.Point(66, 25);
            this.lblCreationName.Name = "lblCreationName";
            this.lblCreationName.Size = new System.Drawing.Size(117, 16);
            this.lblCreationName.TabIndex = 0;
            this.lblCreationName.Text = "Destination Name:";
            // 
            // txtCreationName
            // 
            this.txtCreationName.Location = new System.Drawing.Point(69, 44);
            this.txtCreationName.Name = "txtCreationName";
            this.txtCreationName.Size = new System.Drawing.Size(100, 22);
            this.txtCreationName.TabIndex = 1;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(191, 213);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtCreationLocation
            // 
            this.txtCreationLocation.Location = new System.Drawing.Point(273, 44);
            this.txtCreationLocation.Name = "txtCreationLocation";
            this.txtCreationLocation.Size = new System.Drawing.Size(100, 22);
            this.txtCreationLocation.TabIndex = 4;
            // 
            // lblCreationLocation
            // 
            this.lblCreationLocation.AutoSize = true;
            this.lblCreationLocation.Location = new System.Drawing.Point(270, 25);
            this.lblCreationLocation.Name = "lblCreationLocation";
            this.lblCreationLocation.Size = new System.Drawing.Size(61, 16);
            this.lblCreationLocation.TabIndex = 3;
            this.lblCreationLocation.Text = "Location:";
            // 
            // txtCreationCost
            // 
            this.txtCreationCost.Location = new System.Drawing.Point(69, 133);
            this.txtCreationCost.Name = "txtCreationCost";
            this.txtCreationCost.Size = new System.Drawing.Size(100, 22);
            this.txtCreationCost.TabIndex = 6;
            // 
            // lblCreationCost
            // 
            this.lblCreationCost.AutoSize = true;
            this.lblCreationCost.Location = new System.Drawing.Point(66, 114);
            this.lblCreationCost.Name = "lblCreationCost";
            this.lblCreationCost.Size = new System.Drawing.Size(37, 16);
            this.lblCreationCost.TabIndex = 5;
            this.lblCreationCost.Text = "Cost:";
            // 
            // txtCreationURL
            // 
            this.txtCreationURL.Location = new System.Drawing.Point(273, 133);
            this.txtCreationURL.Name = "txtCreationURL";
            this.txtCreationURL.Size = new System.Drawing.Size(100, 22);
            this.txtCreationURL.TabIndex = 8;
            // 
            // lblCreationURL
            // 
            this.lblCreationURL.AutoSize = true;
            this.lblCreationURL.Location = new System.Drawing.Point(270, 114);
            this.lblCreationURL.Name = "lblCreationURL";
            this.lblCreationURL.Size = new System.Drawing.Size(37, 16);
            this.lblCreationURL.TabIndex = 7;
            this.lblCreationURL.Text = "URL:";
            // 
            // pnlModify
            // 
            this.pnlModify.Controls.Add(this.btnDelete);
            this.pnlModify.Controls.Add(this.cbxModifyDestination);
            this.pnlModify.Controls.Add(this.txtModifyURL);
            this.pnlModify.Controls.Add(this.lblModifyURL);
            this.pnlModify.Controls.Add(this.txtModifyCost);
            this.pnlModify.Controls.Add(this.lblModifyCost);
            this.pnlModify.Controls.Add(this.txtModifyLocation);
            this.pnlModify.Controls.Add(this.lblModifyLocation);
            this.pnlModify.Controls.Add(this.btnModify);
            this.pnlModify.Controls.Add(this.lblModifyDestination);
            this.pnlModify.Location = new System.Drawing.Point(118, 124);
            this.pnlModify.Name = "pnlModify";
            this.pnlModify.Size = new System.Drawing.Size(558, 286);
            this.pnlModify.TabIndex = 9;
            this.pnlModify.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtModifyURL
            // 
            this.txtModifyURL.Location = new System.Drawing.Point(333, 146);
            this.txtModifyURL.Name = "txtModifyURL";
            this.txtModifyURL.Size = new System.Drawing.Size(100, 22);
            this.txtModifyURL.TabIndex = 17;
            // 
            // lblModifyURL
            // 
            this.lblModifyURL.AutoSize = true;
            this.lblModifyURL.Location = new System.Drawing.Point(330, 127);
            this.lblModifyURL.Name = "lblModifyURL";
            this.lblModifyURL.Size = new System.Drawing.Size(37, 16);
            this.lblModifyURL.TabIndex = 16;
            this.lblModifyURL.Text = "URL:";
            // 
            // txtModifyCost
            // 
            this.txtModifyCost.Location = new System.Drawing.Point(129, 146);
            this.txtModifyCost.Name = "txtModifyCost";
            this.txtModifyCost.Size = new System.Drawing.Size(100, 22);
            this.txtModifyCost.TabIndex = 15;
            // 
            // lblModifyCost
            // 
            this.lblModifyCost.AutoSize = true;
            this.lblModifyCost.Location = new System.Drawing.Point(126, 127);
            this.lblModifyCost.Name = "lblModifyCost";
            this.lblModifyCost.Size = new System.Drawing.Size(37, 16);
            this.lblModifyCost.TabIndex = 14;
            this.lblModifyCost.Text = "Cost:";
            // 
            // txtModifyLocation
            // 
            this.txtModifyLocation.Location = new System.Drawing.Point(333, 57);
            this.txtModifyLocation.Name = "txtModifyLocation";
            this.txtModifyLocation.Size = new System.Drawing.Size(100, 22);
            this.txtModifyLocation.TabIndex = 13;
            // 
            // lblModifyLocation
            // 
            this.lblModifyLocation.AutoSize = true;
            this.lblModifyLocation.Location = new System.Drawing.Point(330, 38);
            this.lblModifyLocation.Name = "lblModifyLocation";
            this.lblModifyLocation.Size = new System.Drawing.Size(61, 16);
            this.lblModifyLocation.TabIndex = 12;
            this.lblModifyLocation.Text = "Location:";
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(168, 218);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 11;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // lblModifyDestination
            // 
            this.lblModifyDestination.AutoSize = true;
            this.lblModifyDestination.Location = new System.Drawing.Point(126, 38);
            this.lblModifyDestination.Name = "lblModifyDestination";
            this.lblModifyDestination.Size = new System.Drawing.Size(117, 16);
            this.lblModifyDestination.TabIndex = 9;
            this.lblModifyDestination.Text = "Destination Name:";
            // 
            // cbxModifyDestination
            // 
            this.cbxModifyDestination.FormattingEnabled = true;
            this.cbxModifyDestination.Location = new System.Drawing.Point(129, 57);
            this.cbxModifyDestination.Name = "cbxModifyDestination";
            this.cbxModifyDestination.Size = new System.Drawing.Size(100, 24);
            this.cbxModifyDestination.TabIndex = 18;
            this.cbxModifyDestination.SelectedIndexChanged += new System.EventHandler(this.cbxModifyDestination_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(333, 218);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreatePage
            // 
            this.btnCreatePage.Location = new System.Drawing.Point(178, 34);
            this.btnCreatePage.Name = "btnCreatePage";
            this.btnCreatePage.Size = new System.Drawing.Size(75, 44);
            this.btnCreatePage.TabIndex = 12;
            this.btnCreatePage.Text = "Create Page";
            this.btnCreatePage.UseVisualStyleBackColor = true;
            this.btnCreatePage.Click += new System.EventHandler(this.btnCreatePage_Click);
            // 
            // btnModifyPage
            // 
            this.btnModifyPage.Location = new System.Drawing.Point(340, 34);
            this.btnModifyPage.Name = "btnModifyPage";
            this.btnModifyPage.Size = new System.Drawing.Size(116, 44);
            this.btnModifyPage.TabIndex = 13;
            this.btnModifyPage.Text = "Modify/Delete Page";
            this.btnModifyPage.UseVisualStyleBackColor = true;
            this.btnModifyPage.Click += new System.EventHandler(this.btnModifyPage_Click);
            // 
            // btnSearchPage
            // 
            this.btnSearchPage.Location = new System.Drawing.Point(551, 34);
            this.btnSearchPage.Name = "btnSearchPage";
            this.btnSearchPage.Size = new System.Drawing.Size(75, 44);
            this.btnSearchPage.TabIndex = 14;
            this.btnSearchPage.Text = "Search Page";
            this.btnSearchPage.UseVisualStyleBackColor = true;
            this.btnSearchPage.Click += new System.EventHandler(this.btnSearchPage_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(699, 382);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 44);
            this.btnHome.TabIndex = 15;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.pbxDestinationPicture);
            this.pnlSearch.Controls.Add(this.lblSearchDestination);
            this.pnlSearch.Controls.Add(this.cbxSearchDestination);
            this.pnlSearch.Controls.Add(this.dgvSearchDestination);
            this.pnlSearch.Location = new System.Drawing.Point(118, 96);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(562, 342);
            this.pnlSearch.TabIndex = 16;
            // 
            // dgvSearchDestination
            // 
            this.dgvSearchDestination.AutoGenerateColumns = false;
            this.dgvSearchDestination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchDestination.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.destinationNameDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.dgvSearchDestination.DataSource = this.destinationsBindingSource;
            this.dgvSearchDestination.Location = new System.Drawing.Point(49, 62);
            this.dgvSearchDestination.Name = "dgvSearchDestination";
            this.dgvSearchDestination.RowHeadersWidth = 51;
            this.dgvSearchDestination.RowTemplate.Height = 24;
            this.dgvSearchDestination.Size = new System.Drawing.Size(427, 150);
            this.dgvSearchDestination.TabIndex = 0;
            this.dgvSearchDestination.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchDestination_CellContentClick);
            // 
            // lab5DBDataSet
            // 
            this.lab5DBDataSet.DataSetName = "lab5DBDataSet";
            this.lab5DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // destinationsBindingSource
            // 
            this.destinationsBindingSource.DataMember = "destinations";
            this.destinationsBindingSource.DataSource = this.lab5DBDataSet;
            // 
            // destinationsTableAdapter
            // 
            this.destinationsTableAdapter.ClearBeforeFill = true;
            // 
            // destinationNameDataGridViewTextBoxColumn
            // 
            this.destinationNameDataGridViewTextBoxColumn.DataPropertyName = "destinationName";
            this.destinationNameDataGridViewTextBoxColumn.HeaderText = "destinationName";
            this.destinationNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.destinationNameDataGridViewTextBoxColumn.Name = "destinationNameDataGridViewTextBoxColumn";
            this.destinationNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "location";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.Width = 125;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.Width = 125;
            // 
            // cbxSearchDestination
            // 
            this.cbxSearchDestination.FormattingEnabled = true;
            this.cbxSearchDestination.Location = new System.Drawing.Point(171, 32);
            this.cbxSearchDestination.Name = "cbxSearchDestination";
            this.cbxSearchDestination.Size = new System.Drawing.Size(186, 24);
            this.cbxSearchDestination.TabIndex = 18;
            this.cbxSearchDestination.SelectedIndexChanged += new System.EventHandler(this.cbxSearchDestination_SelectedIndexChanged);
            // 
            // lblSearchDestination
            // 
            this.lblSearchDestination.AutoSize = true;
            this.lblSearchDestination.Location = new System.Drawing.Point(181, 13);
            this.lblSearchDestination.Name = "lblSearchDestination";
            this.lblSearchDestination.Size = new System.Drawing.Size(77, 16);
            this.lblSearchDestination.TabIndex = 19;
            this.lblSearchDestination.Text = "Destination:";
            // 
            // pbxDestinationPicture
            // 
            this.pbxDestinationPicture.Location = new System.Drawing.Point(377, 189);
            this.pbxDestinationPicture.Name = "pbxDestinationPicture";
            this.pbxDestinationPicture.Size = new System.Drawing.Size(182, 150);
            this.pbxDestinationPicture.TabIndex = 20;
            this.pbxDestinationPicture.TabStop = false;
            this.pbxDestinationPicture.Click += new System.EventHandler(this.pbxDestinationPicture_Click);
            // 
            // frmDestination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnSearchPage);
            this.Controls.Add(this.btnModifyPage);
            this.Controls.Add(this.btnCreatePage);
            this.Controls.Add(this.pnlModify);
            this.Controls.Add(this.pnlCreateDestination);
            this.Name = "frmDestination";
            this.Text = "frmDestination";
            this.Load += new System.EventHandler(this.frmDestination_Load);
            this.pnlCreateDestination.ResumeLayout(false);
            this.pnlCreateDestination.PerformLayout();
            this.pnlModify.ResumeLayout(false);
            this.pnlModify.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchDestination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab5DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDestinationPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCreateDestination;
        private System.Windows.Forms.Label lblCreationName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtCreationName;
        private System.Windows.Forms.Label lblCreationLocation;
        private System.Windows.Forms.TextBox txtCreationURL;
        private System.Windows.Forms.Label lblCreationURL;
        private System.Windows.Forms.TextBox txtCreationCost;
        private System.Windows.Forms.Label lblCreationCost;
        private System.Windows.Forms.TextBox txtCreationLocation;
        private System.Windows.Forms.Panel pnlModify;
        private System.Windows.Forms.TextBox txtModifyURL;
        private System.Windows.Forms.Label lblModifyURL;
        private System.Windows.Forms.TextBox txtModifyCost;
        private System.Windows.Forms.Label lblModifyCost;
        private System.Windows.Forms.TextBox txtModifyLocation;
        private System.Windows.Forms.Label lblModifyLocation;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label lblModifyDestination;
        private System.Windows.Forms.ComboBox cbxModifyDestination;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreatePage;
        private System.Windows.Forms.Button btnModifyPage;
        private System.Windows.Forms.Button btnSearchPage;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.DataGridView dgvSearchDestination;
        private lab5DBDataSet lab5DBDataSet;
        private System.Windows.Forms.BindingSource destinationsBindingSource;
        private lab5DBDataSetTableAdapters.destinationsTableAdapter destinationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbxSearchDestination;
        private System.Windows.Forms.Label lblSearchDestination;
        private System.Windows.Forms.PictureBox pbxDestinationPicture;
    }
}
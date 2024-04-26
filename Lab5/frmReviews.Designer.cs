namespace Lab5
{
    partial class frmReviews
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
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.pbxReview = new System.Windows.Forms.PictureBox();
            this.dgvReview = new System.Windows.Forms.DataGridView();
            this.travelerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reviewsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lab5DBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lab5DBDataSet = new Lab5.lab5DBDataSet();
            this.lblSearchReview = new System.Windows.Forms.Label();
            this.cbxSearchReview = new System.Windows.Forms.ComboBox();
            this.reviewsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSearchPage = new System.Windows.Forms.Button();
            this.btnModifyPage = new System.Windows.Forms.Button();
            this.btnCreatePage = new System.Windows.Forms.Button();
            this.pnlCreateReview = new System.Windows.Forms.Panel();
            this.cbxCreateDestination = new System.Windows.Forms.ComboBox();
            this.txtCreateComments = new System.Windows.Forms.TextBox();
            this.lblCreateComment = new System.Windows.Forms.Label();
            this.txtCreateRating = new System.Windows.Forms.TextBox();
            this.lblCreateRating = new System.Windows.Forms.Label();
            this.lblCreationDestination = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.pnlModifyReview = new System.Windows.Forms.Panel();
            this.cbxModifyDestination = new System.Windows.Forms.ComboBox();
            this.lblModifyReview = new System.Windows.Forms.Label();
            this.cbxReviewID = new System.Windows.Forms.ComboBox();
            this.txtModifyComments = new System.Windows.Forms.TextBox();
            this.lblReviewComments = new System.Windows.Forms.Label();
            this.txtModifyRating = new System.Windows.Forms.TextBox();
            this.lblModifyRating = new System.Windows.Forms.Label();
            this.lblModifyReviewId = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.reviewsTableAdapter = new Lab5.lab5DBDataSetTableAdapters.reviewsTableAdapter();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxReview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab5DBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab5DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewsBindingSource)).BeginInit();
            this.pnlCreateReview.SuspendLayout();
            this.pnlModifyReview.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.pbxReview);
            this.pnlSearch.Controls.Add(this.dgvReview);
            this.pnlSearch.Controls.Add(this.lblSearchReview);
            this.pnlSearch.Controls.Add(this.cbxSearchReview);
            this.pnlSearch.Location = new System.Drawing.Point(119, 80);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(562, 342);
            this.pnlSearch.TabIndex = 23;
            // 
            // pbxReview
            // 
            this.pbxReview.Location = new System.Drawing.Point(358, 161);
            this.pbxReview.Name = "pbxReview";
            this.pbxReview.Size = new System.Drawing.Size(201, 178);
            this.pbxReview.TabIndex = 22;
            this.pbxReview.TabStop = false;
            // 
            // dgvReview
            // 
            this.dgvReview.AutoGenerateColumns = false;
            this.dgvReview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.travelerNameDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn,
            this.commentsDataGridViewTextBoxColumn});
            this.dgvReview.DataSource = this.reviewsBindingSource1;
            this.dgvReview.Location = new System.Drawing.Point(12, 62);
            this.dgvReview.Name = "dgvReview";
            this.dgvReview.RowHeadersWidth = 51;
            this.dgvReview.RowTemplate.Height = 24;
            this.dgvReview.Size = new System.Drawing.Size(550, 199);
            this.dgvReview.TabIndex = 21;
            this.dgvReview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReview_CellContentClick);
            // 
            // travelerNameDataGridViewTextBoxColumn
            // 
            this.travelerNameDataGridViewTextBoxColumn.DataPropertyName = "travelerName";
            this.travelerNameDataGridViewTextBoxColumn.HeaderText = "travelerName";
            this.travelerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.travelerNameDataGridViewTextBoxColumn.Name = "travelerNameDataGridViewTextBoxColumn";
            this.travelerNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "rating";
            this.ratingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            this.ratingDataGridViewTextBoxColumn.Width = 125;
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "comments";
            this.commentsDataGridViewTextBoxColumn.HeaderText = "comments";
            this.commentsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            this.commentsDataGridViewTextBoxColumn.Width = 125;
            // 
            // reviewsBindingSource1
            // 
            this.reviewsBindingSource1.DataMember = "reviews";
            this.reviewsBindingSource1.DataSource = this.lab5DBDataSetBindingSource;
            // 
            // lab5DBDataSetBindingSource
            // 
            this.lab5DBDataSetBindingSource.DataSource = this.lab5DBDataSet;
            this.lab5DBDataSetBindingSource.Position = 0;
            // 
            // lab5DBDataSet
            // 
            this.lab5DBDataSet.DataSetName = "lab5DBDataSet";
            this.lab5DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblSearchReview
            // 
            this.lblSearchReview.AutoSize = true;
            this.lblSearchReview.Location = new System.Drawing.Point(181, 13);
            this.lblSearchReview.Name = "lblSearchReview";
            this.lblSearchReview.Size = new System.Drawing.Size(77, 16);
            this.lblSearchReview.TabIndex = 19;
            this.lblSearchReview.Text = "Destination:";
            // 
            // cbxSearchReview
            // 
            this.cbxSearchReview.FormattingEnabled = true;
            this.cbxSearchReview.Location = new System.Drawing.Point(171, 32);
            this.cbxSearchReview.Name = "cbxSearchReview";
            this.cbxSearchReview.Size = new System.Drawing.Size(186, 24);
            this.cbxSearchReview.TabIndex = 18;
            this.cbxSearchReview.SelectedIndexChanged += new System.EventHandler(this.cbxSearchReview_SelectedIndexChanged);
            // 
            // reviewsBindingSource
            // 
            this.reviewsBindingSource.DataMember = "reviews";
            this.reviewsBindingSource.DataSource = this.lab5DBDataSetBindingSource;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(687, 378);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 44);
            this.btnHome.TabIndex = 22;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSearchPage
            // 
            this.btnSearchPage.Location = new System.Drawing.Point(539, 30);
            this.btnSearchPage.Name = "btnSearchPage";
            this.btnSearchPage.Size = new System.Drawing.Size(75, 44);
            this.btnSearchPage.TabIndex = 21;
            this.btnSearchPage.Text = "Search Page";
            this.btnSearchPage.UseVisualStyleBackColor = true;
            this.btnSearchPage.Click += new System.EventHandler(this.btnSearchPage_Click);
            // 
            // btnModifyPage
            // 
            this.btnModifyPage.Location = new System.Drawing.Point(328, 30);
            this.btnModifyPage.Name = "btnModifyPage";
            this.btnModifyPage.Size = new System.Drawing.Size(116, 44);
            this.btnModifyPage.TabIndex = 20;
            this.btnModifyPage.Text = "Modify/Delete Page";
            this.btnModifyPage.UseVisualStyleBackColor = true;
            this.btnModifyPage.Click += new System.EventHandler(this.btnModifyPage_Click);
            // 
            // btnCreatePage
            // 
            this.btnCreatePage.Location = new System.Drawing.Point(166, 30);
            this.btnCreatePage.Name = "btnCreatePage";
            this.btnCreatePage.Size = new System.Drawing.Size(75, 44);
            this.btnCreatePage.TabIndex = 19;
            this.btnCreatePage.Text = "Create Page";
            this.btnCreatePage.UseVisualStyleBackColor = true;
            this.btnCreatePage.Click += new System.EventHandler(this.btnCreatePage_Click);
            // 
            // pnlCreateReview
            // 
            this.pnlCreateReview.Controls.Add(this.cbxCreateDestination);
            this.pnlCreateReview.Controls.Add(this.txtCreateComments);
            this.pnlCreateReview.Controls.Add(this.lblCreateComment);
            this.pnlCreateReview.Controls.Add(this.txtCreateRating);
            this.pnlCreateReview.Controls.Add(this.lblCreateRating);
            this.pnlCreateReview.Controls.Add(this.lblCreationDestination);
            this.pnlCreateReview.Controls.Add(this.btnCreate);
            this.pnlCreateReview.Location = new System.Drawing.Point(177, 94);
            this.pnlCreateReview.Name = "pnlCreateReview";
            this.pnlCreateReview.Size = new System.Drawing.Size(464, 266);
            this.pnlCreateReview.TabIndex = 17;
            // 
            // cbxCreateDestination
            // 
            this.cbxCreateDestination.FormattingEnabled = true;
            this.cbxCreateDestination.Location = new System.Drawing.Point(69, 46);
            this.cbxCreateDestination.Name = "cbxCreateDestination";
            this.cbxCreateDestination.Size = new System.Drawing.Size(121, 24);
            this.cbxCreateDestination.TabIndex = 16;
            // 
            // txtCreateComments
            // 
            this.txtCreateComments.Location = new System.Drawing.Point(69, 102);
            this.txtCreateComments.Name = "txtCreateComments";
            this.txtCreateComments.Size = new System.Drawing.Size(327, 22);
            this.txtCreateComments.TabIndex = 15;
            // 
            // lblCreateComment
            // 
            this.lblCreateComment.AutoSize = true;
            this.lblCreateComment.Location = new System.Drawing.Point(66, 73);
            this.lblCreateComment.Name = "lblCreateComment";
            this.lblCreateComment.Size = new System.Drawing.Size(74, 16);
            this.lblCreateComment.TabIndex = 14;
            this.lblCreateComment.Text = "Comments:";
            // 
            // txtCreateRating
            // 
            this.txtCreateRating.Location = new System.Drawing.Point(310, 44);
            this.txtCreateRating.Name = "txtCreateRating";
            this.txtCreateRating.Size = new System.Drawing.Size(86, 22);
            this.txtCreateRating.TabIndex = 8;
            // 
            // lblCreateRating
            // 
            this.lblCreateRating.AutoSize = true;
            this.lblCreateRating.Location = new System.Drawing.Point(307, 25);
            this.lblCreateRating.Name = "lblCreateRating";
            this.lblCreateRating.Size = new System.Drawing.Size(78, 16);
            this.lblCreateRating.TabIndex = 7;
            this.lblCreateRating.Text = "Rating (1-5):";
            // 
            // lblCreationDestination
            // 
            this.lblCreationDestination.AutoSize = true;
            this.lblCreationDestination.Location = new System.Drawing.Point(66, 25);
            this.lblCreationDestination.Name = "lblCreationDestination";
            this.lblCreationDestination.Size = new System.Drawing.Size(77, 16);
            this.lblCreationDestination.TabIndex = 3;
            this.lblCreationDestination.Text = "Destination:";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(191, 229);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // pnlModifyReview
            // 
            this.pnlModifyReview.Controls.Add(this.cbxModifyDestination);
            this.pnlModifyReview.Controls.Add(this.lblModifyReview);
            this.pnlModifyReview.Controls.Add(this.cbxReviewID);
            this.pnlModifyReview.Controls.Add(this.txtModifyComments);
            this.pnlModifyReview.Controls.Add(this.lblReviewComments);
            this.pnlModifyReview.Controls.Add(this.txtModifyRating);
            this.pnlModifyReview.Controls.Add(this.lblModifyRating);
            this.pnlModifyReview.Controls.Add(this.lblModifyReviewId);
            this.pnlModifyReview.Controls.Add(this.btnDelete);
            this.pnlModifyReview.Controls.Add(this.btnModify);
            this.pnlModifyReview.Location = new System.Drawing.Point(112, 103);
            this.pnlModifyReview.Name = "pnlModifyReview";
            this.pnlModifyReview.Size = new System.Drawing.Size(559, 301);
            this.pnlModifyReview.TabIndex = 18;
            this.pnlModifyReview.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlModifyReview_Paint);
            // 
            // cbxModifyDestination
            // 
            this.cbxModifyDestination.FormattingEnabled = true;
            this.cbxModifyDestination.Location = new System.Drawing.Point(117, 118);
            this.cbxModifyDestination.Name = "cbxModifyDestination";
            this.cbxModifyDestination.Size = new System.Drawing.Size(121, 24);
            this.cbxModifyDestination.TabIndex = 27;
            // 
            // lblModifyReview
            // 
            this.lblModifyReview.AutoSize = true;
            this.lblModifyReview.Location = new System.Drawing.Point(114, 97);
            this.lblModifyReview.Name = "lblModifyReview";
            this.lblModifyReview.Size = new System.Drawing.Size(77, 16);
            this.lblModifyReview.TabIndex = 26;
            this.lblModifyReview.Text = "Destination:";
            // 
            // cbxReviewID
            // 
            this.cbxReviewID.FormattingEnabled = true;
            this.cbxReviewID.Location = new System.Drawing.Point(219, 47);
            this.cbxReviewID.Name = "cbxReviewID";
            this.cbxReviewID.Size = new System.Drawing.Size(121, 24);
            this.cbxReviewID.TabIndex = 25;
            // 
            // txtModifyComments
            // 
            this.txtModifyComments.Location = new System.Drawing.Point(117, 178);
            this.txtModifyComments.Name = "txtModifyComments";
            this.txtModifyComments.Size = new System.Drawing.Size(327, 22);
            this.txtModifyComments.TabIndex = 24;
            // 
            // lblReviewComments
            // 
            this.lblReviewComments.AutoSize = true;
            this.lblReviewComments.Location = new System.Drawing.Point(114, 149);
            this.lblReviewComments.Name = "lblReviewComments";
            this.lblReviewComments.Size = new System.Drawing.Size(74, 16);
            this.lblReviewComments.TabIndex = 23;
            this.lblReviewComments.Text = "Comments:";
            // 
            // txtModifyRating
            // 
            this.txtModifyRating.Location = new System.Drawing.Point(323, 120);
            this.txtModifyRating.Name = "txtModifyRating";
            this.txtModifyRating.Size = new System.Drawing.Size(121, 22);
            this.txtModifyRating.TabIndex = 22;
            // 
            // lblModifyRating
            // 
            this.lblModifyRating.AutoSize = true;
            this.lblModifyRating.Location = new System.Drawing.Point(320, 101);
            this.lblModifyRating.Name = "lblModifyRating";
            this.lblModifyRating.Size = new System.Drawing.Size(78, 16);
            this.lblModifyRating.TabIndex = 21;
            this.lblModifyRating.Text = "Rating (1-5):";
            // 
            // lblModifyReviewId
            // 
            this.lblModifyReviewId.AutoSize = true;
            this.lblModifyReviewId.Location = new System.Drawing.Point(183, 28);
            this.lblModifyReviewId.Name = "lblModifyReviewId";
            this.lblModifyReviewId.Size = new System.Drawing.Size(215, 16);
            this.lblModifyReviewId.TabIndex = 20;
            this.lblModifyReviewId.Text = "ReviewID (check search tab for ID):";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(369, 263);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(117, 263);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 11;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // reviewsTableAdapter
            // 
            this.reviewsTableAdapter.ClearBeforeFill = true;
            // 
            // frmReviews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnSearchPage);
            this.Controls.Add(this.btnModifyPage);
            this.Controls.Add(this.btnCreatePage);
            this.Controls.Add(this.pnlCreateReview);
            this.Controls.Add(this.pnlModifyReview);
            this.Name = "frmReviews";
            this.Text = "frmReviews";
            this.Load += new System.EventHandler(this.frmReviews_Load);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxReview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab5DBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab5DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewsBindingSource)).EndInit();
            this.pnlCreateReview.ResumeLayout(false);
            this.pnlCreateReview.PerformLayout();
            this.pnlModifyReview.ResumeLayout(false);
            this.pnlModifyReview.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblSearchReview;
        private System.Windows.Forms.ComboBox cbxSearchReview;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSearchPage;
        private System.Windows.Forms.Button btnModifyPage;
        private System.Windows.Forms.Button btnCreatePage;
        private System.Windows.Forms.Panel pnlCreateReview;
        private System.Windows.Forms.Label lblCreateComment;
        private System.Windows.Forms.TextBox txtCreateRating;
        private System.Windows.Forms.Label lblCreateRating;
        private System.Windows.Forms.Label lblCreationDestination;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel pnlModifyReview;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.DataGridView dgvReview;
        private System.Windows.Forms.PictureBox pbxReview;
        private System.Windows.Forms.BindingSource lab5DBDataSetBindingSource;
        private lab5DBDataSet lab5DBDataSet;
        private System.Windows.Forms.BindingSource reviewsBindingSource;
        private lab5DBDataSetTableAdapters.reviewsTableAdapter reviewsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn travelerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtCreateComments;
        private System.Windows.Forms.ComboBox cbxCreateDestination;
        private System.Windows.Forms.ComboBox cbxReviewID;
        private System.Windows.Forms.TextBox txtModifyComments;
        private System.Windows.Forms.Label lblReviewComments;
        private System.Windows.Forms.TextBox txtModifyRating;
        private System.Windows.Forms.Label lblModifyRating;
        private System.Windows.Forms.Label lblModifyReviewId;
        private System.Windows.Forms.ComboBox cbxModifyDestination;
        private System.Windows.Forms.Label lblModifyReview;
        private System.Windows.Forms.BindingSource reviewsBindingSource1;
    }
}
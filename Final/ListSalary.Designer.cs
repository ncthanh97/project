namespace Manage_Cinema
{
    partial class ListSalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListSalary));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dgvListSalary = new DevExpress.XtraGrid.GridControl();
            this.gridSalary = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnEditSalary = new System.Windows.Forms.Button();
            this.btnDeleteSalary = new System.Windows.Forms.Button();
            this.btnSearchSalary = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.searchSalary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.ImageIndex = 2;
            this.btnUpdate.ImageList = this.imageList1;
            this.btnUpdate.Location = new System.Drawing.Point(500, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 71);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "btnDelete.png");
            this.imageList1.Images.SetKeyName(1, "btnEdit.png");
            this.imageList1.Images.SetKeyName(2, "btnUpdate.png");
            // 
            // dgvListSalary
            // 
            this.dgvListSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListSalary.Location = new System.Drawing.Point(4, 83);
            this.dgvListSalary.MainView = this.gridSalary;
            this.dgvListSalary.Name = "dgvListSalary";
            this.dgvListSalary.Size = new System.Drawing.Size(766, 350);
            this.dgvListSalary.TabIndex = 24;
            this.dgvListSalary.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridSalary});
            // 
            // gridSalary
            // 
            this.gridSalary.GridControl = this.dgvListSalary;
            this.gridSalary.Name = "gridSalary";
            // 
            // btnEditSalary
            // 
            this.btnEditSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditSalary.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditSalary.ImageKey = "btnEdit.png";
            this.btnEditSalary.ImageList = this.imageList1;
            this.btnEditSalary.Location = new System.Drawing.Point(685, 6);
            this.btnEditSalary.Name = "btnEditSalary";
            this.btnEditSalary.Size = new System.Drawing.Size(85, 71);
            this.btnEditSalary.TabIndex = 23;
            this.btnEditSalary.Text = "Edit";
            this.btnEditSalary.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditSalary.UseVisualStyleBackColor = true;
            this.btnEditSalary.Click += new System.EventHandler(this.btnEditSalary_Click);
            // 
            // btnDeleteSalary
            // 
            this.btnDeleteSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteSalary.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteSalary.ImageIndex = 0;
            this.btnDeleteSalary.ImageList = this.imageList1;
            this.btnDeleteSalary.Location = new System.Drawing.Point(594, 6);
            this.btnDeleteSalary.Name = "btnDeleteSalary";
            this.btnDeleteSalary.Size = new System.Drawing.Size(88, 71);
            this.btnDeleteSalary.TabIndex = 22;
            this.btnDeleteSalary.Text = "Delete";
            this.btnDeleteSalary.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteSalary.UseVisualStyleBackColor = true;
            this.btnDeleteSalary.Click += new System.EventHandler(this.btnDeleteSalary_Click);
            // 
            // btnSearchSalary
            // 
            this.btnSearchSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchSalary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchSalary.ImageIndex = 0;
            this.btnSearchSalary.ImageList = this.imageList2;
            this.btnSearchSalary.Location = new System.Drawing.Point(402, 19);
            this.btnSearchSalary.Name = "btnSearchSalary";
            this.btnSearchSalary.Size = new System.Drawing.Size(92, 41);
            this.btnSearchSalary.TabIndex = 21;
            this.btnSearchSalary.Text = "Search";
            this.btnSearchSalary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchSalary.UseVisualStyleBackColor = true;
            this.btnSearchSalary.Click += new System.EventHandler(this.btnSearchSalary_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "btnSearch.png");
            // 
            // searchSalary
            // 
            this.searchSalary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchSalary.Location = new System.Drawing.Point(35, 28);
            this.searchSalary.Name = "searchSalary";
            this.searchSalary.Size = new System.Drawing.Size(361, 23);
            this.searchSalary.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID:";
            // 
            // ListSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 438);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvListSalary);
            this.Controls.Add(this.btnEditSalary);
            this.Controls.Add(this.btnDeleteSalary);
            this.Controls.Add(this.btnSearchSalary);
            this.Controls.Add(this.searchSalary);
            this.Controls.Add(this.label1);
            this.Name = "ListSalary";
            this.Text = "ListSalary";
            this.Load += new System.EventHandler(this.ListSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraGrid.GridControl dgvListSalary;
        private DevExpress.XtraGrid.Views.Grid.GridView gridSalary;
        private System.Windows.Forms.Button btnEditSalary;
        private System.Windows.Forms.Button btnDeleteSalary;
        private System.Windows.Forms.Button btnSearchSalary;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.TextBox searchSalary;
        private System.Windows.Forms.Label label1;
    }
}
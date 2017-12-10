namespace Manage_Cinema
{
    partial class List_show
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List_show));
            this.label1 = new System.Windows.Forms.Label();
            this.searchShow = new System.Windows.Forms.TextBox();
            this.btnSearchShow = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnDeleteShow = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.dgvListShow = new DevExpress.XtraGrid.GridControl();
            this.gridShow = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.searchByIDMovie = new System.Windows.Forms.CheckBox();
            this.searchByIDShow = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridShow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // searchShow
            // 
            this.searchShow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchShow.Location = new System.Drawing.Point(35, 12);
            this.searchShow.Name = "searchShow";
            this.searchShow.Size = new System.Drawing.Size(412, 23);
            this.searchShow.TabIndex = 1;
            // 
            // btnSearchShow
            // 
            this.btnSearchShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchShow.ImageIndex = 0;
            this.btnSearchShow.ImageList = this.imageList2;
            this.btnSearchShow.Location = new System.Drawing.Point(453, 28);
            this.btnSearchShow.Name = "btnSearchShow";
            this.btnSearchShow.Size = new System.Drawing.Size(92, 41);
            this.btnSearchShow.TabIndex = 2;
            this.btnSearchShow.Text = "Search";
            this.btnSearchShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchShow.UseVisualStyleBackColor = true;
            this.btnSearchShow.Click += new System.EventHandler(this.btnSearchShow_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "btnSearch.png");
            // 
            // btnDeleteShow
            // 
            this.btnDeleteShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteShow.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteShow.ImageIndex = 0;
            this.btnDeleteShow.ImageList = this.imageList1;
            this.btnDeleteShow.Location = new System.Drawing.Point(654, 12);
            this.btnDeleteShow.Name = "btnDeleteShow";
            this.btnDeleteShow.Size = new System.Drawing.Size(88, 71);
            this.btnDeleteShow.TabIndex = 3;
            this.btnDeleteShow.Text = "Delete";
            this.btnDeleteShow.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteShow.UseVisualStyleBackColor = true;
            this.btnDeleteShow.Click += new System.EventHandler(this.btnDeleteShow_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "btnDelete.png");
            this.imageList1.Images.SetKeyName(1, "btnEdit.png");
            this.imageList1.Images.SetKeyName(2, "btnUpdate.png");
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.ImageKey = "btnEdit.png";
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(748, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 71);
            this.button2.TabIndex = 4;
            this.button2.Text = "Edit";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvListShow
            // 
            this.dgvListShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListShow.Location = new System.Drawing.Point(4, 89);
            this.dgvListShow.MainView = this.gridShow;
            this.dgvListShow.Name = "dgvListShow";
            this.dgvListShow.Size = new System.Drawing.Size(829, 350);
            this.dgvListShow.TabIndex = 5;
            this.dgvListShow.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridShow});
            // 
            // gridShow
            // 
            this.gridShow.GridControl = this.dgvListShow;
            this.gridShow.Name = "gridShow";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.ImageIndex = 2;
            this.btnUpdate.ImageList = this.imageList1;
            this.btnUpdate.Location = new System.Drawing.Point(560, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 71);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // searchByIDMovie
            // 
            this.searchByIDMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchByIDMovie.AutoSize = true;
            this.searchByIDMovie.Location = new System.Drawing.Point(193, 48);
            this.searchByIDMovie.Name = "searchByIDMovie";
            this.searchByIDMovie.Size = new System.Drawing.Size(83, 21);
            this.searchByIDMovie.TabIndex = 21;
            this.searchByIDMovie.Text = "ID Movie";
            this.searchByIDMovie.UseVisualStyleBackColor = true;
            this.searchByIDMovie.CheckedChanged += new System.EventHandler(this.searchByIDMovie_CheckedChanged);
            // 
            // searchByIDShow
            // 
            this.searchByIDShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchByIDShow.AutoSize = true;
            this.searchByIDShow.Location = new System.Drawing.Point(72, 48);
            this.searchByIDShow.Name = "searchByIDShow";
            this.searchByIDShow.Size = new System.Drawing.Size(108, 21);
            this.searchByIDShow.TabIndex = 20;
            this.searchByIDShow.Text = "ID Showtime";
            this.searchByIDShow.UseVisualStyleBackColor = true;
            this.searchByIDShow.CheckedChanged += new System.EventHandler(this.searchByIDShow_CheckedChanged);
            // 
            // List_show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 442);
            this.Controls.Add(this.searchByIDMovie);
            this.Controls.Add(this.searchByIDShow);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvListShow);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDeleteShow);
            this.Controls.Add(this.btnSearchShow);
            this.Controls.Add(this.searchShow);
            this.Controls.Add(this.label1);
            this.Name = "List_show";
            this.Text = "List_show";
            this.Load += new System.EventHandler(this.List_show_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchShow;
        private System.Windows.Forms.Button btnSearchShow;
        private System.Windows.Forms.Button btnDeleteShow;
        private System.Windows.Forms.Button button2;
        private DevExpress.XtraGrid.GridControl dgvListShow;
        private DevExpress.XtraGrid.Views.Grid.GridView gridShow;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckBox searchByIDMovie;
        private System.Windows.Forms.CheckBox searchByIDShow;
    }
}
namespace Manage_Cinema
{
    partial class Types_of_ticket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Types_of_ticket));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.dgvListTOT = new DevExpress.XtraGrid.GridControl();
            this.gridTOT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnEditTOT = new System.Windows.Forms.Button();
            this.btnDeleteTOT = new System.Windows.Forms.Button();
            this.btnSearchTOT = new System.Windows.Forms.Button();
            this.searchTOT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTOT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTOT)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "btnDelete.png");
            this.imageList1.Images.SetKeyName(1, "btnEdit.png");
            this.imageList1.Images.SetKeyName(2, "btnUpdate.png");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "btnSearch.png");
            // 
            // dgvListTOT
            // 
            this.dgvListTOT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListTOT.Location = new System.Drawing.Point(3, 83);
            this.dgvListTOT.MainView = this.gridTOT;
            this.dgvListTOT.Name = "dgvListTOT";
            this.dgvListTOT.Size = new System.Drawing.Size(766, 350);
            this.dgvListTOT.TabIndex = 17;
            this.dgvListTOT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridTOT});
            this.dgvListTOT.Click += new System.EventHandler(this.dgvListTOT_Click);
            // 
            // gridTOT
            // 
            this.gridTOT.GridControl = this.dgvListTOT;
            this.gridTOT.Name = "gridTOT";
            // 
            // btnEditTOT
            // 
            this.btnEditTOT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditTOT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditTOT.ImageKey = "btnEdit.png";
            this.btnEditTOT.ImageList = this.imageList1;
            this.btnEditTOT.Location = new System.Drawing.Point(684, 6);
            this.btnEditTOT.Name = "btnEditTOT";
            this.btnEditTOT.Size = new System.Drawing.Size(85, 71);
            this.btnEditTOT.TabIndex = 16;
            this.btnEditTOT.Text = "Edit";
            this.btnEditTOT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditTOT.UseVisualStyleBackColor = true;
            this.btnEditTOT.Click += new System.EventHandler(this.btnEditTOT_Click);
            // 
            // btnDeleteTOT
            // 
            this.btnDeleteTOT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteTOT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteTOT.ImageIndex = 0;
            this.btnDeleteTOT.ImageList = this.imageList1;
            this.btnDeleteTOT.Location = new System.Drawing.Point(593, 6);
            this.btnDeleteTOT.Name = "btnDeleteTOT";
            this.btnDeleteTOT.Size = new System.Drawing.Size(88, 71);
            this.btnDeleteTOT.TabIndex = 15;
            this.btnDeleteTOT.Text = "Delete";
            this.btnDeleteTOT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteTOT.UseVisualStyleBackColor = true;
            this.btnDeleteTOT.Click += new System.EventHandler(this.btnDeleteTOT_Click);
            // 
            // btnSearchTOT
            // 
            this.btnSearchTOT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchTOT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchTOT.ImageIndex = 0;
            this.btnSearchTOT.ImageList = this.imageList2;
            this.btnSearchTOT.Location = new System.Drawing.Point(401, 19);
            this.btnSearchTOT.Name = "btnSearchTOT";
            this.btnSearchTOT.Size = new System.Drawing.Size(92, 41);
            this.btnSearchTOT.TabIndex = 14;
            this.btnSearchTOT.Text = "Search";
            this.btnSearchTOT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchTOT.UseVisualStyleBackColor = true;
            this.btnSearchTOT.Click += new System.EventHandler(this.btnSearchTOT_Click);
            // 
            // searchTOT
            // 
            this.searchTOT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTOT.Location = new System.Drawing.Point(34, 28);
            this.searchTOT.Name = "searchTOT";
            this.searchTOT.Size = new System.Drawing.Size(361, 23);
            this.searchTOT.TabIndex = 13;
            this.searchTOT.TextChanged += new System.EventHandler(this.searchTOT_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.ImageIndex = 2;
            this.btnUpdate.ImageList = this.imageList1;
            this.btnUpdate.Location = new System.Drawing.Point(499, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 71);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Types_of_ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 438);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvListTOT);
            this.Controls.Add(this.btnEditTOT);
            this.Controls.Add(this.btnDeleteTOT);
            this.Controls.Add(this.btnSearchTOT);
            this.Controls.Add(this.searchTOT);
            this.Controls.Add(this.label1);
            this.Name = "Types_of_ticket";
            this.Text = "Types_of_ticket";
            this.Load += new System.EventHandler(this.Types_of_ticket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTOT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTOT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private DevExpress.XtraGrid.GridControl dgvListTOT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridTOT;
        private System.Windows.Forms.Button btnEditTOT;
        private System.Windows.Forms.Button btnDeleteTOT;
        private System.Windows.Forms.Button btnSearchTOT;
        private System.Windows.Forms.TextBox searchTOT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
    }
}
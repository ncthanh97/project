namespace Manage_Cinema
{
    partial class ListRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListRoom));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.dgvListRoom = new DevExpress.XtraGrid.GridControl();
            this.gridRoom = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnEditRoom = new System.Windows.Forms.Button();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.btnSearchRoom = new System.Windows.Forms.Button();
            this.searchRoom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRoom)).BeginInit();
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
            // dgvListRoom
            // 
            this.dgvListRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListRoom.Location = new System.Drawing.Point(3, 83);
            this.dgvListRoom.MainView = this.gridRoom;
            this.dgvListRoom.Name = "dgvListRoom";
            this.dgvListRoom.Size = new System.Drawing.Size(828, 350);
            this.dgvListRoom.TabIndex = 23;
            this.dgvListRoom.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridRoom});
            // 
            // gridRoom
            // 
            this.gridRoom.GridControl = this.dgvListRoom;
            this.gridRoom.Name = "gridRoom";
            // 
            // btnEditRoom
            // 
            this.btnEditRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditRoom.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditRoom.ImageKey = "btnEdit.png";
            this.btnEditRoom.ImageList = this.imageList1;
            this.btnEditRoom.Location = new System.Drawing.Point(746, 6);
            this.btnEditRoom.Name = "btnEditRoom";
            this.btnEditRoom.Size = new System.Drawing.Size(85, 71);
            this.btnEditRoom.TabIndex = 22;
            this.btnEditRoom.Text = "Edit";
            this.btnEditRoom.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditRoom.UseVisualStyleBackColor = true;
            this.btnEditRoom.Click += new System.EventHandler(this.btnEditRoom_Click);
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteRoom.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteRoom.ImageIndex = 0;
            this.btnDeleteRoom.ImageList = this.imageList1;
            this.btnDeleteRoom.Location = new System.Drawing.Point(652, 6);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(88, 71);
            this.btnDeleteRoom.TabIndex = 21;
            this.btnDeleteRoom.Text = "Delete";
            this.btnDeleteRoom.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteRoom.UseVisualStyleBackColor = true;
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
            // 
            // btnSearchRoom
            // 
            this.btnSearchRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchRoom.ImageIndex = 0;
            this.btnSearchRoom.ImageList = this.imageList2;
            this.btnSearchRoom.Location = new System.Drawing.Point(449, 22);
            this.btnSearchRoom.Name = "btnSearchRoom";
            this.btnSearchRoom.Size = new System.Drawing.Size(92, 41);
            this.btnSearchRoom.TabIndex = 20;
            this.btnSearchRoom.Text = "Search";
            this.btnSearchRoom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchRoom.UseVisualStyleBackColor = true;
            this.btnSearchRoom.Click += new System.EventHandler(this.btnSearchRoom_Click);
            // 
            // searchRoom
            // 
            this.searchRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchRoom.Location = new System.Drawing.Point(45, 31);
            this.searchRoom.Name = "searchRoom";
            this.searchRoom.Size = new System.Drawing.Size(398, 23);
            this.searchRoom.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.ImageIndex = 2;
            this.btnUpdate.ImageList = this.imageList1;
            this.btnUpdate.Location = new System.Drawing.Point(558, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 71);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ListRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 438);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvListRoom);
            this.Controls.Add(this.btnEditRoom);
            this.Controls.Add(this.btnDeleteRoom);
            this.Controls.Add(this.btnSearchRoom);
            this.Controls.Add(this.searchRoom);
            this.Controls.Add(this.label1);
            this.Name = "ListRoom";
            this.Text = "ListRoom";
            this.Load += new System.EventHandler(this.ListRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private DevExpress.XtraGrid.GridControl dgvListRoom;
        private DevExpress.XtraGrid.Views.Grid.GridView gridRoom;
        private System.Windows.Forms.Button btnEditRoom;
        private System.Windows.Forms.Button btnDeleteRoom;
        private System.Windows.Forms.Button btnSearchRoom;
        private System.Windows.Forms.TextBox searchRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
    }
}
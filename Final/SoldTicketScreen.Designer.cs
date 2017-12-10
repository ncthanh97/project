namespace Manage_Cinema
{
    partial class SoldTicketScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoldTicketScreen));
            this.btnSearchShow = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.searchShow = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSellTicket = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dgvListShow = new DevExpress.XtraGrid.GridControl();
            this.gridShow = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.searchByIDMovie = new System.Windows.Forms.CheckBox();
            this.searchByIDShow = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvTicketSell = new DevExpress.XtraGrid.GridControl();
            this.grid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicketSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchShow
            // 
            this.btnSearchShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchShow.ImageIndex = 0;
            this.btnSearchShow.ImageList = this.imageList2;
            this.btnSearchShow.Location = new System.Drawing.Point(543, 41);
            this.btnSearchShow.Name = "btnSearchShow";
            this.btnSearchShow.Size = new System.Drawing.Size(92, 41);
            this.btnSearchShow.TabIndex = 24;
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
            // searchShow
            // 
            this.searchShow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchShow.Location = new System.Drawing.Point(53, 25);
            this.searchShow.Name = "searchShow";
            this.searchShow.Size = new System.Drawing.Size(484, 23);
            this.searchShow.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID:";
            // 
            // btnSellTicket
            // 
            this.btnSellTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSellTicket.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSellTicket.ImageIndex = 0;
            this.btnSellTicket.ImageList = this.imageList1;
            this.btnSellTicket.Location = new System.Drawing.Point(764, 25);
            this.btnSellTicket.Name = "btnSellTicket";
            this.btnSellTicket.Size = new System.Drawing.Size(88, 71);
            this.btnSellTicket.TabIndex = 25;
            this.btnSellTicket.Text = "Sell ticket";
            this.btnSellTicket.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSellTicket.UseVisualStyleBackColor = true;
            this.btnSellTicket.Click += new System.EventHandler(this.btnSellTicket_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "btnDelete.png");
            this.imageList1.Images.SetKeyName(1, "btnEdit.png");
            this.imageList1.Images.SetKeyName(2, "btnUpdate.png");
            // 
            // dgvListShow
            // 
            this.dgvListShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListShow.Location = new System.Drawing.Point(12, 102);
            this.dgvListShow.MainView = this.gridShow;
            this.dgvListShow.Name = "dgvListShow";
            this.dgvListShow.Size = new System.Drawing.Size(833, 385);
            this.dgvListShow.TabIndex = 27;
            this.dgvListShow.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridShow});
            // 
            // gridShow
            // 
            this.gridShow.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridShow.GridControl = this.dgvListShow;
            this.gridShow.Name = "gridShow";
            // 
            // searchByIDMovie
            // 
            this.searchByIDMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchByIDMovie.AutoSize = true;
            this.searchByIDMovie.Location = new System.Drawing.Point(294, 61);
            this.searchByIDMovie.Name = "searchByIDMovie";
            this.searchByIDMovie.Size = new System.Drawing.Size(83, 21);
            this.searchByIDMovie.TabIndex = 30;
            this.searchByIDMovie.Text = "ID Movie";
            this.searchByIDMovie.UseVisualStyleBackColor = true;
            this.searchByIDMovie.CheckedChanged += new System.EventHandler(this.searchByIDMovie_CheckedChanged);
            // 
            // searchByIDShow
            // 
            this.searchByIDShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchByIDShow.AutoSize = true;
            this.searchByIDShow.Location = new System.Drawing.Point(173, 61);
            this.searchByIDShow.Name = "searchByIDShow";
            this.searchByIDShow.Size = new System.Drawing.Size(108, 21);
            this.searchByIDShow.TabIndex = 29;
            this.searchByIDShow.Text = "ID Showtime";
            this.searchByIDShow.UseVisualStyleBackColor = true;
            this.searchByIDShow.CheckedChanged += new System.EventHandler(this.searchByIDShow_CheckedChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.ImageIndex = 2;
            this.btnUpdate.ImageList = this.imageList1;
            this.btnUpdate.Location = new System.Drawing.Point(659, 25);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 71);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // dgvTicketSell
            // 
            this.dgvTicketSell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTicketSell.Location = new System.Drawing.Point(851, 102);
            this.dgvTicketSell.MainView = this.grid;
            this.dgvTicketSell.Name = "dgvTicketSell";
            this.dgvTicketSell.Size = new System.Drawing.Size(10, 385);
            this.dgvTicketSell.TabIndex = 31;
            this.dgvTicketSell.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grid});
            // 
            // grid
            // 
            this.grid.GridControl = this.dgvTicketSell;
            this.grid.Name = "grid";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Movie";
            this.gridColumn1.FieldName = "Name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Time";
            this.gridColumn2.FieldName = "Time1";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Day";
            this.gridColumn3.FieldName = "Day1";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Room";
            this.gridColumn4.FieldName = "IDRoom";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // SoldTicketScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 499);
            this.Controls.Add(this.dgvTicketSell);
            this.Controls.Add(this.btnSearchShow);
            this.Controls.Add(this.searchShow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSellTicket);
            this.Controls.Add(this.dgvListShow);
            this.Controls.Add(this.searchByIDMovie);
            this.Controls.Add(this.searchByIDShow);
            this.Controls.Add(this.btnUpdate);
            this.Name = "SoldTicketScreen";
            this.Text = "SoldTicketScreen";
            this.Load += new System.EventHandler(this.SoldTicketScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicketSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchShow;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.TextBox searchShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSellTicket;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraGrid.GridControl dgvListShow;
        private DevExpress.XtraGrid.Views.Grid.GridView gridShow;
        private System.Windows.Forms.CheckBox searchByIDMovie;
        private System.Windows.Forms.CheckBox searchByIDShow;
        private System.Windows.Forms.Button btnUpdate;
        private DevExpress.XtraGrid.GridControl dgvTicketSell;
        private DevExpress.XtraGrid.Views.Grid.GridView grid;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}
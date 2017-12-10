namespace Manage_Cinema
{
    partial class ListSold
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvListSold = new DevExpress.XtraGrid.GridControl();
            this.gridSold = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnSearchTWS = new System.Windows.Forms.Button();
            this.searchByNameMovie = new System.Windows.Forms.CheckBox();
            this.searchByIDMovie = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.keySearchTWS = new System.Windows.Forms.TextBox();
            this.searchByIDRoom = new System.Windows.Forms.CheckBox();
            this.searchByIDShow = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSold)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(5, 64);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(141, 46);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvListSold
            // 
            this.dgvListSold.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListSold.Location = new System.Drawing.Point(5, 116);
            this.dgvListSold.MainView = this.gridSold;
            this.dgvListSold.Name = "dgvListSold";
            this.dgvListSold.Size = new System.Drawing.Size(919, 387);
            this.dgvListSold.TabIndex = 14;
            this.dgvListSold.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridSold});
            // 
            // gridSold
            // 
            this.gridSold.GridControl = this.dgvListSold;
            this.gridSold.Name = "gridSold";
            // 
            // btnSearchTWS
            // 
            this.btnSearchTWS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchTWS.Location = new System.Drawing.Point(792, 16);
            this.btnSearchTWS.Name = "btnSearchTWS";
            this.btnSearchTWS.Size = new System.Drawing.Size(132, 33);
            this.btnSearchTWS.TabIndex = 13;
            this.btnSearchTWS.Text = "Search";
            this.btnSearchTWS.UseVisualStyleBackColor = true;
            this.btnSearchTWS.Click += new System.EventHandler(this.btnSearchTWS_Click);
            // 
            // searchByNameMovie
            // 
            this.searchByNameMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchByNameMovie.AutoSize = true;
            this.searchByNameMovie.Location = new System.Drawing.Point(508, 22);
            this.searchByNameMovie.Name = "searchByNameMovie";
            this.searchByNameMovie.Size = new System.Drawing.Size(106, 21);
            this.searchByNameMovie.TabIndex = 12;
            this.searchByNameMovie.Text = "Name movie";
            this.searchByNameMovie.UseVisualStyleBackColor = true;
            this.searchByNameMovie.CheckedChanged += new System.EventHandler(this.searchByNameMovie_CheckedChanged);
            // 
            // searchByIDMovie
            // 
            this.searchByIDMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchByIDMovie.AutoSize = true;
            this.searchByIDMovie.Location = new System.Drawing.Point(419, 22);
            this.searchByIDMovie.Name = "searchByIDMovie";
            this.searchByIDMovie.Size = new System.Drawing.Size(83, 21);
            this.searchByIDMovie.TabIndex = 11;
            this.searchByIDMovie.Text = "ID Movie";
            this.searchByIDMovie.UseVisualStyleBackColor = true;
            this.searchByIDMovie.CheckedChanged += new System.EventHandler(this.searchByIDMovie_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Keyword:";
            // 
            // keySearchTWS
            // 
            this.keySearchTWS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keySearchTWS.Location = new System.Drawing.Point(98, 21);
            this.keySearchTWS.Name = "keySearchTWS";
            this.keySearchTWS.Size = new System.Drawing.Size(315, 23);
            this.keySearchTWS.TabIndex = 9;
            // 
            // searchByIDRoom
            // 
            this.searchByIDRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchByIDRoom.AutoSize = true;
            this.searchByIDRoom.Location = new System.Drawing.Point(613, 23);
            this.searchByIDRoom.Name = "searchByIDRoom";
            this.searchByIDRoom.Size = new System.Drawing.Size(85, 21);
            this.searchByIDRoom.TabIndex = 18;
            this.searchByIDRoom.Text = "ID Room";
            this.searchByIDRoom.UseVisualStyleBackColor = true;
            this.searchByIDRoom.CheckedChanged += new System.EventHandler(this.searchByIDRoom_CheckedChanged);
            // 
            // searchByIDShow
            // 
            this.searchByIDShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchByIDShow.AutoSize = true;
            this.searchByIDShow.Location = new System.Drawing.Point(704, 23);
            this.searchByIDShow.Name = "searchByIDShow";
            this.searchByIDShow.Size = new System.Drawing.Size(82, 21);
            this.searchByIDShow.TabIndex = 19;
            this.searchByIDShow.Text = "ID Show";
            this.searchByIDShow.UseVisualStyleBackColor = true;
            this.searchByIDShow.CheckedChanged += new System.EventHandler(this.searchByIDShow_CheckedChanged);
            // 
            // ListSold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 506);
            this.Controls.Add(this.searchByIDShow);
            this.Controls.Add(this.searchByIDRoom);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvListSold);
            this.Controls.Add(this.btnSearchTWS);
            this.Controls.Add(this.searchByNameMovie);
            this.Controls.Add(this.searchByIDMovie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keySearchTWS);
            this.Name = "ListSold";
            this.Text = "ListSold";
            this.Load += new System.EventHandler(this.ListSold_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private DevExpress.XtraGrid.GridControl dgvListSold;
        private DevExpress.XtraGrid.Views.Grid.GridView gridSold;
        private System.Windows.Forms.Button btnSearchTWS;
        private System.Windows.Forms.CheckBox searchByNameMovie;
        private System.Windows.Forms.CheckBox searchByIDMovie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox keySearchTWS;
        private System.Windows.Forms.CheckBox searchByIDRoom;
        private System.Windows.Forms.CheckBox searchByIDShow;
    }
}
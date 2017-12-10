namespace Manage_Cinema
{
    partial class ListAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListAccount));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dgvListAccount = new DevExpress.XtraGrid.GridControl();
            this.gridAccount = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.editAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnSearchShow = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.searchAccount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.ImageIndex = 2;
            this.btnUpdate.ImageList = this.imageList1;
            this.btnUpdate.Location = new System.Drawing.Point(559, 8);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 71);
            this.btnUpdate.TabIndex = 28;
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
            // dgvListAccount
            // 
            this.dgvListAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListAccount.Location = new System.Drawing.Point(3, 85);
            this.dgvListAccount.MainView = this.gridAccount;
            this.dgvListAccount.Name = "dgvListAccount";
            this.dgvListAccount.Size = new System.Drawing.Size(829, 350);
            this.dgvListAccount.TabIndex = 27;
            this.dgvListAccount.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridAccount});
            // 
            // gridAccount
            // 
            this.gridAccount.GridControl = this.dgvListAccount;
            this.gridAccount.Name = "gridAccount";
            // 
            // editAccount
            // 
            this.editAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editAccount.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.editAccount.ImageKey = "btnEdit.png";
            this.editAccount.ImageList = this.imageList1;
            this.editAccount.Location = new System.Drawing.Point(747, 8);
            this.editAccount.Name = "editAccount";
            this.editAccount.Size = new System.Drawing.Size(85, 71);
            this.editAccount.TabIndex = 26;
            this.editAccount.Text = "Edit";
            this.editAccount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.editAccount.UseVisualStyleBackColor = true;
            this.editAccount.Click += new System.EventHandler(this.editAccount_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteAccount.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteAccount.ImageIndex = 0;
            this.btnDeleteAccount.ImageList = this.imageList1;
            this.btnDeleteAccount.Location = new System.Drawing.Point(653, 8);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(88, 71);
            this.btnDeleteAccount.TabIndex = 25;
            this.btnDeleteAccount.Text = "Delete";
            this.btnDeleteAccount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnSearchShow
            // 
            this.btnSearchShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchShow.ImageIndex = 0;
            this.btnSearchShow.ImageList = this.imageList2;
            this.btnSearchShow.Location = new System.Drawing.Point(461, 24);
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
            // searchAccount
            // 
            this.searchAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchAccount.Location = new System.Drawing.Point(76, 33);
            this.searchAccount.Name = "searchAccount";
            this.searchAccount.Size = new System.Drawing.Size(379, 23);
            this.searchAccount.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID Staff:";
            // 
            // ListAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 442);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvListAccount);
            this.Controls.Add(this.editAccount);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.btnSearchShow);
            this.Controls.Add(this.searchAccount);
            this.Controls.Add(this.label1);
            this.Name = "ListAccount";
            this.Text = "ListAccount";
            this.Load += new System.EventHandler(this.ListAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraGrid.GridControl dgvListAccount;
        private DevExpress.XtraGrid.Views.Grid.GridView gridAccount;
        private System.Windows.Forms.Button editAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnSearchShow;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.TextBox searchAccount;
        private System.Windows.Forms.Label label1;
    }
}
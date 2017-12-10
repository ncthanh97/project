namespace Manage_Cinema
{
    partial class ListUser
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
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvListUser = new DevExpress.XtraGrid.GridControl();
            this.gridUser = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.searchByNameUser = new System.Windows.Forms.CheckBox();
            this.searchByIDUser = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.keySearchUser = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditUser
            // 
            this.btnEditUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditUser.Location = new System.Drawing.Point(535, 56);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(141, 46);
            this.btnEditUser.TabIndex = 17;
            this.btnEditUser.Text = "Edit";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteUser.Location = new System.Drawing.Point(353, 56);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(141, 46);
            this.btnDeleteUser.TabIndex = 16;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(164, 56);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(141, 46);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvListUser
            // 
            this.dgvListUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListUser.Location = new System.Drawing.Point(3, 108);
            this.dgvListUser.MainView = this.gridUser;
            this.dgvListUser.Name = "dgvListUser";
            this.dgvListUser.Size = new System.Drawing.Size(821, 370);
            this.dgvListUser.TabIndex = 14;
            this.dgvListUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridUser});
            // 
            // gridUser
            // 
            this.gridUser.GridControl = this.dgvListUser;
            this.gridUser.Name = "gridUser";
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchUser.Location = new System.Drawing.Point(683, 8);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(132, 33);
            this.btnSearchUser.TabIndex = 13;
            this.btnSearchUser.Text = "Search";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // searchByNameUser
            // 
            this.searchByNameUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchByNameUser.AutoSize = true;
            this.searchByNameUser.Location = new System.Drawing.Point(610, 14);
            this.searchByNameUser.Name = "searchByNameUser";
            this.searchByNameUser.Size = new System.Drawing.Size(65, 21);
            this.searchByNameUser.TabIndex = 12;
            this.searchByNameUser.Text = "Name";
            this.searchByNameUser.UseVisualStyleBackColor = true;
            this.searchByNameUser.CheckedChanged += new System.EventHandler(this.searchByNameUser_CheckedChanged);
            // 
            // searchByIDUser
            // 
            this.searchByIDUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchByIDUser.AutoSize = true;
            this.searchByIDUser.Location = new System.Drawing.Point(535, 14);
            this.searchByIDUser.Name = "searchByIDUser";
            this.searchByIDUser.Size = new System.Drawing.Size(44, 21);
            this.searchByIDUser.TabIndex = 11;
            this.searchByIDUser.Text = "ID";
            this.searchByIDUser.UseVisualStyleBackColor = true;
            this.searchByIDUser.CheckedChanged += new System.EventHandler(this.searchByIDUser_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Keyword:";
            // 
            // keySearchUser
            // 
            this.keySearchUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keySearchUser.Location = new System.Drawing.Point(96, 13);
            this.keySearchUser.Name = "keySearchUser";
            this.keySearchUser.Size = new System.Drawing.Size(433, 23);
            this.keySearchUser.TabIndex = 9;
            // 
            // ListUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 487);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvListUser);
            this.Controls.Add(this.btnSearchUser);
            this.Controls.Add(this.searchByNameUser);
            this.Controls.Add(this.searchByIDUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keySearchUser);
            this.Name = "ListUser";
            this.Text = "ListUser";
            this.Load += new System.EventHandler(this.ListUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnUpdate;
        private DevExpress.XtraGrid.GridControl dgvListUser;
        private DevExpress.XtraGrid.Views.Grid.GridView gridUser;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.CheckBox searchByNameUser;
        private System.Windows.Forms.CheckBox searchByIDUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox keySearchUser;
    }
}
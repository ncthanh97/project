namespace Manage_Cinema
{
    partial class ListStaff
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
            this.btnEditStaff = new System.Windows.Forms.Button();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvListStaff = new DevExpress.XtraGrid.GridControl();
            this.grid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnSearchStaff = new System.Windows.Forms.Button();
            this.searchByNameStaff = new System.Windows.Forms.CheckBox();
            this.searchByIDStaff = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.keySearchStaff = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditStaff
            // 
            this.btnEditStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditStaff.Location = new System.Drawing.Point(535, 56);
            this.btnEditStaff.Name = "btnEditStaff";
            this.btnEditStaff.Size = new System.Drawing.Size(141, 46);
            this.btnEditStaff.TabIndex = 17;
            this.btnEditStaff.Text = "Edit";
            this.btnEditStaff.UseVisualStyleBackColor = true;
            this.btnEditStaff.Click += new System.EventHandler(this.btnEditStaff_Click);
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteStaff.Location = new System.Drawing.Point(353, 56);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(141, 46);
            this.btnDeleteStaff.TabIndex = 16;
            this.btnDeleteStaff.Text = "Delete";
            this.btnDeleteStaff.UseVisualStyleBackColor = true;
            this.btnDeleteStaff.Click += new System.EventHandler(this.btnDeleteStaff_Click);
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
            // dgvListStaff
            // 
            this.dgvListStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListStaff.Location = new System.Drawing.Point(3, 108);
            this.dgvListStaff.MainView = this.grid;
            this.dgvListStaff.Name = "dgvListStaff";
            this.dgvListStaff.Size = new System.Drawing.Size(821, 370);
            this.dgvListStaff.TabIndex = 14;
            this.dgvListStaff.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grid});
            // 
            // grid
            // 
            this.grid.GridControl = this.dgvListStaff;
            this.grid.Name = "grid";
            // 
            // btnSearchStaff
            // 
            this.btnSearchStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchStaff.Location = new System.Drawing.Point(683, 8);
            this.btnSearchStaff.Name = "btnSearchStaff";
            this.btnSearchStaff.Size = new System.Drawing.Size(132, 33);
            this.btnSearchStaff.TabIndex = 13;
            this.btnSearchStaff.Text = "Search";
            this.btnSearchStaff.UseVisualStyleBackColor = true;
            this.btnSearchStaff.Click += new System.EventHandler(this.btnSearchStaff_Click);
            // 
            // searchByNameStaff
            // 
            this.searchByNameStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchByNameStaff.AutoSize = true;
            this.searchByNameStaff.Location = new System.Drawing.Point(610, 14);
            this.searchByNameStaff.Name = "searchByNameStaff";
            this.searchByNameStaff.Size = new System.Drawing.Size(65, 21);
            this.searchByNameStaff.TabIndex = 12;
            this.searchByNameStaff.Text = "Name";
            this.searchByNameStaff.UseVisualStyleBackColor = true;
            this.searchByNameStaff.CheckedChanged += new System.EventHandler(this.searchByNameStaff_CheckedChanged);
            // 
            // searchByIDStaff
            // 
            this.searchByIDStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchByIDStaff.AutoSize = true;
            this.searchByIDStaff.Location = new System.Drawing.Point(535, 14);
            this.searchByIDStaff.Name = "searchByIDStaff";
            this.searchByIDStaff.Size = new System.Drawing.Size(44, 21);
            this.searchByIDStaff.TabIndex = 11;
            this.searchByIDStaff.Text = "ID";
            this.searchByIDStaff.UseVisualStyleBackColor = true;
            this.searchByIDStaff.CheckedChanged += new System.EventHandler(this.searchByIDStaff_CheckedChanged);
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
            // keySearchStaff
            // 
            this.keySearchStaff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keySearchStaff.Location = new System.Drawing.Point(96, 13);
            this.keySearchStaff.Name = "keySearchStaff";
            this.keySearchStaff.Size = new System.Drawing.Size(433, 23);
            this.keySearchStaff.TabIndex = 9;
            // 
            // ListStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 487);
            this.Controls.Add(this.btnEditStaff);
            this.Controls.Add(this.btnDeleteStaff);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvListStaff);
            this.Controls.Add(this.btnSearchStaff);
            this.Controls.Add(this.searchByNameStaff);
            this.Controls.Add(this.searchByIDStaff);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keySearchStaff);
            this.Name = "ListStaff";
            this.Text = "ListStaff";
            this.Load += new System.EventHandler(this.ListStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditStaff;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.Button btnUpdate;
        private DevExpress.XtraGrid.GridControl dgvListStaff;
        private DevExpress.XtraGrid.Views.Grid.GridView grid;
        private System.Windows.Forms.Button btnSearchStaff;
        private System.Windows.Forms.CheckBox searchByNameStaff;
        private System.Windows.Forms.CheckBox searchByIDStaff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox keySearchStaff;
    }
}
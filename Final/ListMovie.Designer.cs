namespace Manage_Cinema
{
    partial class ListMovie
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
            this.keySearchMovie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchByIDMovie = new System.Windows.Forms.CheckBox();
            this.searchByNameMovie = new System.Windows.Forms.CheckBox();
            this.btnSearchMovie = new System.Windows.Forms.Button();
            this.dgvListMovie = new DevExpress.XtraGrid.GridControl();
            this.grid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnShowAllMovie = new System.Windows.Forms.Button();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.btnEditMovie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // keySearchMovie
            // 
            this.keySearchMovie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keySearchMovie.Location = new System.Drawing.Point(96, 17);
            this.keySearchMovie.Name = "keySearchMovie";
            this.keySearchMovie.Size = new System.Drawing.Size(433, 23);
            this.keySearchMovie.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Keyword:";
            // 
            // searchByIDMovie
            // 
            this.searchByIDMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchByIDMovie.AutoSize = true;
            this.searchByIDMovie.Location = new System.Drawing.Point(535, 18);
            this.searchByIDMovie.Name = "searchByIDMovie";
            this.searchByIDMovie.Size = new System.Drawing.Size(44, 21);
            this.searchByIDMovie.TabIndex = 2;
            this.searchByIDMovie.Text = "ID";
            this.searchByIDMovie.UseVisualStyleBackColor = true;
            this.searchByIDMovie.CheckedChanged += new System.EventHandler(this.searchByIDMovie_CheckedChanged);
            // 
            // searchByNameMovie
            // 
            this.searchByNameMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchByNameMovie.AutoSize = true;
            this.searchByNameMovie.Location = new System.Drawing.Point(610, 18);
            this.searchByNameMovie.Name = "searchByNameMovie";
            this.searchByNameMovie.Size = new System.Drawing.Size(65, 21);
            this.searchByNameMovie.TabIndex = 3;
            this.searchByNameMovie.Text = "Name";
            this.searchByNameMovie.UseVisualStyleBackColor = true;
            this.searchByNameMovie.CheckedChanged += new System.EventHandler(this.searchByNameMovie_CheckedChanged);
            // 
            // btnSearchMovie
            // 
            this.btnSearchMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchMovie.Location = new System.Drawing.Point(683, 12);
            this.btnSearchMovie.Name = "btnSearchMovie";
            this.btnSearchMovie.Size = new System.Drawing.Size(132, 33);
            this.btnSearchMovie.TabIndex = 4;
            this.btnSearchMovie.Text = "Search";
            this.btnSearchMovie.UseVisualStyleBackColor = true;
            this.btnSearchMovie.Click += new System.EventHandler(this.btnSearchMovie_Click);
            // 
            // dgvListMovie
            // 
            this.dgvListMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListMovie.Location = new System.Drawing.Point(3, 112);
            this.dgvListMovie.MainView = this.grid;
            this.dgvListMovie.Name = "dgvListMovie";
            this.dgvListMovie.Size = new System.Drawing.Size(821, 370);
            this.dgvListMovie.TabIndex = 5;
            this.dgvListMovie.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grid});
            // 
            // grid
            // 
            this.grid.GridControl = this.dgvListMovie;
            this.grid.Name = "grid";
            // 
            // btnShowAllMovie
            // 
            this.btnShowAllMovie.Location = new System.Drawing.Point(164, 60);
            this.btnShowAllMovie.Name = "btnShowAllMovie";
            this.btnShowAllMovie.Size = new System.Drawing.Size(141, 46);
            this.btnShowAllMovie.TabIndex = 6;
            this.btnShowAllMovie.Text = "Update";
            this.btnShowAllMovie.UseVisualStyleBackColor = true;
            this.btnShowAllMovie.Click += new System.EventHandler(this.btnShowAllMovie_Click);
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteMovie.Location = new System.Drawing.Point(353, 60);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(141, 46);
            this.btnDeleteMovie.TabIndex = 7;
            this.btnDeleteMovie.Text = "Delete";
            this.btnDeleteMovie.UseVisualStyleBackColor = true;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // btnEditMovie
            // 
            this.btnEditMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditMovie.Location = new System.Drawing.Point(535, 60);
            this.btnEditMovie.Name = "btnEditMovie";
            this.btnEditMovie.Size = new System.Drawing.Size(141, 46);
            this.btnEditMovie.TabIndex = 8;
            this.btnEditMovie.Text = "Edit";
            this.btnEditMovie.UseVisualStyleBackColor = true;
            this.btnEditMovie.Click += new System.EventHandler(this.button2_Click);
            // 
            // ListMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 487);
            this.Controls.Add(this.btnEditMovie);
            this.Controls.Add(this.btnDeleteMovie);
            this.Controls.Add(this.btnShowAllMovie);
            this.Controls.Add(this.dgvListMovie);
            this.Controls.Add(this.btnSearchMovie);
            this.Controls.Add(this.searchByNameMovie);
            this.Controls.Add(this.searchByIDMovie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keySearchMovie);
            this.Name = "ListMovie";
            this.Text = "ListMovie";
            this.Load += new System.EventHandler(this.ListMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMovie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox keySearchMovie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox searchByIDMovie;
        private System.Windows.Forms.CheckBox searchByNameMovie;
        private System.Windows.Forms.Button btnSearchMovie;
        private DevExpress.XtraGrid.GridControl dgvListMovie;
        private DevExpress.XtraGrid.Views.Grid.GridView grid;
        private System.Windows.Forms.Button btnShowAllMovie;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.Button btnEditMovie;
    }
}
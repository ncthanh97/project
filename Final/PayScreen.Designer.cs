namespace Manage_Cinema
{
    partial class PayScreen
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameMovie = new System.Windows.Forms.Label();
            this.timeMovie = new System.Windows.Forms.Label();
            this.dayMovie = new System.Windows.Forms.Label();
            this.seatMovie = new System.Windows.Forms.Label();
            this.priceMovie = new System.Windows.Forms.Label();
            this.btnSold = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.nameMovie, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.timeMovie, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dayMovie, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.seatMovie, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.priceMovie, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(454, 272);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movie:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Day:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Seat:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price:";
            // 
            // nameMovie
            // 
            this.nameMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nameMovie.AutoSize = true;
            this.nameMovie.Location = new System.Drawing.Point(139, 11);
            this.nameMovie.Name = "nameMovie";
            this.nameMovie.Size = new System.Drawing.Size(312, 17);
            this.nameMovie.TabIndex = 5;
            this.nameMovie.Text = "label6";
            // 
            // timeMovie
            // 
            this.timeMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.timeMovie.AutoSize = true;
            this.timeMovie.Location = new System.Drawing.Point(139, 51);
            this.timeMovie.Name = "timeMovie";
            this.timeMovie.Size = new System.Drawing.Size(312, 17);
            this.timeMovie.TabIndex = 6;
            this.timeMovie.Text = "label7";
            // 
            // dayMovie
            // 
            this.dayMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dayMovie.AutoSize = true;
            this.dayMovie.Location = new System.Drawing.Point(139, 91);
            this.dayMovie.Name = "dayMovie";
            this.dayMovie.Size = new System.Drawing.Size(312, 17);
            this.dayMovie.TabIndex = 7;
            this.dayMovie.Text = "label8";
            // 
            // seatMovie
            // 
            this.seatMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.seatMovie.AutoSize = true;
            this.seatMovie.Location = new System.Drawing.Point(139, 131);
            this.seatMovie.Name = "seatMovie";
            this.seatMovie.Size = new System.Drawing.Size(312, 17);
            this.seatMovie.TabIndex = 8;
            // 
            // priceMovie
            // 
            this.priceMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.priceMovie.AutoSize = true;
            this.priceMovie.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceMovie.Location = new System.Drawing.Point(139, 199);
            this.priceMovie.Name = "priceMovie";
            this.priceMovie.Size = new System.Drawing.Size(312, 34);
            this.priceMovie.TabIndex = 9;
            this.priceMovie.Text = "label10";
            this.priceMovie.Click += new System.EventHandler(this.priceMovie_Click);
            // 
            // btnSold
            // 
            this.btnSold.Location = new System.Drawing.Point(163, 290);
            this.btnSold.Name = "btnSold";
            this.btnSold.Size = new System.Drawing.Size(138, 48);
            this.btnSold.TabIndex = 1;
            this.btnSold.Text = "Sold";
            this.btnSold.UseVisualStyleBackColor = true;
            this.btnSold.Click += new System.EventHandler(this.btnSold_Click);
            // 
            // PayScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 343);
            this.Controls.Add(this.btnSold);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PayScreen";
            this.Text = "PayScreen";
            this.Load += new System.EventHandler(this.PayScreen_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label nameMovie;
        private System.Windows.Forms.Label timeMovie;
        private System.Windows.Forms.Label dayMovie;
        private System.Windows.Forms.Label seatMovie;
        private System.Windows.Forms.Button btnSold;
        private System.Windows.Forms.Label priceMovie;
    }
}
namespace Manage_Cinema
{
    partial class Add_show
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.idAddShowtime = new System.Windows.Forms.TextBox();
            this.ticketNumberAddShowtime = new System.Windows.Forms.TextBox();
            this.idMovieAddShowTime = new System.Windows.Forms.TextBox();
            this.idRoomAddShowTime = new System.Windows.Forms.TextBox();
            this.addShow = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeAddShow = new System.Windows.Forms.TextBox();
            this.dayAddShowTime = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.idAddShowtime, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.timeAddShow, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ticketNumberAddShowtime, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.idMovieAddShowTime, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.idRoomAddShowTime, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.dayAddShowTime, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(353, 292);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Day:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ticket munber:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID Movie:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "ID Room:";
            // 
            // idAddShowtime
            // 
            this.idAddShowtime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.idAddShowtime.Location = new System.Drawing.Point(108, 12);
            this.idAddShowtime.Name = "idAddShowtime";
            this.idAddShowtime.Size = new System.Drawing.Size(242, 23);
            this.idAddShowtime.TabIndex = 6;
            // 
            // ticketNumberAddShowtime
            // 
            this.ticketNumberAddShowtime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ticketNumberAddShowtime.Location = new System.Drawing.Point(108, 156);
            this.ticketNumberAddShowtime.Name = "ticketNumberAddShowtime";
            this.ticketNumberAddShowtime.Size = new System.Drawing.Size(242, 23);
            this.ticketNumberAddShowtime.TabIndex = 9;
            // 
            // idMovieAddShowTime
            // 
            this.idMovieAddShowTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.idMovieAddShowTime.Location = new System.Drawing.Point(108, 204);
            this.idMovieAddShowTime.Name = "idMovieAddShowTime";
            this.idMovieAddShowTime.Size = new System.Drawing.Size(242, 23);
            this.idMovieAddShowTime.TabIndex = 10;
            // 
            // idRoomAddShowTime
            // 
            this.idRoomAddShowTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.idRoomAddShowTime.Location = new System.Drawing.Point(108, 254);
            this.idRoomAddShowTime.Name = "idRoomAddShowTime";
            this.idRoomAddShowTime.Size = new System.Drawing.Size(242, 23);
            this.idRoomAddShowTime.TabIndex = 11;
            // 
            // addShow
            // 
            this.addShow.Location = new System.Drawing.Point(383, 65);
            this.addShow.Name = "addShow";
            this.addShow.Size = new System.Drawing.Size(113, 70);
            this.addShow.TabIndex = 1;
            this.addShow.Text = "Add";
            this.addShow.UseVisualStyleBackColor = true;
            this.addShow.Click += new System.EventHandler(this.addShow_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(383, 141);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(113, 70);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // timeAddShow
            // 
            this.timeAddShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.timeAddShow.Location = new System.Drawing.Point(108, 60);
            this.timeAddShow.Name = "timeAddShow";
            this.timeAddShow.Size = new System.Drawing.Size(242, 23);
            this.timeAddShow.TabIndex = 7;
            // 
            // dayAddShowTime
            // 
            this.dayAddShowTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dayAddShowTime.Location = new System.Drawing.Point(108, 109);
            this.dayAddShowTime.Name = "dayAddShowTime";
            this.dayAddShowTime.Size = new System.Drawing.Size(242, 23);
            this.dayAddShowTime.TabIndex = 12;
            // 
            // Add_show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 311);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.addShow);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Add_show";
            this.Text = "Add_show";
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox idAddShowtime;
        private System.Windows.Forms.TextBox ticketNumberAddShowtime;
        private System.Windows.Forms.TextBox idMovieAddShowTime;
        private System.Windows.Forms.TextBox idRoomAddShowTime;
        private System.Windows.Forms.Button addShow;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox timeAddShow;
        private System.Windows.Forms.DateTimePicker dayAddShowTime;
    }
}
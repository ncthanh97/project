namespace Manage_Cinema
{
    partial class Add_ticket_type
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
            this.idAddTicketType = new System.Windows.Forms.TextBox();
            this.conditionAddTicketType = new System.Windows.Forms.TextBox();
            this.priceAddTicketType = new System.Windows.Forms.TextBox();
            this.btnAddType = new System.Windows.Forms.Button();
            this.btnClearType = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Controls.Add(this.idAddTicketType, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.conditionAddTicketType, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.priceAddTicketType, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(332, 192);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Condition:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price:";
            // 
            // idAddTicketType
            // 
            this.idAddTicketType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.idAddTicketType.Location = new System.Drawing.Point(102, 20);
            this.idAddTicketType.Name = "idAddTicketType";
            this.idAddTicketType.Size = new System.Drawing.Size(227, 23);
            this.idAddTicketType.TabIndex = 3;
            // 
            // conditionAddTicketType
            // 
            this.conditionAddTicketType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.conditionAddTicketType.Location = new System.Drawing.Point(102, 84);
            this.conditionAddTicketType.Name = "conditionAddTicketType";
            this.conditionAddTicketType.Size = new System.Drawing.Size(227, 23);
            this.conditionAddTicketType.TabIndex = 4;
            // 
            // priceAddTicketType
            // 
            this.priceAddTicketType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.priceAddTicketType.Location = new System.Drawing.Point(102, 148);
            this.priceAddTicketType.Name = "priceAddTicketType";
            this.priceAddTicketType.Size = new System.Drawing.Size(227, 23);
            this.priceAddTicketType.TabIndex = 5;
            // 
            // btnAddType
            // 
            this.btnAddType.Location = new System.Drawing.Point(369, 35);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(101, 46);
            this.btnAddType.TabIndex = 1;
            this.btnAddType.Text = "Add";
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // btnClearType
            // 
            this.btnClearType.Location = new System.Drawing.Point(369, 98);
            this.btnClearType.Name = "btnClearType";
            this.btnClearType.Size = new System.Drawing.Size(101, 46);
            this.btnClearType.TabIndex = 2;
            this.btnClearType.Text = "Clear";
            this.btnClearType.UseVisualStyleBackColor = true;
            this.btnClearType.Click += new System.EventHandler(this.btnClearType_Click);
            // 
            // Add_ticket_type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 216);
            this.Controls.Add(this.btnClearType);
            this.Controls.Add(this.btnAddType);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Add_ticket_type";
            this.Text = "Add_ticket_type";
            this.Load += new System.EventHandler(this.Add_ticket_type_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idAddTicketType;
        private System.Windows.Forms.TextBox conditionAddTicketType;
        private System.Windows.Forms.TextBox priceAddTicketType;
        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.Button btnClearType;
    }
}
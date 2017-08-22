namespace UserInterfaceLayer._03_TicketSalesOperations
{
    partial class SaleListForm
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
            this.dgvTicketList = new System.Windows.Forms.DataGridView();
            this.btnSaveSale = new System.Windows.Forms.Button();
            this.btnUpdateSale = new System.Windows.Forms.Button();
            this.btnRemoveSale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicketList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTicketList
            // 
            this.dgvTicketList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicketList.Location = new System.Drawing.Point(0, 1);
            this.dgvTicketList.Name = "dgvTicketList";
            this.dgvTicketList.Size = new System.Drawing.Size(588, 252);
            this.dgvTicketList.TabIndex = 0;
            this.dgvTicketList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSaleList_RowHeaderMouseClick);
            // 
            // btnSaveSale
            // 
            this.btnSaveSale.Location = new System.Drawing.Point(0, 259);
            this.btnSaveSale.Name = "btnSaveSale";
            this.btnSaveSale.Size = new System.Drawing.Size(192, 41);
            this.btnSaveSale.TabIndex = 1;
            this.btnSaveSale.Text = "Yeni Satış";
            this.btnSaveSale.UseVisualStyleBackColor = true;
            this.btnSaveSale.Click += new System.EventHandler(this.btnSaveSale_Click);
            // 
            // btnUpdateSale
            // 
            this.btnUpdateSale.Location = new System.Drawing.Point(198, 259);
            this.btnUpdateSale.Name = "btnUpdateSale";
            this.btnUpdateSale.Size = new System.Drawing.Size(192, 41);
            this.btnUpdateSale.TabIndex = 2;
            this.btnUpdateSale.Text = "Satışı Güncelle";
            this.btnUpdateSale.UseVisualStyleBackColor = true;
            this.btnUpdateSale.Click += new System.EventHandler(this.btnUpdateSale_Click);
            // 
            // btnRemoveSale
            // 
            this.btnRemoveSale.Location = new System.Drawing.Point(396, 259);
            this.btnRemoveSale.Name = "btnRemoveSale";
            this.btnRemoveSale.Size = new System.Drawing.Size(192, 41);
            this.btnRemoveSale.TabIndex = 3;
            this.btnRemoveSale.Text = "Satışı Sil";
            this.btnRemoveSale.UseVisualStyleBackColor = true;
            this.btnRemoveSale.Click += new System.EventHandler(this.btnRemoveSale_Click);
            // 
            // SaleListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 301);
            this.Controls.Add(this.btnRemoveSale);
            this.Controls.Add(this.btnUpdateSale);
            this.Controls.Add(this.btnSaveSale);
            this.Controls.Add(this.dgvTicketList);
            this.Name = "SaleListForm";
            this.Text = "SaleListForm";
            this.Load += new System.EventHandler(this.SaleListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicketList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTicketList;
        private System.Windows.Forms.Button btnSaveSale;
        private System.Windows.Forms.Button btnUpdateSale;
        private System.Windows.Forms.Button btnRemoveSale;
    }
}
namespace UserInterfaceLayer._03_TicketSalesOperations
{
    partial class TicketListForm
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
            this.btnRemoveTicket = new System.Windows.Forms.Button();
            this.btnUpdateTicket = new System.Windows.Forms.Button();
            this.btnSaveTicket = new System.Windows.Forms.Button();
            this.dgvTicketList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicketList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemoveTicket
            // 
            this.btnRemoveTicket.Location = new System.Drawing.Point(396, 258);
            this.btnRemoveTicket.Name = "btnRemoveTicket";
            this.btnRemoveTicket.Size = new System.Drawing.Size(192, 41);
            this.btnRemoveTicket.TabIndex = 7;
            this.btnRemoveTicket.Text = "Bileti Sil";
            this.btnRemoveTicket.UseVisualStyleBackColor = true;
            this.btnRemoveTicket.Click += new System.EventHandler(this.btnRemoveTicket_Click);
            // 
            // btnUpdateTicket
            // 
            this.btnUpdateTicket.Location = new System.Drawing.Point(198, 258);
            this.btnUpdateTicket.Name = "btnUpdateTicket";
            this.btnUpdateTicket.Size = new System.Drawing.Size(192, 41);
            this.btnUpdateTicket.TabIndex = 6;
            this.btnUpdateTicket.Text = "Bileti Güncelle";
            this.btnUpdateTicket.UseVisualStyleBackColor = true;
            this.btnUpdateTicket.Click += new System.EventHandler(this.btnUpdateTicket_Click);
            // 
            // btnSaveTicket
            // 
            this.btnSaveTicket.Location = new System.Drawing.Point(0, 258);
            this.btnSaveTicket.Name = "btnSaveTicket";
            this.btnSaveTicket.Size = new System.Drawing.Size(192, 41);
            this.btnSaveTicket.TabIndex = 5;
            this.btnSaveTicket.Text = "Yeni Bilet";
            this.btnSaveTicket.UseVisualStyleBackColor = true;
            this.btnSaveTicket.Click += new System.EventHandler(this.btnSaveTicket_Click);
            // 
            // dgvTicketList
            // 
            this.dgvTicketList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicketList.Location = new System.Drawing.Point(0, 0);
            this.dgvTicketList.Name = "dgvTicketList";
            this.dgvTicketList.Size = new System.Drawing.Size(588, 252);
            this.dgvTicketList.TabIndex = 4;
            this.dgvTicketList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTicketList_RowHeaderMouseClick);
            // 
            // TicketListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 296);
            this.Controls.Add(this.btnRemoveTicket);
            this.Controls.Add(this.btnUpdateTicket);
            this.Controls.Add(this.btnSaveTicket);
            this.Controls.Add(this.dgvTicketList);
            this.Name = "TicketListForm";
            this.Text = "Bilet Listesi";
            this.Load += new System.EventHandler(this.TicketListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicketList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveTicket;
        private System.Windows.Forms.Button btnUpdateTicket;
        private System.Windows.Forms.Button btnSaveTicket;
        private System.Windows.Forms.DataGridView dgvTicketList;
    }
}
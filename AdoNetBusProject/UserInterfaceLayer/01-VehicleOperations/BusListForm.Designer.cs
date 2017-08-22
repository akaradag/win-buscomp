namespace UserInterfaceLayer._01_VehicleOperations
{
    partial class BusListForm
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
            this.dgvBusList = new System.Windows.Forms.DataGridView();
            this.btnRemoveBus = new System.Windows.Forms.Button();
            this.btnEditBus = new System.Windows.Forms.Button();
            this.btnNewBus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBusList
            // 
            this.dgvBusList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusList.Location = new System.Drawing.Point(12, 12);
            this.dgvBusList.Name = "dgvBusList";
            this.dgvBusList.Size = new System.Drawing.Size(518, 218);
            this.dgvBusList.TabIndex = 1;
            this.dgvBusList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBusList_CellMouseClick);
            // 
            // btnRemoveBus
            // 
            this.btnRemoveBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveBus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveBus.Location = new System.Drawing.Point(355, 246);
            this.btnRemoveBus.Name = "btnRemoveBus";
            this.btnRemoveBus.Size = new System.Drawing.Size(149, 62);
            this.btnRemoveBus.TabIndex = 9;
            this.btnRemoveBus.Text = "Sil       ";
            this.btnRemoveBus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveBus.UseVisualStyleBackColor = true;
            this.btnRemoveBus.Click += new System.EventHandler(this.btnRemoveBus_Click);
            // 
            // btnEditBus
            // 
            this.btnEditBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEditBus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditBus.Location = new System.Drawing.Point(200, 246);
            this.btnEditBus.Name = "btnEditBus";
            this.btnEditBus.Size = new System.Drawing.Size(149, 62);
            this.btnEditBus.TabIndex = 8;
            this.btnEditBus.Text = "Düzenle  ";
            this.btnEditBus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditBus.UseVisualStyleBackColor = true;
            this.btnEditBus.Click += new System.EventHandler(this.btnEditBus_Click);
            // 
            // btnNewBus
            // 
            this.btnNewBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewBus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewBus.Location = new System.Drawing.Point(45, 246);
            this.btnNewBus.Name = "btnNewBus";
            this.btnNewBus.Size = new System.Drawing.Size(149, 62);
            this.btnNewBus.TabIndex = 7;
            this.btnNewBus.Text = "Yeni Kayıt ";
            this.btnNewBus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewBus.UseVisualStyleBackColor = true;
            this.btnNewBus.Click += new System.EventHandler(this.btnNewBus_Click);
            // 
            // BusListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 337);
            this.Controls.Add(this.btnRemoveBus);
            this.Controls.Add(this.btnEditBus);
            this.Controls.Add(this.btnNewBus);
            this.Controls.Add(this.dgvBusList);
            this.Name = "BusListForm";
            this.Text = "Otobüs Listesi";
            this.Load += new System.EventHandler(this.BusListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBusList;
        private System.Windows.Forms.Button btnRemoveBus;
        private System.Windows.Forms.Button btnEditBus;
        private System.Windows.Forms.Button btnNewBus;
    }
}
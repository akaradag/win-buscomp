namespace UserInterfaceLayer._01_VehicleOperations
{
    partial class BusTypeListForm
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
            this.dgvBusTypeList = new System.Windows.Forms.DataGridView();
            this.btnRemoveBusType = new System.Windows.Forms.Button();
            this.btnEditBusType = new System.Windows.Forms.Button();
            this.btnNewBusType = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusTypeList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBusTypeList
            // 
            this.dgvBusTypeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusTypeList.Location = new System.Drawing.Point(12, 12);
            this.dgvBusTypeList.Name = "dgvBusTypeList";
            this.dgvBusTypeList.Size = new System.Drawing.Size(518, 218);
            this.dgvBusTypeList.TabIndex = 1;
            this.dgvBusTypeList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBusTypeList_CellMouseClick);
            // 
            // btnRemoveBusType
            // 
            this.btnRemoveBusType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveBusType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveBusType.Location = new System.Drawing.Point(346, 250);
            this.btnRemoveBusType.Name = "btnRemoveBusType";
            this.btnRemoveBusType.Size = new System.Drawing.Size(149, 62);
            this.btnRemoveBusType.TabIndex = 9;
            this.btnRemoveBusType.Text = "Sil       ";
            this.btnRemoveBusType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveBusType.UseVisualStyleBackColor = true;
            this.btnRemoveBusType.Click += new System.EventHandler(this.btnRemoveBusType_Click);
            // 
            // btnEditBusType
            // 
            this.btnEditBusType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEditBusType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditBusType.Location = new System.Drawing.Point(191, 250);
            this.btnEditBusType.Name = "btnEditBusType";
            this.btnEditBusType.Size = new System.Drawing.Size(149, 62);
            this.btnEditBusType.TabIndex = 8;
            this.btnEditBusType.Text = "Düzenle  ";
            this.btnEditBusType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditBusType.UseVisualStyleBackColor = true;
            this.btnEditBusType.Click += new System.EventHandler(this.btnEditBusType_Click);
            // 
            // btnNewBusType
            // 
            this.btnNewBusType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewBusType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewBusType.Location = new System.Drawing.Point(36, 250);
            this.btnNewBusType.Name = "btnNewBusType";
            this.btnNewBusType.Size = new System.Drawing.Size(149, 62);
            this.btnNewBusType.TabIndex = 7;
            this.btnNewBusType.Text = "Yeni Kayıt ";
            this.btnNewBusType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewBusType.UseVisualStyleBackColor = true;
            this.btnNewBusType.Click += new System.EventHandler(this.btnNewBusType_Click);
            // 
            // BusTypeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 349);
            this.Controls.Add(this.btnRemoveBusType);
            this.Controls.Add(this.btnEditBusType);
            this.Controls.Add(this.btnNewBusType);
            this.Controls.Add(this.dgvBusTypeList);
            this.Name = "BusTypeListForm";
            this.Text = "Otobüs Tipi Listesi";
            this.Load += new System.EventHandler(this.BusTypeListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusTypeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBusTypeList;
        private System.Windows.Forms.Button btnRemoveBusType;
        private System.Windows.Forms.Button btnEditBusType;
        private System.Windows.Forms.Button btnNewBusType;
    }
}
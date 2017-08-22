namespace UserInterfaceLayer._01_VehicleOperations
{
    partial class BrandListForm
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
            this.dgvBrandList = new System.Windows.Forms.DataGridView();
            this.btnRemoveBrand = new System.Windows.Forms.Button();
            this.btnEditBrand = new System.Windows.Forms.Button();
            this.btnNewBrand = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrandList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBrandList
            // 
            this.dgvBrandList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBrandList.Location = new System.Drawing.Point(12, 12);
            this.dgvBrandList.Name = "dgvBrandList";
            this.dgvBrandList.Size = new System.Drawing.Size(518, 218);
            this.dgvBrandList.TabIndex = 0;
            this.dgvBrandList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBrandList_CellClick);
            // 
            // btnRemoveBrand
            // 
            this.btnRemoveBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveBrand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveBrand.Location = new System.Drawing.Point(350, 255);
            this.btnRemoveBrand.Name = "btnRemoveBrand";
            this.btnRemoveBrand.Size = new System.Drawing.Size(149, 62);
            this.btnRemoveBrand.TabIndex = 6;
            this.btnRemoveBrand.Text = "Sil       ";
            this.btnRemoveBrand.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveBrand.UseVisualStyleBackColor = true;
            this.btnRemoveBrand.Click += new System.EventHandler(this.btnRemoveEmployee_Click);
            // 
            // btnEditBrand
            // 
            this.btnEditBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEditBrand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditBrand.Location = new System.Drawing.Point(195, 255);
            this.btnEditBrand.Name = "btnEditBrand";
            this.btnEditBrand.Size = new System.Drawing.Size(149, 62);
            this.btnEditBrand.TabIndex = 5;
            this.btnEditBrand.Text = "Düzenle  ";
            this.btnEditBrand.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditBrand.UseVisualStyleBackColor = true;
            this.btnEditBrand.Click += new System.EventHandler(this.btnEditBrand_Click);
            // 
            // btnNewBrand
            // 
            this.btnNewBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewBrand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewBrand.Location = new System.Drawing.Point(40, 255);
            this.btnNewBrand.Name = "btnNewBrand";
            this.btnNewBrand.Size = new System.Drawing.Size(149, 62);
            this.btnNewBrand.TabIndex = 4;
            this.btnNewBrand.Text = "Yeni Kayıt ";
            this.btnNewBrand.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewBrand.UseVisualStyleBackColor = true;
            this.btnNewBrand.Click += new System.EventHandler(this.btnNewBrand_Click);
            // 
            // BrandListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 344);
            this.Controls.Add(this.btnRemoveBrand);
            this.Controls.Add(this.btnEditBrand);
            this.Controls.Add(this.btnNewBrand);
            this.Controls.Add(this.dgvBrandList);
            this.Name = "BrandListForm";
            this.Text = "Marka Listesi";
            this.Load += new System.EventHandler(this.BrandListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrandList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBrandList;
        private System.Windows.Forms.Button btnRemoveBrand;
        private System.Windows.Forms.Button btnEditBrand;
        private System.Windows.Forms.Button btnNewBrand;
    }
}
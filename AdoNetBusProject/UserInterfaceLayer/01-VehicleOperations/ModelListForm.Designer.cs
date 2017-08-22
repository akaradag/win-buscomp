namespace UserInterfaceLayer._01_VehicleOperations
{
    partial class ModelListForm
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
            this.dgvModelList = new System.Windows.Forms.DataGridView();
            this.btnRemoveModel = new System.Windows.Forms.Button();
            this.btnEditModel = new System.Windows.Forms.Button();
            this.btnNewModel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvModelList
            // 
            this.dgvModelList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModelList.Location = new System.Drawing.Point(12, 12);
            this.dgvModelList.Name = "dgvModelList";
            this.dgvModelList.Size = new System.Drawing.Size(518, 218);
            this.dgvModelList.TabIndex = 1;
            this.dgvModelList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvModelList_CellMouseClick);
            // 
            // btnRemoveModel
            // 
            this.btnRemoveModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveModel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveModel.Location = new System.Drawing.Point(348, 241);
            this.btnRemoveModel.Name = "btnRemoveModel";
            this.btnRemoveModel.Size = new System.Drawing.Size(149, 62);
            this.btnRemoveModel.TabIndex = 9;
            this.btnRemoveModel.Text = "Sil       ";
            this.btnRemoveModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveModel.UseVisualStyleBackColor = true;
            this.btnRemoveModel.Click += new System.EventHandler(this.btnRemoveModel_Click);
            // 
            // btnEditModel
            // 
            this.btnEditModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEditModel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditModel.Location = new System.Drawing.Point(193, 241);
            this.btnEditModel.Name = "btnEditModel";
            this.btnEditModel.Size = new System.Drawing.Size(149, 62);
            this.btnEditModel.TabIndex = 8;
            this.btnEditModel.Text = "Düzenle  ";
            this.btnEditModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditModel.UseVisualStyleBackColor = true;
            this.btnEditModel.Click += new System.EventHandler(this.btnEditModel_Click);
            // 
            // btnNewModel
            // 
            this.btnNewModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewModel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewModel.Location = new System.Drawing.Point(38, 241);
            this.btnNewModel.Name = "btnNewModel";
            this.btnNewModel.Size = new System.Drawing.Size(149, 62);
            this.btnNewModel.TabIndex = 7;
            this.btnNewModel.Text = "Yeni Kayıt ";
            this.btnNewModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewModel.UseVisualStyleBackColor = true;
            this.btnNewModel.Click += new System.EventHandler(this.btnNewModel_Click);
            // 
            // ModelListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 315);
            this.Controls.Add(this.btnRemoveModel);
            this.Controls.Add(this.btnEditModel);
            this.Controls.Add(this.btnNewModel);
            this.Controls.Add(this.dgvModelList);
            this.Name = "ModelListForm";
            this.Text = "Model Listesi";
            this.Load += new System.EventHandler(this.ModelListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvModelList;
        private System.Windows.Forms.Button btnRemoveModel;
        private System.Windows.Forms.Button btnEditModel;
        private System.Windows.Forms.Button btnNewModel;
    }
}
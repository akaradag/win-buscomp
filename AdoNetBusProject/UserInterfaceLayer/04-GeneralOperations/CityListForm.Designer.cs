namespace UserInterfaceLayer._04_GeneralOperations
{
    partial class CityListForm
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
            this.dgvCityList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCityList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCityList
            // 
            this.dgvCityList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCityList.Location = new System.Drawing.Point(42, 50);
            this.dgvCityList.Name = "dgvCityList";
            this.dgvCityList.Size = new System.Drawing.Size(240, 302);
            this.dgvCityList.TabIndex = 0;
            this.dgvCityList.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCityList_RowHeaderMouseDoubleClick);
            // 
            // CityListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 408);
            this.Controls.Add(this.dgvCityList);
            this.Name = "CityListForm";
            this.Text = "CityListForm";
            this.Load += new System.EventHandler(this.CityListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCityList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCityList;
    }
}
namespace UserInterfaceLayer._00_EmployeeTransactions
{
    partial class EmployeeListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeListForm));
            this.dgvEmployeeList = new System.Windows.Forms.DataGridView();
            this.btnNewEmployee = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployeeList
            // 
            this.dgvEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeList.Location = new System.Drawing.Point(12, 12);
            this.dgvEmployeeList.Name = "dgvEmployeeList";
            this.dgvEmployeeList.Size = new System.Drawing.Size(830, 397);
            this.dgvEmployeeList.TabIndex = 0;
            this.dgvEmployeeList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEmployeeList_RowHeaderMouseClick);
            // 
            // btnNewEmployee
            // 
            this.btnNewEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnNewEmployee.Image")));
            this.btnNewEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewEmployee.Location = new System.Drawing.Point(185, 415);
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.Size = new System.Drawing.Size(149, 62);
            this.btnNewEmployee.TabIndex = 1;
            this.btnNewEmployee.Text = "Yeni Kayıt ";
            this.btnNewEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewEmployee.UseVisualStyleBackColor = true;
            this.btnNewEmployee.Click += new System.EventHandler(this.btnNewEmployee_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEditEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEditEmployee.Image")));
            this.btnEditEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditEmployee.Location = new System.Drawing.Point(340, 415);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(149, 62);
            this.btnEditEmployee.TabIndex = 2;
            this.btnEditEmployee.Text = "Düzenle  ";
            this.btnEditEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveEmployee.Image")));
            this.btnRemoveEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveEmployee.Location = new System.Drawing.Point(495, 415);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(149, 62);
            this.btnRemoveEmployee.TabIndex = 3;
            this.btnRemoveEmployee.Text = "Sil       ";
            this.btnRemoveEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveEmployee.UseVisualStyleBackColor = true;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.btnRemoveEmployee_Click);
            // 
            // EmployeeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 489);
            this.Controls.Add(this.dgvEmployeeList);
            this.Controls.Add(this.btnRemoveEmployee);
            this.Controls.Add(this.btnEditEmployee);
            this.Controls.Add(this.btnNewEmployee);
            this.Name = "EmployeeListForm";
            this.Text = "EmployeeListForm";
            this.Load += new System.EventHandler(this.EmployeeListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployeeList;
        private System.Windows.Forms.Button btnNewEmployee;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnRemoveEmployee;
    }
}
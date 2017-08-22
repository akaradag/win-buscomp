namespace UserInterfaceLayer._01_VehicleOperations
{
    partial class BusTypeEditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblBusTypeID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBusTypeName = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // lblBusTypeID
            // 
            this.lblBusTypeID.AutoSize = true;
            this.lblBusTypeID.Location = new System.Drawing.Point(82, 21);
            this.lblBusTypeID.Name = "lblBusTypeID";
            this.lblBusTypeID.Size = new System.Drawing.Size(13, 13);
            this.lblBusTypeID.TabIndex = 1;
            this.lblBusTypeID.Text = "..";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tip :";
            // 
            // txtBusTypeName
            // 
            this.txtBusTypeName.Location = new System.Drawing.Point(85, 57);
            this.txtBusTypeName.Name = "txtBusTypeName";
            this.txtBusTypeName.Size = new System.Drawing.Size(226, 20);
            this.txtBusTypeName.TabIndex = 3;
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApply.Location = new System.Drawing.Point(188, 92);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(123, 57);
            this.btnApply.TabIndex = 14;
            this.btnApply.Text = "Kaydet";
            this.btnApply.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // BusTypeEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 176);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.txtBusTypeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBusTypeID);
            this.Controls.Add(this.label1);
            this.Name = "BusTypeEditForm";
            this.Text = "Otobüs Tipi Ekleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBusTypeID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBusTypeName;
        private System.Windows.Forms.Button btnApply;

    }
}
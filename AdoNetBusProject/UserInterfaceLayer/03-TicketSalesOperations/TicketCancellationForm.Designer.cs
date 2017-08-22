namespace UserInterfaceLayer._03_TicketSalesOperations
{
    partial class TicketCancellationForm
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
            this.txtTicketID = new System.Windows.Forms.TextBox();
            this.btnDeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bilet No :";
            // 
            // txtTicketID
            // 
            this.txtTicketID.Location = new System.Drawing.Point(69, 10);
            this.txtTicketID.Name = "txtTicketID";
            this.txtTicketID.Size = new System.Drawing.Size(172, 20);
            this.txtTicketID.TabIndex = 1;
            // 
            // btnDeleteButton
            // 
            this.btnDeleteButton.Location = new System.Drawing.Point(121, 36);
            this.btnDeleteButton.Name = "btnDeleteButton";
            this.btnDeleteButton.Size = new System.Drawing.Size(120, 23);
            this.btnDeleteButton.TabIndex = 2;
            this.btnDeleteButton.Text = "Bileti İptal Et";
            this.btnDeleteButton.UseVisualStyleBackColor = true;
            this.btnDeleteButton.Click += new System.EventHandler(this.btnDeleteButton_Click);
            // 
            // TicketCancellationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 109);
            this.Controls.Add(this.btnDeleteButton);
            this.Controls.Add(this.txtTicketID);
            this.Controls.Add(this.label1);
            this.Name = "TicketCancellationForm";
            this.Text = "TicketCancellationForm";
            this.Load += new System.EventHandler(this.TicketCancellationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTicketID;
        private System.Windows.Forms.Button btnDeleteButton;
    }
}
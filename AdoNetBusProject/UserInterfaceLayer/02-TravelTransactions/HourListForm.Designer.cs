namespace UserInterfaceLayer._02_TravelTransactions
{
    partial class HourListForm
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
            this.components = new System.ComponentModel.Container();
            this.dgvHour = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miDeleteHour = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHour)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHour
            // 
            this.dgvHour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHour.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvHour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHour.Location = new System.Drawing.Point(0, 0);
            this.dgvHour.Name = "dgvHour";
            this.dgvHour.RowTemplate.Height = 24;
            this.dgvHour.Size = new System.Drawing.Size(342, 262);
            this.dgvHour.TabIndex = 0;
            this.dgvHour.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvHour_CellMouseUp);
            this.dgvHour.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvHour_RowHeaderMouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDeleteHour});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 28);
            // 
            // miDeleteHour
            // 
            this.miDeleteHour.Name = "miDeleteHour";
            this.miDeleteHour.Size = new System.Drawing.Size(135, 24);
            this.miDeleteHour.Text = "Kaydı Sil";
            this.miDeleteHour.Click += new System.EventHandler(this.miDeleteHour_Click);
            // 
            // HourListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 262);
            this.Controls.Add(this.dgvHour);
            this.Name = "HourListForm";
            this.Text = "HourListForm";
            this.Load += new System.EventHandler(this.HourListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHour)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHour;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miDeleteHour;
    }
}
namespace UserInterfaceLayer._02_TravelTransactions
{
    partial class TripEditForm
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblIDValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbBus = new System.Windows.Forms.ComboBox();
            this.cmbRoute = new System.Windows.Forms.ComboBox();
            this.cmbHour = new System.Windows.Forms.ComboBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpPredictedTime = new System.Windows.Forms.DateTimePicker();
            this.lstRoute = new System.Windows.Forms.ListBox();
            this.btnAddRoute = new System.Windows.Forms.Button();
            this.btnRemoveRoute = new System.Windows.Forms.Button();
            this.btnTripEdit = new System.Windows.Forms.Button();
            this.lstEmployee = new System.Windows.Forms.ListBox();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetBus = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetEmployees = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lstRouteHour = new System.Windows.Forms.ListBox();
            this.btnAddHour = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemoveHour = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(6, 31);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 17);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // lblIDValue
            // 
            this.lblIDValue.AutoSize = true;
            this.lblIDValue.Location = new System.Drawing.Point(252, 31);
            this.lblIDValue.Name = "lblIDValue";
            this.lblIDValue.Size = new System.Drawing.Size(0, 17);
            this.lblIDValue.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Otobüs:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rotalar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kalkış Saati:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Seyahat Balangıç Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Seyahat Bitiş Tarihi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(660, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tahmini Süre:";
            // 
            // cmbBus
            // 
            this.cmbBus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBus.Enabled = false;
            this.cmbBus.FormattingEnabled = true;
            this.cmbBus.Location = new System.Drawing.Point(252, 259);
            this.cmbBus.Name = "cmbBus";
            this.cmbBus.Size = new System.Drawing.Size(270, 24);
            this.cmbBus.TabIndex = 8;
            // 
            // cmbRoute
            // 
            this.cmbRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoute.FormattingEnabled = true;
            this.cmbRoute.Location = new System.Drawing.Point(98, 39);
            this.cmbRoute.Name = "cmbRoute";
            this.cmbRoute.Size = new System.Drawing.Size(136, 24);
            this.cmbRoute.TabIndex = 9;
            // 
            // cmbHour
            // 
            this.cmbHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHour.FormattingEnabled = true;
            this.cmbHour.Location = new System.Drawing.Point(404, 39);
            this.cmbHour.Name = "cmbHour";
            this.cmbHour.Size = new System.Drawing.Size(118, 24);
            this.cmbHour.TabIndex = 10;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(252, 82);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(270, 22);
            this.dtpStartDate.TabIndex = 11;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(252, 138);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(270, 22);
            this.dtpEndDate.TabIndex = 12;
            // 
            // dtpPredictedTime
            // 
            this.dtpPredictedTime.CustomFormat = "HH:mm";
            this.dtpPredictedTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPredictedTime.Location = new System.Drawing.Point(788, 144);
            this.dtpPredictedTime.Name = "dtpPredictedTime";
            this.dtpPredictedTime.ShowUpDown = true;
            this.dtpPredictedTime.Size = new System.Drawing.Size(204, 22);
            this.dtpPredictedTime.TabIndex = 13;
            // 
            // lstRoute
            // 
            this.lstRoute.FormattingEnabled = true;
            this.lstRoute.ItemHeight = 16;
            this.lstRoute.Location = new System.Drawing.Point(9, 152);
            this.lstRoute.Name = "lstRoute";
            this.lstRoute.Size = new System.Drawing.Size(225, 84);
            this.lstRoute.TabIndex = 14;
            // 
            // btnAddRoute
            // 
            this.btnAddRoute.Location = new System.Drawing.Point(9, 78);
            this.btnAddRoute.Name = "btnAddRoute";
            this.btnAddRoute.Size = new System.Drawing.Size(104, 51);
            this.btnAddRoute.TabIndex = 15;
            this.btnAddRoute.Text = "Rota Ekle";
            this.btnAddRoute.UseVisualStyleBackColor = true;
            this.btnAddRoute.Click += new System.EventHandler(this.btnAddRoute_Click);
            // 
            // btnRemoveRoute
            // 
            this.btnRemoveRoute.Location = new System.Drawing.Point(130, 78);
            this.btnRemoveRoute.Name = "btnRemoveRoute";
            this.btnRemoveRoute.Size = new System.Drawing.Size(104, 51);
            this.btnRemoveRoute.TabIndex = 16;
            this.btnRemoveRoute.Text = "Rota Çıkar";
            this.btnRemoveRoute.UseVisualStyleBackColor = true;
            this.btnRemoveRoute.Click += new System.EventHandler(this.btnRemoveRoute_Click);
            // 
            // btnTripEdit
            // 
            this.btnTripEdit.Location = new System.Drawing.Point(788, 196);
            this.btnTripEdit.Name = "btnTripEdit";
            this.btnTripEdit.Size = new System.Drawing.Size(204, 40);
            this.btnTripEdit.TabIndex = 17;
            this.btnTripEdit.Text = "Seferi Kaydet";
            this.btnTripEdit.UseVisualStyleBackColor = true;
            this.btnTripEdit.Click += new System.EventHandler(this.btnTripEdit_Click);
            // 
            // lstEmployee
            // 
            this.lstEmployee.FormattingEnabled = true;
            this.lstEmployee.ItemHeight = 16;
            this.lstEmployee.Location = new System.Drawing.Point(767, 194);
            this.lstEmployee.Name = "lstEmployee";
            this.lstEmployee.Size = new System.Drawing.Size(225, 84);
            this.lstEmployee.TabIndex = 20;
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.Location = new System.Drawing.Point(888, 125);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(104, 51);
            this.btnRemoveEmployee.TabIndex = 22;
            this.btnRemoveEmployee.Text = "Personel Çıkar";
            this.btnRemoveEmployee.UseVisualStyleBackColor = true;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.btnRemoveEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(767, 125);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(104, 51);
            this.btnAddEmployee.TabIndex = 21;
            this.btnAddEmployee.Text = "Personel Ekle";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(767, 79);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(225, 24);
            this.cmbEmployee.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(764, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Personeller:";
            // 
            // btnGetBus
            // 
            this.btnGetBus.Location = new System.Drawing.Point(321, 190);
            this.btnGetBus.Name = "btnGetBus";
            this.btnGetBus.Size = new System.Drawing.Size(201, 40);
            this.btnGetBus.TabIndex = 26;
            this.btnGetBus.Text = "Otobüsleri getir";
            this.btnGetBus.UseVisualStyleBackColor = true;
            this.btnGetBus.Click += new System.EventHandler(this.btnGetControlledBus_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 41);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tarihleri değiştirdikten sonra uygun otobüsler için otobüsleri getir butonuna bas" +
    "ınız.";
            // 
            // btnGetEmployees
            // 
            this.btnGetEmployees.Location = new System.Drawing.Point(538, 71);
            this.btnGetEmployees.Name = "btnGetEmployees";
            this.btnGetEmployees.Size = new System.Drawing.Size(136, 41);
            this.btnGetEmployees.TabIndex = 28;
            this.btnGetEmployees.Text = "Personelleri Getir";
            this.btnGetEmployees.UseVisualStyleBackColor = true;
            this.btnGetEmployees.Click += new System.EventHandler(this.btnGetEmployees_Click);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(535, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(204, 64);
            this.label9.TabIndex = 29;
            this.label9.Text = "Tarih seçimlerinden sonra personelleri getirmek için butona tıklayıız.";
            // 
            // lstRouteHour
            // 
            this.lstRouteHour.FormattingEnabled = true;
            this.lstRouteHour.ItemHeight = 16;
            this.lstRouteHour.Location = new System.Drawing.Point(297, 152);
            this.lstRouteHour.Name = "lstRouteHour";
            this.lstRouteHour.Size = new System.Drawing.Size(225, 84);
            this.lstRouteHour.TabIndex = 30;
            // 
            // btnAddHour
            // 
            this.btnAddHour.Location = new System.Drawing.Point(297, 78);
            this.btnAddHour.Name = "btnAddHour";
            this.btnAddHour.Size = new System.Drawing.Size(106, 51);
            this.btnAddHour.TabIndex = 31;
            this.btnAddHour.Text = "Rota Saati Ekle";
            this.btnAddHour.UseVisualStyleBackColor = true;
            this.btnAddHour.Click += new System.EventHandler(this.btnAddHour_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.lblIDValue);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnGetEmployees);
            this.groupBox1.Controls.Add(this.cmbBus);
            this.groupBox1.Controls.Add(this.btnGetBus);
            this.groupBox1.Controls.Add(this.dtpStartDate);
            this.groupBox1.Controls.Add(this.cmbEmployee);
            this.groupBox1.Controls.Add(this.dtpEndDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lstEmployee);
            this.groupBox1.Controls.Add(this.btnRemoveEmployee);
            this.groupBox1.Controls.Add(this.btnAddEmployee);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1072, 302);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sefer Detayları";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemoveHour);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnTripEdit);
            this.groupBox2.Controls.Add(this.btnAddHour);
            this.groupBox2.Controls.Add(this.dtpPredictedTime);
            this.groupBox2.Controls.Add(this.cmbRoute);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lstRouteHour);
            this.groupBox2.Controls.Add(this.cmbHour);
            this.groupBox2.Controls.Add(this.lstRoute);
            this.groupBox2.Controls.Add(this.btnRemoveRoute);
            this.groupBox2.Controls.Add(this.btnAddRoute);
            this.groupBox2.Location = new System.Drawing.Point(12, 331);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1072, 261);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sefer Güzergah Detayları";
            // 
            // btnRemoveHour
            // 
            this.btnRemoveHour.Location = new System.Drawing.Point(416, 78);
            this.btnRemoveHour.Name = "btnRemoveHour";
            this.btnRemoveHour.Size = new System.Drawing.Size(106, 51);
            this.btnRemoveHour.TabIndex = 33;
            this.btnRemoveHour.Text = "Rota Saati Çıkar";
            this.btnRemoveHour.UseVisualStyleBackColor = true;
            this.btnRemoveHour.Click += new System.EventHandler(this.btnRemoveHour_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(582, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(440, 17);
            this.label10.TabIndex = 32;
            this.label10.Text = "Seferi kaydetmeden önce her rotaya karşılık bir kalkış saati ekleyiniz.";
            // 
            // TripEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 620);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TripEditForm";
            this.Text = "TripEditForm";
            this.Load += new System.EventHandler(this.TripEditForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblIDValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbBus;
        private System.Windows.Forms.ComboBox cmbRoute;
        private System.Windows.Forms.ComboBox cmbHour;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpPredictedTime;
        private System.Windows.Forms.ListBox lstRoute;
        private System.Windows.Forms.Button btnAddRoute;
        private System.Windows.Forms.Button btnRemoveRoute;
        private System.Windows.Forms.Button btnTripEdit;
        private System.Windows.Forms.ListBox lstEmployee;
        private System.Windows.Forms.Button btnRemoveEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetBus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetEmployees;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstRouteHour;
        private System.Windows.Forms.Button btnAddHour;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRemoveHour;
    }
}
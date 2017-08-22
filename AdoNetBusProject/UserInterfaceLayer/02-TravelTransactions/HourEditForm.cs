using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLogicLayer;
using BusCompanyClassLibrary;

namespace UserInterfaceLayer._02_TravelTransactions
{
    public partial class HourEditForm : Form
    {
        Employee _emp;
        HourBussiness _hourBussiness;
        Hour _hour;
        public HourEditForm()
        {
            InitializeComponent();
            _hour = new Hour();
            lblIDValue.Enabled = false;
            lblID.Enabled = false;

            MDIForms mainForm = this.MdiParent as MDIForms;
            _emp = mainForm.GetEmployee();
        }
        public HourEditForm(int hourId)
        {
            InitializeComponent();
            MDIForms mainForm = this.MdiParent as MDIForms;
            _emp = mainForm.GetEmployee();
            _hourBussiness = new HourBussiness(_emp);
            try
            {
                _hour = _hourBussiness.GetBLL(hourId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Text = "Hareket Saati Düzenleme";
            btnEdit.Text = "Güncelle";
            dtpHour.Value = Convert.ToDateTime(_hour.DepartureTime);
            lblID.Text = "ID: ";
            lblIDValue.Text = _hour.ID.ToString();
        }

        private void HourEditForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool result = false;
            _hourBussiness = new HourBussiness(_emp);
            _hour.DepartureTime = dtpHour.Value.ToShortTimeString();
            if (_hour.ID != null)
            {
                try
                {
                    result = _hourBussiness.UpdateBLL(_hour);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    result = _hourBussiness.SaveBLL(_hour);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            MessageBox.Show((result) ? "İşlem başarılı" : "İşlem başarısız");
            foreach (Form item in this.MdiParent.MdiChildren)
            {
                if (item is HourListForm)
                {
                    ((HourListForm)item).RefreshHourList();
                    break;
                }
            }
            this.Close();
        }
    }
}

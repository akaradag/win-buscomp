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
    public partial class HourListForm : Form
    {
        Employee _emp;
        HourBussiness _hourBussiness;
        Hour _hour;
        int _hourId;
        
        public HourListForm()
        {
            InitializeComponent();
            MDIForms mainForm = this.MdiParent as MDIForms;
            _emp = mainForm.GetEmployee();
            _hourBussiness = new HourBussiness(_emp);
        }
        private void HourListForm_Load(object sender, EventArgs e)
        {
            RefreshHourList();
        }
        public void RefreshHourList()
        {
            dgvHour.DataSource = null;
            try
            {
                dgvHour.DataSource = _hourBussiness.GetAllBLL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvHour_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _hourId = (int)dgvHour.Rows[e.RowIndex].Cells["ID"].Value;
            HourEditForm hEditForm = new HourEditForm(_hourId);
            hEditForm.MdiParent = this.MdiParent;
            hEditForm.Show();
        }

        #region Silme İşlemi
        private void dgvHour_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                _hourId = (int)dgvHour.Rows[e.RowIndex].Cells["ID"].Value;

                try
                {
                    _hour = _hourBussiness.GetBLL(_hourId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void miDeleteHour_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(_hour.DepartureTime + " sefer saatini kaldırmak istediğinize emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                bool bllResult = false;
                try
                {
                    bllResult = _hourBussiness.DeleteBLL(_hour);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show(bllResult ? "İşlem başarılı." : "İşlem başarısız.");
            }
        }

        #endregion
    }
}

using BusCompanyClassLibrary;
using BussinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaceLayer._02_TravelTransactions
{
    public partial class TripListForm : Form
    {
        int _tripId=-1;

        Employee _emp;
        Trip _trip;
        TripDetails _tDetails;

        TripBussiness _tBuss;
        TripDetailsBussiness _tdBuss;


        public TripListForm()
        {
            InitializeComponent();
        }

        private void TripListForm_Load(object sender, EventArgs e)
        {
            MDIForms mainForm = this.MdiParent as MDIForms;
            _emp = mainForm.GetEmployee();

            _tdBuss = new TripDetailsBussiness(_emp);
            RefreshList();

        }
        public void RefreshList()
        {
            dgvTrip.DataSource = null;
            try
            {
                dgvTrip.DataSource = _tdBuss.GetAllwDetailsBLL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvTrip_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                _tripId = (int)dgvTrip.Rows[e.RowIndex].Cells["ID"].Value;
                try
                {
                    _trip = _tBuss.GetBLL(_tripId);
                    _tDetails = _tdBuss.GetBLL(_tripId);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvTrip_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void kaydıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

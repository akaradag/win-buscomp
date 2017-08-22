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

namespace UserInterfaceLayer._03_TicketSalesOperations
{
    
    public partial class TicketListForm : Form
    {
        TicketBussiness _ticketBLL;
        Employee _employee;
        int _ticketID;

        public TicketListForm()
        {
            InitializeComponent();
            
            
        }

        private void btnSaveTicket_Click(object sender, EventArgs e)
        {
            TicketEditForm editForm = new TicketEditForm(_employee);
            editForm.MdiParent = this.MdiParent;
            editForm.Text = "Yeni Bilet Ekleme Formu";
            editForm.Show();
            this.Close();
        }

        private void btnUpdateTicket_Click(object sender, EventArgs e)
        {
            Ticket ticket = _ticketBLL.GetBLL(_ticketID);
            TicketEditForm editForm = new TicketEditForm(_employee);
            editForm.MdiParent = this.MdiParent;
            editForm.Text = "Bilet Güncelleme Formu";
            editForm.Show();
        }

        private void btnRemoveTicket_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Seçilen bileti silmek istediğinizden emin misiniz?","Dikkat",MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                Ticket deletedTicket = _ticketBLL.GetBLL(_ticketID);
                _ticketBLL.DeleteBLL(deletedTicket);
            }
        }

        private void dgvTicketList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _ticketID = (int)dgvTicketList.Rows[e.RowIndex].Cells["ID"].Value;
        }

        private void RefreshList()
        {
            dgvTicketList.DataSource = null;
            dgvTicketList.DataSource = _ticketBLL.GetAllBLL();
        }

        private void TicketListForm_Load(object sender, EventArgs e)
        {
            MDIForms mainForm = this.MdiParent as MDIForms;
            _employee = mainForm.GetEmployee();
            _ticketBLL = new TicketBussiness(_employee);
            RefreshList();
        }
    }
}

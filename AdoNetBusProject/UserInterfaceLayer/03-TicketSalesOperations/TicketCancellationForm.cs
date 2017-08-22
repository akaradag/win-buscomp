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
    public partial class TicketCancellationForm : Form
    {
        TicketBussiness _ticketBLL;
        Employee _emp = new Employee();
        Ticket _ticket;
        int _id;
        public TicketCancellationForm()
        {
            InitializeComponent();
           
        }


        private void btnDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                _id = int.Parse(txtTicketID.Text);
                _ticket = new Ticket();
                _ticket = _ticketBLL.GetBLL(_id);
            }
            catch (Exception)
            {

                MessageBox.Show("Geçersiz bilet no giridiniz.");
            }

            

            DialogResult result = new DialogResult();
            result = MessageBox.Show("Bileti silmek istediğinize emin misiniz?","Dikkat",MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                _ticketBLL.DeleteBLL(_ticket);
            }
        }

        private void TicketCancellationForm_Load(object sender, EventArgs e)
        {
            MDIForms mainForm = this.MdiParent as MDIForms;
            _emp = mainForm.GetEmployee();
        }
    }
}

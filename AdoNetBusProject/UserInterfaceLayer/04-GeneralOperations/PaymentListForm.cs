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

namespace UserInterfaceLayer._04_GeneralOperations
{
    public partial class PaymentListForm : Form
    {
        PaymentBussiness _payBLL;
        Employee _employee;
        Payment payment = new Payment();

        public PaymentListForm()
        {
            InitializeComponent();
            _payBLL = new PaymentBussiness(_employee);
        }

        private void PaymentListForm_Load(object sender, EventArgs e)
        {
            try
            {
                dgvPaymentList.DataSource = _payBLL.GetAllBLL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void dgvPaymentList_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int paymentId = (int)dgvPaymentList.Rows[e.RowIndex].Cells["ID"].Value;

            PaymentEditForm editForm = new PaymentEditForm(paymentId);
            editForm.MdiParent = this.MdiParent;
            editForm.Text = "Ödeme Tipi Güncelleme";
            editForm.Show();
            this.Close();
        }
    }
}

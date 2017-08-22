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
    public partial class PaymentEditForm : Form
    {
        Payment payment;
        PaymentBussiness _payBLL;
        Employee _employee = new Employee();
        private int paymentId;

        public PaymentEditForm()
        {
            InitializeComponent();
            payment = new Payment();
            _payBLL = new PaymentBussiness(_employee);
        }

        public PaymentEditForm(int paymentId)
        {
            InitializeComponent();
            this.paymentId = paymentId;

            _payBLL = new PaymentBussiness(_employee);
            payment = _payBLL.GetBLL(paymentId);

            txtPaymentType.Text = payment.PaymenType;
            btnApply.Text = "Güncelle";
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            MDIForms mainForm = this.MdiParent as MDIForms;
            _employee = mainForm.GetEmployee();

            payment.PaymenType = txtPaymentType.Text;
            try
            {
                bool result;
                if (payment.ID == null)
                {
                    _payBLL = new PaymentBussiness(_employee);
                    result = _payBLL.SaveBLL(payment);
                }
                else
                {
                    _payBLL = new PaymentBussiness(_employee);
                    result = _payBLL.UpdateBLL(payment);
                }
                if (result)
                {
                    MessageBox.Show("İşlem başarılı..");
                }
                else
                {
                    MessageBox.Show("İşlem başarısız.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            PaymentListForm listForm = new PaymentListForm();
            listForm.MdiParent = this.MdiParent;
            listForm.Show();
            this.Close();
        }
    }
}

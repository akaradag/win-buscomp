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
    public partial class SaleEditForm : Form
    {

        SaleBussiness _saleBLL;
        Employee _employee;
        Sale _sale;
        PaymentBussiness _paymentBLL;
        
        public SaleEditForm()
        {
            InitializeComponent();
            MDIForms mainForm = this.MdiParent as MDIForms;
            _employee = mainForm.GetEmployee();
            _saleBLL = new SaleBussiness(_employee);

            txtSaleID.Visible = false;
            label1.Visible = false;

            _paymentBLL = new PaymentBussiness(_employee);
            cmbPaymentID.DataSource = _paymentBLL.GetAllBLL();
            cmbPaymentID.ValueMember = "ID";
            cmbPaymentID.DisplayMember = "PaymentType";
        }

        
        public SaleEditForm(int saleID)
        {
            txtSaleID.Visible = true;
            label1.Visible = true;
            btnSaveSale.Text = "Satışı Güncelle";
            _sale = new Sale();
            _sale = _saleBLL.GetBLL(saleID);
            _sale = _saleBLL.GetBLL(saleID);
            txtSaleID.Text = _sale.ID.ToString();
            dtpDate.Value = _sale.Date;
            txtTotalPrice.Text = _sale.TotalPrice.ToString();
            cmbPaymentID.ValueMember = _sale.PaymentID.ToString();
        }

        public SaleEditForm(Employee _employee)
        {
            this._employee = _employee;
        }

        private void btnSaveSale_Click(object sender, EventArgs e)
        {
            if(_sale == null)
            {
                _saleBLL.SaveBLL(_sale);
            }
            else
            {
                _saleBLL.UpdateBLL(_sale);
            }
        }
    }
}

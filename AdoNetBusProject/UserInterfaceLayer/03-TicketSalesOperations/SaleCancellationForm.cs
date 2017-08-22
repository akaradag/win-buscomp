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
    public partial class SaleCancellationForm : Form
    {
        SaleBussiness _saleBLL;
        Employee _emp = new Employee();
        Sale _sale;
        int _id;
        public SaleCancellationForm()
        {
            InitializeComponent();
            MDIForms mainForm = this.MdiParent as MDIForms;
            _emp = mainForm.GetEmployee();
        }

        private void btnDeleteSale_Click(object sender, EventArgs e)
        {
            try
            {
                _id = int.Parse(txtSaleID.Text);
                _sale = new Sale();
                _sale = _saleBLL.GetBLL(_id);
            }
            catch (Exception)
            {

                MessageBox.Show("Geçersiz satış no girdiniz.");
            }

            DialogResult result = new DialogResult();
            result = MessageBox.Show("Satışı silmek istediğinize emin misiniz?","Dikkat",MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                _saleBLL.DeleteBLL(_sale);
            }
        }
    }
}

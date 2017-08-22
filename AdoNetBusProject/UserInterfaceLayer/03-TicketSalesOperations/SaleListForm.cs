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
    public partial class SaleListForm : Form
    {
        SaleBussiness _saleBLL;
        Employee _employee;
        int _saleID;

        public SaleListForm()
        {
            InitializeComponent();
           
            

        }

        private void btnSaveSale_Click(object sender, EventArgs e)
        {
            SaleEditForm editForm = new SaleEditForm(_employee);
            editForm.MdiParent = this.MdiParent;
            editForm.Text = "Yeni Satış Ekleme Formu";
            editForm.Show();

        }

        private void btnUpdateSale_Click(object sender, EventArgs e)
        {
            Sale sale = _saleBLL.GetBLL(_saleID);
            SaleEditForm editForm = new SaleEditForm(_employee);
            editForm.MdiParent = this.MdiParent;
            editForm.Text = "Satış Güncelleme Formu";
            editForm.Show();
            
        }

       

        private void btnRemoveSale_Click(object sender, EventArgs e)
        {
            
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Seçilen satışı silmek istediğinizden emin misniz?","Dikkat",MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                Sale deletedSale =  _saleBLL.GetBLL(_saleID);
                _saleBLL.DeleteBLL(deletedSale);
            }
            
        }

        private void dgvSaleList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _saleID = (int)dgvTicketList.Rows[e.RowIndex].Cells["ID"].Value;
        }

        private void SaleListForm_Load(object sender, EventArgs e)
        {
            MDIForms mainForm = this.MdiParent as MDIForms;
            _employee = mainForm.GetEmployee();

            _saleBLL = new SaleBussiness(_employee);
            dgvTicketList.DataSource = null;
            dgvTicketList.DataSource = _saleBLL.GetAllBLL();
        }
    }
}

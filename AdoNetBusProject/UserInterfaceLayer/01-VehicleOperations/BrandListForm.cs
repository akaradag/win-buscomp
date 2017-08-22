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

namespace UserInterfaceLayer._01_VehicleOperations
{
    public partial class BrandListForm : Form
    {
        BrandBussiness _brandBLL;
        Employee _employee;
        Brand _brand = new Brand();
        int _brandId;
        bool _isSelected = false;

        public BrandListForm()
        {
            InitializeComponent();


            // Giriş yapan Employee bilgileri alınıp  _employee atılacak           
        }

        private void BrandListForm_Load(object sender, EventArgs e)
        {


            try
            {
                MDIForms mainForm = this.MdiParent as MDIForms;
                _employee = mainForm.GetEmployee();

                _brandBLL = new BrandBussiness(_employee);

                dgvBrandList.DataSource = null;
                dgvBrandList.DataSource = _brandBLL.GetAllBLL();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnEditBrand_Click(object sender, EventArgs e)
        {
            BrandEditForm brandEditForm = new BrandEditForm(_brandId);
            brandEditForm.MdiParent = this.MdiParent;
            brandEditForm.Text = "Marka Güncelleme";
            brandEditForm.Show();
            this.Close();
        }

        private void btnNewBrand_Click(object sender, EventArgs e)
        {
            BrandEditForm brandEditForm = new BrandEditForm();
            brandEditForm.MdiParent = this.MdiParent;
            brandEditForm.Text = "Yeni Marka Ekleme";
            brandEditForm.Show();
            this.Close();
        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            if (_isSelected == true)
            {
                try
                {
                    DialogResult choice = MessageBox.Show(_brand.ID + " ID ' li " + _brand.Name + " Markası Silinsin mi ?", "Marka Silme", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                    if (choice == DialogResult.Yes)
                    {
                        _brandBLL.DeleteBLL(_brand);

                        // MessageBox.Show(_brand.ID.ToString() + " : ID li" + _brand.Name + " İsimli Marka Silindi", "Bilgilendirme");

                        //DGV refresh lenecek
                        dgvBrandList.DataSource = null;
                        dgvBrandList.DataSource = _brandBLL.GetAllBLL();
                    }
                    else if (choice == DialogResult.No)
                    {
                        MessageBox.Show("Silme işlemi iptal Edildi.", "Bilgilendirme");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Seçim Yapınız.", "Bilgilendirme");
            }

        }

        private void dgvBrandList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _isSelected = true;
            _brandId = (int)dgvBrandList.Rows[e.RowIndex].Cells["ID"].Value;
            _brand.ID = (int)dgvBrandList.Rows[e.RowIndex].Cells["ID"].Value;
            _brand.Name = (string)dgvBrandList.Rows[e.RowIndex].Cells["Name"].Value;
        }

        void FillDGV()
        {

        }
    }
}

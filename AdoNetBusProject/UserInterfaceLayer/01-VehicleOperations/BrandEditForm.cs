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
    public partial class BrandEditForm : Form
    {
        BrandBussiness _brandBLL;
        Employee _employee = new Employee();
        Brand _brand = new Brand();
        // Bu _employee ye anaformdan gelen employee atanacak
        bool _isUpdate = false;

        public BrandEditForm(int brandId)
        {
            InitializeComponent();

            //Buradan açıldıysa Düzenleme işlemleri yapılacak ve
            //textbox un text i seçilen  satırın name i ile doldurulacak.

            _isUpdate = true;

            try
            {
                _brandBLL = new BrandBussiness(_employee);
                _brand = _brandBLL.GetBLL(brandId);

                txtBrandName.Text = _brand.Name;
                lblBrandID.Text = _brand.ID.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public BrandEditForm()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                MDIForms mainForm = this.MdiParent as MDIForms;
                _employee = mainForm.GetEmployee();


                if (_isUpdate == true)
                {
                    _brandBLL = new BrandBussiness(_employee);
                    _brand.Name = txtBrandName.Text;

                    _brandBLL.UpdateBLL(_brand);

                    MessageBox.Show("Güncelleme başarılı.", "Bilgilendirme");

                    BrandListForm bListForm = new BrandListForm();
                    bListForm.MdiParent = this.MdiParent;
                    bListForm.Show();
                    this.Close();
                }
                else
                {
                    _brandBLL = new BrandBussiness(_employee);
                    _brand.Name = txtBrandName.Text;

                    _brandBLL.SaveBLL(_brand);

                    MessageBox.Show("Kayıt başarılı.", "Bilgilendirme");

                    BrandListForm bListForm = new BrandListForm();
                    bListForm.MdiParent = this.MdiParent;
                    bListForm.Show();
                    this.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

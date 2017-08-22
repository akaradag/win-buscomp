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
    public partial class BusTypeEditForm : Form
    {
        BusTypeBussiness _busTypeBLL;
        BusType _busType= new BusType();
        bool _isUpdate = false;
        Employee _employee = new Employee();
        public BusTypeEditForm()
        {
            InitializeComponent();
            try
            {
              

                _busTypeBLL = new BusTypeBussiness(_employee);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        public BusTypeEditForm(int busTypeId)
        {
            InitializeComponent();
            try
            {

               
                _isUpdate = true;
                _busTypeBLL = new BusTypeBussiness(_employee);


                _busType = _busTypeBLL.GetBLL(busTypeId);

                txtBusTypeName.Text = _busType.Name;
                lblBusTypeID.Text = _busType.ID.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
           

            try
            {
                MDIForms mainForm = this.MdiParent as MDIForms;
                _employee = mainForm.GetEmployee();

                _busTypeBLL = new BusTypeBussiness(_employee);

                if (_isUpdate == true)
                {

                    _busType.Name = txtBusTypeName.Text;
                    _busTypeBLL.UpdateBLL(_busType);

                    MessageBox.Show("Güncelleme Başarılı.", "Bilgilendirme");


                    BusTypeListForm bListForm = new BusTypeListForm();
                    bListForm.MdiParent = this.MdiParent;
                    bListForm.Show();
                    this.Close();

                }
                else
                {
                    _busType.Name = txtBusTypeName.Text;
                    _busTypeBLL.SaveBLL(_busType);

                    MessageBox.Show("Kayıt Ekleme Başarılı.", "Bilgilendirme");

                    BusTypeListForm bListForm = new BusTypeListForm();
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

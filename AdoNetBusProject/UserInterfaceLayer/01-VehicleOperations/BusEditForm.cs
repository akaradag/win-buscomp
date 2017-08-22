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
    public partial class BusEditForm : Form
    {
        BusBussiness _busBusiness;
        Employee _employee;
        //Main formdan gelen amployee ile eşlenecek
        Bus _bus = new Bus();
        bool _isUpdate = false;


        public BusEditForm(int busId)
        {
            InitializeComponent();
            // Burası düzenleme ekranı
            FillCmb();
            try
            {
                _busBusiness = new BusBussiness(_employee);
                _bus = _busBusiness.GetBLL(busId);

                lblID.Text = _bus.ID.ToString();
                txtSeatCount.Text = _bus.SeatCount.ToString();
                cmbModel.SelectedValue = _bus.ModelID;
                cmbType.SelectedValue = _bus.TypeID;

                if (_bus.IsAvaliable == true)
                {
                    cbIsAvaible.Checked = true;
                }
                else
                {
                    cbIsAvaible.Checked = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public BusEditForm()
        {
            InitializeComponent();

            FillCmb();

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {

                MDIForms mainForm = this.MdiParent as MDIForms;
                _employee = mainForm.GetEmployee();


                _busBusiness = new BusBussiness(_employee);

                if (_isUpdate == true)
                {
                    _bus.SeatCount = Convert.ToInt32(txtSeatCount.Text);
                    _bus.ModelID = (int)cmbModel.SelectedValue;
                    _bus.TypeID = (int)cmbType.SelectedValue;



                    if (cbIsAvaible.Checked == true)
                    {
                        _bus.IsAvaliable = true;
                    }
                    else
                    {
                        _bus.IsAvaliable = false;
                    }

                    _busBusiness.UpdateBLL(_bus);

                    MessageBox.Show("Güncelleme İşlemi Başarılı", "Bilgilendirme");

                    BusListForm bListForm = new BusListForm();
                    bListForm.MdiParent = this.MdiParent;
                    bListForm.Show();
                    this.Close();

                }
                else
                {
                    _bus.SeatCount = Convert.ToInt32(txtSeatCount.Text);
                    _bus.ModelID = (int)cmbModel.SelectedValue;
                    _bus.TypeID = (int)cmbType.SelectedValue;



                    if (cbIsAvaible.Checked == true)
                    {
                        _bus.IsAvaliable = true;
                    }
                    else
                    {
                        _bus.IsAvaliable = false;
                    }

                    _busBusiness.SaveBLL(_bus);

                    MessageBox.Show("Kayıt İşlemi Başarılı", "Bilgilendirme");


                    BusListForm bListForm = new BusListForm();
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

        void FillCmb()
        {
            BusTypeBussiness busTypeBLL = new BusTypeBussiness(_employee);
            ModelBussiness modelBLL = new ModelBussiness(_employee);
            try
            {
                cmbType.DataSource = busTypeBLL.GetAllBLL();
                cmbType.DisplayMember = "Name";
                cmbType.ValueMember = "ID";
                cmbModel.DataSource = modelBLL.GetAllBLL();
                cmbModel.DisplayMember = "Name";
                cmbModel.ValueMember = "ID";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }
    }
}

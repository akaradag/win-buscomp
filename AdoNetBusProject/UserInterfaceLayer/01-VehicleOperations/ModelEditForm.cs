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
    public partial class ModelEditForm : Form
    {
        ModelBussiness _modelBLL;
        Model _model = new Model();
        bool _isUpdate = false;

        Employee _employee = new Employee();
        //Employe main formdan gelen employee ile eşlenecek


        public ModelEditForm()
        {
            InitializeComponent();

            try
            {
               

                _modelBLL = new ModelBussiness(_employee);
                FillCmb();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public ModelEditForm(int modelId)
        {
            InitializeComponent();

            try
            {
                
                _modelBLL = new ModelBussiness(_employee);

                FillCmb();

                _isUpdate = true;


                _model = _modelBLL.GetBLL(modelId);

                lblModelID.Text = _model.ID.ToString();
                txtModelName.Text = _model.Name.ToString();
                cmbModelBrand.SelectedValue = _model.BrandID;
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

                _modelBLL = new ModelBussiness(_employee);

                if (_isUpdate == true)
                {
                    _model.Name = (string)txtModelName.Text;
                    _model.BrandID = (int)cmbModelBrand.SelectedValue;

                    _modelBLL.UpdateBLL(_model);

                    MessageBox.Show("Güncelleme Başarılı.", "Bilgilendirme");

                    ModelListForm mListForm = new ModelListForm();
                    mListForm.MdiParent = this.MdiParent;
                    mListForm.Show();
                    this.Close();
                }
                else
                {
                    _model.Name = (string)txtModelName.Text;
                    _model.BrandID = (int)cmbModelBrand.SelectedValue;
                    _modelBLL.SaveBLL(_model);

                    MessageBox.Show("Kayıt Başarılı.", "Bilgilendirme");

                    ModelListForm mListForm = new ModelListForm();
                    mListForm.MdiParent = this.MdiParent;
                    mListForm.Show();
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

            BrandBussiness brandBLL = new BrandBussiness(_employee);

            try
            {
                cmbModelBrand.DataSource = brandBLL.GetAllBLL();
                cmbModelBrand.DisplayMember = "Name";
                cmbModelBrand.ValueMember = "ID";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

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
    public partial class ModelListForm : Form
    {
        ModelBussiness _modelBLL;
        Model _model = new Model();
        Employee _employee = new Employee();
        int _modelId;

        public ModelListForm()
        {
            InitializeComponent();

            

        }

        private void dgvModelList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _modelId = (int)dgvModelList.Rows[e.RowIndex].Cells["ID"].Value;
            _model.ID = (int)dgvModelList.Rows[e.RowIndex].Cells["ID"].Value;
            _model.Name = (string)dgvModelList.Rows[e.RowIndex].Cells["Name"].Value;
        }

        private void ModelListForm_Load(object sender, EventArgs e)
        {
            try
            {
                MDIForms mainForm = this.MdiParent as MDIForms;
                _employee = mainForm.GetEmployee();

                _modelBLL = new ModelBussiness(_employee);

                dgvModelList.DataSource = _modelBLL.GetAllBLL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNewModel_Click(object sender, EventArgs e)
        {
            ModelEditForm modelEditForm = new ModelEditForm();
            modelEditForm.MdiParent = this.MdiParent;
            modelEditForm.Text = "Yeni Model Ekleme";
            modelEditForm.Show();
            this.Close();

        }

        private void btnEditModel_Click(object sender, EventArgs e)
        {
            ModelEditForm modelEditForm = new ModelEditForm(_modelId);
            modelEditForm.MdiParent = this.MdiParent;
            modelEditForm.Text = "Model Düzenleme";
            modelEditForm.Show();
            this.Close();
        }

        private void btnRemoveModel_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show(_model.ID + " ID ' li " + _model.Name + " İsimli Model Silinsin mi ?", "Model Silme", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            try
            {
                if (choice == DialogResult.Yes)
                {
                    _modelBLL.DeleteBLL(_model);


                    dgvModelList.DataSource = null;
                    dgvModelList.DataSource = _modelBLL.GetAllBLL();
                    //    MessageBox.Show(_model.ID.ToString() + " : ID li" + _model.Name + "İsimli" + "Model Silindi");
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
    }
}

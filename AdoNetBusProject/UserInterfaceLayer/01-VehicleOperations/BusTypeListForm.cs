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
    public partial class BusTypeListForm : Form
    {
        BusTypeBussiness _busTypeBLL;
        BusType _busType = new BusType();
        Employee _employee=new Employee();
        int _busTypeId;

        public BusTypeListForm()
        {
            InitializeComponent();

           
        }

        private void BusTypeListForm_Load(object sender, EventArgs e)
        {
            try
            {
                MDIForms mainForm = this.MdiParent as MDIForms;
                _employee = mainForm.GetEmployee();

                _busTypeBLL = new BusTypeBussiness(_employee);

                dgvBusTypeList.DataSource = _busTypeBLL.GetAllBLL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvBusTypeList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            _busTypeId=(int)dgvBusTypeList.Rows[e.RowIndex].Cells["ID"].Value;
            _busType.ID = (int)dgvBusTypeList.Rows[e.RowIndex].Cells["ID"].Value;
            _busType.Name = (string)dgvBusTypeList.Rows[e.RowIndex].Cells["Name"].Value;
        }

        private void btnNewBusType_Click(object sender, EventArgs e)
        {
            BusTypeEditForm busTypeEditForm = new BusTypeEditForm();
            busTypeEditForm.MdiParent = this.MdiParent;
            busTypeEditForm.Text = "Yeni Otobüs Tipi Ekleme";
            busTypeEditForm.Show();
            this.Close();
        }

        private void btnEditBusType_Click(object sender, EventArgs e)
        {
            BusTypeEditForm busTypeEditForm = new BusTypeEditForm(_busTypeId);
            busTypeEditForm.MdiParent = this.MdiParent;
            busTypeEditForm.Text = "Otobüs Tipi Düzenleme";
            busTypeEditForm.Show();
            this.Close();
        }

        private void btnRemoveBusType_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult choice = MessageBox.Show(_busType.ID + " ID ' li " + _busType.Name + " Otobüs tipi Silinsin mi ?", "Otobüs tipi Silme", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if (choice == DialogResult.Yes)
                {
                    _busTypeBLL.DeleteBLL(_busType);

                    dgvBusTypeList.DataSource = null;
                    dgvBusTypeList.DataSource = _busTypeBLL.GetAllBLL();
              //      MessageBox.Show(_busType.ID.ToString() + " : ID li" + _busType.Name + "İsimli" + "Otobüs Tipi Silindi");
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

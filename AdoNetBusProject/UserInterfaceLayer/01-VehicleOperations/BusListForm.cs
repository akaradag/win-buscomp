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
    public partial class BusListForm : Form
    {
        BusBussiness _busBusiness;
        Employee _employee= new Employee();
        //Employye main formdan gelen ile birleştirilecek
        int _busId;
        Bus _bus = new Bus();

       
        public BusListForm()
        {
            InitializeComponent();

           
        }

       

        private void btnNewBus_Click(object sender, EventArgs e)
        {
            BusEditForm busEditForm = new BusEditForm();
            busEditForm.MdiParent = this.MdiParent;
            busEditForm.Text = "Yeni Otobüs Ekleme";
            busEditForm.Show();
            this.Close();
        }

        private void btnEditBus_Click(object sender, EventArgs e)
        {
            BusEditForm busEditForm = new BusEditForm(_busId);
            busEditForm.MdiParent = this.MdiParent;
            busEditForm.Text = "Otobüs Güncelleme";
            busEditForm.Show();
            this.Close();
        }

        private void dgvBusList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _busId = (int)dgvBusList.Rows[e.RowIndex].Cells["ID"].Value;
            _bus.ID = (int)dgvBusList.Rows[e.RowIndex].Cells["ID"].Value;
            _bus.IsAvaliable = (bool)dgvBusList.Rows[e.RowIndex].Cells["IsAvaliable"].Value;
            _bus.SeatCount = (int)dgvBusList.Rows[e.RowIndex].Cells["SeatCount"].Value;

        }

        private void btnRemoveBus_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult choice = MessageBox.Show(_bus.ID + " ID ' li  otobüs Silinsin mi ?", "Otobüs Silme", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);


                if (choice == DialogResult.Yes)
                {
                    _busBusiness.DeleteBLL(_bus);

                    dgvBusList.DataSource = null;
                    dgvBusList.DataSource = _busBusiness.GetAllBLL();
                 //   MessageBox.Show(_bus.ID.ToString() + " : ID li" + "Marka Silindi");
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

        private void BusListForm_Load(object sender, EventArgs e)
        {
            MDIForms mainForm = this.MdiParent as MDIForms;
            _employee = mainForm.GetEmployee();

            _busBusiness = new BusBussiness(_employee);

            try
            {
                dgvBusList.DataSource = _busBusiness.GetAllBLL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}

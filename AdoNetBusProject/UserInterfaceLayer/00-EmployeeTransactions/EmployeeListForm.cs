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

namespace UserInterfaceLayer._00_EmployeeTransactions
{
    public partial class EmployeeListForm : Form
    {
        EmployeeBussiness _empBLL;
        Employee _employee;

        public EmployeeListForm()
        {
            InitializeComponent();
            _employee = new Employee();
            _empBLL = new EmployeeBussiness(_employee);
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            EmployeeEditForm editForm = new EmployeeEditForm();
            editForm.MdiParent = this.MdiParent;
            editForm.Text = "Yeni Çalışan Tanımlama";
            editForm.Show();
            this.Close();
        }

        int employeeId = -1;

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            if (employeeId>=0)
            {
                
            EmployeeEditForm editForm = new EmployeeEditForm(employeeId);
            editForm.MdiParent = this.MdiParent;
            editForm.Text = "Çalışan Güncelleme";
            editForm.Show();
            this.Close();
            }


        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult choice = MessageBox.Show(_employee.ID.ToString() + " ID 'li" + _employee.FirstName + " " + _employee.LastName + " isimli çalışan silinsin mi ?", "Dikkat !!", MessageBoxButtons.YesNo);

                if (choice == DialogResult.Yes)
                {
                    if (_employee.RoleID != 1)
                    {
                        _empBLL.DeleteBLL(_employee);
                        MessageBox.Show(_employee.ID.ToString() + " : ID li" + _employee.FirstName + " " + _employee.LastName + " isimli çalışan silindi", "Bilgilendirme");

                    }

                }
                else if (choice == DialogResult.No)
                {
                    MessageBox.Show("Silme işlemi iptal edildi.", "Bilgilendirme");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void EmployeeListForm_Load(object sender, EventArgs e)
        {
            try
            {
                dgvEmployeeList.DataSource = _empBLL.GetAllBLL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvEmployeeList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            employeeId = (int)dgvEmployeeList.Rows[e.RowIndex].Cells["ID"].Value;
        }
    }
}

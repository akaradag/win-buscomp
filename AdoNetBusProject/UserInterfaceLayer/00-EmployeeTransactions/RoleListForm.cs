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
    public partial class RoleListForm : Form
    {
        RoleBussiness _roleBLL;
        Employee _employee;
        Role _role = new Role();

        public RoleListForm()
        {
            InitializeComponent();
            _roleBLL = new RoleBussiness(_employee);
        }

        private void dgvRoles_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int Id = (int)dgvRoles.Rows[e.RowIndex].Cells["ID"].Value;

            RoleForm editForm = new RoleForm(Id);
            editForm.MdiParent = this.MdiParent;
            editForm.Text = "Şehir Güncelleme";
            editForm.Show();
            this.Close();
        }

        private void RoleListForm_Load(object sender, EventArgs e)
        {
            try
            {
                dgvRoles.DataSource = _roleBLL.GetAllBLL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
    }
}

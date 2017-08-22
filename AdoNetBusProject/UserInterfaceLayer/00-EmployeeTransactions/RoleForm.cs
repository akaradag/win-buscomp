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
    public partial class RoleForm : Form
    {
        Role role;
        RoleBussiness _roleBLL;
        Employee _employee = new Employee();

        private int Id;

        public RoleForm()
        {
            InitializeComponent();
            _roleBLL = new RoleBussiness(_employee);
            role = new Role();
        }

        public RoleForm(int Id)
        {
            InitializeComponent();
            this.Id = Id;

            _roleBLL = new RoleBussiness(_employee);
            role = _roleBLL.GetBLL(Id);

            txtRoleName.Text = role.Name;
            btnApply.Text = "Güncelle";
        }

        private void btnApply_Click(object sender, EventArgs e)
        {

            MDIForms mainForm = this.MdiParent as MDIForms;
            _employee = mainForm.GetEmployee();
            _roleBLL = new RoleBussiness(_employee);
            role.Name = txtRoleName.Text;

            try
            {

                bool result;
                if (role.ID == null)
                {
                    
                    result = _roleBLL.SaveBLL(role);
                }
                else
                {
                    
                    result = _roleBLL.UpdateBLL(role);
                }
                if (result)
                {
                    MessageBox.Show("İşlem başarılı..");
                }
                else
                {
                    MessageBox.Show("İşlem başarısız.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtRoleName.Clear();

            RoleListForm listForm = new RoleListForm();
            listForm.MdiParent = this.MdiParent;
            listForm.Show();
            this.Close();
        }


    }
}
